//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelNWT
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public user()
        {
            this.food_order = new HashSet<food_order>();
            this.reservation = new HashSet<reservation>();
            this.resource = new HashSet<resource>();
        }
    
        public int iduser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public sbyte user_type { get; set; }
        public System.DateTime created_date { get; set; }
        public Nullable<System.DateTime> activated_date { get; set; }
        public Nullable<System.DateTime> deactivated_date { get; set; }
        public string confirmation_key { get; set; }
    
        public virtual ICollection<food_order> food_order { get; set; }
        public virtual ICollection<reservation> reservation { get; set; }
        public virtual ICollection<resource> resource { get; set; }
    }
}
