﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Piranha.EF;

namespace Piranha.EF.Migrations
{
    [DbContext(typeof(Db))]
    partial class DbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("Piranha.EF.Data.Block", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<DateTime?>("Published");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("TypeId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("View")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Piranha_Blocks");
                });

            modelBuilder.Entity("Piranha.EF.Data.BlockField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlockId");

                    b.Property<string>("CLRType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("BlockId", "RegionId", "FieldId", "SortOrder")
                        .IsUnique();

                    b.ToTable("Piranha_BlockFields");
                });

            modelBuilder.Entity("Piranha.EF.Data.BlockType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<string>("Body");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("Id");

                    b.ToTable("Piranha_BlockTypes");
                });

            modelBuilder.Entity("Piranha.EF.Data.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArchiveDescription");

                    b.Property<string>("ArchiveKeywords");

                    b.Property<string>("ArchiveRoute");

                    b.Property<string>("ArchiveTitle");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(512);

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Categories");
                });

            modelBuilder.Entity("Piranha.EF.Data.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(255);

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(128);

                    b.Property<string>("NavigationTitle")
                        .HasMaxLength(128);

                    b.Property<Guid?>("ParentId");

                    b.Property<DateTime?>("Published");

                    b.Property<string>("Route")
                        .HasMaxLength(255);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("TypeId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("View")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("TypeId");

                    b.ToTable("Piranha_Pages");
                });

            modelBuilder.Entity("Piranha.EF.Data.PageField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CLRType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<Guid>("PageId");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PageId", "RegionId", "FieldId", "SortOrder")
                        .IsUnique();

                    b.ToTable("Piranha_PageFields");
                });

            modelBuilder.Entity("Piranha.EF.Data.PageType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<string>("Body");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("Id");

                    b.ToTable("Piranha_PageTypes");
                });

            modelBuilder.Entity("Piranha.EF.Data.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<Guid>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Excerpt")
                        .HasMaxLength(512);

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(255);

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(128);

                    b.Property<DateTime?>("Published");

                    b.Property<string>("Route")
                        .HasMaxLength(255);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Posts");
                });

            modelBuilder.Entity("Piranha.EF.Data.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Tags");
                });

            modelBuilder.Entity("Piranha.EF.Data.Block", b =>
                {
                    b.HasOne("Piranha.EF.Data.BlockType", "Type")
                        .WithMany("Blocks")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.EF.Data.BlockField", b =>
                {
                    b.HasOne("Piranha.EF.Data.Block", "Block")
                        .WithMany("Fields")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.EF.Data.Page", b =>
                {
                    b.HasOne("Piranha.EF.Data.PageType", "Type")
                        .WithMany("Pages")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.EF.Data.PageField", b =>
                {
                    b.HasOne("Piranha.EF.Data.Page", "Page")
                        .WithMany("Fields")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.EF.Data.Post", b =>
                {
                    b.HasOne("Piranha.EF.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
