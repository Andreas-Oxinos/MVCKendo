using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.ViewModels
{
    public class PetVW
    {
        [HiddenInput(DisplayValue = false)]
        public int PetId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int PersonId { get; set; }
    }
}
