//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dnd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Character_Class
    {
        public int Id { get; set; }
        public string class_name { get; set; }
        public int class_level { get; set; }
        public int character_ID { get; set; }
        public string subclass { get; set; }
    
        public virtual Characters Characters { get; set; }
    }
}