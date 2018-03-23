namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            ArtigosClientes = new HashSet<ArtigosCliente>();
            Encomendas = new HashSet<Encomenda>();
        }

        [Required]
        [StringLength(50)]
        public string ID { get; set; }

        [Key]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Localidade { get; set; }

        public float? MargemLucro { get; set; }

        [StringLength(50)]
        public string Transporte { get; set; }

        [StringLength(50)]
        public string TipoEsterilizacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtigosCliente> ArtigosClientes { get; set; }

        public virtual Esterilizacao Esterilizacao { get; set; }

        public virtual Transporte Transporte1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encomenda> Encomendas { get; set; }

        public virtual VerPreco VerPreco { get; set; }
    }
}
