namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Componente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Componente()
        {
            ComponentesDosArtigo = new HashSet<ComponentesDosArtigo>();
            Feitas = new HashSet<Feita>();
        }

        [Key]
        [StringLength(50)]
        public string Nome { get; set; }

        public int? ID { get; set; }

        [StringLength(50)]
        public string Transporte { get; set; }

        public float? PrecoCompra { get; set; }

        [StringLength(50)]
        public string Moeda { get; set; }

        public float? PrecoCusto { get; set; }

        public float? CustoAlfandega { get; set; }

        public int? QtdCartao { get; set; }

        public float? VolCartao { get; set; }

        [StringLength(50)]
        public string UnBase { get; set; }

        public float? PrecoCustoFinal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponentesDosArtigo> ComponentesDosArtigo { get; set; }

        public virtual Moeda Moeda1 { get; set; }

        public virtual Transporte Transporte1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feita> Feitas { get; set; }
    }
}
