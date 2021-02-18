using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Repository.Interfaces
{
	public interface IBaseRepository<T> where T : class
	{
		IQueryable<T> GetAll();

		Task<ICollection<T>> GetAllAsyn();

		T Get(int id);

		Task<T> GetAsync(int id);

		T Add(T t);

		Task<T> AddAsync(T t);

		ICollection<T> AddRange(ICollection<T> tList);

		Task<ICollection<T>> AddRangeAsync(ICollection<T> tList);

		T Find(Expression<Func<T, bool>> match);

		Task<T> FindAsync(Expression<Func<T, bool>> match);

		ICollection<T> FindAll(Expression<Func<T, bool>> match);

		Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);

		void Delete(T entity);

		void Delete(int id);

		Task<int> DeleteAsyn(T entity);

		T Update(T t, object key);

		Task<T> UpdateAsyn(T t, object key);

		int Count();

		Task<int> CountAsync();

		void Save();

		Task<int> SaveAsync();

		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

		Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate);

		IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

		void RemoveAll();
		void Dispose(bool disposing);

		void Dispose();
	}
}
