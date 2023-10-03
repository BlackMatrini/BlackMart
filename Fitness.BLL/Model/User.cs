using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL.Model
{    //создаем пользователя и делаем нужные ему свойства
    public class User

    {
        #region свойства
        //ставим имя только get что бы нельзя было много раз менять 
        public string Name { get; }
        //ставим гендер только get что бы нельзя было много раз менять
        public Gender Gender { get; }
        //ставим дату рождения только get что бы нельзя было много раз менять
        public DateTime Birthday { get; }
        //ставим вес и гет и сет ибо вес будет меняться
        public double Weight { get; set; }
        //ставим рост и гет сет ибо рост может меняться
        public double Height { get; set; }
        #endregion
        public User(string name,
                    Gender gender,
                    DateTime birthDate,
                    double weight,
                    double height)
        { //проверяем входные параметрызволяет получить в строковом представлении имя переменной
            #region Проверка условий
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }

            if(Gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));
            }

            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now )
            {
                throw new ArgumentException("Невозможная дата рождения. ", nameof(birthDate));
            }
             if (weight <= 0)
            {
                throw new ArgumentException ("Вес не может быть меньше либо равен нулю.", nameof(weight));
            }
             if(height <= 0)
            {
                throw new ArgumentException("Рост не может быть меньше либо равен нулю.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            Birthday = birthDate;
            Weight = weight;
            Height = height;
        }
        //переопределение к строке 
        public override string ToString()
        {
            return Name;
        }

    }
}
