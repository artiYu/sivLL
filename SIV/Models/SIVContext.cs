using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SIV
{
    public partial class SIVContext : DbContext
    {
        public SIVContext()
        {
        }

        public SIVContext(DbContextOptions<SIVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Habitat> Habitats { get; set; } = null!;
        public virtual DbSet<PokemonType> PokemonTypes { get; set; } = null!;
        public virtual DbSet<PokemonsCatalog> PokemonsCatalogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habitat>(entity =>
            {
                entity.ToTable("Habitat");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .UseCollation("Cyrillic_General_CI_AS");
            });

            modelBuilder.Entity<PokemonType>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .UseCollation("Cyrillic_General_CI_AS");
            });

            modelBuilder.Entity<PokemonsCatalog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PokemonsCatalog");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .UseCollation("Cyrillic_General_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
