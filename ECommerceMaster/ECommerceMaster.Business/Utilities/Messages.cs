using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceMaster.Businnes.Utilities
{
    public static class Messages
    {
        public static class General { 
        public static string ValidationError()
            {
                return $"Bir ya da daha fazla validasyon hatası ile karşılaşıldı";
            }
        }
        //Messages.Category.NotFound()
        public static class Product
        {
            public static string NotFound(bool isPlural)
            {
                return isPlural ? "Hiçbir kategori bulunamadı" : "Böyle bir kategori bulunamadı";
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
                return $"{categoryName}adlı kategori veritabanından başarıyla silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName}adlı kategori başarıyla arşivden geri getirilmiştir.";
            }
        }
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                return isPlural ? "Hiçbir kategori bulunamadı" : "Böyle bir kategori bulunamadı";
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
                return $"{categoryName}adlı kategori veritabanından başarıyla silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName}adlı kategori başarıyla arşivden geri getirilmiştir.";
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
                return $"{articleId } makale koduna ait bir makale bulunamadı";
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
                return $"{articleTitle} adlı makale başarıyla arşivden geri getirilmiştir.";
            }
            public static string IncreaseViewCount(string articleTitle)
            {
                return $"{articleTitle} başlıklı makalenin okunma sayısı başarıyla arttırılmıştır.";
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
                return $"{commentId} nolu yorum başarıyla eklenmiştir.";
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
    }
}
