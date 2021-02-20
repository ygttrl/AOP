using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Message
    {
        public static string ErrorMasage { get { return "Eklenemedi."; } }
        public static string SuccesMassage { get { return "Başarılı."; } }
        public static string UserErrorMassage { get { return "Kullanıcı Ekleme Başarısız."; } }
        public static string UserSuccessMassage { get { return "Kullanıcı Ekleme Başarılı."; } }
        public static string UserSuccessDeleteMassage { get { return "Kullanıcı Silme Başarılı."; } }
        public static string UserErrorDeleteMassage { get { return "Kullanıcı Silme Başarısız."; } }
        public static string UserErrorListMassage { get { return "Kullanıcı Listeleme Başarısız."; } }
        public static string UserSuccessListMassage { get { return "Kullanıcı Listeleme Başarılı."; } }
        public static string UserSuccessGetMassage { get { return "Kullanıcı Getirme Başarılı."; } }
        public static string UserErrorGetMassage { get { return "Kullanıcı Getirme Başarısız."; } }

    }
}
