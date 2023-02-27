using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiprodutos.Data.Entities
{
    public class Categoria
    {
        private Guid? _idcategoria;
        private string? _nome;
        private string? _descricao;

        public Guid? Idcategoria { get => _idcategoria; set => _idcategoria = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Descricao { get => _descricao; set => _descricao = value; }
    }
}
