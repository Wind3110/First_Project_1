//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webbanhang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NGUOIDUNG
    {
        public NGUOIDUNG()
        {
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int maND { get; set; }
        public string tenND { get; set; }
        public string username { get; set; }
        public string MK { get; set; }
        public string email { get; set; }
        public string SDT { get; set; }
        public string DC { get; set; }
    
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
