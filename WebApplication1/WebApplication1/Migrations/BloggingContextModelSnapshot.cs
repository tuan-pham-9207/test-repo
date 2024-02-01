﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Entities.ConstructionDrawing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CompletionDateline")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("FieldId")
                        .HasColumnType("bigint");

                    b.Property<long>("MainClassificationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Order")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("SubClassificationId")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SubClassificationId");

                    b.ToTable("ConstructionDrawings");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.DrawingCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DrawingCategories");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.MainClassification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("FieldId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Order")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MainClassification");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ReviewDrawing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("AdvanceSharingFlag")
                        .HasColumnType("bit");

                    b.Property<string>("AdvanceSharingMemo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentRoomId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ConstructionDrawingId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Memo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PostApprovalChangeFlag")
                        .HasColumnType("bit");

                    b.Property<long>("ReviewTypeId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<bool>("SharedFlag")
                        .HasColumnType("bit");

                    b.Property<long>("StatusId")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ConstructionDrawingId");

                    b.HasIndex("ReviewTypeId");

                    b.HasIndex("StatusId");

                    b.ToTable("ReviewDrawings");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ReviewProgress", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ReviewDrawingId")
                        .HasColumnType("bigint");

                    b.Property<bool>("ReviewerUseFlag")
                        .HasColumnType("bit");

                    b.Property<long>("RoutingSlipsId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime?>("ScheduledReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReviewDrawingId");

                    b.HasIndex("RoutingSlipsId");

                    b.ToTable("ReviewProgresses");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ReviewType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("DrawingCategoryId")
                        .HasColumnType("bigint");

                    b.Property<long>("FieldId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DrawingCategoryId");

                    b.ToTable("ReviewType");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.RoutingSlips", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("FieldId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Order")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RoutingSlips");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.Status", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.SubClassification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdminUpdateUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AdminUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DeleteUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("MainClassificationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Order")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdateProgramId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UpdateUserId")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MainClassificationId");

                    b.ToTable("SubClassification");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ConstructionDrawing", b =>
                {
                    b.HasOne("WebApplication1.Models.Entities.SubClassification", "SubClassification")
                        .WithMany()
                        .HasForeignKey("SubClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubClassification");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ReviewDrawing", b =>
                {
                    b.HasOne("WebApplication1.Models.Entities.ConstructionDrawing", "ConstructionDrawing")
                        .WithMany("ReviewDrawings")
                        .HasForeignKey("ConstructionDrawingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Entities.ReviewType", "ReviewType")
                        .WithMany()
                        .HasForeignKey("ReviewTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ConstructionDrawing");

                    b.Navigation("ReviewType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ReviewProgress", b =>
                {
                    b.HasOne("WebApplication1.Models.Entities.ReviewDrawing", "ReviewDrawing")
                        .WithMany("ReviewsProgresses")
                        .HasForeignKey("ReviewDrawingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Entities.RoutingSlips", "RoutingSlips")
                        .WithMany()
                        .HasForeignKey("RoutingSlipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReviewDrawing");

                    b.Navigation("RoutingSlips");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ReviewType", b =>
                {
                    b.HasOne("WebApplication1.Models.Entities.DrawingCategory", "DrawingCategory")
                        .WithMany()
                        .HasForeignKey("DrawingCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DrawingCategory");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.SubClassification", b =>
                {
                    b.HasOne("WebApplication1.Models.Entities.MainClassification", "MainClassification")
                        .WithMany("SubClassification")
                        .HasForeignKey("MainClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainClassification");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ConstructionDrawing", b =>
                {
                    b.Navigation("ReviewDrawings");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.MainClassification", b =>
                {
                    b.Navigation("SubClassification");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.ReviewDrawing", b =>
                {
                    b.Navigation("ReviewsProgresses");
                });
#pragma warning restore 612, 618
        }
    }
}