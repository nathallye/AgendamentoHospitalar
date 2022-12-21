using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoHospitalar.Modelos;

public partial class MasterContext : DbContext
{
    public MasterContext()
    {
    }


    public MasterContext(DbContextOptions<MasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agendamento> Agendamentos { get; set; }

    public virtual DbSet<AgendamentoConfiguracao> AgendamentoConfiguracaos { get; set; }

    public virtual DbSet<Beneficiario> Beneficiarios { get; set; }

    public virtual DbSet<DadosBancario> DadosBancarios { get; set; }

    public virtual DbSet<Especialidade> Especialidades { get; set; }

    public virtual DbSet<Hospital> Hospitals { get; set; }

    public virtual DbSet<Profissional> Profissionals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        => optionsBuilder.UseSqlServer(
            new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build().GetConnectionString("projeto"));
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agendamento>(entity =>
        {
            entity.HasKey(e => e.IdAgendamento);

            entity.ToTable("Agendamento");

            entity.HasIndex(e => new { e.IdHospital, e.IdEspecialidade, e.IdProfissional, e.IdBeneficiario, e.DataHoraAgendamento }, "UC_Agendamento").IsUnique();

            entity.Property(e => e.IdAgendamento).HasColumnName("idAgendamento");
            entity.Property(e => e.DataHoraAgendamento).HasColumnType("datetime");
            entity.Property(e => e.IdBeneficiario).HasColumnName("idBeneficiario");
            entity.Property(e => e.IdEspecialidade).HasColumnName("idEspecialidade");
            entity.Property(e => e.IdHospital).HasColumnName("idHospital");
            entity.Property(e => e.IdProfissional).HasColumnName("idProfissional");

            entity.HasOne(d => d.IdBeneficiarioNavigation).WithMany(p => p.Agendamentos)
                .HasForeignKey(d => d.IdBeneficiario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Agendamento_Beneficiario");

            entity.HasOne(d => d.IdEspecialidadeNavigation).WithMany(p => p.Agendamentos)
                .HasForeignKey(d => d.IdEspecialidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Agendamento_Especialidade");

            entity.HasOne(d => d.IdHospitalNavigation).WithMany(p => p.Agendamentos)
                .HasForeignKey(d => d.IdHospital)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Agendamento_Hospital");

            entity.HasOne(d => d.IdProfissionalNavigation).WithMany(p => p.Agendamentos)
                .HasForeignKey(d => d.IdProfissional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Agendamento_Profissional");
        });

        modelBuilder.Entity<AgendamentoConfiguracao>(entity =>
        {
            entity.HasKey(e => e.IdConfiguracao);

            entity.ToTable("AgendamentoConfiguracao");

            entity.HasIndex(e => new { e.IdHospital, e.IdEspecialidade, e.IdProfissional, e.DataHoraInicioAtendimento, e.DataHoraFinalAtendimento }, "UC_AgendamentoConfiguracao").IsUnique();

            entity.Property(e => e.DataHoraFinalAtendimento).HasColumnType("datetime");
            entity.Property(e => e.DataHoraInicioAtendimento).HasColumnType("datetime");

            entity.HasOne(d => d.IdEspecialidadeNavigation).WithMany(p => p.AgendamentoConfiguracaos)
                .HasForeignKey(d => d.IdEspecialidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgendamentoConfiguracao_Especialidade");

            entity.HasOne(d => d.IdHospitalNavigation).WithMany(p => p.AgendamentoConfiguracaos)
                .HasForeignKey(d => d.IdHospital)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgendamentoConfiguracao_Hospital");

            entity.HasOne(d => d.IdProfissionalNavigation).WithMany(p => p.AgendamentoConfiguracaos)
                .HasForeignKey(d => d.IdProfissional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgendamentoConfiguracao_Profissional");
        });

        modelBuilder.Entity<Beneficiario>(entity =>
        {
            entity.HasKey(e => e.IdBeneficiario);

            entity.ToTable("Beneficiario");

            entity.Property(e => e.IdBeneficiario).HasColumnName("idBeneficiario");
            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nome).IsUnicode(false);
            entity.Property(e => e.NumeroCarteirinha)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("senha");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DadosBancario>(entity =>
        {
            entity.HasKey(e => e.IdDadosBancarios);

            entity.Property(e => e.Agencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPix)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IdProfissional).HasColumnName("idProfissional");
            entity.Property(e => e.NumeroBanco)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.NumeroConta)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProfissionalNavigation).WithMany(p => p.DadosBancarios)
                .HasForeignKey(d => d.IdProfissional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DadosBancarios_Profissional");
        });

        modelBuilder.Entity<Especialidade>(entity =>
        {
            entity.HasKey(e => e.IdEspecialidade);

            entity.ToTable("Especialidade");

            entity.Property(e => e.Descricao).IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hospital>(entity =>
        {
            entity.HasKey(e => e.IdHospital).HasName("PK__Hospital__AF70C2B274578F60");

            entity.ToTable("Hospital");

            entity.Property(e => e.IdHospital).HasColumnName("idHospital");
            entity.Property(e => e.Cnes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNES");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CNPJ");
            entity.Property(e => e.Endereco).IsUnicode(false);
            entity.Property(e => e.Nome).IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Profissional>(entity =>
        {
            entity.HasKey(e => e.IdProfissional);

            entity.ToTable("Profissional");

            entity.Property(e => e.Endereco).IsUnicode(false);
            entity.Property(e => e.Nome).IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
