using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.DataAccess
{
    public interface IDataAccess<M>
    {
        bool incluir(M model);
        bool deletar(M model);
        bool deletarById(int idModel);
        bool atualizar(M model);
        M retornar(int idModel);
        List<M> retornarAll();
    }
}
