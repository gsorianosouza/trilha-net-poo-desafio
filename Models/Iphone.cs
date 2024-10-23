namespace DesafioPOO.Models
{
    // FEITO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string modelo, string imei, int memoria) : base (numero,modelo,imei,memoria)
        {
        }

        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Iphone!");
        }
    }
        // FEITO: Sobrescrever o método "InstalarAplicativo"
}