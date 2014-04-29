using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL
{
    public class MenuDal : IDisposable
    {
        public IEnumerable<MenuVM> GetMenuItems()
        {
            return new List<Domain.ViewModels.MenuVM>
            {
                 new Domain.ViewModels.MenuVM { Dropdown = false, Action = "Index", Controller = "Home", DisplayValue = "Home", Id = 1 },
                 new Domain.ViewModels.MenuVM { Dropdown = false, Action = "Grid", Controller = "Home", DisplayValue = "Grid", Id = 2},
                 new Domain.ViewModels.MenuVM { Dropdown = true, DisplayValue = "DROPDOWN", Id = 3, Subs =
                    new List<Domain.ViewModels.MenuVM>
                    {
                        new Domain.ViewModels.MenuVM { Action = "GridDetail", Controller = "Home", DisplayValue = "Grid With Detail", Id = 3 },
                        new Domain.ViewModels.MenuVM { Action = "GridDetail", Controller = "Home", DisplayValue = "Grid With Detail", Id = 3 },
                        new Domain.ViewModels.MenuVM { Action = "GridDetail", Controller = "Home", DisplayValue = "Grid With Detail", Id = 3 },
                        new Domain.ViewModels.MenuVM { Action = "GridDetail", Controller = "Home", DisplayValue = "Grid With Detail", Id = 3 },
                        new Domain.ViewModels.MenuVM { Action = "GridDetail", Controller = "Home", DisplayValue = "Grid With Detail", Id = 3 }
                    }
                 }
            };
        }

        public void Dispose()
        {
        }
    }
}