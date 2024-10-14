using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data;

public partial class MyappDatabaseContext : DbContext
{
    public MyappDatabaseContext()
    {
    }

    public MyappDatabaseContext(DbContextOptions<MyappDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<DishIngredient> DishIngredients { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-ATODD8J\\SQLEXPRESS;Initial Catalog=myapp_database;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dishes__3214EC0749BC997B");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DishIngredient>(entity =>
        {
            entity.HasOne(d => d.Dish).WithMany().HasConstraintName("FK__DishIngre__DishI__534D60F1");

            entity.HasOne(d => d.Ingredient).WithMany().HasConstraintName("FK__DishIngre__Ingre__5441852A");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingredie__3214EC0762B6E4B0");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
