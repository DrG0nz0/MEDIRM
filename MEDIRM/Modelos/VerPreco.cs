namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VerPrecos")]
    public partial class VerPreco
    {
        [Key]
        [StringLength(50)]
        public string Cliente { get; set; }

        [StringLength(50)]
        public string Artigo { get; set; }

        public int? Quantidade { get; set; }

        public float? Preco { get; set; }

        public float? MargemLucro { get; set; }

        public float? CustosFixos { get; set; }

        public float? Transporte { get; set; }

        public float? PrecoFinal { get; set; }

        public virtual Artigo Artigo1 { get; set; }

        public virtual Cliente Cliente1 { get; set; }
    }
}
