//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEDIRM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionario()
        {
            this.PessoasMaquinas = new HashSet<PessoasMaquinas>();
            this.TurnosFuncionarios = new HashSet<TurnosFuncionarios>();
        }
    
        public string Nome { get; set; }
        public Nullable<int> ID { get; set; }
        public string Sigla { get; set; }
        public Nullable<bool> Frente { get; set; }
        public Nullable<bool> Tras { get; set; }
        public Nullable<bool> Manual { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoasMaquinas> PessoasMaquinas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TurnosFuncionarios> TurnosFuncionarios { get; set; }
    }
}
