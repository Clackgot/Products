using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Classes
{
    /// <summary>
    /// Деталь
    /// </summary>
    public class Detail: Product
    {
        /// <summary>
        /// Тип
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Габариты
        /// </summary>
        public string Size { get; }

        /// <summary>
        /// Материал
        /// </summary>
        public string Material { get; }

        /// <summary>
        /// Подвижный ли тип детали
        /// </summary>
        /// <returns></returns>
        public bool TypeIsMobile() => Type.ToLowerInvariant() == "подвижный";

        /// <summary>
        /// Если размер больше маленького
        /// </summary>
        public bool SizeMoreThanSmall => Size.ToLowerInvariant() == "средний" || Size.ToLowerInvariant() == "большой";

        /// <summary>
        /// Стальной ли материал
        /// </summary>
        public bool MaterialIsSteel => Material.ToLowerInvariant() == "сталь";


        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="vendorCode"></param>
        /// <param name="detailType"></param>
        /// <param name="detailSize"></param>
        /// <param name="detailMaterial"></param>
        public Detail(int id, string name, string vendorCode, string detailType, string detailSize, string detailMaterial) :base(id, name, vendorCode)
        {
            Type = detailType;
            Size = detailSize;
            Material = detailMaterial;
        }

        /// <summary>
        /// Возвращает строковый эквивалент экземпляра класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"Тип детали: {Type}, Размер детали: {Size}, Материал детали: {Material}";
        }
    }
}
