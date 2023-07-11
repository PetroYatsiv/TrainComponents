﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainComponent.Persistence;

#nullable disable

namespace TrainComponent.Persistence.Migrations
{
    [DbContext(typeof(TrainComponentDbContext))]
    [Migration("20230710184535_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrainComponent.Domain.Entities.TrainComponentNode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CanAssignQuantity")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UniqueNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainComponentNodes");
                });

            modelBuilder.Entity("TrainComponentNodeTrainComponentNode", b =>
                {
                    b.Property<Guid>("ChildTrainComponentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParentTrainComponentsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ChildTrainComponentsId", "ParentTrainComponentsId");

                    b.HasIndex("ParentTrainComponentsId");

                    b.ToTable("TrainComponentNodeTrainComponentNode");
                });

            modelBuilder.Entity("TrainComponentNodeTrainComponentNode", b =>
                {
                    b.HasOne("TrainComponent.Domain.Entities.TrainComponentNode", null)
                        .WithMany()
                        .HasForeignKey("ChildTrainComponentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainComponent.Domain.Entities.TrainComponentNode", null)
                        .WithMany()
                        .HasForeignKey("ParentTrainComponentsId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}