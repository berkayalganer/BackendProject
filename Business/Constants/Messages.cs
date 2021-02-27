using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    // Newleme yapmamak için static yaparız.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameValid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı.";
        public static string ProductsListed = "Ürünler başarıyla listelendi.";
        public static string ProductCountOfCategoryError = "Aynı kategoride maksimum 10 ürün eklenebilir.";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}
