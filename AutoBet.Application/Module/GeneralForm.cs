using AutoBet.Application.Models;
using AutoBet.Data.Enums;
using AutoBet.Data.Models;
using AutoBet.Service.ConfigurationService;
using AutoBet.Service.DieuKienService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AutoBet.Application.Module
{
    public static class InputGeneralHandler
    {
        public static Form mainForm;
        public static ComboBox cbProvider;
        public static ComboBox cbTable;
        public static ComboBox cbCondition;
        public static RichTextBox rtbLogResult;
        public static TextBox stopWin;
        public static TextBox stopLose;
        public static TabPage tpTongQuat;
        public static TextBox exit;
        public static int playerWin;
        public static int bankerWin;
        public static int userWin;
        public static int userLose;
        public static int tie;
        public static string currentBet;
        public static int winMoneyUser;
        public static int betMoneyUser;
        public static bool isUserWin = true;
        public static List<AllTypeModel> allType = new List<AllTypeModel>();
        public static List<string> lsResult = new List<string>();
        public static System.Timers.Timer timer;
        public static List<ConditionCommand> condition = new List<ConditionCommand>();
        public static string provider;
        public static string conditionInput;
        public static string tableInput;
        public static bool haveResult = true;
        public static bool beginBet = true;
        public static bool isFirst = true;
        public static bool stopShowResult = false;
        public static void formAutoBet_Load(object sender, EventArgs e)
        {
            LoadProviderToComboBox();
            LoadConditionToComboBox();
        }
        public static void tbMenu_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tpTongQuat)
            {
                LoadProviderToComboBox();
                LoadConditionToComboBox();
            }
        }

        public static void btnExit_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        public static void cbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listTable = new ConfigurationService().GetListConfiguration().GroupBy(t => t.TableName).Select(t => t.Key).ToList();
            cbTable.DataSource = listTable;
            provider = cbProvider.SelectedText;
            tableInput = listTable[0];
        }
        public static void cbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            conditionInput = cbCondition.SelectedValue.ToString();
        }
        public static void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableInput = cbTable.SelectedValue.ToString();
        }
        public static void btnBetAuto_Click(object sender, EventArgs e)
        {
            SplitCondtionCommand();
            PostionFromConfiguration(condition);
            SetTimerEvent();
            //BetAuto();
        }
        public static void LoadProviderToComboBox()
        {
            var listProvider = new ConfigurationService().GetListProvider();
            cbProvider.DataSource = listProvider.Select(t => t.ProviderName).ToList();
            provider = listProvider.Select(t => t.ProviderName).FirstOrDefault();
        }
        public static void LoadConditionToComboBox()
        {
            var listCondition = new ConditionService().GetListCondtion().Select(t=>t.ConditionTitle).ToList();
            cbCondition.DataSource = listCondition;
            conditionInput = listCondition[0];
        }

        #region Data auto click
        //object sender, ElapsedEventArgs e
        public static void BetAuto(object sender, ElapsedEventArgs e)
        {
            StopShowResult();
            //Check ready for implement auto
            if (CheckTimeForBet() && beginBet)
            {
                beginBet = false;
                if (CheckValidResultAtCondition1())
                {
                    //Auto click
                    foreach (var config in allType.Where(t => t.IDType == 1))
                    {
                        Extension.Extension.AutoClick(config.chipTypeModel.Position);
                        Thread.Sleep(500);
                        Extension.Extension.AutoClick(config.betTypeModel.Position);
                        betMoneyUser += Convert.ToInt32(Regex.Replace(Enum.GetName(typeof(ConfigurationEnum), config.chipTypeModel.TypeOfChip),"[Money_]",string.Empty));
                        currentBet = Extension.Extension.GetEnumBetType(config.betTypeModel.TypeOfChip);
                    }
                }
                else if (allType.Count > 1 && isUserWin == false && isFirst == true)
                {
                    //Auto click
                    foreach (var config in allType.Where(t => t.IDType == 2))
                    {
                        Extension.Extension.AutoClick(config.chipTypeModel.Position);
                        Thread.Sleep(500);
                        Extension.Extension.AutoClick(config.betTypeModel.Position);
                        betMoneyUser += Convert.ToInt32(Regex.Replace(Enum.GetName(typeof(ConfigurationEnum), config.chipTypeModel.TypeOfChip), "[Money_]", string.Empty));
                        currentBet = Extension.Extension.GetEnumBetType(config.chipTypeModel.TypeOfChip);
                    }
                    isFirst = false;
                }

                Extension.Extension.AutoClick(GetApprovePostion());
                //beginBet = true;
                haveResult = false;
            }
            else if (CheckTimeForPlayerWinAtScore()) //Player
            {
                if (stopShowResult == false)
                {
                    lsResult.Add("P");
                    rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} P: Win {Environment.NewLine}"); }));
                    stopShowResult = true;
                }
                if (!haveResult)
                {
                    playerWin++;
                    if (currentBet == "P")
                    {
                        userWin++;
                        isUserWin = true;
                        isFirst = true;
                        winMoneyUser += betMoneyUser;
                        rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} Bạn đã đặt P {betMoneyUser} và đã thắng {winMoneyUser} {Environment.NewLine}"); }));
                    }
                    else if (currentBet != string.Empty)
                    {
                        userLose++;
                        isUserWin = false;
                        winMoneyUser -= betMoneyUser;
                        rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} Bạn đã đặt P {betMoneyUser} và đã thua {winMoneyUser} {Environment.NewLine}"); }));
                    }
                    haveResult = true;
                    currentBet = string.Empty;
                }
                betMoneyUser = 0;
                beginBet = true;

            }
            else if (CheckTimeForBankerWinAtScore()) //Banker
            {
                if (stopShowResult == false)
                {
                    lsResult.Add("B");
                    rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} B: Win {Environment.NewLine}"); }));
                    stopShowResult = true;
                }
                if (!haveResult)
                {
                    bankerWin++;
                    if (currentBet == "B")
                    {
                        userWin++;
                        isUserWin = true;
                        isFirst = true;
                        winMoneyUser += betMoneyUser;
                        rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} Bạn đã đặt B {betMoneyUser} và đã thắng {winMoneyUser} {Environment.NewLine}"); }));
                    }
                    else if (currentBet != string.Empty)
                    {
                        userLose++;
                        isUserWin = false;
                        winMoneyUser -= betMoneyUser;
                        rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} Bạn đã đặt B {betMoneyUser} và đã thua {winMoneyUser} {Environment.NewLine}"); }));
                    }
                    haveResult = true;
                    currentBet = string.Empty;
                }
                betMoneyUser = 0;
                beginBet = true;

            }
            else if (CheckTimeForTieAtScore())
            {
                if (stopShowResult == false)
                {
                    lsResult.Add("T");
                    rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} Tie {Environment.NewLine}"); }));
                    stopShowResult = true;
                }
                if (!haveResult)
                {
                    tie++;
                    haveResult = true;

                    if (currentBet == "T")
                    {
                        userWin++;
                        isUserWin = true;
                        isFirst = true;
                        winMoneyUser += betMoneyUser;
                        rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} Bạn đã đạt Tie {betMoneyUser} và đã thắng {winMoneyUser} {Environment.NewLine}"); }));
                    }
                    else if (currentBet != string.Empty)
                    {
                        userLose++;
                        isUserWin = false;
                        winMoneyUser -= betMoneyUser;
                        rtbLogResult.Invoke(new Action(() => { rtbLogResult.AppendText($"{DateTime.Now.ToString("HH:mm")} Bạn đã đặt Tie {betMoneyUser} và đã thua {winMoneyUser} {Environment.NewLine}"); }));
                    }
                    currentBet = string.Empty;
                }
                betMoneyUser = 0;
                beginBet = true;
            }


            if (!string.IsNullOrEmpty(stopLose.Text) && !string.IsNullOrEmpty(stopWin.Text)){
                if (!(string.IsNullOrEmpty(stopLose.Text) && Convert.ToInt32(stopLose.Text) <= winMoneyUser) || !(string.IsNullOrEmpty(stopWin.Text) && Convert.ToInt32(stopWin.Text) <= winMoneyUser))
                {
                    timer.Stop();
                }
            }
        }

        #region Check Image at RealTime
        private static bool CheckTimeForBet()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.Bet &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault();

            var bitmap = new Bitmap(10, 20);
            return CheckImageBetValid(bitmap, betConfiguration.Position, betConfiguration.WidthHeight, betConfiguration.LocationPath);

        }

        #region Player Win
        public static bool CheckTimeForPlayerWinAtTable()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.Result_Player &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault();

            var bitmap = new Bitmap(10, 20);
            return CheckImageBetValid(bitmap, betConfiguration.Position, betConfiguration.WidthHeight, betConfiguration.LocationPath);
        }

        public static bool CheckTimeForPlayerWinAtScore()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.Result_Player_2 &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault();

            var bitmap = new Bitmap(10, 20);
            return CheckImageBetValid(bitmap, betConfiguration.Position, betConfiguration.WidthHeight, betConfiguration.LocationPath);
        }
        #endregion

        #region Banker Win
        public static bool CheckTimeForBankerWinAtTable()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.Result_Banker &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault();

            var bitmap = new Bitmap(10, 20);
            return CheckImageBetValid(bitmap, betConfiguration.Position, betConfiguration.WidthHeight, betConfiguration.LocationPath);
        }

        public static bool CheckTimeForBankerWinAtScore()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.Result_Banker_2 &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault();

            var bitmap = new Bitmap(10, 20);
            return CheckImageBetValid(bitmap, betConfiguration.Position, betConfiguration.WidthHeight, betConfiguration.LocationPath);
        }

        #endregion

        #region Tie
        public static bool CheckTimeForTieAtTable()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.Result_Tie &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault();

            var bitmap = new Bitmap(10, 20);
            return CheckImageBetValid(bitmap, betConfiguration.Position, betConfiguration.WidthHeight, betConfiguration.LocationPath);
        }

        public static bool CheckTimeForTieAtScore()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.Result_Tie_2 &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault();

            var bitmap = new Bitmap(10, 20);
            return CheckImageBetValid(bitmap, betConfiguration.Position, betConfiguration.WidthHeight, betConfiguration.LocationPath);
        }
        #endregion

        #endregion
        public static void StopShowResult()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.WaitingAccept &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault();

            var bitmap = new Bitmap(10, 20);
            var checkImageValid = CheckImageBetValid(bitmap, betConfiguration.Position, betConfiguration.WidthHeight, betConfiguration.LocationPath);
            if (checkImageValid) stopShowResult = false;
        }
        private static bool CheckImageBetValid(Bitmap bmp, string positionXY, string widthHeight, string imgPath)
        {
            Extension.Extension.GetImageRectangle(out bmp, positionXY, widthHeight);
            if (Extension.Extension.CheckImageValid(bmp, imgPath)) return true;
            else return false;
        }

        public static void PostionFromConfiguration(List<ConditionCommand> condition)
        {
            var idCondition = 0;
            var idDefault = 1;
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            foreach (var item in condition)
            {
                var conditionBet = Extension.Extension.GetEnumBetType(item.Bet);
                var betConfiguration = new ConfigurationService().GetListConfiguration().Where(
                    t => t.TypeOfChip == Extension.Extension.GetEnumBetType(item.Bet) &&
                    t.TableName == tableInput &&
                    t.ProviderID == providerId).FirstOrDefault();

                var chipConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == Extension.Extension.GetEnumBetChip(item.ChipType) &&
                t.TableName == tableInput &&
                t.ProviderID == providerId).FirstOrDefault();

                for (int i = 0; i < item.NumberImplement; i++)
                {
                    if (item.isNegative == false)
                    {
                        allType.Add(new AllTypeModel
                        {
                            IDType = 1,
                            betTypeModel = betConfiguration,
                            chipTypeModel = chipConfiguration
                        });
                    }
                    else
                    {
                        allType.Add(new AllTypeModel
                        {
                            IDType = 2,
                            betTypeModel = betConfiguration,
                            chipTypeModel = chipConfiguration
                        });
                    }
                }
            }
        }

        public static void SplitCondtionCommand()
        {
            //Example: B,B,B,P_C,B:1000:1,B:2000:1
            var conditionInput = new ConditionService().GetListCondtion().Where(t => t.ConditionTitle.Contains(cbCondition.SelectedValue.ToString())).Select(t => t.ConditionContent).FirstOrDefault();
            var splitCommand = conditionInput.Replace("_C,", "/").Split('/');

            var commandBet = Regex.Replace(splitCommand[1], "[_,]", "/").ToString().Split('/');

            var listConditionBet = splitCommand[0].Split(',').ToList();

            int increment = 0;
            foreach (var item in commandBet)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    condition.Add(new ConditionCommand
                    {
                        TypeWin = listConditionBet.Select(x => (BetType)Enum.Parse(typeof(BetType), x)).ToList(),
                        Bet = (BetType)Enum.Parse(typeof(BetType), item.Split(':')[0]),
                        ChipType = (ConfigurationEnum)Enum.Parse(typeof(ConfigurationEnum), "Money_" + item.Split(':')[1]),
                        NumberImplement = Convert.ToInt32(Regex.Replace(item.Split(':')[2], "[_,]", string.Empty)),
                        isNegative = (commandBet[++increment] == string.Empty &&  commandBet.Length > 2)? true : false
                    }) ;
                }
                
            }
        }

        public static string GetApprovePostion()
        {
            var providerId = new ConfigurationService().GetListProvider().Where(t => t.ProviderName == provider).Select(t => t.ID).FirstOrDefault();

            //Check image valid;
            var betConfiguration = new ConfigurationService().GetListConfiguration().Where(t => t.TypeOfChip == (int)ConfigurationEnum.Accept &&
            t.TableName == tableInput &&
            t.ProviderID == providerId).FirstOrDefault().Position;

            return betConfiguration;
        }

        public static bool CheckValidResultAtCondition1()
        {
            var initialCondition = condition.FirstOrDefault();
            if (lsResult.Count >= initialCondition.TypeWin.Count)
            {
                var lastResult = lsResult.Skip(lsResult.Count - initialCondition.TypeWin.Count).Select(x => (BetType)Enum.Parse(typeof(BetType), x)).ToList();
                var compare = lastResult.Zip(initialCondition.TypeWin, (i, j) => i == j).Count(eq => eq);
                if (compare == initialCondition.TypeWin.Count) return true;
            }
            return false;
        }

        private static void SetTimerEvent()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += BetAuto;
            timer.Start();
        }

        #endregion
    }
}
