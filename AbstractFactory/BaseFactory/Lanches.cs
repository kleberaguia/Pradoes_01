using System.Collections;

namespace AbstractFactory.BaseFactory
{
    public abstract class Lanches
    {
        public abstract string Nome { get; }
        public ArrayList Ingredientes = new ArrayList();
    }
}
