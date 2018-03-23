namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TurnosFuncionario
    {
        [Required]
        [StringLength(50)]
        public string Funcionario { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaDaSemana { get; set; }

        [StringLength(50)]
        public string Turno1 { get; set; }

        [StringLength(50)]
        public string Turno2 { get; set; }

        [StringLength(50)]
        public string Turno3 { get; set; }

        [StringLength(50)]
        public string Turno4 { get; set; }

        public int ID { get; set; }

        public virtual Funcionario Funcionario1 { get; set; }
    }
}
