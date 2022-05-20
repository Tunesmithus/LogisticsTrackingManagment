using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsManagement.Data
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                    UserId = "5a98663f-baa0-448d-8a26-7c6218a568d4",
                },

                new IdentityUserRole<string>
                {
                    RoleId = "34c39c00-deb8-4e14-9482-7509a60ad573",
                    UserId = "94c39c00-deb8-4e14-9482-7509a60ad572",
                }

                );
        }
    }
}