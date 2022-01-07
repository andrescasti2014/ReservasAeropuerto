using Reservas.Abstraction;
using Reservas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application
{
    public interface IApplicationReserva<T> : ICrud<T>
    {
    }
    public class Reserva<T> : IApplicationReserva<T> where T : IReserva
    {
        IRepositoryReserva<T> _repository;
        public Reserva(IRepositoryReserva<T> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void DeleteAsync(int id)
        {
            _repository.DeleteAsync(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<IList<T>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task<T> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public T Save(T entity)
        {
            return _repository.Save(entity);
        }

        public Task<T> SaveAsync(T entity)
        {
            return _repository.SaveAsync(entity);
        }
        public T GetByDescription(string Description)
        {
            return _repository.GetByDescription(Description);
        }
    }
}
