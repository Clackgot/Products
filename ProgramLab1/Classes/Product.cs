using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Classes
{

    /// <summary>
    /// Абстрактный класс продукта
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Артикул
        /// </summary>
        public string VendorCode { get; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreatedAt { get; }


        /// <summary>
        /// Конструктор класса Изделие
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="vendorCode"></param>
        protected Product(int id, string name, string vendorCode)
        {
            Id = id;
            Name = name;
            VendorCode = vendorCode;
            CreatedAt = DateTime.Now;
        }

        /// <summary>
        /// Возвращает строковый эквивалент экземпляра класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ID: {Id}, Название: {Name}, Артикул: {VendorCode} ";
        }
    }
}

