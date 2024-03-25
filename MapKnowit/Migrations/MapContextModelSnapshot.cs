﻿// <auto-generated />
using System;
using MapIt.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MapIt.Migrations
{
    [DbContext(typeof(MapContext))]
    partial class MapContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MapIt.Data.Model.Activity", b =>
                {
                    b.Property<int>("ActivityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityID"));

                    b.Property<string>("ActivityType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityID");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("MapIt.Data.Model.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyID"));

                    b.Property<bool>("CompanyName")
                        .HasColumnType("bit")
                        .HasColumnName("Name");

                    b.Property<int>("DivisionID")
                        .HasColumnType("int");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("MapIt.Data.Model.CompanySiteActivityRelation", b =>
                {
                    b.Property<int>("CompanySiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanySiteID"));

                    b.Property<int>("ActivityID")
                        .HasColumnType("int");

                    b.HasKey("CompanySiteID");

                    b.ToTable("CompanyActivities");
                });

            modelBuilder.Entity("MapIt.Data.Model.CompanySiteOwnerRelation", b =>
                {
                    b.Property<int>("CompanySiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanySiteID"));

                    b.Property<bool>("IsInternal")
                        .HasColumnType("bit");

                    b.Property<int>("OwnershipTupeID")
                        .HasColumnType("int");

                    b.HasKey("CompanySiteID");

                    b.ToTable("CompanySiteOwnerRelations");
                });

            modelBuilder.Entity("MapIt.Data.Model.CompanySiteRelation", b =>
                {
                    b.Property<int>("CompanySiteRelationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanySiteRelationID"));

                    b.Property<int>("SiteID")
                        .HasColumnType("int");

                    b.HasKey("CompanySiteRelationID");

                    b.ToTable("CompanySites");
                });

            modelBuilder.Entity("MapIt.Data.Model.Division", b =>
                {
                    b.Property<int>("DivisionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DivisionID"));

                    b.Property<bool>("DivisionName")
                        .HasColumnType("bit");

                    b.HasKey("DivisionID");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("MapIt.Data.Model.OwnershipType", b =>
                {
                    b.Property<int>("OwnershipTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnershipTypeID"));

                    b.Property<bool>("Ownership")
                        .HasColumnType("bit");

                    b.HasKey("OwnershipTypeID");

                    b.ToTable("OwnershipTypes");
                });

            modelBuilder.Entity("MapIt.Data.Model.Site", b =>
                {
                    b.Property<int>("SiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SiteID"));

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<float?>("Rent")
                        .HasColumnType("real");

                    b.Property<string>("SiteName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiteID");

                    b.ToTable("Sites");
                });
#pragma warning restore 612, 618
        }
    }
}
