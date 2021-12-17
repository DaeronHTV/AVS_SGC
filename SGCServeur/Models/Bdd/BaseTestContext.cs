using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class BaseTestContext : DbContext
    {
        public BaseTestContext()
        {
        }

        public BaseTestContext(DbContextOptions<BaseTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Competence> Competences { get; set; }
        public virtual DbSet<Compte> Comptes { get; set; }
        public virtual DbSet<Connaissance> Connaissances { get; set; }
        public virtual DbSet<Emploi> Emplois { get; set; }
        public virtual DbSet<Emploicompetence> Emploicompetences { get; set; }
        public virtual DbSet<Emploiconnaissance> Emploiconnaissances { get; set; }
        public virtual DbSet<Emploiservice> Emploiservices { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Employecompetence> Employecompetences { get; set; }
        public virtual DbSet<Employeconnaissance> Employeconnaissances { get; set; }
        public virtual DbSet<Employeemploi> Employeemplois { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=Parametrage/BaseTest.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competence>(entity =>
            {
                entity.ToTable("COMPETENCE");

                entity.HasIndex(e => e.Code, "IX_COMPETENCE_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(10)")
                    .HasColumnName("CODE");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datemaj)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .HasColumnType("VARCHAR2(500)")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(100)")
                    .HasColumnName("LIBELLE");
            });

            modelBuilder.Entity<Compte>(entity =>
            {
                entity.ToTable("COMPTE");

                entity.HasIndex(e => e.Employeid, "IX_COMPTE_EMPLOYEID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datemaj)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Employeid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("EMPLOYEID");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(50)")
                    .HasColumnName("MAIL");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(50)")
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Typecompte)
                    .HasColumnType("VARCHAR2(30)")
                    .HasColumnName("TYPECOMPTE")
                    .HasDefaultValueSql("\"MEMBRE\"");

                entity.HasOne(d => d.Employe)
                    .WithOne(p => p.Compte)
                    .HasForeignKey<Compte>(d => d.Employeid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Connaissance>(entity =>
            {
                entity.ToTable("CONNAISSANCE");

                entity.HasIndex(e => e.Code, "IX_CONNAISSANCE_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(10)")
                    .HasColumnName("CODE");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datemaj)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .HasColumnType("VARCHAR2(500)")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Libelle)
                    .HasColumnType("VARCHAR2(100)")
                    .HasColumnName("LIBELLE");
            });

            modelBuilder.Entity<Emploi>(entity =>
            {
                entity.ToTable("EMPLOI");

                entity.HasIndex(e => e.Code, "IX_EMPLOI_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(10)")
                    .HasColumnName("CODE");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datemaj)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .HasColumnType("VARCHAR2(500)")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(100)")
                    .HasColumnName("LIBELLE");
            });

            modelBuilder.Entity<Emploicompetence>(entity =>
            {
                entity.ToTable("EMPLOICOMPETENCE");

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Competenceid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("COMPETENCEID");

                entity.Property(e => e.Datedebut)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datefin)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Emploiid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("EMPLOIID");

                entity.HasOne(d => d.Competence)
                    .WithMany(p => p.Emploicompetences)
                    .HasForeignKey(d => d.Competenceid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Emploi)
                    .WithMany(p => p.Emploicompetences)
                    .HasForeignKey(d => d.Emploiid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Emploiconnaissance>(entity =>
            {
                entity.ToTable("EMPLOICONNAISSANCE");

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Connaissanceid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("CONNAISSANCEID");

                entity.Property(e => e.Datedebut)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datefin)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Emploiid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("EMPLOIID");

                entity.HasOne(d => d.Connaissance)
                    .WithMany(p => p.Emploiconnaissances)
                    .HasForeignKey(d => d.Connaissanceid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Emploi)
                    .WithMany(p => p.Emploiconnaissances)
                    .HasForeignKey(d => d.Emploiid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Emploiservice>(entity =>
            {
                entity.ToTable("EMPLOISERVICE");

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Datedebut)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datefin)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Emploiid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("EMPLOIID");

                entity.Property(e => e.Serviceid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("SERVICEID");

                entity.HasOne(d => d.Emploi)
                    .WithMany(p => p.Emploiservices)
                    .HasForeignKey(d => d.Emploiid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Emploiservices)
                    .HasForeignKey(d => d.Serviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.ToTable("EMPLOYE");

                entity.HasIndex(e => e.Code, "IX_EMPLOYE_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.Mail, "IX_EMPLOYE_MAIL")
                    .IsUnique();

                entity.HasIndex(e => e.Code, "Employe_Trigramme");

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(3)")
                    .HasColumnName("CODE");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datemaj)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(50)")
                    .HasColumnName("MAIL");

                entity.Property(e => e.Nom)
                    .HasColumnType("VARCHAR2(50)")
                    .HasColumnName("NOM");

                entity.Property(e => e.Nomascii)
                    .HasColumnType("VARCHAR2(50)")
                    .HasColumnName("NOMASCII");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Prenom)
                    .HasColumnType("VARCHAR2(50)")
                    .HasColumnName("PRENOM");

                entity.Property(e => e.Prenomascii)
                    .HasColumnType("VARCHAR2(50)")
                    .HasColumnName("PRENOMASCII");

                entity.Property(e => e.Telephone)
                    .HasColumnType("NUMBER(10)")
                    .HasColumnName("TELEPHONE");
            });

            modelBuilder.Entity<Employecompetence>(entity =>
            {
                entity.ToTable("EMPLOYECOMPETENCE");

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Competenceid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("COMPETENCEID");

                entity.Property(e => e.Dateacquisition)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEACQUISITION");

                entity.Property(e => e.Employeid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("EMPLOYEID");

                entity.Property(e => e.Niveau)
                    .HasColumnType("NUMBER(1)")
                    .HasColumnName("NIVEAU")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Competence)
                    .WithMany(p => p.Employecompetences)
                    .HasForeignKey(d => d.Competenceid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Employe)
                    .WithMany(p => p.Employecompetences)
                    .HasForeignKey(d => d.Employeid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employeconnaissance>(entity =>
            {
                entity.ToTable("EMPLOYECONNAISSANCE");

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Connaissanceid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("CONNAISSANCEID");

                entity.Property(e => e.Dateacquisition)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEACQUISITION");

                entity.Property(e => e.Employeid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("EMPLOYEID");

                entity.Property(e => e.Niveau)
                    .HasColumnType("NUMBER(1)")
                    .HasColumnName("NIVEAU")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Connaissance)
                    .WithMany(p => p.Employeconnaissances)
                    .HasForeignKey(d => d.Connaissanceid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Employe)
                    .WithMany(p => p.Employeconnaissances)
                    .HasForeignKey(d => d.Employeid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employeemploi>(entity =>
            {
                entity.ToTable("EMPLOYEEMPLOI");

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Datedebut)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datefin)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Emploiid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("EMPLOIID");

                entity.Property(e => e.Employeid)
                    .IsRequired()
                    .HasColumnType("RAW(16)")
                    .HasColumnName("EMPLOYEID");

                entity.HasOne(d => d.Emploi)
                    .WithMany(p => p.Employeemplois)
                    .HasForeignKey(d => d.Emploiid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Employe)
                    .WithMany(p => p.Employeemplois)
                    .HasForeignKey(d => d.Employeid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("SERVICE");

                entity.HasIndex(e => e.Code, "IX_SERVICE_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("RAW(16)")
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(10)")
                    .HasColumnName("CODE");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Datemaj)
                    .HasColumnType("TIMESTAMP")
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnType("VARCHAR2(50)")
                    .HasColumnName("LIBELLE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
