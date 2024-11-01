using AbstractFactory.BaseFactory;
using AbstractFactory.Enum;
using CrossCutting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactory.FactoryLanchesMethods
{
    public class LanchesFactory : LancheFactoryMethod
    {

        public override Lanches CriarLanches(int tipo)
        {
            var tp = (TipoEnum)tipo; 
            var tipos = tp.ToString();        
            var classes =  GetType().Assembly.GetType(AppDenpendencyInjection.NameSpacesConsole() + "." + tipos);          
            if (classes != null)
            {
                // Instanciar a classe
                object instance = Activator.CreateInstance(classes);
                return (Lanches)instance;

            }
            else
            {
                throw new System.ArgumentException("Lanche não encontrada");
            }

        }
    }
}
