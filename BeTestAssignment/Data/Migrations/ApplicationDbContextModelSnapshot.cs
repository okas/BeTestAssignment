﻿// <auto-generated />
using System;
using BeTestAssignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeTestAssignment.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeTestAssignment.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "ab07a835-1db0-4610-8661-380134b7d361",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9448ba20-1b52-45ff-9cad-2870832cacec",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "UBERGEEB@AOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHZEZLxDwa5kUvHslMfLAk+RjA6MSpWkVCr7dk3rp3jaSQmDyoT6Q/hDNl5QolaJ/A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a535cda9-2fb7-425f-9ffa-99665d4e43ef",
                            TwoFactorEnabled = false,
                            UserName = "ubergeeb@aol.com"
                        },
                        new
                        {
                            Id = "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "081e214c-04c1-4a78-83e6-01e37e02a6c7",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "AMICHALO@LIVE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJwgrPZsWTGd8vqHMqYz+KKKRB02iz954F+DyLM2jjfUBNoG1arXMX5FKZ1LRT+/YA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "80b95cc6-4771-488b-9216-86c1a9e2eabb",
                            TwoFactorEnabled = false,
                            UserName = "amichalo@live.com"
                        },
                        new
                        {
                            Id = "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "78c7a942-d876-41bb-bc83-207e91ff7a62",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "MASTINFO@SBCGLOBAL.NET",
                            PasswordHash = "AQAAAAEAACcQAAAAEBoXroy61yvPRzPr5iWeFTnzbwG/z5yrYyuaIRPOCclcuW9VtoQZk/2XkWOmHiUxIA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6413183c-2305-43af-be5a-30b4407e2b44",
                            TwoFactorEnabled = false,
                            UserName = "mastinfo@sbcglobal.net"
                        },
                        new
                        {
                            Id = "3dc0badb-71dd-4ce7-b3e7-052349b2996f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e6f383c0-fb55-42b2-82a3-d17092e19242",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "SBMRJBR@OPTONLINE.NET",
                            PasswordHash = "AQAAAAEAACcQAAAAEPAJyPVD+8CgvR613d9OdxwwXjpvsGXp+nVtOB+o2bqbHv4Xdmb8+w015AwZea0a0A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2e523f8f-e13b-4179-adf6-ffd7f6a874a4",
                            TwoFactorEnabled = false,
                            UserName = "sbmrjbr@optonline.net"
                        },
                        new
                        {
                            Id = "b5ab401b-dfc6-4553-b275-5519253cf9da",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e67899c5-c08f-4410-b586-26b6df787b57",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "SATISHR@HOTMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELpKWz4ejfvZD9HxI0bv4mKcV04DN4oYjJadq8Aed0vhuocPgbaQE/BFzCPP/Hp1bw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "074e01a4-787f-47cf-95ba-15fdc4de02a2",
                            TwoFactorEnabled = false,
                            UserName = "satishr@hotmail.com"
                        },
                        new
                        {
                            Id = "522608c8-bac8-43d6-bdce-cfdf77dfad43",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "36c6de73-db46-4a8d-9246-57e2ae7e74ec",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "WEAZELMAN@ICLOUD.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIgOt6o6fGpc54K0XYyKy1n+Nu7KLRlNtEWhVHr3nL8D+mGjxFV9V0Qhau+tCwSyvQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6a95deae-6b31-41c9-a040-a798056146f8",
                            TwoFactorEnabled = false,
                            UserName = "weazelman@icloud.com"
                        },
                        new
                        {
                            Id = "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "95d22183-dec1-4a7a-94c7-0459c58260cd",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "WMSZELIGA@YAHOO.CA",
                            PasswordHash = "AQAAAAEAACcQAAAAEIjJh6QPIgogVni+pT0J56XVOUxBRxid15uqJoj72vuNao2gZmDY++2R1H9ENeuLqQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "52ec0347-8be1-4d00-810b-fc1fa69e89d1",
                            TwoFactorEnabled = false,
                            UserName = "wmszeliga@yahoo.ca"
                        },
                        new
                        {
                            Id = "2652e409-1d33-4933-baa2-951954e7cf6b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dcb22c19-e95d-4580-83cf-127e989abaf5",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "CDEROOVE@ATT.NET",
                            PasswordHash = "AQAAAAEAACcQAAAAELJyBHLlBdtn3awVH/2N71V6YnKMQhs0ILnbx4B6HlxHCDhe5h3LPBpOZO3+eDS8Uw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0b28ef5c-bfdd-477c-9f9a-5f4a05c74196",
                            TwoFactorEnabled = false,
                            UserName = "cderoove@att.net"
                        },
                        new
                        {
                            Id = "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "866da966-a4fb-4fb4-9a28-34184636819d",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "JAARNIAL@AOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFixmA4Yjg0VfwcvuqOOTPZoPTteE0MQ2c/K05nviuzEC9RVkg5IcJOm36OzldXfBA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7aab0428-1dca-4435-97d1-0b3ced4c5cd3",
                            TwoFactorEnabled = false,
                            UserName = "jaarnial@aol.com"
                        },
                        new
                        {
                            Id = "8c6a38f1-80b4-4625-affc-061837bee170",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7f0d9429-c9a5-4a25-b433-d2c1de895e7b",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "SARAHS@OUTLOOK.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMxnAv+XCOPFGbYHrVvcH2/Zo2f1q6kx8ckP3OCoKBuaq3y48N6/PBjeJ+5T6aNKlw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e0441bce-985b-4d77-a395-afc9f0b21e91",
                            TwoFactorEnabled = false,
                            UserName = "sarahs@outlook.com"
                        });
                });

            modelBuilder.Entity("BeTestAssignment.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistryCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b55dfab-c72e-4a1b-a229-fd11c406e146"),
                            Address = "Nurme 99, Varudi, Lääne-Virumaa",
                            CountryCode = "est",
                            Name = "Company One",
                            RegistryCode = "123451"
                        },
                        new
                        {
                            Id = new Guid("68a720d6-049f-4f4b-957e-04bfb4380d64"),
                            Address = "Kase 93, Paatsalu, Pärnumaa",
                            CountryCode = "est",
                            Name = "Company Two",
                            RegistryCode = "123452"
                        },
                        new
                        {
                            Id = new Guid("8e8004bc-25c9-4313-b9d9-60358ad2c995"),
                            Address = "Kraavi 4, Viljandi, Viljandimaa",
                            CountryCode = "est",
                            Name = "Company Three",
                            RegistryCode = "123453"
                        },
                        new
                        {
                            Id = new Guid("7fa7d08e-d5d1-4c34-bf7d-83c3f55a749b"),
                            Address = "Tamme 78, Tsiamäe, Võrumaa",
                            CountryCode = "est",
                            Name = "Company Four",
                            RegistryCode = "123454"
                        },
                        new
                        {
                            Id = new Guid("4f7750ac-02b9-43eb-af0d-1b8ae1601867"),
                            Address = "Jõe 41, Mõisamäe, Võrumaa",
                            CountryCode = "est",
                            Name = "Company Five",
                            RegistryCode = "123455"
                        },
                        new
                        {
                            Id = new Guid("88fb0b1b-ad3a-4991-98f6-4673263bca31"),
                            Address = "Õie 96, Neeruti, Lääne-Virumaa",
                            CountryCode = "est",
                            Name = "Company Six",
                            RegistryCode = "123456"
                        });
                });

            modelBuilder.Entity("BeTestAssignment.Models.Contract", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CompanyId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BeTestAssignment.Models.Contract", b =>
                {
                    b.HasOne("BeTestAssignment.Models.Company", "Company")
                        .WithMany("Contracts")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeTestAssignment.Models.ApplicationUser", "User")
                        .WithMany("Contracts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BeTestAssignment.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BeTestAssignment.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeTestAssignment.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BeTestAssignment.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
