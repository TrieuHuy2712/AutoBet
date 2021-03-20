using AutoBet.Data;
using System.Collections.Generic;
using System.Linq;

namespace AutoBet.Service.DieuKienService
{
    public class DieuKienService : IDieuKien
    {
        private DatabaseContext context = new DatabaseContext();
        public DieuKienService() { }
        public List<DieuKien> DanhSachDieuKien()
        {
            return context.DieuKiens.ToList();
        }

        public DieuKien DieuKienDetail(int ID)
        {
            return context.DieuKiens.Where(dk => dk.ID == ID).FirstOrDefault();
        }

        public void SuaDieuKien(DieuKien dieuKien)
        {
            var updatingDieuKien = DieuKienDetail(dieuKien.ID);

            updatingDieuKien.NoiDung = string.IsNullOrEmpty(dieuKien.NoiDung) ? updatingDieuKien.NoiDung : dieuKien.NoiDung;
            updatingDieuKien.TenDieuKien = string.IsNullOrEmpty(dieuKien.TenDieuKien) ? updatingDieuKien.TenDieuKien : dieuKien.TenDieuKien;

            context.SaveChanges();
        }

        public void ThemDieuKien(DieuKien dieuKien)
        {
            var dieukienMoi = new DieuKien
            {
                NoiDung = dieuKien.NoiDung,
                TenDieuKien = dieuKien.TenDieuKien
            };
            context.DieuKiens.Add(dieukienMoi);
            context.SaveChanges();
        }

        public void XoaDieuKien(int ID)
        {
            var deletingDieuKien = DieuKienDetail(ID);
            if (deletingDieuKien != null)
                context.DieuKiens.Remove(deletingDieuKien);

            context.SaveChanges();
        }
    }
}
