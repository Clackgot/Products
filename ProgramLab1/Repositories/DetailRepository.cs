using ProgramLab1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLab1.Repositories
{

    /// <summary>
    /// Хранилище деталей
    /// </summary>
    public class DetailRepository
    {
        /// <summary>
        /// Список деталей
        /// </summary>
        private readonly List<Detail> _detailList;

        /// <summary>
        /// Конструктор хранилища деталей
        /// </summary>
        public DetailRepository()
        {
            _detailList = new List<Detail>();
        }


        /// <summary>
        /// Сохраняет деталь в список 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="vendorCode"></param>
        /// <param name="detailType"></param>
        /// <param name="detailSize"></param>
        /// <param name="detailMaterial"></param>
        public void Save(string name, string vendorCode, string detailType, string detailSize, string detailMaterial)
        {
            var detail = new Detail(GetId(), name, vendorCode, detailType, detailSize, detailMaterial);

            _detailList.Add(detail);
        }

        /// <summary>
        /// Возвращает список деталей
        /// </summary>
        /// <returns></returns>
        public List<Detail> GetList()
        {
            return _detailList;
        }

        /// <summary>
        /// Возвращает деталь с заданным ID
        /// </summary>
        /// <param name="id">ID детали</param>
        /// <returns></returns>
        public Detail GetById(int id)
        {
            return _detailList.Find(detail => detail.Id == id);
        }

        /// <summary>
        /// Возвращает ID нового элемента
        /// </summary>
        /// <returns></returns>
        private int GetId()
        {
            return _detailList.Any() ? _detailList.Count() + 1 : 1;
        }
    }
}
