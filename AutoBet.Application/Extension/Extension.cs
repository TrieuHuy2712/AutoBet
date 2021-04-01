using AutoBet.Data.Enums;
using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoBet.Application.Extension
{
    public static class Extension
    {
        public static AutoItX3 autoIt= new AutoItX3();
        public static List<bool> GetHash(Bitmap bmpSource)
        {
            List<bool> lResult = new List<bool>();
            //create new image with 16x16 pixel
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16));
            for (int j = 0; j < bmpMin.Height; j++)
            {
                for (int i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }
            return lResult;
        }

        public static int GetEnumBetType(BetType betType)
        {
            switch (betType)
            {
                case BetType.P:
                    return (int)ConfigurationEnum.Bet_Player;
                case BetType.B:
                    return (int)ConfigurationEnum.Bet_Banker;
            }
            return 0;
        }

        public static string GetEnumBetType(int betType)
        {
            if (betType == (int)ConfigurationEnum.Bet_Player) return "P";
            else if (betType == (int)ConfigurationEnum.Bet_Banker) return "B";
            else return "T";
        }

        public static int GetEnumBetChip(ConfigurationEnum config)
        {
            switch (config)
            {
                case ConfigurationEnum.Bet:
                    return (int)ConfigurationEnum.Bet;
                case ConfigurationEnum.Money_1:
                    return (int)ConfigurationEnum.Money_1;
                case ConfigurationEnum.Money_2:
                    return (int)ConfigurationEnum.Money_2;
                case ConfigurationEnum.Money_5:
                    return (int)ConfigurationEnum.Money_5;
                case ConfigurationEnum.Money_10:
                    return (int)ConfigurationEnum.Money_10;
                case ConfigurationEnum.Money_20:
                    return (int)ConfigurationEnum.Money_20;
                case ConfigurationEnum.Money_25:
                    return (int)ConfigurationEnum.Money_25;
                case ConfigurationEnum.Money_50:
                    return (int)ConfigurationEnum.Money_50;
                case ConfigurationEnum.Money_100:
                    return (int)ConfigurationEnum.Money_100;
                case ConfigurationEnum.Money_200:
                    return (int)ConfigurationEnum.Money_200;
                case ConfigurationEnum.Money_500:
                    return (int)ConfigurationEnum.Money_500;
                case ConfigurationEnum.Money_1000:
                    return (int)ConfigurationEnum.Money_1000;
                case ConfigurationEnum.Money_2000:
                    return (int)ConfigurationEnum.Money_2000;
                case ConfigurationEnum.Money_5000:
                    return (int)ConfigurationEnum.Money_5000;
                case ConfigurationEnum.Money_10000:
                    return (int)ConfigurationEnum.Money_10000;
                case ConfigurationEnum.Money_20000:
                    return (int)ConfigurationEnum.Money_20000;
                case ConfigurationEnum.Money_50000:
                    return (int)ConfigurationEnum.Money_50000;
            }
            return 0;
        }

        public static void GetImageRectangle(out Bitmap bmp, string positionXY, string widthHeight)
        {
            var position = positionXY.Split(',');
            var wtht = widthHeight.Split(',');
            Rectangle rect = new Rectangle(Convert.ToInt32(position[0]), Convert.ToInt32(position[1]), Convert.ToInt32(wtht[0]), Convert.ToInt32(wtht[1]));
            bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, new Size(rect.Width, rect.Height), CopyPixelOperation.SourceCopy);
        }

        public static bool CheckImageValid(Bitmap bmp, string imgPath)
        {
            List<bool> pointCheck = GetHash(bmp);
            List<bool> img = GetHash(new Bitmap(@"" + imgPath));

            //determine the number of equal pixel (x of 256)
            int equalElements = pointCheck.Zip(img, (i, j) => i == j).Count(eq => eq);

            if ((equalElements * 100 / 256) == 100) return true;
            else return false;
        }

        public static void AutoClick(string positionXY)
        {
            autoIt.MouseClick("LEFT", Convert.ToInt32(positionXY.Split(',')[0]), Convert.ToInt32(positionXY.Split(',')[1]), 1, -1);
            Thread.Sleep(1000); 
        }
    }
}
