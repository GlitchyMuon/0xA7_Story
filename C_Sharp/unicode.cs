using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Symbole Wingdings
        string wingdingsSymbol = "➔"; // Remplacez cela par le symbole réel Wingdings que vous utilisez

        // Créez un objet pour stocker vos données
        var data = new
        {
            wingdings = wingdingsSymbol
        };

        // Convertissez l'objet en JSON
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);

        // Enregistrez le JSON dans un fichier
        File.WriteAllText("output.json", json);

        Console.WriteLine("Données JSON sauvegardées avec succès.");
    }
}
