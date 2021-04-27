using System;
using System.Collections.Generic;

namespace OnlyOneLevelPerMethod
{
    public class Class1
    {
        public void AnalisarRegistros(List<Registro> registros)
        {
            foreach (var registro in registros)
            {
                //Implementação...

                foreach (var filho in registro.Filhos)
                {
                    //Implementação...
                }
            }
        }

        public void AnalisarRegistros2(List<Registro> registros)
        {
            foreach (var registro in registros)
            {
                //Implementação...

                AnalisarRegistrosFilhos(registro);
            }
        }

        private void AnalisarRegistrosFilhos(Registro registro)
        {
            foreach (var filho in registro.Filhos)
            {
                //Implementação...
            }
        }
    }

    public class Registro
    {
        public List<Registro> Filhos { get; set; }
    }
}
