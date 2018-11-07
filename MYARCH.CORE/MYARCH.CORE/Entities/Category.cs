using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYARCH.CORE
{
    //partial 'ın olduğunda aynı isimden birden fazla calss tanımlanabilir ve ortak özellikleri kullanılabilir

    public partial class Category : Base
    {
        public string Name { get; set; }

    }
}
