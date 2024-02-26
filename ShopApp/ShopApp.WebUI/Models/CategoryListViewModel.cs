using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class CategoryListViewModel
    {
        public string SelectedCategory { get; set; }//Eğer telefon bilgisayar veya elektroniği seçersek seçili olcak hiç birini seçmezsek seçili gözükmeyecek
        public List<Category> Categories { get; set; }
    }
}
