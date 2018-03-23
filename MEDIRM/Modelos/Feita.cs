namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Feita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Encomenda { get; set; }

        [StringLength(50)]
        public string Artigo { get; set; }

        [StringLength(50)]
        public string Componente { get; set; }

        public int? Feitas { get; set; }

        public virtual Artigo Artigo1 { get; set; }

        public virtual Componente Componente1 { get; set; }

        public virtual Encomenda Encomenda1 { get; set; }
    }
}
