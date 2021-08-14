using System;
using BeTestAssignment.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BeTestAssignment.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ConfigureContract(builder);

            SeedCompanies(builder);

            SeedUsers(builder);

            SeedContracts(builder);
        }

        private static void ConfigureContract(ModelBuilder builder)
        {
            builder.Entity<Contract>().HasOne(ctr => ctr.Company)
                .WithMany(cmp => cmp.Contracts).HasForeignKey(ctr => ctr.CompanyId)
                .IsRequired().OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Contract>().HasOne(ctr => ctr.User)
               .WithMany(usr => usr.Contracts).HasForeignKey(ctr => ctr.UserId)
               .IsRequired().OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Contract>().Property(ctr => ctr.Occupation).IsRequired();
        }

        private static void SeedUsers(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "ab07a835-1db0-4610-8661-380134b7d361",
                    UserName = "ubergeeb@aol.com",
                    NormalizedUserName = "UBERGEEB@AOL.COM",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                    UserName = "amichalo@live.com",
                    NormalizedUserName = "AMICHALO@LIVE.COM",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                    UserName = "mastinfo@sbcglobal.net",
                    NormalizedUserName = "MASTINFO@SBCGLOBAL.NET",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "3dc0badb-71dd-4ce7-b3e7-052349b2996f",
                    UserName = "sbmrjbr@optonline.net",
                    NormalizedUserName = "SBMRJBR@OPTONLINE.NET",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "b5ab401b-dfc6-4553-b275-5519253cf9da",
                    UserName = "satishr@hotmail.com",
                    NormalizedUserName = "SATISHR@HOTMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "522608c8-bac8-43d6-bdce-cfdf77dfad43",
                    UserName = "weazelman@icloud.com",
                    NormalizedUserName = "WEAZELMAN@ICLOUD.COM",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8",
                    UserName = "wmszeliga@yahoo.ca",
                    NormalizedUserName = "WMSZELIGA@YAHOO.CA",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "2652e409-1d33-4933-baa2-951954e7cf6b",
                    UserName = "cderoove@att.net",
                    NormalizedUserName = "CDEROOVE@ATT.NET",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2",
                    UserName = "jaarnial@aol.com",
                    NormalizedUserName = "JAARNIAL@AOL.COM",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "8c6a38f1-80b4-4625-affc-061837bee170",
                    UserName = "sarahs@outlook.com",
                    NormalizedUserName = "SARAHS@OUTLOOK.COM",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                });
        }

        private static void SeedCompanies(ModelBuilder builder)
        {
            builder.Entity<Company>().HasData(
                new Company
                {
                    Id = new Guid("6b55dfab-c72e-4a1b-a229-fd11c406e146"),
                    Name = "Company One",
                    Address = "Nurme 99, Varudi, Lääne-Virumaa",
                    CountryCode = "est",
                    RegistryCode = "123451"
                },
                new Company
                {
                    Id = new Guid("68a720d6-049f-4f4b-957e-04bfb4380d64"),
                    Name = "Company Two",
                    Address = "Kase 93, Paatsalu, Pärnumaa",
                    CountryCode = "est",
                    RegistryCode = "123452"
                },
                new Company
                {
                    Id = new Guid("8e8004bc-25c9-4313-b9d9-60358ad2c995"),
                    Name = "Company Three",
                    Address = "Kraavi 4, Viljandi, Viljandimaa",
                    CountryCode = "est",
                    RegistryCode = "123453"
                },
                new Company
                {
                    Id = new Guid("7fa7d08e-d5d1-4c34-bf7d-83c3f55a749b"),
                    Name = "Company Four",
                    Address = "Tamme 78, Tsiamäe, Võrumaa",
                    CountryCode = "est",
                    RegistryCode = "123454"
                },
                new Company
                {
                    Id = new Guid("4f7750ac-02b9-43eb-af0d-1b8ae1601867"),
                    Name = "Company Five",
                    Address = "Jõe 41, Mõisamäe, Võrumaa",
                    CountryCode = "est",
                    RegistryCode = "123455"
                },
                new Company
                {
                    Id = new Guid("88fb0b1b-ad3a-4991-98f6-4673263bca31"),
                    Name = "Company Six",
                    Address = "Õie 96, Neeruti, Lääne-Virumaa",
                    CountryCode = "est",
                    RegistryCode = "123456"
                }
            );
        }

        private static void SeedContracts(ModelBuilder builder)
        {
            builder.Entity<Contract>().HasData(
                new Contract
                {
                    Id = new Guid("6b7a60ab-c380-4935-a3a9-626364ca3bc7"),
                    Occupation = "Carpenter",
                    StartDate = new DateTime(2021, 08, 2),
                    EndDate = null,
                    CompanyId = new Guid("88fb0b1b-ad3a-4991-98f6-4673263bca31"),
                    UserId = "8c6a38f1-80b4-4625-affc-061837bee170",
                });
        }
    }
}