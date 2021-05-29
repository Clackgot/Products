using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLab1.Classes;

namespace ProgramLab1.Repositories
{

    /// <summary>
    /// Хранилише узлов
    /// </summary>
    public class NodeRepository
    {
        /// <summary>
        /// Список узлов
        /// </summary>
        private readonly List<Node> _nodeList;

        /// <summary>
        /// Конструктор класса хранилища узлов
        /// </summary>
        public NodeRepository()
        {
            _nodeList = new List<Node>();
        }

        /// <summary>
        /// Сохраняет узел в список узлов 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="vendorCode">Артикул</param>
        /// <param name="nodeFunction">Предназначение</param>
        /// <param name="nodeWeight">Масса</param>
        /// <param name="nodeQuality">Качество</param>
        public void Save(string name,string vendorCode,string nodeFunction, int nodeWeight,string nodeQuality)
        {
            var node = new Node(GetId(), name, vendorCode, nodeFunction, nodeWeight, nodeQuality);

            _nodeList.Add(node);
        }
        /// <summary>
        /// Возвращает список узлов
        /// </summary>
        /// <returns></returns>
        public List<Node> GetList()
        {
            return _nodeList;
        }

        /// <summary>
        /// Возвращает узел с заданным ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Node GetById(int id)
        {
            return _nodeList.Find(node => node.Id == id);
        }

        /// <summary>
        /// Возвращает ID нового элемента
        /// </summary>
        /// <returns></returns>
        private int GetId()
        {
            return _nodeList.Any() ? _nodeList.Count() + 1 : 1;
        }
    }
}
