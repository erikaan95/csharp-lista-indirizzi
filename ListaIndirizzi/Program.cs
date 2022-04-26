using ListaIndirizzi;
string path = "C:\Users\ancor\OneDrive\Desktop";
List<Indirizzo> indirizzi = new List<Indirizzo>();

StreamReader fileIndirizziCSV = File.OpenText(path);

fileIndirizziCSV.ReadLine();   

while (!fileIndirizziCSV.EndOfStream)
{
    string riga = fileIndirizziCSV.ReadLine();
    string[] informazioni = riga.Split(',');
    try
    {
        if (informazioni.Length == 6)
        {
            string nome = informazioni[0];
            string cognome = informazioni[1];
            string via = informazioni[2];
            string citta = informazioni[3];
            string provincia = informazioni[4];
            int zip = int.Parse(informazioni[5]);

            Indirizzo indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, zip);
            indirizzi.Add(indirizzo);
        }
        else
        {
            Console.WriteLine("Questo indirizzo non è scritto correttamente");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
fileIndirizziCSV.Close();

foreach (Indirizzo indirizzo in indirizzi)
{
    Console.WriteLine(indirizzo.ToString());
}
