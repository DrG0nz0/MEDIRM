namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transporte")]
    public partial class Transporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transporte()
        {
            Clientes = new HashSet<Cliente>();
            Componentes = new HashSet<Componente>();
        }

        [Key]
        [StringLength(50)]
        public string Designacao { get; set; }

        public float Preco { get; set; }

        [Required]
        [StringLength(50)]
        public string Moeda { get; set; }

        [StringLength(50)]
        public string Transportadora { get; set; }

        [Required]
        [StringLength(50)]
        public string Utilizador { get; set; }

        [StringLength(50)]
        public string De { get; set; }

        [StringLength(50)]
        public string Para { get; set; }

        public string Info { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Componente> Componentes { get; set; }

        public virtual Moeda Moeda1 { get; set; }
    }
}
