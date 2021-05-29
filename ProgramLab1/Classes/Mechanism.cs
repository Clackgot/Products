using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Classes
{
    public class Mechanism
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
        /// Предназначение
        /// </summary>
        public string Function { get; }

        /// <summary>
        /// Качество
        /// </summary>
        public string Quality { get; }

        /// <summary>
        /// Хорошее или отличное качество
        /// </summary>
        public bool QualityIsGood => Quality.ToLowerInvariant() == "хорошее" || Quality.ToLowerInvariant() == "отличное";


        /// <summary>
        /// Предназанчение ли копание
        /// </summary>
        /// <returns></returns>
        public bool FunctionIsMining() => Function.ToLowerInvariant() == "копание" || Function.ToLowerInvariant() == "копка";


        /// <summary>
        /// Количество букв в имени
        /// </summary>
        /// <returns></returns>
        public int CountLettersInName()
        {
            return Name.Length;
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mechansimName"></param>
        /// <param name="mechansimFunction"></param>
        /// <param name="mechanismQuality"></param>
        public Mechanism(int id, string mechansimName, string mechansimFunction, string mechanismQuality)
        {
            Id = id;
            Name = mechansimName;
            Function = mechansimFunction;
            Quality = mechanismQuality;
        }

        /// <summary>
        /// Возвращает строковый эквивалент экземпляра класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"ID: {Id}, Механизм: {Name}, Тип механизма: { Function}, Состояние механизма: {Quality}";
        }
    }
}

