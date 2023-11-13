﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using powerpage.DataLayer.SQLite;

#nullable disable

namespace powerpage.DataLayer.SQLite.Migrations
{
    [DbContext(typeof(SQLiteDbContext))]
    [Migration("20231009154603_V2023_10_09_1945")]
    partial class V2023_10_09_1945
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("NOCASE")
                .HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("powerpage.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.AppDataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FriendlyName")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("XmlData")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("FriendlyName")
                        .IsUnique();

                    b.ToTable("AppDataProtectionKeys", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Identity.AppLogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogLevel")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Logger")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("StateJson")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.ToTable("AppLogItems");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.AppSqlCache", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(449)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<DateTime?>("AbsoluteExpiration")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiresAtTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("SlidingExpirationInSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Value")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("ExpiresAtTime")
                        .HasDatabaseName("Index_ExpiresAtTime");

                    b.ToTable("AppSqlCache", "dbo");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AppRoles", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEmailPublic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<DateTime?>("LastVisitDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhotoFileName")
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AppUsers", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserUsedPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserUsedPasswords", (string)null);
                });

            modelBuilder.Entity("powerpage.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("powerpage.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<int?>("ModifiedByUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("powerpage.Entities.StringResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT")
                        .UseCollation("NOCASE");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("StringResources");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.RoleClaim", b =>
                {
                    b.HasOne("powerpage.Entities.Identity.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserClaim", b =>
                {
                    b.HasOne("powerpage.Entities.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserLogin", b =>
                {
                    b.HasOne("powerpage.Entities.Identity.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("powerpage.Entities.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("powerpage.Entities.Identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserToken", b =>
                {
                    b.HasOne("powerpage.Entities.Identity.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.UserUsedPassword", b =>
                {
                    b.HasOne("powerpage.Entities.Identity.User", "User")
                        .WithMany("UserUsedPasswords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("powerpage.Entities.Product", b =>
                {
                    b.HasOne("powerpage.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("powerpage.Entities.StringResource", b =>
                {
                    b.HasOne("powerpage.Entities.Language", "Language")
                        .WithMany("StringResources")
                        .HasForeignKey("LanguageId");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("powerpage.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.Role", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("powerpage.Entities.Identity.User", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("Roles");

                    b.Navigation("UserTokens");

                    b.Navigation("UserUsedPasswords");
                });

            modelBuilder.Entity("powerpage.Entities.Language", b =>
                {
                    b.Navigation("StringResources");
                });
#pragma warning restore 612, 618
        }
    }
}
