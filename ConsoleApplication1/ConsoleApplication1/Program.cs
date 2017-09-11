using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
//1.	Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год.Создать коллекцию элементов Book и заполнить тестовыми данными.С помощью класса BinaryFormatter сохранить состояние приложения в двоичный файл.
//2.	На основании задания 1 восстановить состояние приложения из двоичного файла.
//3.	Придумать пользовательский атрибут (самостоятельно). Данный атрибут должен выполнять прикладную задачу(а не демонстрационную). Проверить его функциональность.

        static void Main(string[] args)
        {
            Book book = new Book("Русский язык", 2300, "Олег", 2017);
            Console.WriteLine("Объект создан");


            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(@"E:\books\book.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, book);

                Console.WriteLine("Обьект сериализован");
            }


            using (FileStream fs = new FileStream(@"E:\books\book.bin", FileMode.OpenOrCreate))
            {
                Book newBook = (Book)formatter.Deserialize(fs);

                Console.WriteLine("Обьект десериализован");
                Console.WriteLine("Название: " + newBook.Name);
                Console.WriteLine("Цена: " + newBook.Salary);
                Console.WriteLine("Автор: " + newBook.AuthorName);
                Console.WriteLine("Год публикации: " + newBook.Year + "\n");
            }
            Console.ReadLine();
        }
    }
}
