using AbstractFactory.BaseFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactory
{
    public class Frango : Lanches
    {
        private readonly string _nomeLanche;
        public Frango()
        {
            _nomeLanche = "Frango";
            Ingredientes.Add("Peito de frango");
            Ingredientes.Add("Maionese e tomate");


        }
        public override string Nome { get => _nomeLanche; }
    }
}
