using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Data.Mapping
{
    public class DieuKienMapping: EntityTypeConfiguration<DieuKien>
    {
        public DieuKienMapping()
        {
            ToTable("DieuKien");
            Property(p => p.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.TenDieuKien);
            Property(p => p.NoiDung);

        }
    }
}
