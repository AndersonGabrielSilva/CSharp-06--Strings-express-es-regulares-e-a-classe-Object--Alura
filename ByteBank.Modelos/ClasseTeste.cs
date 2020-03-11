using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {

        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            {
                teste.MetodoPublico();
                //teste.MetodoPrivado();
                //teste.MetodoProtegido();

            }
        }

    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            //Visível apenas para a classe  "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            //Visível apenas para a classe  "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            //Visível apenas para o projeto "ByteBank.Modelos"
        }
    }

}
