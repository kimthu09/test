//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ImageProducts = new HashSet<ImageProduct>();
            this.RatingInfoes = new HashSet<RatingInfo>();
            this.MUsers = new HashSet<MUser>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdCategory { get; set; }
        public string IdBrand { get; set; }
        public string IdShop { get; set; }
        public Nullable<long> Price { get; set; }
        public Nullable<int> Sale { get; set; }
        public Nullable<int> InStock { get; set; }
        public Nullable<int> Sold { get; set; }
        public Nullable<bool> IsOneSize { get; set; }
        public Nullable<bool> IsHadSizeS { get; set; }
        public Nullable<bool> IsHadSizeM { get; set; }
        public Nullable<bool> IsHadSizeL { get; set; }
        public Nullable<bool> IsHadSizeXL { get; set; }
        public Nullable<bool> IsHadSizeXXL { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateOfSale { get; set; }
        public string Status { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageProduct> ImageProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingInfo> RatingInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUser> MUsers { get; set; }
    }
}