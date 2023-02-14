﻿// <auto-generated />
using System;
using EntityFrameworkHelloWorld.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkHelloWorld.Migrations
{
    [DbContext(typeof(MembershipDatabaseContext))]
    [Migration("20230213144615_AddAccessLogs")]
    partial class AddAccessLogs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.13");

            modelBuilder.Entity("EntityFrameworkHelloWorld.models.AccessLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("MemberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("AccessLog");
                });

            modelBuilder.Entity("EntityFrameworkHelloWorld.models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CreditRating")
                        .HasColumnType("REAL");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("EntityFrameworkHelloWorld.models.AccessLog", b =>
                {
                    b.HasOne("EntityFrameworkHelloWorld.models.Member", "Member")
                        .WithMany("AccessLogs")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("EntityFrameworkHelloWorld.models.Member", b =>
                {
                    b.Navigation("AccessLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
