//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMVCMultiEdit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HiddenWidget
    {
        public int WebpageId { get; set; }
        public int WidgetId { get; set; }
    
        public virtual Document Document { get; set; }
        public virtual Document Document1 { get; set; }
        public virtual Widget Widget { get; set; }
        public virtual Widget Widget1 { get; set; }
    }
}
