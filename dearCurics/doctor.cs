//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dearCurics
{
    using System;
    using System.Collections.Generic;
    
    public partial class doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doctor()
        {
            this.doctor_price_payment = new HashSet<doctor_price_payment>();
            this.doctor_work_experience = new HashSet<doctor_work_experience>();
        }
    
        public int doctor_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string contact_number { get; set; }
        public string gender { get; set; }
        public string degree { get; set; }
        public string specialization { get; set; }
        public string facebook_id { get; set; }
        public string instegram_id { get; set; }
        public string twitter_id { get; set; }
        public string image_source { get; set; }
        public string personal_statement { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doctor_price_payment> doctor_price_payment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doctor_work_experience> doctor_work_experience { get; set; }
    }
}
