﻿// <auto-generated />
using System;
using Agoda.FileDownloaderSystem.DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agoda.FileDownloaderSystem.DataAccess.Migrations
{
    [DbContext(typeof(FileDownloaderCommandsContext))]
    [Migration("20200311150621_filedownloadersystebetabversion")]
    partial class filedownloadersystebetabversion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agoda.FileDownloaderSystem.Entities.File", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DownloadEndedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("DownloadSpeed")
                        .HasColumnType("float");

                    b.Property<DateTime>("DownloadStartedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ElapsedTime")
                        .HasColumnType("float");

                    b.Property<bool>("IsLargeData")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSlow")
                        .HasColumnType("bit");

                    b.Property<int>("PercentageOfFailure")
                        .HasColumnType("int");

                    b.Property<int>("ProtocolId")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("FileId");

                    b.HasIndex("ProtocolId");

                    b.HasIndex("StatusId");

                    b.ToTable("File");
                });

            modelBuilder.Entity("Agoda.FileDownloaderSystem.Entities.Protocol", b =>
                {
                    b.Property<int>("ProtocolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProtocolId");

                    b.ToTable("Protocol");

                    b.HasData(
                        new
                        {
                            ProtocolId = 1,
                            Name = "http"
                        },
                        new
                        {
                            ProtocolId = 2,
                            Name = "https"
                        },
                        new
                        {
                            ProtocolId = 3,
                            Name = "ftp"
                        },
                        new
                        {
                            ProtocolId = 4,
                            Name = "sftp"
                        },
                        new
                        {
                            ProtocolId = 5,
                            Name = "net.tcp"
                        },
                        new
                        {
                            ProtocolId = 6,
                            Name = "net.pipe"
                        });
                });

            modelBuilder.Entity("Agoda.FileDownloaderSystem.Entities.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            Name = "Completed"
                        },
                        new
                        {
                            StatusId = 2,
                            Name = "Failed"
                        });
                });

            modelBuilder.Entity("Agoda.FileDownloaderSystem.Entities.File", b =>
                {
                    b.HasOne("Agoda.FileDownloaderSystem.Entities.Protocol", "Protocol")
                        .WithMany()
                        .HasForeignKey("ProtocolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agoda.FileDownloaderSystem.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
