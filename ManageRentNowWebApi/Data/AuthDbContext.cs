using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ManageRentNow.Api.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var landlordRoleId = "9a9467c7-e557-483b-9a4b-902cc3d9f1aa";
            var tenantRoleId = "f7fd4c2e-2e4b-45c2-a66a-a8aa99093fb5";
            var adminRoleId = "7f02db65-b38d-4c1c-9ed4-aa985203dd88";

            var roles = new List<IdentityRole>
                {
                    new IdentityRole
                    {
                        Id  = landlordRoleId,
                        ConcurrencyStamp = landlordRoleId,
                        Name = "Landlord",
                        NormalizedName = "LANDLORD"
                    },
                    new IdentityRole
                    {
                        Id  = tenantRoleId,
                        ConcurrencyStamp = tenantRoleId,
                        Name = "Tenant",
                        NormalizedName = "TENANT"
                    },
                      new IdentityRole
                    {
                        Id  = adminRoleId,
                        ConcurrencyStamp = adminRoleId,
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
