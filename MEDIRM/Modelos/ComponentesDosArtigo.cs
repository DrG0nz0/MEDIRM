namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComponentesDosArtigos")]
    public partial class ComponentesDosArtigo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Artigo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Componente { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Quantidade { get; set; }

        public virtual Artigo Artigo1 { get; set; }

        public virtual Componente Componente1 { get; set; }
    }
}
