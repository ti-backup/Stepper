using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepper
{
    interface IDao<T>
    {
        DataTable BuscaTodos();
        T BuscaPorId(Int32 id);
        Boolean Atualiza(T obj);
        void Remove(Int32 id);
        void Adiciona(T obj);
    }
}
