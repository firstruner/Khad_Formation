using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using KhadLib1.Interfaces;

namespace KhadLib1.Classes
{
    public class PeopleSerialization : IPeoplesSerialization // Héritage conforme
    {
        private string Serialize(People people) // Méthode obligatoire
        {
            // Pas de gestion sur le disque avant cryptage, tout en mémoire
            MemoryStream mem = new MemoryStream();
            new XmlSerializer(typeof(People)).Serialize(mem, people);
            mem.Position = 0;
            
            return new StreamReader(mem).ReadToEnd();
            // TODO:Maintenant que tu as un string, trouve un moyen de l'encrypter


            //Stream fichier = File.Create("c:\\c#\\monfich.dat"); << jamais de chemin direct
            //BinaryFormatter serialize = new BinaryFormatter();
            //serialize.Serialize(fichier, employeesList);
            //fichier.Close();
            //Console.WriteLine("serializable terminé avec succsé");
        }

        private People Deserialize(string encryptedString)
        {
            string uncryptedString = encryptedString;
            // TODO:Ici il faudra décrypter les données avant

            XmlSerializer xml = new XmlSerializer(typeof(People));
            return (People) xml.Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(uncryptedString)));

            //List<People> listeP;
            //Stream fichier = File.OpenRead("c:\\c#\\monfich.dat");
            //BinaryFormatter deserilize = new BinaryFormatter();
            //listeP = (List<People>)deserilize.Deserialize(fichier);
            ////foreach(People pl in List<People>)
            ////{
            //// Console.WriteLine(listeP);
            ////}
            //listeP.ForEach(Console.WriteLine);
            //Console.ReadKey();
        }

        public string[] Serialize(People[] peoples)
        {
            List<string> encryptedStrings = new List<string>();

            foreach (People people in peoples)
                encryptedStrings.Add(Serialize(people));

            return encryptedStrings.ToArray();
        }

        public People[] Deserialize(string[] encryptedString)
        {
            List<People> peoples = new List<People>();
            foreach (string s in encryptedString)
                peoples.Add(Deserialize(s));

            return peoples.ToArray();
        }
    }
}
