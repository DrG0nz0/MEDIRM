namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Papel")]
    public partial class Papel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Papel()
        {
            Maquinas = new HashSet<Maquina>();
        }

        [Key]
        [StringLength(50)]
        public string Designacao { get; set; }

        public float PrecoMetro { get; set; }

        public string MetodoCalculo { get; set; }

        [Required]
        [StringLength(50)]
        public string Moeda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maquina> Maquinas { get; set; }

        public virtual Moeda Moeda1 { get; set; }
    }
}
