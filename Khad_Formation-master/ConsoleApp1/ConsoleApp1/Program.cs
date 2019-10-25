#define create

using System;
using System.Collections.Generic;
using System.IO;
using KhadLib1.Classes;

//using System.IO;      pas besoin ici car c'est la classe qui va le gérer
//using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outil de gestion de serialization
            PeopleSerialization ps = new PeopleSerialization();

#if create // << Ici on utilise la définition de symboles // cf : haut de page
            List<People> employeesList = CreateObjects();
            // Exécutée si le symbole create existe

            StreamWriter sw = new StreamWriter("employees.dat");
            // TODO:Nom du fichier embedded à encrypter, trouve TA méthode d'encryptage de valeurs

            foreach (string s in ps.Serialize(employeesList.ToArray()))
            {
                sw.WriteLine(s);
                sw.Flush();
            }
            sw.Close();
#else
            // Exécutée si le symbole create n'existe pas
            StreamReader sr = new StreamReader("employees.dat");
            // TODO:Nom du fichier embedded à encrypter, trouve TA méthode d'encryptage de valeurs

            string[] stringsEncrypted = sr.ReadToEnd().Replace("\r", string.Empty).Split('\n');
            sr.Close();

            List<People> employeesList = new List<People>();
            employeesList.AddRange(ps.Deserialize(stringsEncrypted));
#endif


            // On créer une interface IPeoplesSerialization qui permet d'obliger la classe héritant
            // d'implémenté certaines méthodes.
            //
            // On créer ensuite une classe PeopleSerialization qui hérite de l'interface
            // cf : PeopleSerialization pour la suite

            // --- Projet : KhadLib1 ---
            // TODO : Créer les méthodes de sérialization et désérialization des objets People
            //          La sérialization doit pouvoir inclure le cryptage et décryptage
            //          des données afin que l'utilisateur lambda ne puisse pas avoir accès
            //          aux informations.
            //          1ère possibilité : Utiliser un certificat d'encryptage/décryptage
            //          2nd  possibilité : Utiliser une clé synchrone pour crypter et décrypter
        }

#if create // La méthode existera si le symbole create existe
        private static List<People> CreateObjects()
        {
            // Cette partie doit restée intact pour le principe des tests
            List<People> employeesList = new List<People>();
            employeesList.Add(new People() { Firstname = "Hassib", Lastname = "BOULAS", Birthdate = DateTime.Parse("30/10/1980") });
            employeesList.Add(new People() { Firstname = "Nabila", Lastname = "BOULAS", Birthdate = DateTime.Parse("22/09/1980") });
            employeesList.Add(new People() { Firstname = "Khadija", Lastname = "ESSAFI", Birthdate = DateTime.Parse("01/01/1988") });
            employeesList.Add(new People() { Firstname = "Haj", Lastname = "ESSAFI", Birthdate = DateTime.Parse("01/01/1954") });
            return employeesList;
        }
#endif
    }
}