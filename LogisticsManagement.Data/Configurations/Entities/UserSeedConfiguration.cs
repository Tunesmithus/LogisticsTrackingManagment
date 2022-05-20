using LogisticsManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsManagement.Data;

public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
{

    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        builder.HasData(
            new ApplicationUser
            {
                Id = "5a98663f-baa0-448d-8a26-7c6218a568d4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                CompanyName = "Major Key Trucking",
                FirstName = "Channing",
                LastName = "Robertson",
                PhoneNumber = "6013108018",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            },
            new ApplicationUser
            {
                Id = "94c39c00-deb8-4e14-9482-7509a60ad572",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                CompanyName = "Major Key Trucking",
                FirstName = "Kingston",
                LastName = "Robertson",
                PhoneNumber = "6013108018",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            }

            ); 
    }
}
