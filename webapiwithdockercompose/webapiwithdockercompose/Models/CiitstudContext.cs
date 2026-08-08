using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapiwithdockercompose.Models;

public partial class CiitstudContext : DbContext
{
    public CiitstudContext()
    {
    }

    public CiitstudContext(DbContextOptions<CiitstudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbltrainingCourse> TbltrainingCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=115.124.106.98;Database=ciitstud_;User Id=ciituser;Password=CIIT#0908;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ciituser");

        modelBuilder.Entity<TbltrainingCourse>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__tbltrain__8F1EF7AE1D85AA59");

            entity.ToTable("tbltraining_courses", "dbo");

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66A32A9DDE1").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66A81A18235").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66AA5AA539C").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66AB7509A00").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66AC588406D").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66ADA81FD7D").IsUnique();

            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("course_name");
            entity.Property(e => e.Flag)
                .HasDefaultValue(0)
                .HasColumnName("flag");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
