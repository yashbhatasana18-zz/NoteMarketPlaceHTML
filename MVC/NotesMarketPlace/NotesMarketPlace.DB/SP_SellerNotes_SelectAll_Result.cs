//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotesMarketPlace.DB
{
    using System;
    
    public partial class SP_SellerNotes_SelectAll_Result
    {
        public int SellerID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public bool IsPaid { get; set; }
        public Nullable<decimal> SellingPrice { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
