namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ArtigosCliente
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Artigo { get; set; }

        public float? Preco { get; set; }

        public float? Preco1 { get; set; }

        public float? Preco2 { get; set; }

        public float? Preco3 { get; set; }

        public virtual Artigo Artigo1 { get; set; }

        public virtual Cliente Cliente1 { get; set; }
    }
}
