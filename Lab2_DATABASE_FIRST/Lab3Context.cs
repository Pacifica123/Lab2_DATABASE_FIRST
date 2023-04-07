using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab2_DATABASE_FIRST;

public partial class Lab3Context : DbContext
{
    public Lab3Context()
    {
    }

    public Lab3Context(DbContextOptions<Lab3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Playlist> Playlists { get; set; }

    public virtual DbSet<Playlistsong> Playlistsongs { get; set; }

    public virtual DbSet<Song> Songs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=192.168.0.13;Port=5432;Database=Lab3;Username=noir;Password=Noir_Tea");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Playlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("playlists_pk_Id");

            entity.ToTable("playlists");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Titleplaylist)
                .HasColumnType("character varying")
                .HasColumnName("titleplaylist");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.Playlists)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("playlists_fk");
        });

        modelBuilder.Entity<Playlistsong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("playlistsong_pk_Id");

            entity.ToTable("playlistsong");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Playlistid).HasColumnName("playlistid");
            entity.Property(e => e.Songid).HasColumnName("songid");

            entity.HasOne(d => d.Playlist).WithMany(p => p.Playlistsongs)
                .HasForeignKey(d => d.Playlistid)
                .HasConstraintName("playlistsong_fk_1");

            entity.HasOne(d => d.Song).WithMany(p => p.Playlistsongs)
                .HasForeignKey(d => d.Songid)
                .HasConstraintName("playlistsong_fk");
        });

        modelBuilder.Entity<Song>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("songs_pk_id");

            entity.ToTable("songs");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasColumnType("character varying")
                .HasColumnName("title");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pk_id");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Datereg).HasColumnName("datereg");
            entity.Property(e => e.Login)
                .HasColumnType("character varying")
                .HasColumnName("login");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
