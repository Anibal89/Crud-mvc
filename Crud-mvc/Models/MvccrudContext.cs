using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Crud_mvc.Models;

public partial class MvccrudContext : DbContext
{
    public MvccrudContext()
    {
    }

    public MvccrudContext(DbContextOptions<MvccrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //        => optionsBuilder.UseSqlServer("server=localhost; database=mvccrud; integrated security=true; TrustServerCertificate=True;");
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__2085A9CFF6E40135");

            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.FechaIngreso).HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Producto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
