using System;

namespace NoGettersOrSetters
{

    public class Class1
    {
        public void Testar()
        {
            var jogador1 = new Jogador() { Nome = "J1" };
            var jogador2 = new Jogador() { Nome = "J2" };

            jogador2.Pontos += 1000;
            jogador1.Vencedor = true;
            
            var jogador3 = new JogadorRefatorado("J3");
            var jogador4 = new JogadorRefatorado("J4");

            jogador3.AdicionarPonto();
            var vencedor = jogador4.Vencedor;
        }
    }

    public class Jogador
    {
        public string Nome { get; set; }
        public int Pontos { get; set; }
        public bool Vencedor { get; set; }
    }

    public class JogadorRefatorado
    {
        public string Nome { get; private set; }
        public int Pontos { get; private set; }
        public bool Vencedor => Pontos == 10;

        public JogadorRefatorado(string nome) =>
            Nome = nome;

        public void AdicionarPonto() =>
            Pontos += 1;
    }
}
