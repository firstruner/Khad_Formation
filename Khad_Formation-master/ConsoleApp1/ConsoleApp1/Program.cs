using System;
using System.Collections.Generic;
using KhadLib1.Classes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> employeesList = CreateObjects();

            // --- Projet : KhadLib1 ---
            // TODO : Créer les méthodes de sérialization et désérialization des objets People
            //          La sérialization doit pouvoir inclure le cryptage et décryptage
            //          des données afin que l'utilisateur lambda ne puisse pas avoir accès
            //          aux informations.
            //          1ère possibilité : Utiliser un certificat d'encryptage/décryptage
            //          2nd  possibilité : Utiliser une clé synchrone pour crypter et décrypter
        }

        private static List<People> CreateObjects()
        {
           // List<People> employeesList = new List<People>();
            //employeesList.Add(new People() { Firstname = "Hassib", Lastname = "BOULAS", Birthdate = DateTime.Parse("30/10/1980") });
            //employeesList.Add(new People() { Firstname = "Nabila", Lastname = "BOULAS", Birthdate = DateTime.Parse("22/09/1980") });
            //employeesList.Add(new People() { Firstname = "Khadija", Lastname = "ESSAFI", Birthdate = DateTime.Parse("01/01/1988") });
            //employeesList.Add(new People() { Firstname = "Haj", Lastname = "ESSAFI", Birthdate = DateTime.Parse("01/01/1954") });
            //Stream fichier = File.Create("c:\\c#\\monfich.dat");
            //BinaryFormatter serialize = new BinaryFormatter();
            //serialize.Serialize(fichier, employeesList);
            //fichier.Close();
            //Console.WriteLine("serializable terminé avec succsé");
          
            List<People> listeP;
            Stream fichier = File.OpenRead("c:\\c#\\monfich.dat");
            BinaryFormatter deserilize = new BinaryFormatter();
            listeP = (List<People>)deserilize.Deserialize(fichier);
            //foreach(People pl in List<People>)
            //{
            // Console.WriteLine(listeP);
            //}
            listeP.ForEach(Console.WriteLine);
            Console.ReadKey();

            return listeP;
        }
    }
}
