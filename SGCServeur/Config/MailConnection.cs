using System;

namespace SGCServeur.Config
{
    public class MailConnection
    {
        public int Port { get; set; }

        public string Serveur { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        private string DecodingBase64(string textToDecode, System.Text.Encoding encodage = null)
        {
            encodage = encodage ?? System.Text.Encoding.UTF8;
            return String.IsNullOrEmpty(textToDecode) ? null : encodage.GetString(Convert.FromBase64String(textToDecode));
        }
    }
}
