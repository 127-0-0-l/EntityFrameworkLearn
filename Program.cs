using System;
using System.Linq;

namespace EntityFrameworkLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFLContext db = new EFLContext())
            {
                // создаем два объекта User
                Car user1 = new Car { Mark = "BMW", Speed = 120 };
                Car user2 = new Car { Mark = "Volvo", Speed = 125 };

                // добавляем их в бд
                //db.Cars.Add(user1);
                //db.Cars.Add(user2);
                //db.Cars.Remove(user1);
                //db.Cars.Remove(user2);
                //db.SaveChanges();
                //Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var cars = db.Cars.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Id}.{car.Mark} - {car.Speed}");
                }
            }
            Console.ReadKey();
        }
    }
}
