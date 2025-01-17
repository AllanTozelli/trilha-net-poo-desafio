namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo {get;}
        public string IMEI { get;}
        public int Memoria { get;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void ExibirInformacoes();
    }

  
}