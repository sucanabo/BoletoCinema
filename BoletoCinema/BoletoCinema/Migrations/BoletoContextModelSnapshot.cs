﻿// <auto-generated />
using System;
using BoletoCinema.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoletoCinema.Migrations
{
    [DbContext(typeof(BoletoContext))]
    partial class BoletoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Actor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("actors");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Branch", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("branches");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.ContactForm", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("contactForms");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Discount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("discount_percent")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("discounts");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("movie_id")
                        .HasColumnType("int");

                    b.Property<string>("path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("movie_id");

                    b.ToTable("images");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("published_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("summery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trailer_path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Movie_Actor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("actor_id")
                        .HasColumnType("int");

                    b.Property<int>("movie_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("actor_id");

                    b.HasIndex("movie_id");

                    b.ToTable("movie_Actors");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Movie_Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("movie_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("category_id");

                    b.HasIndex("movie_id");

                    b.ToTable("movie_Categories");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Movie_Discount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("discount_id")
                        .HasColumnType("int");

                    b.Property<int>("movie_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("discount_id");

                    b.HasIndex("movie_id");

                    b.ToTable("Movie_Discount");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<double>("total_price")
                        .HasColumnType("float");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Report", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("create_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("review_id")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("review_id");

                    b.ToTable("reports");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Review", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("heart_rate")
                        .HasColumnType("int");

                    b.Property<int>("movie_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("movie_id");

                    b.HasIndex("user_id");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Room", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("branch_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("branch_id");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Schedule", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("room_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("room_id");

                    b.ToTable("schedules");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Seat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("room_id")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("room_id");

                    b.ToTable("seats");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Session", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("end_time")
                        .HasColumnType("datetime2");

                    b.Property<int>("movie_id")
                        .HasColumnType("int");

                    b.Property<int>("schedule_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("show_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("start_time")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("movie_id");

                    b.HasIndex("schedule_id");

                    b.ToTable("sessions");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Ticket", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Sessionid")
                        .HasColumnType("int");

                    b.Property<int?>("order_id")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int?>("room_id")
                        .HasColumnType("int");

                    b.Property<int?>("schedule_id")
                        .HasColumnType("int");

                    b.Property<int?>("seat_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Sessionid");

                    b.HasIndex("order_id");

                    b.HasIndex("room_id");

                    b.HasIndex("schedule_id");

                    b.HasIndex("seat_id")
                        .IsUnique()
                        .HasFilter("[seat_id] IS NOT NULL");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("displayname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rule")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.UserDiscount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("discount_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("discount_id");

                    b.HasIndex("user_id");

                    b.ToTable("userDiscounts");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.ContactForm", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.User", "user")
                        .WithMany("contactForms")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Image", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Movie", "movie")
                        .WithMany("images")
                        .HasForeignKey("movie_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("movie");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Movie_Actor", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Actor", "actor")
                        .WithMany("movie_Actors")
                        .HasForeignKey("actor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoletoCinema.Areas.Admin.Models.Movie", "movie")
                        .WithMany("movie_Actors")
                        .HasForeignKey("movie_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("actor");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Movie_Category", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Category", "category")
                        .WithMany("movie_category")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoletoCinema.Areas.Admin.Models.Movie", "movie")
                        .WithMany("movie_Categories")
                        .HasForeignKey("movie_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Movie_Discount", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Discount", "discount")
                        .WithMany("movieDiscounts")
                        .HasForeignKey("discount_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoletoCinema.Areas.Admin.Models.Movie", "movie")
                        .WithMany("movieDiscounts")
                        .HasForeignKey("movie_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("discount");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Order", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Report", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Review", "review")
                        .WithMany("report")
                        .HasForeignKey("review_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("review");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Review", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("movie_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoletoCinema.Areas.Admin.Models.User", "user")
                        .WithMany("reviews")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("movie");

                    b.Navigation("user");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Room", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Branch", "branch")
                        .WithMany("rooms")
                        .HasForeignKey("branch_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("branch");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Schedule", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Room", "room")
                        .WithMany("schedules")
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("room");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Seat", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Room", "room")
                        .WithMany("seats")
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("room");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Session", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Movie", "movie")
                        .WithMany("ListSession")
                        .HasForeignKey("movie_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoletoCinema.Areas.Admin.Models.Schedule", "schedule")
                        .WithMany()
                        .HasForeignKey("schedule_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("movie");

                    b.Navigation("schedule");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Ticket", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Session", null)
                        .WithMany("tickets")
                        .HasForeignKey("Sessionid");

                    b.HasOne("BoletoCinema.Areas.Admin.Models.Order", "order")
                        .WithMany("tickets")
                        .HasForeignKey("order_id");

                    b.HasOne("BoletoCinema.Areas.Admin.Models.Room", "room")
                        .WithMany("tickets")
                        .HasForeignKey("room_id");

                    b.HasOne("BoletoCinema.Areas.Admin.Models.Schedule", "schedule")
                        .WithMany("tickets")
                        .HasForeignKey("schedule_id");

                    b.HasOne("BoletoCinema.Areas.Admin.Models.Seat", "seat")
                        .WithOne("tickets")
                        .HasForeignKey("BoletoCinema.Areas.Admin.Models.Ticket", "seat_id");

                    b.Navigation("order");

                    b.Navigation("room");

                    b.Navigation("schedule");

                    b.Navigation("seat");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.UserDiscount", b =>
                {
                    b.HasOne("BoletoCinema.Areas.Admin.Models.Discount", "discount")
                        .WithMany("user_discount")
                        .HasForeignKey("discount_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoletoCinema.Areas.Admin.Models.User", "user")
                        .WithMany("userDiscounts")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("discount");

                    b.Navigation("user");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Actor", b =>
                {
                    b.Navigation("movie_Actors");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Branch", b =>
                {
                    b.Navigation("rooms");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Category", b =>
                {
                    b.Navigation("movie_category");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Discount", b =>
                {
                    b.Navigation("movieDiscounts");

                    b.Navigation("user_discount");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Movie", b =>
                {
                    b.Navigation("images");

                    b.Navigation("ListSession");

                    b.Navigation("movie_Actors");

                    b.Navigation("movie_Categories");

                    b.Navigation("movieDiscounts");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Order", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Review", b =>
                {
                    b.Navigation("report");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Room", b =>
                {
                    b.Navigation("schedules");

                    b.Navigation("seats");

                    b.Navigation("tickets");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Schedule", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Seat", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.Session", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("BoletoCinema.Areas.Admin.Models.User", b =>
                {
                    b.Navigation("contactForms");

                    b.Navigation("orders");

                    b.Navigation("reviews");

                    b.Navigation("userDiscounts");
                });
#pragma warning restore 612, 618
        }
    }
}
