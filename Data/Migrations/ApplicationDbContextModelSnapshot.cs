﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Ord.WebApi.Data.Contexts;

namespace Ord.WebApi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Ord.WebApi.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId", "Name")
                        .IsUnique();

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.MenuCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MenuId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MenuId", "Name")
                        .IsUnique();

                    b.ToTable("MenuCategories");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrdUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("CanPlaceOrders")
                        .HasColumnType("boolean");

                    b.Property<string>("DeviceToken")
                        .HasColumnType("text");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("text");

                    b.Property<int>("OauthId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("OrdUsers");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrdUserHomeAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ComplexName")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("text");

                    b.Property<int>("OrdUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Suburb")
                        .HasColumnType("text");

                    b.Property<string>("UnitNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrdUserId");

                    b.ToTable("OrdUserHomeAddresses");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrdUserWorkAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BuildingName")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("text");

                    b.Property<string>("FloorNumber")
                        .HasColumnType("text");

                    b.Property<string>("OfficeParkName")
                        .HasColumnType("text");

                    b.Property<int>("OrdUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Suburb")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrdUserId");

                    b.ToTable("OrdUserWorkAddresses");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("OrdUserId")
                        .HasColumnType("integer");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("integer");

                    b.Property<string>("StoreOrderNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrdUserId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrderInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateTimeAccepted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateTimeCancelled")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateTimeCompleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateTimePlaced")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateTimeReady")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("boolean");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("numeric");

                    b.Property<int>("RestaurantCollectionTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("RestaurantPaymentMethodId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("RestaurantCollectionTypeId");

                    b.HasIndex("RestaurantPaymentMethodId");

                    b.ToTable("OrderInfo");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ComplexName")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsHalal")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSuspended")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrdUserId")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("RestaurantCoverImagePath")
                        .HasColumnType("text");

                    b.Property<string>("RestaurantImagePath")
                        .HasColumnType("text");

                    b.Property<int>("ServiceAreaId")
                        .HasColumnType("integer");

                    b.Property<string>("ShopNumber")
                        .HasColumnType("text");

                    b.Property<string>("ShoppingCenterName")
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Suburb")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrdUserId");

                    b.HasIndex("ServiceAreaId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.ServiceArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Suburb")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ServiceAreas");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Shared.CollectionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("CollectionTypes");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Shared.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Shared.RestaurantCollectionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CollectionTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CollectionTypeId");

                    b.HasIndex("RestaurantId", "CollectionTypeId")
                        .IsUnique();

                    b.ToTable("RestaurantCollectionTypes");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Shared.RestaurantPaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("integer");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("RestaurantId", "PaymentMethodId")
                        .IsUnique();

                    b.ToTable("RestaurantPaymentMethods");
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Menu", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.Restaurant", "Restaurant")
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.MenuCategory", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.Menu", "Menu")
                        .WithMany("MenuCategories")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.MenuItem", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.MenuCategory", "Category")
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrdUserHomeAddress", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.OrdUser", "OrdUser")
                        .WithMany()
                        .HasForeignKey("OrdUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrdUserWorkAddress", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.OrdUser", "OrdUser")
                        .WithMany()
                        .HasForeignKey("OrdUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Order", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.OrdUser", "OrdUser")
                        .WithMany()
                        .HasForeignKey("OrdUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ord.WebApi.Entities.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrderInfo", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.Order", "Order")
                        .WithOne("OrderInfo")
                        .HasForeignKey("Ord.WebApi.Entities.OrderInfo", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ord.WebApi.Entities.Shared.RestaurantCollectionType", "CollectionType")
                        .WithMany()
                        .HasForeignKey("RestaurantCollectionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ord.WebApi.Entities.Shared.RestaurantPaymentMethod", "RestaurantPaymentMethod")
                        .WithMany()
                        .HasForeignKey("RestaurantPaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.OrderItem", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.MenuItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ord.WebApi.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Restaurant", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.OrdUser", "OrdUser")
                        .WithMany()
                        .HasForeignKey("OrdUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ord.WebApi.Entities.ServiceArea", "ServiceArea")
                        .WithMany()
                        .HasForeignKey("ServiceAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Shared.RestaurantCollectionType", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.Shared.CollectionType", "CollectionType")
                        .WithMany()
                        .HasForeignKey("CollectionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ord.WebApi.Entities.Restaurant", "Restaurant")
                        .WithMany("CollectionTypes")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ord.WebApi.Entities.Shared.RestaurantPaymentMethod", b =>
                {
                    b.HasOne("Ord.WebApi.Entities.Shared.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ord.WebApi.Entities.Restaurant", "Restaurant")
                        .WithMany("PaymentMethods")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
