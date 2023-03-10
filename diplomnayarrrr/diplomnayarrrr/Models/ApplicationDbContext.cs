using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using diplomnayarrrr.Entities;

namespace diplomnayarrrr.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cabinet> Cabinets { get; set; }

    public virtual DbSet<CallSchedule> CallSchedules { get; set; }

    public virtual DbSet<ClassType> ClassTypes { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=SSSDiplom; Trusted_Connection=true; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cabinet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cabinet__3214EC075EC5A294");

            entity.ToTable("Cabinet");
        });

        modelBuilder.Entity<CallSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CallSche__3214EC077B01548A");

            entity.ToTable("CallSchedule");
        });

        modelBuilder.Entity<ClassType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClassTyp__3214EC0727C69B02");

            entity.ToTable("ClassType");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Group__3214EC07C61744CD");

            entity.ToTable("Group");
        });

        modelBuilder.Entity<Lesson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lesson__3214EC072FFD6796");

            entity.ToTable("Lesson");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Lesson__TeacherI__38996AB5");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC07E0C4AC3A");

            entity.ToTable("Role");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schedule__3214EC07E5DD1665");

            entity.ToTable("Schedule");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Cabinet).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.CabinetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedule__Cabine__44FF419A");

            entity.HasOne(d => d.CallSchedule).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.CallScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedule__CallSc__45F365D3");

            entity.HasOne(d => d.ClassType).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.ClassTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedule__ClassT__46E78A0C");

            entity.HasOne(d => d.Group).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedule__GroupI__440B1D61");

            entity.HasOne(d => d.Lesson).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.LessonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedule__Lesson__4316F928");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teacher__3214EC079C597072");

            entity.ToTable("Teacher");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC079A9901E1");

            entity.ToTable("User");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__RoleId__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
