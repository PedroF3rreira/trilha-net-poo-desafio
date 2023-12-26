namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(){}
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        private string _modelo;
        private string _imei;
        private int _memoria;
        public int Memoria
        {
            get => _memoria;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O valor desse campo deve ser maior que zero.");
                }
                _memoria = value;
            }
        }

        public string Imei
        {
            get => _imei;
            private set
            {
                ValidateFieldString(value);
                _imei = value;
            }
        }

        public string Modelo
        {
            get => _modelo;
            private set
            {
                ValidateFieldString(value);
                _modelo = value;
            }
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

        protected void ValidateFieldString(string value)
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Este campo não pode ser vazio.");
            }
        }

        public override string ToString()
        {
            var infor = $"Modelo do celular: {Modelo}\n"
                        + $"Numero do celular: {string.Format("{0:(##)#####-####}", 
                        Convert.ToInt64(Numero.Replace(" ",""))).Trim()}\n"
                        + $"IMEI do celular: {Imei.ToUpper()}\n"
                        + $"Memória do celular: {Memoria} GB";
            return infor;
        }
    }
}