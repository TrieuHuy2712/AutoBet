using AutoBet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Service.DieuKienService
{
    public interface IDieuKien
    {
        // GET
        List<DieuKien> DanhSachDieuKien();

        // GET/:id
        DieuKien DieuKienDetail(int ID);

        // ADD
        void ThemDieuKien(DieuKien dieuKien);

        // UPDATE
        void SuaDieuKien(DieuKien dieuKien);

        // DELETE
        void XoaDieuKien(int ID);
    }
}
