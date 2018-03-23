namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Artigo")]
    public partial class Artigo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artigo()
        {
            ArtigosClientes = new HashSet<ArtigosCliente>();
            ComponentesDosArtigo = new HashSet<ComponentesDosArtigo>();
            Encomendas = new HashSet<Encomenda>();
            Feitas = new HashSet<Feita>();
            VerPrecos = new HashSet<VerPreco>();
        }

        [Key]
        [StringLength(50)]
        public string Nome { get; set; }

        public int ID { get; set; }

        [StringLength(50)]
        public string UnBase { get; set; }

        public int? QtdCartao { get; set; }

        public int? QtdCartolina { get; set; }

        public int? QtdCartoesPalete { get; set; }

        [StringLength(50)]
        public string Cartao { get; set; }

        [StringLength(50)]
        public string Cartolina { get; set; }

        [StringLength(50)]
        public string Maquina1 { get; set; }

        [StringLength(50)]
        public string Maquina2 { get; set; }

        [StringLength(50)]
        public string Maquina3 { get; set; }

        [StringLength(50)]
        public string Maquina4 { get; set; }

        [StringLength(50)]
        public string Maquina5 { get; set; }

        public virtual Cartao Cartao1 { get; set; }

        public virtual Cartolina Cartolina1 { get; set; }

        public virtual Maquina Maquina { get; set; }

        public virtual Maquina Maquina6 { get; set; }

        public virtual Maquina Maquina7 { get; set; }

        public virtual Maquina Maquina8 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtigosCliente> ArtigosClientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponentesDosArtigo> ComponentesDosArtigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encomenda> Encomendas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feita> Feitas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VerPreco> VerPrecos { get; set; }
    }
}
