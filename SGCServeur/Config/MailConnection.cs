using System;

namespace SGCServeur.Config
{
    public class MailConnection
    {
        public int Port { get; set; }

        public string Serveur { get; set; }

        public string Mail
        {
            get
            {
                return DecodingBase64(Mail);
            }

            set
            {
                Mail = value;
            }
        }

        public string Password
        {
            get
            {
                return DecodingBase64(Password);
            }

            set
            {
                Password = value;
            }
        }

        private string DecodingBase64(string textToDecode, System.Text.Encoding encodage = null)
        {
            encodage = encodage ?? System.Text.Encoding.UTF8;
            return String.IsNullOrEmpty(textToDecode) ? null : encodage.GetString(Convert.FromBase64String(textToDecode));
        }
    }
}
