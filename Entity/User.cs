using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class User
    {
        public string UserId
        {
            get; 
            set;
        }

        public string UserName
        {
            get;
            set; 
        }

        public string UserNickName
        {
            get;
            set; 
        }

        public int Sex
        {
            get; 
            set; 
        }

        public string UserSchool
        {
            get; 
            set;
        }

        public int UserGrade
        {
            get;
            set;
        }

        public string UserEmail
        {
            get; 
            set; 
        }
        public Byte[] UserImage
        {
            get;
            set;
        }
        public string PersonalSign
        {
            get;
            set;
        }
        public DateTime RegistrationDate
        {
            get;
            set;
        }
        public int UserType
        {
            get;
            set;
        }
    }
}
