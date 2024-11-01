using AbstractFactory.BaseFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FactoryLanchesMethods
{
    public abstract class LancheFactoryMethod
    {
        public abstract Lanches CriarLanches(int tipo);
    }
}
