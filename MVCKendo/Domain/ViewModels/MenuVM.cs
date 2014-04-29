using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class MenuVM
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string DisplayValue { get; set; }
        public List<MenuVM> Subs { get; set; }

        public bool Dropdown { get; set; }
    }
}
