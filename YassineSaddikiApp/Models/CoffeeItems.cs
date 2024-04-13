using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YassineSaddikiApp.Models.ViewModels
{
    public class CoffeeItems
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ObservableCollection<string> Ingredients { get; set; }
        public string Image { get; set; }
        public int Id { get; set; }
    }
}
