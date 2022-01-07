using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Abstraction
{
    public interface ICacheService<T> where T : IReserva
    {
        bool IsCacheableEntity();
        Task<T> GetOne(int id);
        void SetOne(T entity);

        Task<IList<T>> GetList();
        void SetList(IList<T> entity);

    }
}
