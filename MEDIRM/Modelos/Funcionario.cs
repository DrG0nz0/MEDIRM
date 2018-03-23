namespace MEDIRM.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Funcionario")]
    public partial class Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionario()
        {
            PessoasMaquinas = new HashSet<PessoasMaquina>();
            TurnosFuncionario = new HashSet<TurnosFuncionario>();
        }

        [Key]
        [StringLength(50)]
        public string Nome { get; set; }

        public int? ID { get; set; }

        [StringLength(50)]
        public string Sigla { get; set; }

        public bool? Frente { get; set; }

        public bool? Tras { get; set; }

        public bool? Manual { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoasMaquina> PessoasMaquinas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TurnosFuncionario> TurnosFuncionario { get; set; }
    }
}
