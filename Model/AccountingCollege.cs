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
    
    public partial class AccountingCollege
    {
        public int id { get; set; }
        public Nullable<int> idGroup { get; set; }
        public Nullable<int> idActivity { get; set; }
        public Nullable<int> Evaluation { get; set; }
        public Nullable<System.DateTime> DateEvaluation { get; set; }
    
        public virtual ActivityStudent ActivityStudent { get; set; }
        public virtual GroupStudent GroupStudent { get; set; }
    }
}
