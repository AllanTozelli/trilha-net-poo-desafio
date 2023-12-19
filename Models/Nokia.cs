namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {       
        }        

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }

        public override void ExibirInformacoes()
        {
            System.Console.WriteLine($"O Numero do celular é {base.Numero}, modelo {base.Modelo}, imei {base.IMEI}, memoria {base.Memoria}");
        }
    }
}