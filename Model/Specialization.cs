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
    
    public partial class Specialization
    {
        public Specialization()
        {
            this.GroupStudent = new HashSet<GroupStudent>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<GroupStudent> GroupStudent { get; set; }
    }
}
