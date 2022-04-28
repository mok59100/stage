using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EASL.Data.Models;

#nullable disable

namespace EASL.Data
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actualite> Actualites { get; set; }
        public virtual DbSet<Adhesion> Adhesions { get; set; }
        public virtual DbSet<Appartient> Appartients { get; set; }
        public virtual DbSet<Contient> Contients { get; set; }
        public virtual DbSet<Cotisation> Cotisations { get; set; }
        public virtual DbSet<Don> Dons { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Texte> Textes { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySQL("server=localhost;user=root;database=easlille;port=3308;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actualite>(entity =>
            {
                entity.HasKey(e => e.IdActualite)
                    .HasName("PRIMARY");

                entity.ToTable("actualites");

                entity.Property(e => e.IdActualite).HasColumnType("int(11)");

                entity.Property(e => e.DateAffichage).HasColumnType("date");

                entity.Property(e => e.Titre).HasMaxLength(50);
            });

            modelBuilder.Entity<Adhesion>(entity =>
            {
                entity.HasKey(e => e.IdAdhesion)
                    .HasName("PRIMARY");

                entity.ToTable("adhesions");

                entity.HasIndex(e => e.IdUtilisateur, "FK_Adhesions_Utilisateurs");

                entity.Property(e => e.IdAdhesion).HasColumnType("int(11)");

                entity.Property(e => e.DateDebutAdhesion).HasColumnType("date");

                entity.Property(e => e.DateFinAdhesion).HasColumnType("date");

                entity.Property(e => e.IdUtilisateur).HasColumnType("int(11)");

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Adhesions)
                    .HasForeignKey(d => d.IdUtilisateur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Adhesions_Utilisateurs");
            });

            modelBuilder.Entity<Appartient>(entity =>
            {
                entity.HasKey(e => e.IdActualite)
                    .HasName("PRIMARY");

                entity.ToTable("appartient");

                entity.HasIndex(e => e.IdVideo, "FK_Appartient_Videos");

                entity.Property(e => e.IdActualite)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdVideo).HasColumnType("int(11)");

                entity.HasOne(d => d.IdActualiteNavigation)
                    .WithOne(p => p.Appartient)
                    .HasForeignKey<Appartient>(d => d.IdActualite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appartient_Actualites");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.Appartients)
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appartient_Videos");
            });

            modelBuilder.Entity<Contient>(entity =>
            {
                entity.HasKey(e => e.IdActualite)
                    .HasName("PRIMARY");

                entity.ToTable("contient");

                entity.HasIndex(e => e.IdImage, "FK_Contient_Images");

                entity.Property(e => e.IdActualite)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdImage).HasColumnType("int(11)");

                entity.HasOne(d => d.IdActualiteNavigation)
                    .WithOne(p => p.Contient)
                    .HasForeignKey<Contient>(d => d.IdActualite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contient_Actualites");

                entity.HasOne(d => d.IdImageNavigation)
                    .WithMany(p => p.Contients)
                    .HasForeignKey(d => d.IdImage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contient_Images");
            });

            modelBuilder.Entity<Cotisation>(entity =>
            {
                entity.HasKey(e => e.IdCotisation)
                    .HasName("PRIMARY");

                entity.ToTable("cotisations");

                entity.HasIndex(e => e.IdUtilisateur, "FK_Cotisations_Utilisateurs");

                entity.Property(e => e.IdCotisation).HasColumnType("int(11)");

                entity.Property(e => e.DateCotisation).HasColumnType("date");

                entity.Property(e => e.EtatCotisation).HasMaxLength(50);

                entity.Property(e => e.IdUtilisateur).HasColumnType("int(11)");

                entity.Property(e => e.ModePaiement).HasMaxLength(50);

                entity.Property(e => e.MontantCotisation).HasMaxLength(50);

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Cotisations)
                    .HasForeignKey(d => d.IdUtilisateur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cotisations_Utilisateurs");
            });

            modelBuilder.Entity<Don>(entity =>
            {
                entity.HasKey(e => e.IdDon)
                    .HasName("PRIMARY");

                entity.ToTable("dons");

                entity.Property(e => e.IdDon).HasColumnType("int(11)");

                entity.Property(e => e.MontantDon).HasColumnType("decimal(15,2)");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Prenom).HasMaxLength(50);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.IdImage)
                    .HasName("PRIMARY");

                entity.ToTable("images");

                entity.Property(e => e.IdImage).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.IdMessage)
                    .HasName("PRIMARY");

                entity.ToTable("messages");

                entity.Property(e => e.IdMessage).HasColumnType("int(11)");

                entity.Property(e => e.Dates).HasMaxLength(10);

                entity.Property(e => e.Heure).HasMaxLength(30);

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(200);


            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PRIMARY");

                entity.ToTable("roles");

                entity.Property(e => e.IdRole).HasColumnType("int(11)");

                entity.Property(e => e.LibelleRole).HasMaxLength(50);
            });

            modelBuilder.Entity<Texte>(entity =>
            {
                entity.HasKey(e => e.IdTexte)
                    .HasName("PRIMARY");

                entity.ToTable("textes");

                entity.Property(e => e.IdTexte)
                    .HasColumnType("int(11)")
                    .HasColumnName("idTexte");

                entity.Property(e => e.CodeTexte)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codeTexte");

                entity.Property(e => e.En)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("en");

                entity.Property(e => e.Fr)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("fr");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.IdUtilisateur)
                    .HasName("PRIMARY");

                entity.ToTable("utilisateurs");

                entity.HasIndex(e => e.AdresseMail, "AdresseMail")
                    .IsUnique();

                entity.HasIndex(e => e.IdRole, "FK_Utilisateurs_Roles");

                entity.Property(e => e.IdUtilisateur).HasColumnType("int(11)");

                entity.Property(e => e.AdresseMail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdRole).HasColumnType("int(11)");

                entity.Property(e => e.MotDePasse)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50);

             

                entity.Property(e => e.SituationProfessionnelle).HasMaxLength(50);

                entity.Property(e => e.TelephoneUtilisateur).HasColumnType("int(11)");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Utilisateurs)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Utilisateurs_Roles");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasKey(e => e.IdVideo)
                    .HasName("PRIMARY");

                entity.ToTable("videos");

                entity.Property(e => e.IdVideo).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
