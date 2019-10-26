using System;
using KhadLib1.Classes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            // --- Projet : KhadLib1 ---
            // TODO 1 : Créer une classe instanciable héritant de l'interface
            //          IEncoreDecode permettant d'encrypter et décrypter une chaine
            //          A tester du coup
            // 
            // TODO 2 : Créer une méthode permettant l'accès à la classe créer précédemment via une factory
            //
            // --- Projet : ConsoleApp1
            // TODO : Encrypter un texte via la clé publique fournie dans l'énumération de l'app un texte et
            //        sauvegarder le texte crypter (J'ai la clé privée - Si tout va bien je pourrais décrypter ton texte)
            //
            // TODO : Encrypter le texte fournie dans l'énumération de l'app avec la clé de l'app et le sauvegarder
            //        dans un fichier

            // !! ATTENTION à ta façon de coder !!

            // Pour accéder a EncodeDecode, il faut ajouter la référence du projet KhadLib1 à CE projet
            EncodeDecode inst = new EncodeDecode(); // Entre les crochet, pas dessus
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
