﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quiz_Game.Models;

#nullable disable

namespace Quiz_Game.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20230227170453_QuizAnswers")]
    partial class QuizAnswers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Quiz_Game.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionKey", "Language")
                        .IsUnique();

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("Quiz_Game.Models.QuizAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<bool>("isRightAnswer")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("quizAnswers");
                });

            modelBuilder.Entity("Quiz_Game.Models.QuizAnswer", b =>
                {
                    b.HasOne("Quiz_Game.Models.Quiz", null)
                        .WithMany("quizAnswers")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Quiz_Game.Models.Quiz", b =>
                {
                    b.Navigation("quizAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
