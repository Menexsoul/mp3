using musical;

class Program
{
    static void Main()
    {
        Groupe grpDeClassique = new Groupe("The Rockers", DateTime.Now);

        grpDeClassique.AjouterInstruments(new Violon(4,"Violon"));
        grpDeClassique.AjouterInstruments(new Violloncelle(4, "Violoncelle"));

        grpDeClassique.listeInstruments();

        LecteurMP3 lecteur = new LecteurMP3();
        Console.WriteLine("Entrer le chemin du fichier MP3 : ");
        string fichier = Console.ReadLine();
        lecteur.Jouer(fichier);
    }

}