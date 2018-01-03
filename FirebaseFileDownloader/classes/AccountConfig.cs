using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.classes
{
    class AccountConfig
    {
        private string apiKey;
        private string bucket;
        private string authEmail;
        private string authPassword;
        private string firebaseFolder;

        public AccountConfig(string api,string buc,string mail,string pass, string folder)
        {
            this.apiKey = api;
            this.bucket = buc;
            this.authEmail = mail;
            this.authPassword = pass;
            this.firebaseFolder = folder;
        }

        public string ApiKey
        {
            get
            {
                return apiKey;
            }

            set
            {
                apiKey = value;
            }
        }

        public string Bucket
        {
            get
            {
                return bucket;
            }

            set
            {
                bucket = value;
            }
        }

        public string AuthEmail
        {
            get
            {
                return authEmail;
            }

            set
            {
                authEmail = value;
            }
        }

        public string AuthPassword
        {
            get
            {
                return authPassword;
            }

            set
            {
                authPassword = value;
            }
        }

        public string FirebaseFolder
        {
            get
            {
                return firebaseFolder;
            }

            set
            {
                firebaseFolder = value;
            }
        }
    }
}
