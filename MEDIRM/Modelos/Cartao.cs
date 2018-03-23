namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cartao")]
    public partial class Cartao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cartao()
        {
            Artigoes = new HashSet<Artigo>();
        }

        [Key]
        [StringLength(50)]
        public string Designacao { get; set; }

        public float PrecoCartolina { get; set; }

        [Required]
        [StringLength(10)]
        public string Volume { get; set; }

        [Required]
        [StringLength(50)]
        public string Moeda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artigo> Artigoes { get; set; }

        public virtual Moeda Moeda1 { get; set; }
    }
}
