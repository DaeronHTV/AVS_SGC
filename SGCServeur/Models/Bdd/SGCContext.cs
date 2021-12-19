using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SGCServeur.Models.Bdd
{
    public partial class SGCContext : DbContext
    {
        public SGCContext()
        {
        }

        public SGCContext(DbContextOptions<SGCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auteur> Auteurs { get; set; }
        public virtual DbSet<Competence> Competences { get; set; }
        public virtual DbSet<Compte> Comptes { get; set; }
        public virtual DbSet<Connaissance> Connaissances { get; set; }
        public virtual DbSet<Contenue> Contenues { get; set; }
        public virtual DbSet<Emploi> Emplois { get; set; }
        public virtual DbSet<Emploicompetence> Emploicompetences { get; set; }
        public virtual DbSet<Emploiconnaissance> Emploiconnaissances { get; set; }
        public virtual DbSet<Emploiservice> Emploiservices { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Employecompetence> Employecompetences { get; set; }
        public virtual DbSet<Employeconnaissance> Employeconnaissances { get; set; }
        public virtual DbSet<Employeemploi> Employeemplois { get; set; }
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Formationtag> Formationtags { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Groupemploye> Groupemployes { get; set; }
        public virtual DbSet<Parametre> Parametres { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=Parametrage/SGC.db");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auteur>(entity =>
            {
                entity.ToTable("AUTEUR");

                entity.HasIndex(e => e.Mail, "IX_AUTEUR_MAIL")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Compteid)
                    .HasColumnName("COMPTEID");

                entity.Property(e => e.Datedebutvalidite)
                    .HasColumnName("DATEDEBUTVALIDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvalidite)
                    .HasColumnName("DATEFINVALIDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("MAIL");

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM");

                entity.Property(e => e.Nomascii)
                    .HasColumnName("NOMASCII");

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM");

                entity.Property(e => e.Prenomascii)
                    .HasColumnName("PRENOMASCII");

                entity.HasOne(d => d.Compte)
                    .WithMany(p => p.Auteurs)
                    .HasForeignKey(d => d.Compteid);
            });

            modelBuilder.Entity<Competence>(entity =>
            {
                entity.ToTable("COMPETENCE");

                entity.HasIndex(e => e.Code, "IX_COMPETENCE_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Datedebutvaldite)
                    .HasColumnName("DATEDEBUTVALDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvaldite)
                    .HasColumnName("DATEFINVALDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("LIBELLE");
            });

            modelBuilder.Entity<Compte>(entity =>
            {
                entity.ToTable("COMPTE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Datedebutvaldite)
                    .HasColumnName("DATEDEBUTVALDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvaldite)
                    .HasColumnName("DATEFINVALDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Employeid)
                    .IsRequired()
                    .HasColumnName("EMPLOYEID");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("MAIL");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Typecompte)
                    .HasColumnName("TYPECOMPTE")
                    .HasDefaultValueSql("'MEMBRE'");

                entity.HasOne(d => d.Employe)
                    .WithMany(p => p.Comptes)
                    .HasForeignKey(d => d.Employeid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Connaissance>(entity =>
            {
                entity.ToTable("CONNAISSANCE");

                entity.HasIndex(e => e.Code, "IX_CONNAISSANCE_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Datedebutvaldite)
                    .HasColumnName("DATEDEBUTVALDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvaldite)
                    .HasColumnName("DATEFINVALDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("LIBELLE");
            });

            modelBuilder.Entity<Contenue>(entity =>
            {
                entity.ToTable("CONTENUE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Datedebutvalidite)
                    .HasColumnName("DATEDEBUTVALIDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvalidite)
                    .HasColumnName("DATEFINVALIDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");
            });

            modelBuilder.Entity<Emploi>(entity =>
            {
                entity.ToTable("EMPLOI");

                entity.HasIndex(e => e.Code, "IX_EMPLOI_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Datedebutvaldite)
                    .HasColumnName("DATEDEBUTVALDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvaldite)
                    .HasColumnName("DATEFINVALDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("LIBELLE");
            });

            modelBuilder.Entity<Emploicompetence>(entity =>
            {
                entity.ToTable("EMPLOICOMPETENCE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Competenceid)
                    .IsRequired()
                    .HasColumnName("COMPETENCEID");

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Emploiid)
                    .IsRequired()
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
                    .HasColumnName("ID");

                entity.Property(e => e.Connaissanceid)
                    .IsRequired()
                    .HasColumnName("CONNAISSANCEID");

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Emploiid)
                    .IsRequired()
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
                    .HasColumnName("ID");

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Emploiid)
                    .IsRequired()
                    .HasColumnName("EMPLOIID");

                entity.Property(e => e.Serviceid)
                    .IsRequired()
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
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Datedebutvaldite)
                    .HasColumnName("DATEDEBUTVALDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvaldite)
                    .HasColumnName("DATEFINVALDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("MAIL");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("NOM");

                entity.Property(e => e.Nomascii)
                    .HasColumnName("NOMASCII");

                entity.Property(e => e.Photo)
                    .HasColumnName("PHOTO");

                entity.Property(e => e.Prenom)
                    .HasColumnName("PRENOM");

                entity.Property(e => e.Prenomascii)
                    .HasColumnName("PRENOMASCII");

                entity.Property(e => e.Telephone)
                    .HasColumnName("TELEPHONE");
            });

            modelBuilder.Entity<Employecompetence>(entity =>
            {
                entity.ToTable("EMPLOYECOMPETENCE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Competenceid)
                    .IsRequired()
                    .HasColumnName("COMPETENCEID");

                entity.Property(e => e.Dateacquisition)
                    .HasColumnName("DATEACQUISITION");

                entity.Property(e => e.Employeid)
                    .IsRequired()
                    .HasColumnName("EMPLOYEID");

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasDefaultValueSql("'NONE'");

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
                    .HasColumnName("ID");

                entity.Property(e => e.Connaissanceid)
                    .IsRequired()
                    .HasColumnName("CONNAISSANCEID");

                entity.Property(e => e.Dateacquisition)
                    .HasColumnName("DATEACQUISITION");

                entity.Property(e => e.Employeid)
                    .IsRequired()
                    .HasColumnName("EMPLOYEID");

                entity.Property(e => e.Niveau)
                    .HasColumnName("NIVEAU")
                    .HasDefaultValueSql("'NONE'");

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
                    .HasColumnName("ID");

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Emploiid)
                    .IsRequired()
                    .HasColumnName("EMPLOIID");

                entity.Property(e => e.Employeid)
                    .IsRequired()
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

            modelBuilder.Entity<Formation>(entity =>
            {
                entity.ToTable("FORMATION");

                entity.HasIndex(e => e.Code, "IX_FORMATION_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Datedebutvalidite)
                    .HasColumnName("DATEDEBUTVALIDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvalidite)
                    .HasColumnName("DATEFINVALIDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("LIBELLE");

                entity.Property(e => e.Niveau)
                    .IsRequired()
                    .HasColumnName("NIVEAU")
                    .HasDefaultValueSql("'INITIE'");

                entity.Property(e => e.Tags)
                    .HasColumnName("TAGS");
            });

            modelBuilder.Entity<Formationtag>(entity =>
            {
                entity.ToTable("FORMATIONTAG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Formationid)
                    .IsRequired()
                    .HasColumnName("FORMATIONID");

                entity.Property(e => e.Tagid)
                    .IsRequired()
                    .HasColumnName("TAGID");

                entity.HasOne(d => d.Formation)
                    .WithMany(p => p.Formationtags)
                    .HasForeignKey(d => d.Formationid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.Formationtags)
                    .HasForeignKey(d => d.Tagid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("GROUPS");

                entity.HasIndex(e => e.Code, "IX_GROUPS_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Datedebutvaldite)
                    .HasColumnName("DATEDEBUTVALDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvaldite)
                    .HasColumnName("DATEFINVALDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<Groupemploye>(entity =>
            {
                entity.ToTable("GROUPEMPLOYE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Datedebut)
                    .HasColumnName("DATEDEBUT")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefin)
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Employeid)
                    .IsRequired()
                    .HasColumnName("EMPLOYEID");

                entity.Property(e => e.Groupid)
                    .IsRequired()
                    .HasColumnName("GROUPID");

                entity.HasOne(d => d.Employe)
                    .WithMany(p => p.Groupemployes)
                    .HasForeignKey(d => d.Employeid)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Groupemployes)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Parametre>(entity =>
            {
                entity.ToTable("PARAMETRES");

                entity.HasIndex(e => e.Code, "IX_PARAMETRES_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("LIBELLE");

                entity.Property(e => e.Valeur)
                    .IsRequired()
                    .HasColumnName("VALEUR");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("SERVICE");

                entity.HasIndex(e => e.Code, "IX_SERVICE_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Datedebutvaldite)
                    .HasColumnName("DATEDEBUTVALDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvaldite)
                    .HasColumnName("DATEFINVALDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("LIBELLE");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("TAG");

                entity.HasIndex(e => e.Code, "IX_TAG_CODE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE");

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasDefaultValueSql("'#FFFFF'");

                entity.Property(e => e.Datedebutvalidite)
                    .HasColumnName("DATEDEBUTVALIDITE")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datefinvalidite)
                    .HasColumnName("DATEFINVALIDITE")
                    .HasDefaultValueSql("'3000-12-31'");

                entity.Property(e => e.Dateinsertion)
                    .HasColumnName("DATEINSERTION")
                    .HasDefaultValueSql("current_timestamp");

                entity.Property(e => e.Datemaj)
                    .HasColumnName("DATEMAJ");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
