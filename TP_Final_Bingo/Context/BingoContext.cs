using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TP_Final_Bingo.Models;

namespace TP_Final_Bingo.Context;

public partial class BingoContext : DbContext
{
    public BingoContext()
    {
    }

    public BingoContext(DbContextOptions<BingoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HistorialBolillero> HistorialBolilleros { get; set; }

    public virtual DbSet<HistorialCartones> HistorialCartones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=CNOTE13\\MSSQLSERVER01;Database=BingoDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HistorialBolillero>(entity =>
        {
            entity.ToTable("HistorialBolillero");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora");
            entity.Property(e => e.Numero).HasColumnName("numero");
        });

        modelBuilder.Entity<HistorialCartones>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carton1).HasColumnName("carton1");
            entity.Property(e => e.Carton2).HasColumnName("carton2");
            entity.Property(e => e.Carton3).HasColumnName("carton3");
            entity.Property(e => e.Carton4).HasColumnName("carton4");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
