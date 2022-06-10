﻿// <auto-generated />
using System;
using BP.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BP.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210417171203_Small user model changes")]
    partial class Smallusermodelchanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BP.Models.Fields.Field", b =>
                {
                    b.Property<Guid>("FieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefaultPlayerLimit")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PathUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Payable")
                        .HasColumnType("bit");

                    b.Property<double>("PriceHour")
                        .HasColumnType("float");

                    b.HasKey("FieldId");

                    b.ToTable("Field");
                });

            modelBuilder.Entity("BP.Models.Fields.FieldContact", b =>
                {
                    b.Property<Guid>("FieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FieldId");

                    b.ToTable("FieldContact");
                });

            modelBuilder.Entity("BP.Models.Fields.FieldType", b =>
                {
                    b.Property<Guid>("FieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FieldTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FieldId");

                    b.ToTable("FieldType");
                });

            modelBuilder.Entity("BP.Models.Fields.SportType", b =>
                {
                    b.Property<Guid>("FieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SportName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FieldId");

                    b.ToTable("SportType");
                });

            modelBuilder.Entity("BP.Models.Match.Match", b =>
                {
                    b.Property<Guid>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrentPlayers")
                        .HasColumnType("int");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("PlayerLimit")
                        .HasColumnType("int");

                    b.Property<double>("PriceForPerson")
                        .HasColumnType("float");

                    b.Property<bool>("PublicGame")
                        .HasColumnType("bit");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MatchId");

                    b.HasIndex("FieldId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("BP.Models.Match.MatchUsers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("UserId");

                    b.ToTable("MatchUsers");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("PaymentId");

                    b.HasIndex("FieldId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.PaymentStatusDictionary", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("PaymentStatusDictionary");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.Reservation", b =>
                {
                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReservationId");

                    b.HasIndex("FieldId");

                    b.HasIndex("MatchId")
                        .IsUnique()
                        .HasFilter("[MatchId] IS NOT NULL");

                    b.HasIndex("PaymentId")
                        .IsUnique()
                        .HasFilter("[PaymentId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.ReservationMatch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ReservationMatch");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.ReservationPayment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ReservationPayment");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.ReservationStatusDictionary", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ReservationStatusDictionary");
                });

            modelBuilder.Entity("BP.Models.User.LoginPrivilage", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastPasswordChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LoginPrivilageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Login");

                    b.HasIndex("UserId");

                    b.ToTable("LoginPrivilage");
                });

            modelBuilder.Entity("BP.Models.User.RoleDictionary", b =>
                {
                    b.Property<Guid>("UserTypeDictionaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserTypeDictionaryId");

                    b.HasIndex("UserId");

                    b.ToTable("RoleDictionary");
                });

            modelBuilder.Entity("BP.Models.User.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Absence")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BP.Models.User.UserTypeDictionary", b =>
                {
                    b.Property<Guid>("UserTypeDictionaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserTypeDictionaryId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTypeDictionary");
                });

            modelBuilder.Entity("MatchUser", b =>
                {
                    b.Property<Guid>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MatchId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("MatchUser");
                });

            modelBuilder.Entity("BP.Models.Fields.FieldContact", b =>
                {
                    b.HasOne("BP.Models.Fields.Field", "Field")
                        .WithOne("FieldContact")
                        .HasForeignKey("BP.Models.Fields.FieldContact", "FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("BP.Models.Fields.FieldType", b =>
                {
                    b.HasOne("BP.Models.Fields.Field", "Field")
                        .WithOne("FieldType")
                        .HasForeignKey("BP.Models.Fields.FieldType", "FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("BP.Models.Fields.SportType", b =>
                {
                    b.HasOne("BP.Models.Fields.Field", "Field")
                        .WithOne("SportType")
                        .HasForeignKey("BP.Models.Fields.SportType", "FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("BP.Models.Match.Match", b =>
                {
                    b.HasOne("BP.Models.Fields.Field", "Field")
                        .WithMany("Match")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("BP.Models.Match.MatchUsers", b =>
                {
                    b.HasOne("BP.Models.Match.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BP.Models.User.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.Payment", b =>
                {
                    b.HasOne("BP.Models.Fields.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.Reservation", b =>
                {
                    b.HasOne("BP.Models.Fields.Field", "Field")
                        .WithMany("Reservations")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BP.Models.Match.Match", "Match")
                        .WithOne("Reservation")
                        .HasForeignKey("BP.Models.ReservationPayment.Reservation", "MatchId");

                    b.HasOne("BP.Models.ReservationPayment.Payment", "Payment")
                        .WithOne("Reservation")
                        .HasForeignKey("BP.Models.ReservationPayment.Reservation", "PaymentId");

                    b.HasOne("BP.Models.User.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");

                    b.Navigation("Match");

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BP.Models.User.LoginPrivilage", b =>
                {
                    b.HasOne("BP.Models.User.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BP.Models.User.RoleDictionary", b =>
                {
                    b.HasOne("BP.Models.User.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BP.Models.User.UserTypeDictionary", b =>
                {
                    b.HasOne("BP.Models.User.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MatchUser", b =>
                {
                    b.HasOne("BP.Models.Match.Match", null)
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BP.Models.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BP.Models.Fields.Field", b =>
                {
                    b.Navigation("FieldContact");

                    b.Navigation("FieldType");

                    b.Navigation("Match");

                    b.Navigation("Reservations");

                    b.Navigation("SportType");
                });

            modelBuilder.Entity("BP.Models.Match.Match", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("BP.Models.ReservationPayment.Payment", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("BP.Models.User.User", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
