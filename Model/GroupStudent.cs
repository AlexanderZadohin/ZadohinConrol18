//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZadohinConrol18.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupStudent
    {
        public GroupStudent()
        {
            this.AccountingCollege = new HashSet<AccountingCollege>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<int> idSpecialization { get; set; }
    
        public virtual ICollection<AccountingCollege> AccountingCollege { get; set; }
        public virtual Specialization Specialization { get; set; }
    }
}
