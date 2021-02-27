using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
  public static  class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductListed= "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka kategori var";
        public static string CategoryLimitExceded = "kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
