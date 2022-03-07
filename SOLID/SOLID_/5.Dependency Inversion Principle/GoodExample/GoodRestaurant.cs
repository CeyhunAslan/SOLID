using SOLID_._5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._5.DIP.GoodExample
{
    public class GoodRestaurant
    {
        private IRecipes _recipes;

        public GoodRestaurant(IRecipes recipes)
        {
            this._recipes = recipes;
        }

        public string GetMenu()
        {
            return $"{_recipes.GetCooking()}";
        }

    }
}
