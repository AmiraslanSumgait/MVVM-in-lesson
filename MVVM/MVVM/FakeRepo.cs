using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class FakeRepo
    {
        public ObservableCollection<Car> Cars { get; set; }
        public FakeRepo()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car
                {
                    Id=1,
                     Model="Focus",
                      Vendor="Ford",
                       Year="2002"
                },
                new Car
                {
                    Id=2,
                     Model="x100",
                      Vendor="Bmw",
                       Year="2010"
                },
                new Car
                {
                    Id=3,
                     Model="x100",
                      Vendor="Bmw",
                       Year="2010"
                },
                new Car
                {
                    Id=4,
                     Model="x100",
                      Vendor="Bmw",
                       Year="2010"
                },
            };
        }
    }
}
