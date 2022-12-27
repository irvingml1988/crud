using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace crud.Models;

public partial class CrudMvcContext : DbContext
{
    public CrudMvcContext()
    {
    }

    public CrudMvcContext(DbContextOptions<CrudMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=Darian_ML\\SQLEXPRESS01;Database=CRUD_MVC;Trusted_Connection=true; Trust Server Certificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("empleados");

            entity.Property(e => e.FechaIngreso)
                .HasColumnType("date")
                .HasColumnName("fechaIngreso");
            entity.Property(e => e.Sueldo)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("sueldo");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__usuarios__CB9A1CFFC94EFB05");

            entity.ToTable("usuarios");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Materno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Paterno)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
