//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace College
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListStudents
    {
        public int id { get; set; }
        public int idFirstName { get; set; }
        public int idSpecialty { get; set; }
    
        public virtual Specialty Specialty { get; set; }
        public virtual Student Student { get; set; }
    }
}
