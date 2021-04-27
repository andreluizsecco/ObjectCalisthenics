using System;
using System.Linq;
using System.Collections.Generic;

namespace OneDotPerLine
{
    public class Class1
    {
        public void Testar()
        {
            var registro = new Registro();

            registro.Filhos.Add(new Registro());

            registro.Filhos
                    .OrderByDescending(p => p.DataCriacao)
                    .FirstOrDefault()
                    .Filhos.Add(new Registro());



            var registroRefatorado = new RegistroRefatorado();

            registroRefatorado.AdicionarFilho(new RegistroRefatorado());

            var filhoMaisRecente = registroRefatorado.ObterFilhoMaisRecente();
            filhoMaisRecente.AdicionarFilho(new RegistroRefatorado());
        }

    }

    public class Registro
    {
        public DateTime DataCriacao { get; private set; }
        public List<Registro> Filhos { get; set; }

        public Registro() =>
            DataCriacao = DateTime.Now;
    }

    public class RegistroRefatorado
    {
        public DateTime DataCriacao { get; private set; }
        public List<RegistroRefatorado> Filhos { get; private set; }

        public RegistroRefatorado() =>
            DataCriacao = DateTime.Now;

        public void AdicionarFilho(RegistroRefatorado registro) =>
            Filhos.Add(registro);

        public RegistroRefatorado ObterFilhoMaisRecente() =>
            Filhos.OrderByDescending(p => p.DataCriacao)
                  .FirstOrDefault();
    }
}
