using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ImageLimitExceeded="Sadece bir adet profil fotosu olabilir";

        public static string TopicAdded = "Konu Oluşturuldu";
        public static string TopicListed = "Konular Listelendi";
        public static string CommentAdded = "Yorum Oluşturuldu";
        public static string CommentListed = "Yorumlar Listelendi";
        public static string CommentDeleted = "Yorum Silindi";
        public static string PhotoAdded = "Profil Fotosu Eklendi";


        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime=" Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Her kategorinin 10 adet ürünü olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Paralo hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Giriş Yapıldı";

       
    }
}
