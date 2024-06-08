﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using W8.Context;

#nullable disable

namespace W8.Migrations
{
    [DbContext(typeof(W7Context))]
    partial class W7ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentStudentGroup", b =>
                {
                    b.Property<int>("StudentGroupsIdStudentGroup")
                        .HasColumnType("int");

                    b.Property<int>("StudentsIdStudent")
                        .HasColumnType("int");

                    b.HasKey("StudentGroupsIdStudentGroup", "StudentsIdStudent");

                    b.HasIndex("StudentsIdStudent");

                    b.ToTable("StudentStudentGroup");
                });

            modelBuilder.Entity("W8.Models.Student", b =>
                {
                    b.Property<int>("IdStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStudent"));

                    b.Property<int>("IdStudies")
                        .HasColumnType("int");

                    b.Property<string>("IndexNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdStudent");

                    b.HasIndex("IdStudies");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("W8.Models.StudentGroup", b =>
                {
                    b.Property<int>("IdStudentGroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStudentGroup"));

                    b.Property<string>("number")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdStudentGroup");

                    b.ToTable("StudentGroups");
                });

            modelBuilder.Entity("W8.Models.Studies", b =>
                {
                    b.Property<int>("IdStudies")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStudies"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdStudies");

                    b.ToTable("Studies");
                });

            modelBuilder.Entity("StudentStudentGroup", b =>
                {
                    b.HasOne("W8.Models.StudentGroup", null)
                        .WithMany()
                        .HasForeignKey("StudentGroupsIdStudentGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("W8.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsIdStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("W8.Models.Student", b =>
                {
                    b.HasOne("W8.Models.Studies", "Studies")
                        .WithMany("Students")
                        .HasForeignKey("IdStudies")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studies");
                });

            modelBuilder.Entity("W8.Models.Studies", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
