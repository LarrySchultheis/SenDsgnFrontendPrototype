using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCApp.Services.DBModels
{
    public partial class TicketingSystemContext : DbContext
    {
        public TicketingSystemContext()
        {
        }

        public TicketingSystemContext(DbContextOptions<TicketingSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<JobType> JobType { get; set; }
        public virtual DbSet<TicketData> TicketData { get; set; }
        public virtual DbSet<TicketDataLog> TicketDataLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local);Database=TicketingSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");

                entity.Property(e => e.JobType1)
                    .IsRequired()
                    .HasColumnName("JobType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketData>(entity =>
            {
                entity.HasKey(e => e.EntryId)
                    .HasName("PK__TicketDa__F57BD2D7FC8FA1D5");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("date");

                entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");

                entity.Property(e => e.PalletNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PalletType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StageNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TrailerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TicketData)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TicketDat__Emplo__47DBAE45");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.TicketData)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TicketDat__JobTy__48CFD27E");
            });

            modelBuilder.Entity<TicketDataLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__TicketDa__5E5499A8278C8D19");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ChangeTime).HasColumnType("datetime");

                entity.Property(e => e.DataAction)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Details)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.TicketDataLog)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TicketDat__Entry__5DCAEF64");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
