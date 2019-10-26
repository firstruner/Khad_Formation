using System;
using System.Text;
using KhadLib1.Interfaces;
using System.Security.Cryptography;

namespace KhadLib1.Classes
{
    public class EncodeDecode : IEncodeDecode // si elle n'était pas PUBLIC tu ne pourra jamais y accéder en dehors du projet
    {
        /*  public string _rsaPublicKey;
           string rsaPublicKey
           {
               get { return _rsaPublicKey; }
               set { _rsaPublicKey = value; }
           }

           public string _source;
           string source
           {
               get { return _source; }
               set { _source = value; }
           }*/

        // les variables private débutes toutes par un '_' suivi de la 1ère lettre en minuscule
        private RSACryptoServiceProvider _csp = new RSACryptoServiceProvider(); // Pas besoin du static dans ce type de projet
        private RSAParameters _privatekey;
        private RSAParameters _publickey;

        public EncodeDecode()
        {
            _privatekey = _csp.ExportParameters(true);
            _publickey = _csp.ExportParameters(false);
        }

        public string Encrypt(string source)
        {

            _csp = new RSACryptoServiceProvider();
           _csp.ImportParameters(_publickey);
            var data = Encoding.Unicode.GetBytes(source);
            var cypher = _csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }

        public string Decrypt(string cypher)
        {
            var databyte = Convert.FromBase64String(cypher);
            _csp.ImportParameters(_privatekey);
            var source = _csp.Decrypt(databyte, false);
            return Encoding.Unicode.GetString(source);
        }


        [Obsolete("Dans la classe car une classe ne peux pas d'instanciée elle même")]
        static void Main(string[] args)
        {

        }
    }
}