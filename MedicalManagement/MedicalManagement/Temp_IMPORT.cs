//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Temp_IMPORT
    {
        public string IMPORT_ID { get; set; }
        public string PRO_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public Nullable<System.DateTime> IMPORT_DATE { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public Nullable<int> QUANTITY { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
