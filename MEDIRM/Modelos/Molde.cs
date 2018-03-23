namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Molde")]
    public partial class Molde
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Molde()
        {
            Maquinas = new HashSet<Maquina>();
        }

        [Key]
        [StringLength(50)]
        public string Designacao { get; set; }

        [Required]
        [StringLength(50)]
        public string Cortantes { get; set; }

        [Required]
        [StringLength(50)]
        public string PecasPorAvanco { get; set; }

        public float? MetrosPorAvanco { get; set; }

        public float? Profundidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maquina> Maquinas { get; set; }
    }
}
