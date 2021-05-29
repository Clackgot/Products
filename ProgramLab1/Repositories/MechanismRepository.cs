using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLab1.Classes;

namespace ProgramLab1.Repositories
{
 
    /// <summary>
    /// Хранилише механизмов
    /// </summary>
    public class MechanismRepository
    {
        /// <summary>
        /// Список механизмов
        /// </summary>
        private readonly List<Mechanism> _mechanismList;


        /// <summary>
        /// Конструктор хранилища механизмов
        /// </summary>
        public MechanismRepository()
        {
            _mechanismList = new List<Mechanism>();
        }


        /// <summary>
        /// Сохраняет механизм в список механизмов
        /// </summary>
        /// <param name="mechansimName">Имя механизма</param>
        /// <param name="mechansimFunction">Предназначение механизма</param>
        /// <param name="mechanismQuality">Качество механизма</param>
        public void Save(string mechansimName, string mechansimFunction, string mechanismQuality)
        {
            var mechanism = new Mechanism(GetId(), mechansimName, mechansimFunction, mechanismQuality);

            _mechanismList.Add(mechanism);
        }
        /// <summary>
        /// Возвращает список механизмов
        /// </summary>
        /// <returns></returns>
        public List<Mechanism> GetList()
        {
            return _mechanismList;
        }

        /// <summary>
        /// Возвращает механизм с заданным ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Mechanism GetById(int id)
        {
            return _mechanismList.Find(mechanism => mechanism.Id == id);
        }
        /// <summary>
        /// Возвращает ID нового элемента
        /// </summary>
        /// <returns></returns>
        private int GetId()
        {
            return _mechanismList.Any() ? _mechanismList.Count() + 1 : 1;
        }
    }
}
