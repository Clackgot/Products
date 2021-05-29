using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLab1.Classes;
using ProgramLab1.Repositories;

namespace ConsoleApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //Хранилища деталей, узлов, механизмов
            DetailRepository detailRepository = new DetailRepository(); //Детали
            NodeRepository nodeRepository = new NodeRepository(); //Узлы
            MechanismRepository mechanismRepository = new MechanismRepository(); //Механизмы

            bool showMenu = true;

            while (showMenu) //обрабатывет исключения
            {
                try
                {
                    showMenu = MainMenu(detailRepository, nodeRepository, mechanismRepository);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Статичный метод отрисовывающий меню
        /// </summary>
        /// <param name="detailRepository"></param>
        /// <param name="nodeRepository"></param>
        /// <param name="mechanismRepository"></param>
        /// <returns></returns>
        private static bool MainMenu(DetailRepository detailRepository, NodeRepository nodeRepository, MechanismRepository mechanismRepository)
        {
            Console.Clear();

            Console.WriteLine("1. Изготовить деталь");
            Console.WriteLine("2. Перечень деталей");
            Console.WriteLine("3. Найти деталь по ID");
            Console.WriteLine("");
            Console.WriteLine("4. Добавить узел");
            Console.WriteLine("5. Просмотр узлов");
            Console.WriteLine("6. Найти узел по ID");
            Console.WriteLine("");
            Console.WriteLine("7. Создать механизм");
            Console.WriteLine("8. Список механизмов");
            Console.WriteLine("9. Найти механизм по ID");

            Console.Write("\nВыберите вариант: ");

            switch (Console.ReadLine())
            {
                case "1": //Изготовить деталь
                    Console.WriteLine("Введите название детали: ");
                    var name = Console.ReadLine();

                    Console.WriteLine("Введите артикул: ");
                    var vendorCode = Console.ReadLine();

                    Console.WriteLine("Введите тип детали: ");
                    var detailType = Console.ReadLine();

                    Console.WriteLine("Введите габариты детали(мм): ");
                    var detailSize = Console.ReadLine();

                    Console.WriteLine("Введите материал детали: ");
                    var detailMaterial = Console.ReadLine();                    

                    detailRepository.Save(name, vendorCode, detailType, detailSize, detailMaterial);

                    return true;

                case "2": //Перечень деталей
                    var list = detailRepository.GetList();
                    Console.WriteLine($"Перечень деталей: {list.Count}");

                    foreach (var item in detailRepository.GetList())
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Для продолжения нажмите любую клавишу... ");
                    Console.ReadKey();
                    return true;

                case "3": //Найти деталь по ID
                    Console.WriteLine("Введите ID: ");
                    int.TryParse(Console.ReadLine(), out var detailid);
                    Console.WriteLine(detailRepository.GetById(detailid));
                    Console.ReadKey();
                    return true;
               
                case "4": //Добавить узел
                    Console.WriteLine("Введите название узла: ");
                    var nodeName = Console.ReadLine();

                    Console.WriteLine("Введите артикул: ");
                    var nodeVendorCode = Console.ReadLine();

                    Console.WriteLine("Введите предназначение для узла: ");
                    var nodeFunction = Console.ReadLine();

                    Console.WriteLine("Введите вес(кг): ");
                    int.TryParse(Console.ReadLine(), out var nodeWeight);

                    Console.WriteLine("Введите качество узла: ");
                    var nodeQuality = Console.ReadLine();

                    nodeRepository.Save(nodeName, nodeVendorCode, nodeFunction, nodeWeight, nodeQuality);

                    return true;

                case "5": //Просмотр узлов
                    var nodelist = nodeRepository.GetList();
                    Console.WriteLine($"Перечень узлов: {nodelist.Count}");

                    foreach (var item in nodeRepository.GetList())
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Для продолжения нажмите любую клавишу... ");
                    Console.ReadKey();
                    return true;

                case "6": //Найти узел по ID
                    Console.WriteLine("Введите ID: ");
                    int.TryParse(Console.ReadLine(), out var nodeid);
                    Console.WriteLine(nodeRepository.GetById(nodeid));
                    Console.ReadKey();
                    return true;

                case "7": //Создать механизм
                    Console.WriteLine("Введите название механизма: ");
                    var mechanismName = Console.ReadLine();

                    Console.WriteLine("Введите предназначение для механизма: ");
                    var mechanismFunction = Console.ReadLine();

                    Console.WriteLine("Введите качество механизма: ");
                    var mechanismQuality = Console.ReadLine();                 

                    mechanismRepository.Save(mechanismName, mechanismFunction, mechanismQuality);

                    return true;

                case "8": //Список механизмов
                    var mechanismlist = mechanismRepository.GetList();
                    Console.WriteLine($"Количество механизмов: {mechanismlist.Count}");

                    foreach (var item in mechanismRepository.GetList())
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Для продолжения нажмите любую клавишу... ");
                    Console.ReadKey();
                    return true;

                case "9": //Найти механизм по ID
                    Console.WriteLine("Введите ID: ");
                    int.TryParse(Console.ReadLine(), out var mechanismid);
                    Console.WriteLine(mechanismRepository.GetById(mechanismid));
                    Console.ReadKey();
                    return true;

                default:
                    return true;
            }

        }
    }
}
