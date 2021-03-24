using System;
using System.ComponentModel.DataAnnotations;

namespace GameForPraktika
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables

            int id = 1;
            int switcher;
            
            #endregion

            Character Fil = new Character("Gleb", State.Нормальное,true,true,Sex.Мужской,
                Race.Человек,19,100,100,0);
            Character Semen = new Character("Gleb", State.Нормальное,true,true,Sex.Мужской,
                Race.Человек,19,100,100,0);
            Console.WriteLine(Fil);
            Console.WriteLine(Semen);
            
        }
    }
}