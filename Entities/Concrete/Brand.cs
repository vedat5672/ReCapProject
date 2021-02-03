using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntities
    {
        public int BrandID { get; set; }

        public string BrandNameOfCar { get; set; }
    }
}
