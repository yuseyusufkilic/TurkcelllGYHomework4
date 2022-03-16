﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleProject.Data;

namespace SampleProject.Migrations
{
    [DbContext(typeof(FootballerDBContext))]
    [Migration("20220311115640_teamNameChanged")]
    partial class teamNameChanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleProject.Models.Footballer", b =>
                {
                    b.Property<int>("FootballerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("FootballerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Footballers");

                    b.HasData(
                        new
                        {
                            FootballerId = 1,
                            Name = "Ferdi",
                            Surname = "Kadıoğlu",
                            TeamId = 1
                        });
                });

            modelBuilder.Entity("SampleProject.Models.FootballerSponsor", b =>
                {
                    b.Property<int>("FootballerId")
                        .HasColumnType("int");

                    b.Property<int>("SponsorId")
                        .HasColumnType("int");

                    b.HasKey("FootballerId", "SponsorId");

                    b.HasIndex("SponsorId");

                    b.ToTable("FootballerSponsor");

                    b.HasData(
                        new
                        {
                            FootballerId = 1,
                            SponsorId = 1
                        });
                });

            modelBuilder.Entity("SampleProject.Models.Sponsor", b =>
                {
                    b.Property<int>("SponsorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SponsorId");

                    b.ToTable("Sponsors");

                    b.HasData(
                        new
                        {
                            SponsorId = 1,
                            Name = "Carlsberg"
                        });
                });

            modelBuilder.Entity("SampleProject.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            Name = "Fenerbahçe"
                        });
                });

            modelBuilder.Entity("SampleProject.Models.Footballer", b =>
                {
                    b.HasOne("SampleProject.Models.Team", "Team")
                        .WithMany("Footballer")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("SampleProject.Models.FootballerSponsor", b =>
                {
                    b.HasOne("SampleProject.Models.Footballer", "Footballer")
                        .WithMany("FootballerSponsors")
                        .HasForeignKey("FootballerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SampleProject.Models.Sponsor", "Sponsor")
                        .WithMany("FootballerSponsors")
                        .HasForeignKey("SponsorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Footballer");

                    b.Navigation("Sponsor");
                });

            modelBuilder.Entity("SampleProject.Models.Footballer", b =>
                {
                    b.Navigation("FootballerSponsors");
                });

            modelBuilder.Entity("SampleProject.Models.Sponsor", b =>
                {
                    b.Navigation("FootballerSponsors");
                });

            modelBuilder.Entity("SampleProject.Models.Team", b =>
                {
                    b.Navigation("Footballer");
                });
#pragma warning restore 612, 618
        }
    }
}
