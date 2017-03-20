using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication.Models;

namespace WebApplication.Migrations
{
    [DbContext(typeof(AlbumContext))]
    partial class AlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Artist");

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<int>("Rank");

                    b.Property<DateTime>("RelaseData");

                    b.HasKey("ID");

                    b.ToTable("Album");
                });
        }
    }
}
