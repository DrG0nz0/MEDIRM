namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PessoasMaquina
    {
        [Key]
        [StringLength(50)]
        public string Maquina { get; set; }

        [StringLength(50)]
        public string Funcionario { get; set; }

        [StringLength(50)]
        public string Posicao { get; set; }

        public virtual Funcionario Funcionario1 { get; set; }

        public virtual Maquina Maquina1 { get; set; }
    }
}
