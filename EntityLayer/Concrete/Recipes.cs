using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
 public   class Recipes
    {
        public int RecipesID { get; set; }
        public string RecipesName { get; set; }
        public string FoodDescription { get; set; }
        public bool RecipesStatus { get; set; }
        public double RecipesCalorie { get; set; }
        public double Recipescarbo { get; set; }
        public double RecipesProtein { get; set; }
        public double RecipesFat { get; set; }
        public string Ingredients { get; set; }
        public string Ingredients1 { get; set; }
        public string Ingredients2 { get; set; }
        public string Ingredients3 { get; set; }
        public string Ingredients4 { get; set; }
        public string Ingredients5 { get; set; }
        public string Ingredients6 { get; set; }
        public string Foodamount { get; set; }
        public string RecipesImage { get; set; }
        public string RecipesCook { get; set; }
        public string RecipesMethod { get; set; }
        public string RecipesMethod1 { get; set; }
        public string RecipesMethod2 { get; set; }
        public string RecipesMethod3 { get; set; }
        public DateTime RecipesDate { get; set; }


    }
}
