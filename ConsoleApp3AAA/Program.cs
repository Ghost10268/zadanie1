using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3AAA
{
    class Program
    {
        static void Main(string[] args)
        {
            double people_hp = 1200;//хп игрока
            double first_people_damage = 85;// дамаг игрока
            double people_armor = 0.1;//щит игрока

            double monster_hp = 2700;//хп монстра
            double first_monster_damage = 40;//дамаг монстра
            double monster_armor = 0.03;//щит монстра

            double second_people_damage = (first_people_damage-first_people_damage * monster_armor);// урон игрока с учетом защиты монстра
            double second_monster_damage = (first_monster_damage-first_monster_damage * people_armor);// урон монстра с учетом защиты игрока

            Console.WriteLine("Бой начат");
            while(people_hp > 0 && monster_hp > 0)
            {
                Console.WriteLine($"игрок наносит удар монстру, оставляя ему {monster_hp -= second_people_damage} HP");
                Console.WriteLine($"монстр наносит удар игроку, оставляя ему {people_hp -= second_monster_damage} HP");
                

            }
            Console.WriteLine("PEOPLE WIN");
            Console.ReadKey();
        }
    }
}
