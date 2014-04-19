using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.ViewModels
{
    public class PersonVM
    {
        [HiddenInput(DisplayValue= false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
