//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restoran
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            this.OrderDish = new HashSet<OrderDish>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Compound { get; set; }
        public string Discription { get; set; }
        public short Weight { get; set; }
        public decimal Cost { get; set; }
        public int DishCategoryID { get; set; }
        public string Photo { get; set; }
    
        public virtual DishCategory DishCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDish> OrderDish { get; set; }
    }
}
