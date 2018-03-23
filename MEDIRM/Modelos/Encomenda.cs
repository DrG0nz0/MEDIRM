namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Encomenda")]
    public partial class Encomenda
    {
        [Key]
        public int NumeroEnco { get; set; }

        [StringLength(50)]
        public string Artigo { get; set; }

        [StringLength(50)]
        public string Cliente { get; set; }

        public int? Quantidade { get; set; }

        public DateTime? DataLimite { get; set; }

        public DateTime? DataEntregaPrevista { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public int? Feitas { get; set; }

        public virtual Artigo Artigo1 { get; set; }

        public virtual Cliente Cliente1 { get; set; }

        public virtual Feita Feita { get; set; }
    }
}
