namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    // IMPLEMENTADO
    public class Nokia:Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {

        }
        // Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no Nokia.");
        }
    }
}