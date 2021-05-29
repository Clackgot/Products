using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Classes
{

    /// <summary>
    /// Узел
    /// </summary>
    public class Node: Product
    {

        /// <summary>
        /// Предназначение
        /// </summary>
        public string Function { get; }

        /// <summary>
        /// Масса
        /// </summary>
        public int Weight { get; }

        /// <summary>
        /// Качество
        /// </summary>
        public string Quality { get; }

        /// <summary>
        /// Хорошее ли качество
        /// </summary>
        public bool QualityIsGood => Quality.ToLowerInvariant() == "хорошее";


        /// <summary>
        /// Предназанчение ли вращение
        /// </summary>
        /// <returns></returns>
        public bool FunctionIsMining() => Function.ToLowerInvariant() == "вращение" || Function.ToLowerInvariant() == "кручение";


        /// <summary>
        /// Масса в тоннах
        /// </summary>
        /// <returns></returns>
        public double WeightInTons() => Weight / 1000;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="vendorCode"></param>
        /// <param name="nodeFunction"></param>
        /// <param name="nodeWeight"></param>
        /// <param name="nodeQuality"></param>
        public Node(int id, string name, string vendorCode, 
            string nodeFunction,int nodeWeight,string nodeQuality): 
            base(id, name, vendorCode)
            {
                Function = nodeFunction;
                Weight = nodeWeight;
                Quality = nodeQuality;
            }

        /// <summary>
        /// Возвращает строковый эквивалент экземпляра класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"Функция узла: {Function}, Состояние узла: {Quality}, Вес узла: {Weight}";
        }
    }
}
