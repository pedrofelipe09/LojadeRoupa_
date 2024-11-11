using LojadeRoupa._01_Service.Interface;
using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using LojadeRoupa._03_Entidades.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service
{
    public class VendaService:IVendaService
    {
        public IVendaRepository _service { get; set; }
        public VendaService(string connection)
        {
            _service = new VendaRepository(connection);
        }
        public void AdicionarVenda(Venda venda)
        {
            _service.AdicionarVenda(venda);
        }

        public List<Venda> ListarVenda()
        {
            return _service.ListarVenda();
        }

        public void EditarVenda(Venda venda)
        {
            _service.EditarVenda(venda);
        }

        public void DeleteVenda(int id)
        {
            _service.DeleteVenda(id);
        }

    }
}
