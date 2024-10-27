﻿// <auto-generated />
using System;
using Dokaanah.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dokaanah.DataAccessLayer.Data.Migrations
{
    [DbContext(typeof(Dokkanah2Contex))]
    partial class Dokkanah2ContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dokaanah.DataAccessLayer.ViewModels.CustomerViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AddressView")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NameView")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordView")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("Password is required  ");

                    b.Property<int?>("PhoneNumberView")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.Property<string>("confirmPasswordView")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool?>("isAgreeView")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("CustomerViewModel");
                });

            modelBuilder.Entity("Dokaanah.DataAccessLayer.ViewModels.ProductViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ProductViewModel");
                });

            modelBuilder.Entity("Dokaanah.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationData")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Custid")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Dokaanah.Models.Cart_Product", b =>
                {
                    b.Property<int>("Prid")
                        .HasColumnType("int");

                    b.Property<int>("Caid")
                        .HasColumnType("int");

                    b.Property<int?>("NumberConstant")
                        .HasColumnType("int");

                    b.Property<int?>("ProductItemsNumbers")
                        .HasColumnType("int");

                    b.HasKey("Prid", "Caid");

                    b.HasIndex("Caid");

                    b.ToTable("Cart_Products");
                });

            modelBuilder.Entity("Dokaanah.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationData")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Dokaanah.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<int?>("CustomerViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("confirmPassword")
                        .HasColumnType("longtext");

                    b.Property<bool?>("isAgree")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerViewModelId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Dokaanah.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Customerid")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Customerid");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Dokaanah.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreationData")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Customerid")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Customerid");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Dokaanah.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationData")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("Orderid")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("Sellerid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Orderid");

                    b.HasIndex("Sellerid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Dokaanah.Models.Product_Category", b =>
                {
                    b.Property<int>("Pid")
                        .HasColumnType("int");

                    b.Property<int>("Cid")
                        .HasColumnType("int");

                    b.HasKey("Pid", "Cid");

                    b.HasIndex("Cid");

                    b.ToTable("Product_Categories");
                });

            modelBuilder.Entity("Dokaanah.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationData")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("Dokaanah.Models.product_customer", b =>
                {
                    b.Property<int>("PrudId")
                        .HasColumnType("int");

                    b.Property<string>("CustId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("PrudId", "CustId");

                    b.HasIndex("CustId");

                    b.ToTable("Product_Customers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Dokaanah.Models.Cart_Product", b =>
                {
                    b.HasOne("Dokaanah.Models.Cart", "Ca")
                        .WithMany("Cart_Products")
                        .HasForeignKey("Caid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dokaanah.Models.Product", "Pr")
                        .WithMany("Cart_Products")
                        .HasForeignKey("Prid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ca");

                    b.Navigation("Pr");
                });

            modelBuilder.Entity("Dokaanah.Models.Customer", b =>
                {
                    b.HasOne("Dokaanah.DataAccessLayer.ViewModels.CustomerViewModel", null)
                        .WithMany("CustomersViewModelProp")
                        .HasForeignKey("CustomerViewModelId");
                });

            modelBuilder.Entity("Dokaanah.Models.Order", b =>
                {
                    b.HasOne("Dokaanah.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("Customerid");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Dokaanah.Models.Payment", b =>
                {
                    b.HasOne("Dokaanah.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("Customerid");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Dokaanah.Models.Product", b =>
                {
                    b.HasOne("Dokaanah.Models.Order", "Order")
                        .WithMany("GetProducts")
                        .HasForeignKey("Orderid");

                    b.HasOne("Dokaanah.Models.Seller", "Seller")
                        .WithMany("GetProducts")
                        .HasForeignKey("Sellerid");

                    b.Navigation("Order");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Dokaanah.Models.Product_Category", b =>
                {
                    b.HasOne("Dokaanah.Models.Category", "C")
                        .WithMany("Product_Categories")
                        .HasForeignKey("Cid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dokaanah.Models.Product", "P")
                        .WithMany("Product_Categories")
                        .HasForeignKey("Pid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C");

                    b.Navigation("P");
                });

            modelBuilder.Entity("Dokaanah.Models.product_customer", b =>
                {
                    b.HasOne("Dokaanah.Models.Customer", "Cust")
                        .WithMany("Product_Customelrs")
                        .HasForeignKey("CustId")
                        .IsRequired();

                    b.HasOne("Dokaanah.Models.Product", "Prud")
                        .WithMany("Product_Customers")
                        .HasForeignKey("PrudId")
                        .IsRequired();

                    b.Navigation("Cust");

                    b.Navigation("Prud");
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
                    b.HasOne("Dokaanah.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Dokaanah.Models.Customer", null)
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

                    b.HasOne("Dokaanah.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Dokaanah.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dokaanah.DataAccessLayer.ViewModels.CustomerViewModel", b =>
                {
                    b.Navigation("CustomersViewModelProp");
                });

            modelBuilder.Entity("Dokaanah.Models.Cart", b =>
                {
                    b.Navigation("Cart_Products");
                });

            modelBuilder.Entity("Dokaanah.Models.Category", b =>
                {
                    b.Navigation("Product_Categories");
                });

            modelBuilder.Entity("Dokaanah.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Payments");

                    b.Navigation("Product_Customelrs");
                });

            modelBuilder.Entity("Dokaanah.Models.Order", b =>
                {
                    b.Navigation("GetProducts");
                });

            modelBuilder.Entity("Dokaanah.Models.Product", b =>
                {
                    b.Navigation("Cart_Products");

                    b.Navigation("Product_Categories");

                    b.Navigation("Product_Customers");
                });

            modelBuilder.Entity("Dokaanah.Models.Seller", b =>
                {
                    b.Navigation("GetProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
