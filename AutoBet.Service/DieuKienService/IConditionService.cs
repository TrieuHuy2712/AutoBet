using AutoBet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Service.DieuKienService
{
    public interface IConditionService
    {
        // GET
        List<Condition> GetListCondtion();

        // GET/:id
        Condition GetConditionDetail(int ID);

        // ADD
        void AddCondition(Condition dieuKien);

        // UPDATE
        void UpdateCondition(Condition dieuKien);

        // DELETE
        void RemoveCondition(int ID);
    }
}
