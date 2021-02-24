using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi 2021";
        public static string ProductCountOfCategoryError="Bir Kategoride En Fazla 10 ürün olabilir";
        internal static string ProductNameAlreadyExists = "Aynı isimde ürün var";
    }
}
