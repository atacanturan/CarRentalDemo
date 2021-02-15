using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ürün başarıyla eklendi.";
        public static string AddedException = "Ürün eklenirken beklenmeyen bir hata oluştu.";
        public static string Deleted = "Ürün başarıyla silindi.";
        public static string DeletedException = "Ürün silinirken beklenmeyen bir hata oluştu.";
        public static string Updated = "Ürün başarıyla güncellendi.";
        public static string UpdatedException = "Ürün güncellenirken beklenmeyen bir hata oluştu.";
        public static string RentalAddedException = "Seçtiğiniz ürün başka biri tarafından kiralandı.";
        public static string Rented = "Araba başarıyla kiralandı.";
    }
}
