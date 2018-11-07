using System.ComponentModel.DataAnnotations;

namespace MYARCH.CORE
{
    //Yeni bir nesne bu sınıftan türetilmicek o yüzden abstract
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
