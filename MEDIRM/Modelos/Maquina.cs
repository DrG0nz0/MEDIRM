namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maquina")]
    public partial class Maquina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maquina()
        {
            Artigoes = new HashSet<Artigo>();
            Artigoes1 = new HashSet<Artigo>();
            Artigoes2 = new HashSet<Artigo>();
            Artigoes3 = new HashSet<Artigo>();
        }

        [Key]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        public int? MinPessFrente { get; set; }

        public int? MaxPessFrente { get; set; }

        public int? MinPessTras { get; set; }

        public int? MaxPessTras { get; set; }

        [StringLength(50)]
        public string Filme { get; set; }

        [StringLength(50)]
        public string Papel { get; set; }

        [StringLength(50)]
        public string Molde { get; set; }

        [StringLength(10)]
        public string Velocidade1 { get; set; }

        [StringLength(10)]
        public string Velocidade2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artigo> Artigoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artigo> Artigoes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artigo> Artigoes2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artigo> Artigoes3 { get; set; }

        public virtual Filme Filme1 { get; set; }

        public virtual Molde Molde1 { get; set; }

        public virtual Papel Papel1 { get; set; }

        public virtual TipoMaquina TipoMaquina { get; set; }

        public virtual PessoasMaquina PessoasMaquina { get; set; }
    }
}
