using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OrderManager.Model.Models.Mapping
{
    public class OM_PermissionMap : EntityTypeConfiguration<OM_Permission>
    {
        public OM_PermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.Guid);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Guid)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AreaName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ControllerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ActionName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ico)
                .HasMaxLength(100);

            this.Property(t => t.LinkUrl)
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OM_Permission");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.Parent).HasColumnName("Parent");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
            this.Property(t => t.ControllerName).HasColumnName("ControllerName");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
            this.Property(t => t.FormMethod).HasColumnName("FormMethod");
            this.Property(t => t.OperationType).HasColumnName("OperationType");
            this.Property(t => t.Ico).HasColumnName("Ico");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
            this.Property(t => t.IsLink).HasColumnName("IsLink");
            this.Property(t => t.LinkUrl).HasColumnName("LinkUrl");
            this.Property(t => t.IsShow).HasColumnName("IsShow");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsDel).HasColumnName("IsDel");
            this.Property(t => t.CreateDatetime).HasColumnName("CreateDatetime");
            this.Property(t => t.UpdateDateTime).HasColumnName("UpdateDateTime");
        }
    }
}
