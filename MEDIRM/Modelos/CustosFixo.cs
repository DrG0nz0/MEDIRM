namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustosFixos")]
    public partial class CustosFixo
    {
        [Key]
        [StringLength(50)]
        public string Designacao { get; set; }

        public float? Custo { get; set; }
    }
}
