//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApartmanOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblExpenseTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblExpenseTypes()
        {
            this.tblExpenses = new HashSet<tblExpenses>();
        }
    
        public int TypeID { get; set; }
        public string TypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblExpenses> tblExpenses { get; set; }
    }
}
