namespace MEDIRM.Modelos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MEDIRMContext : DbContext
    {
        public MEDIRMContext()
            : base("name=MedirmDB")
        {
        }

        public virtual DbSet<Artigo> Artigoes { get; set; }
        public virtual DbSet<Cartao> Cartaos { get; set; }
        public virtual DbSet<Cartolina> Cartolinas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Componente> Componentes { get; set; }
        public virtual DbSet<CustosFixo> CustosFixos { get; set; }
        public virtual DbSet<Encomenda> Encomendas { get; set; }
        public virtual DbSet<Esterilizacao> Esterilizacaos { get; set; }
        public virtual DbSet<Feria> Ferias { get; set; }
        public virtual DbSet<Filme> Filmes { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Maquina> Maquinas { get; set; }
        public virtual DbSet<Moeda> Moedas { get; set; }
        public virtual DbSet<Molde> Moldes { get; set; }
        public virtual DbSet<Papel> Papels { get; set; }
        public virtual DbSet<TipoMaquina> TipoMaquinas { get; set; }
        public virtual DbSet<Transporte> Transportes { get; set; }
        public virtual DbSet<TurnosFuncionario> TurnosFuncionario { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ArtigosCliente> ArtigosClientes { get; set; }
        public virtual DbSet<ComponentesDosArtigo> ComponentesDosArtigo { get; set; }
        public virtual DbSet<Feita> Feitas { get; set; }
        public virtual DbSet<PessoasMaquina> PessoasMaquinas { get; set; }
        public virtual DbSet<VerPreco> VerPrecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artigo>()
                .HasMany(e => e.ArtigosClientes)
                .WithRequired(e => e.Artigo1)
                .HasForeignKey(e => e.Artigo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artigo>()
                .HasMany(e => e.ComponentesDosArtigo)
                .WithRequired(e => e.Artigo1)
                .HasForeignKey(e => e.Artigo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artigo>()
                .HasMany(e => e.Encomendas)
                .WithOptional(e => e.Artigo1)
                .HasForeignKey(e => e.Artigo);

            modelBuilder.Entity<Artigo>()
                .HasMany(e => e.Feitas)
                .WithOptional(e => e.Artigo1)
                .HasForeignKey(e => e.Artigo);

            modelBuilder.Entity<Artigo>()
                .HasMany(e => e.VerPrecos)
                .WithOptional(e => e.Artigo1)
                .HasForeignKey(e => e.Artigo);

            modelBuilder.Entity<Cartao>()
                .Property(e => e.Volume)
                .IsFixedLength();

            modelBuilder.Entity<Cartao>()
                .HasMany(e => e.Artigoes)
                .WithOptional(e => e.Cartao1)
                .HasForeignKey(e => e.Cartao);

            modelBuilder.Entity<Cartolina>()
                .HasMany(e => e.Artigoes)
                .WithOptional(e => e.Cartolina1)
                .HasForeignKey(e => e.Cartolina);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.ArtigosClientes)
                .WithRequired(e => e.Cliente1)
                .HasForeignKey(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Encomendas)
                .WithOptional(e => e.Cliente1)
                .HasForeignKey(e => e.Cliente);

            modelBuilder.Entity<Cliente>()
                .HasOptional(e => e.VerPreco)
                .WithRequired(e => e.Cliente1);

            modelBuilder.Entity<Componente>()
                .HasMany(e => e.ComponentesDosArtigo)
                .WithRequired(e => e.Componente1)
                .HasForeignKey(e => e.Componente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Componente>()
                .HasMany(e => e.Feitas)
                .WithOptional(e => e.Componente1)
                .HasForeignKey(e => e.Componente);

            modelBuilder.Entity<Encomenda>()
                .HasOptional(e => e.Feita)
                .WithRequired(e => e.Encomenda1);

            modelBuilder.Entity<Esterilizacao>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.Esterilizacao)
                .HasForeignKey(e => e.TipoEsterilizacao);

            modelBuilder.Entity<Filme>()
                .HasMany(e => e.Maquinas)
                .WithOptional(e => e.Filme1)
                .HasForeignKey(e => e.Filme);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.PessoasMaquinas)
                .WithOptional(e => e.Funcionario1)
                .HasForeignKey(e => e.Funcionario);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.TurnosFuncionario)
                .WithRequired(e => e.Funcionario1)
                .HasForeignKey(e => e.Funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Maquina>()
                .Property(e => e.Velocidade1)
                .IsFixedLength();

            modelBuilder.Entity<Maquina>()
                .HasMany(e => e.Artigoes)
                .WithOptional(e => e.Maquina)
                .HasForeignKey(e => e.Maquina1);

            modelBuilder.Entity<Maquina>()
                .HasMany(e => e.Artigoes1)
                .WithOptional(e => e.Maquina6)
                .HasForeignKey(e => e.Maquina2);

            modelBuilder.Entity<Maquina>()
                .HasMany(e => e.Artigoes2)
                .WithOptional(e => e.Maquina7)
                .HasForeignKey(e => e.Maquina3);

            modelBuilder.Entity<Maquina>()
                .HasMany(e => e.Artigoes3)
                .WithOptional(e => e.Maquina8)
                .HasForeignKey(e => e.Maquina4);

            modelBuilder.Entity<Maquina>()
                .HasOptional(e => e.PessoasMaquina)
                .WithRequired(e => e.Maquina1);

            modelBuilder.Entity<Moeda>()
                .HasMany(e => e.Cartaos)
                .WithRequired(e => e.Moeda1)
                .HasForeignKey(e => e.Moeda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moeda>()
                .HasMany(e => e.Cartolinas)
                .WithRequired(e => e.Moeda1)
                .HasForeignKey(e => e.Moeda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moeda>()
                .HasMany(e => e.Componentes)
                .WithOptional(e => e.Moeda1)
                .HasForeignKey(e => e.Moeda);

            modelBuilder.Entity<Moeda>()
                .HasMany(e => e.Esterilizacaos)
                .WithRequired(e => e.Moeda1)
                .HasForeignKey(e => e.Moeda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moeda>()
                .HasMany(e => e.Filmes)
                .WithRequired(e => e.Moeda1)
                .HasForeignKey(e => e.Moeda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moeda>()
                .HasMany(e => e.Papels)
                .WithRequired(e => e.Moeda1)
                .HasForeignKey(e => e.Moeda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moeda>()
                .HasMany(e => e.Transportes)
                .WithRequired(e => e.Moeda1)
                .HasForeignKey(e => e.Moeda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Molde>()
                .HasMany(e => e.Maquinas)
                .WithOptional(e => e.Molde1)
                .HasForeignKey(e => e.Molde);

            modelBuilder.Entity<Papel>()
                .HasMany(e => e.Maquinas)
                .WithOptional(e => e.Papel1)
                .HasForeignKey(e => e.Papel);

            modelBuilder.Entity<TipoMaquina>()
                .HasMany(e => e.Maquinas)
                .WithRequired(e => e.TipoMaquina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transporte>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.Transporte1)
                .HasForeignKey(e => e.Transporte);

            modelBuilder.Entity<Transporte>()
                .HasMany(e => e.Componentes)
                .WithOptional(e => e.Transporte1)
                .HasForeignKey(e => e.Transporte);

            modelBuilder.Entity<ComponentesDosArtigo>()
                .Property(e => e.Quantidade)
                .IsFixedLength();
        }
    }
}
