namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Esterilizacao")]
    public partial class Esterilizacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Esterilizacao()
        {
            Clientes = new HashSet<Cliente>();
        }

        [Key]
        [StringLength(50)]
        public string Designacao { get; set; }

        public float Preco { get; set; }

        [Required]
        [StringLength(50)]
        public string Moeda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Clientes { get; set; }

        public virtual Moeda Moeda1 { get; set; }
    }
}
