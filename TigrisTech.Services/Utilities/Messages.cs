using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigrisTech.Services.Utilities
{
    public static class Messages
    {

        public static class General
        {
            public static string ValidationError()
            {
                return "Bir veya daha fazla validasyon hatası ile karşılaşıldı";
            }
        }
        //Messages.Category.NotFound()
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir slider bulunamadı";
                return "Böyle bir slider bulunamadı.";
            }
            public static string NotFoundById(int categoryId)
            {

                return $"{categoryId} Böyle bir kategori bulunamadı.";
            }
            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }
     
        }
        public static class Slider
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı";
                return "Böyle bir kategori bulunamadı.";
            }
            public static string NotFoundById(int categoryId)
            {

                return $"{categoryId} Böyle bir kategori bulunamadı.";
            }
            public static string Add(string sliderName)
            {
                return $"{sliderName} başlıklı Slider başarıyla eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı slider başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string sliderName)
            {
                return $"{sliderName} adlı kategori başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }

        }
        public static class Photo
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı";
                return "Böyle bir kategori bulunamadı.";
            }
            public static string NotFoundById(int categoryId)
            {

                return $"{categoryId} Böyle bir kategori bulunamadı.";
            }
            public static string Add(string photoName)
            {
                return $"{photoName} fotogranız başarıyla eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı slider başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string sliderName)
            {
                return $"{sliderName} adlı kategori başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }

        }
        public static class Galery
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir galery bulunamadı";
                return "Böyle bir galery bulunamadı.";
            }
            public static string NotFoundById(int categoryId)
            {

                return $"{categoryId} Böyle bir kategori bulunamadı.";
            }
            public static string Add(string galeryName)
            {
                return $"{galeryName} başlıklı galery başarıyla eklenmiştir.";
            }
            public static string Update(string galeryName)
            {
                return $"{galeryName} adlı galeri başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string galeryName)
            {
                return $"{galeryName} adlı galeri başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }

        }
        public static class Profil
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir proril bulunamadı";
                return "Böyle bir profil bulunamadı.";
            }
            public static string NotFoundById(int categoryId)
            {

                return $"{categoryId} Böyle bir profil bulunamadı.";
            }
            public static string Add(string profilName)
            {
                return $"{profilName} başlıklı profil başarıyla eklenmiştir.";
            }
            public static string Update(string profilName)
            {
                return $"{profilName} adlı profil başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string profilName)
            {
                return $"{profilName} adlı profil başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }

        }
        public static class Patient
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir hasta bulunamadı";
                return "Böyle bir hasta bulunamadı.";
            }
            public static string NotFoundById(int patientId)
            {

                return $"{patientId} Böyle bir hasta bulunamadı.";
            }
            public static string Add(string patientName)
            {
                return $"{patientName} başlıklı hasta başarıyla eklenmiştir.";
            }
            public static string Update(string patientName)
            {
                return $"{patientName} adlı hasta başarıyla güncellenmiştir.";
            }
            public static string Delete(string patientName)
            {
                return $"{patientName} adlı hasta başarıyla silinmiştir.";
            }
            public static string HardDelete(string patientName)
            {
                return $"{patientName} adlı hasta başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string patientName)
            {
                return $"{patientName} adlı hasta başarıyla arşivden geri getirilmiştir.";
            }

        }
        public static class PaymentType
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı";
                return "Böyle bir kategori bulunamadı.";
            }
            public static string NotFoundById(int categoryId)
            {

                return $"{categoryId} Böyle bir kategori bulunamadı.";
            }
            public static string Add(string paymentTypeName)
            {
                return $"{paymentTypeName} adlı ödeme tipi başarıyla eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }

        }
        public static class Article
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Makaleler bulunamadı.";
                return "Böyle bir makale bulunamadı.";
            }
            public static string NotFoundById(int articleId)
            {

                return $"{articleId} Böyle bir makale bulunamadı.";
            }
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla eklenmiştir.";
            }

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir.";
            }
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silinmiştir.";
            }
            public static string HardDelete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla arşivden geri getirilmiştir.";
            }
            public static string IncreaseViewCount(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla arttırılmıştır.";
            }
        }
        public static class Comment
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir yorum bulunamadı.";
                return "Böyle bir yorum bulunamadı.";
            }
            public static string Approve(int commentId)
            {
                return $"{commentId} no'lu yorum başarıyla onaylanmıştır.";
            }
            public static string Add(string createdByName)
            {
                return $"Sayın {createdByName}, yorumunuz başarıyla eklenmiştir.";
            }

            public static string Update(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla güncellenmiştir.";
            }
            public static string Delete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla silinmiştir.";
            }
            public static string HardDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla arşivden geri getirilmiştir.";
            }
        }
        public static class User
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı";
                return "Böyle bir kategori bulunamadı.";
            }
            public static string NotFoundById(int userId)
            {

                return $"{userId} Böyle bir kullanıcı bulunamadı.";
            }
            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }

        }
        public static class AccountCode
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı";
                return "Böyle bir kategori bulunamadı.";
            }
            public static string NotFoundById(int userId)
            {

                return $"{userId} Böyle bir kullanıcı bulunamadı.";
            }
            public static string Add(string AccountCodeName)
            {
                return $"{AccountCodeName} adlı hesap kodu başarıyla eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
            }

        }

    }
}
