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
    
    public partial class OrderDish
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int DishID { get; set; }
        public byte Count { get; set; }
    
        public virtual Dish Dish { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
