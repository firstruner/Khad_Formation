using System;
using System.Text;
using KhadLib1.Interfaces;
using System.Security.Cryptography;

namespace KhadLib1.Classes
{
    class instanciable: IEncodeDecode
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
       

        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
        private  RSAParameters privatekey;
        private  RSAParameters publickey;

        public  instanciable()
        {
            privatekey = csp.ExportParameters(true);
            publickey = csp.ExportParameters(false);
            
        }
       



        public string Encrypt(string source )
        {
           
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(publickey);
            var data = Encoding.Unicode.GetBytes(source);
            var cypher=csp.Encrypt(data,false);
            return Convert.ToBase64String(cypher);


        }
        public string Decrypt(string cypher)
        {
          
            var databyte = Convert.FromBase64String(cypher);
            csp.ImportParameters(privatekey);
            var source = csp.Decrypt(databyte, false);
            return Encoding.Unicode.GetString(source);


        }
        static void Main(string[] args)
        { instanciable inst = new instanciable();
            string cypher = string.Empty;
            

            Console.WriteLine("saisie ton text en encrypt");
            var text = Console.ReadLine();
            if (text != string.Empty)
            {
                 cypher = inst.Encrypt(text);
                Console.WriteLine($"text encrypt: :\n {cypher}\n");
            }
            Console.WriteLine("decrypter :");
            Console.ReadLine();
            var plaintext = inst.Decrypt(cypher);
            Console.WriteLine(plaintext);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
