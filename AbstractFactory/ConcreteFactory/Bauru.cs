using AbstractFactory.BaseFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactory
{
    public class Bauru : Lanches
    {
        public readonly string _nomeLanche;

        public Bauru()
        {
            _nomeLanche = "Bauru";
            Ingredientes.Add("Pão Frances");
            Ingredientes.Add("Presunto");
            Ingredientes.Add("Mussarela");
            Ingredientes.Add("Tomate e maionese");

        }

        public override string Nome { get => _nomeLanche;  }
    }
}
