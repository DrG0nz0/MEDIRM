namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Filme")]
    public partial class Filme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filme()
        {
            Maquinas = new HashSet<Maquina>();
        }

        [Key]
        [StringLength(50)]
        public string Designacao { get; set; }

        public float PrecoMetro { get; set; }

        [Required]
        [StringLength(50)]
        public string Moeda { get; set; }

        public string MetodoDeCalculo { get; set; }

        public virtual Moeda Moeda1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maquina> Maquinas { get; set; }
    }
}
