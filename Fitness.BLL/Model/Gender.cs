using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL.Model
{ // пол
    public class Gender
    {
        public string Name { get; }
        //создаем конструктор для гендера 
        public Gender (string name)
        {  //проверяем входные условия
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустим или null", nameof(name));
            }
            //присвоение введенных данных
            Name = name;
        } //переопределение метода строки
        public override string ToString()
        {
            return Name;
        }
    }
}
