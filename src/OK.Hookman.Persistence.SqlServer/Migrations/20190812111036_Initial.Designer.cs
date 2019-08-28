﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OK.Hookman.Persistence.SqlServer.Contexts;

namespace OK.Hookman.Persistence.SqlServer.Migrations
{
    [DbContext(typeof(HookmanDataContext))]
    [Migration("20190812111036_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OK.Hookman.Persistence.Core.Entities.ActionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Actions","hmx");
                });

            modelBuilder.Entity("OK.Hookman.Persistence.Core.Entities.EventEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActionId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Headers");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Method");

                    b.Property<string>("Path");

                    b.Property<string>("QueryStrings");

                    b.Property<int>("ReceiverId");

                    b.Property<int>("RetryCount");

                    b.Property<int?>("SenderId");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("ActionId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Events","hmx");
                });

            modelBuilder.Entity("OK.Hookman.Persistence.Core.Entities.HookEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Data");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<int>("EventId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Message");

                    b.Property<string>("RequestBody");

                    b.Property<string>("RequestHeaders");

                    b.Property<string>("RequestUrl");

                    b.Property<string>("ResponseBody");

                    b.Property<int>("ResponseCode");

                    b.Property<string>("ResponseHeaders");

                    b.Property<int>("SenderId");

                    b.Property<int>("StatusId");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("SenderId");

                    b.HasIndex("StatusId");

                    b.ToTable("Hooks","hmx");
                });

            modelBuilder.Entity("OK.Hookman.Persistence.Core.Entities.ReceiverEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Headers");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<string>("QueryStrings");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Receivers","hmx");
                });

            modelBuilder.Entity("OK.Hookman.Persistence.Core.Entities.SenderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("Token");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Senders","hmx");
                });

            modelBuilder.Entity("OK.Hookman.Persistence.Core.Entities.StatusEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Statuses","hmx");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Created"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Sending"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Sent"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Failed"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Canceled"
                        });
                });

            modelBuilder.Entity("OK.Hookman.Persistence.Core.Entities.EventEntity", b =>
                {
                    b.HasOne("OK.Hookman.Persistence.Core.Entities.ActionEntity", "Action")
                        .WithMany("Events")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OK.Hookman.Persistence.Core.Entities.ReceiverEntity", "Receiver")
                        .WithMany("Events")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OK.Hookman.Persistence.Core.Entities.SenderEntity", "Sender")
                        .WithMany("Events")
                        .HasForeignKey("SenderId");
                });

            modelBuilder.Entity("OK.Hookman.Persistence.Core.Entities.HookEntity", b =>
                {
                    b.HasOne("OK.Hookman.Persistence.Core.Entities.EventEntity", "Event")
                        .WithMany("Hooks")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OK.Hookman.Persistence.Core.Entities.SenderEntity", "Sender")
                        .WithMany("Hooks")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OK.Hookman.Persistence.Core.Entities.StatusEntity", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
