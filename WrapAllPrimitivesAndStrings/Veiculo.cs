using System;

namespace WrapAllPrimitivesAndStrings
{
    public class Veiculo
    {
        public string Placa { get; set; }
    }

    public class Veiculo2
    {
        public PlacaVeiculo Placa { get; set; }
    }

    public class PlacaVeiculo
    {
        public string Numero { get; set; }
        public long NumeroLacre { get; set; }

        public PlacaVeiculo(string numero)
        {
            if (EstaInvalido(numero))
                throw new Exception("Número de placa inválido");
            Numero = numero;            
        }

        private bool EstaInvalido(string numero)
        {
            //Implementação...

            return false;
        }
    }
}
