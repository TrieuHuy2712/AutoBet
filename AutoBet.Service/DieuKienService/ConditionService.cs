using AutoBet.Data;
using System.Collections.Generic;
using System.Linq;

namespace AutoBet.Service.DieuKienService
{
    public class ConditionService : IConditionService
    {
        private DatabaseContext context = new DatabaseContext();
        public ConditionService() { }
        public List<Condition> GetListCondtion()
        {
            return context.Conditions.ToList();
        }

        public void UpdateCondition(Condition condition)
        {
            var updatingCondition = GetConditionDetail(condition.ID);

            updatingCondition.ConditionContent = string.IsNullOrEmpty(condition.ConditionContent) ? updatingCondition.ConditionContent : condition.ConditionContent;
            updatingCondition.ConditionTitle = string.IsNullOrEmpty(condition.ConditionTitle) ? updatingCondition.ConditionTitle : condition.ConditionTitle;

            context.SaveChanges();
        }

        public void AddCondition(Condition condition)
        {
            var dieukienMoi = new Condition
            {
                ConditionContent = condition.ConditionContent,
                ConditionTitle = condition.ConditionTitle
            };
            context.Conditions.Add(dieukienMoi);
            context.SaveChanges();
        }

        public void RemoveCondition(int ID)
        {
            var deletingDieuKien = GetConditionDetail(ID);
            if (deletingDieuKien != null)
                context.Conditions.Remove(deletingDieuKien);

            context.SaveChanges();
        }

        public Condition GetConditionDetail(int ID)
        {
            return context.Conditions.Where(dk => dk.ID == ID).FirstOrDefault();
        }
    }
}
