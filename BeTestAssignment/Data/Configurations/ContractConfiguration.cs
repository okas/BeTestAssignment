using BeTestAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeTestAssignment.Data.Configurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(ctr => ctr.Company).WithMany(cmp => cmp.Contracts)
                .HasForeignKey(ctr => ctr.CompanyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ctr => ctr.User).WithMany(usr => usr.Contracts)
                .HasForeignKey(ctr => ctr.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(ctr => ctr.CompanyId);
            builder.HasIndex(ctr => ctr.UserId);
            builder.HasIndex(ctr => new { ctr.CompanyId, ctr.UserId }).IsUnique();
            builder.Property(ctr => ctr.Occupation).IsRequired();
        }
    }
}
