using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.BuilderPattern
{
    public class BarbanDirector
    {
        private IBuilder _builder;

        public BarbanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(8);
            _builder.SetWater(33);
            _builder.AddIngredients("2 Limones");
            _builder.AddIngredients("Pizca de sal");
            _builder.Mix();
            _builder.Rest(1000);
        }
    }
}
