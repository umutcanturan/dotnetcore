using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
	public static class IQueryableExtension
	{
		public static IOrderedQueryable<TSource> OrderBy<TSource>(this IQueryable<TSource> query, string propertyName)
		{
			var entityType = typeof(TSource);
			var propertyInfo = entityType.GetProperty(propertyName);
			if (propertyInfo == null)
			{
				return query as IOrderedQueryable<TSource>;
			}
			ParameterExpression arg = Expression.Parameter(entityType, "x");
			MemberExpression property = Expression.Property(arg, propertyName);
			var selector = Expression.Lambda(property, new ParameterExpression[] { arg });
			var enumarableType = typeof(Queryable);
			var method = enumarableType.GetMethods()
				 .Where(m => m.Name == "OrderBy" && m.IsGenericMethodDefinition)
				 .Where(m =>
				 {
					 var parameters = m.GetParameters().ToList();
					 return parameters.Count == 2;
				 }).Single();
			MethodInfo genericMethod = method.MakeGenericMethod(entityType, propertyInfo.PropertyType);
			var newQuery = (IOrderedQueryable<TSource>)genericMethod

				 .Invoke(genericMethod, new object[] { query, selector });

			return newQuery;

		}



		public static IOrderedQueryable<TSource> OrderByDescending<TSource>(this IQueryable<TSource> query, string propertyName)
		{
			var entityType = typeof(TSource);
			var propertyInfo = entityType.GetProperty(propertyName);
			if (propertyInfo == null)
			{
				return query as IOrderedQueryable<TSource>;
			}
			ParameterExpression arg = Expression.Parameter(entityType, "x");
			MemberExpression property = Expression.Property(arg, propertyName);
			var selector = Expression.Lambda(property, new ParameterExpression[] { arg });
			var enumarableType = typeof(Queryable);
			var method = enumarableType.GetMethods()
				 .Where(m => m.Name == "OrderByDescending" && m.IsGenericMethodDefinition)
				 .Where(m =>
				 {
					 var parameters = m.GetParameters().ToList();
					 return parameters.Count == 2;
				 }).Single();
			MethodInfo genericMethod = method.MakeGenericMethod(entityType, propertyInfo.PropertyType);
			var newQuery = (IOrderedQueryable<TSource>)genericMethod

				 .Invoke(genericMethod, new object[] { query, selector });

			return newQuery;

		}

	}
}
