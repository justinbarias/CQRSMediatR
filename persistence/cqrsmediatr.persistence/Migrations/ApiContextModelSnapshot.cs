﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cqrsmediatr.persistence;

namespace cqrsmediatr.persistence.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Todo")
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cqrsmediatr.domain.models.TodoItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("IsCompleted");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("TodoItem");
                });
#pragma warning restore 612, 618
        }
    }
}
