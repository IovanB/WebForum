using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebForum.Domain.Entities;
namespace WebForum.Application.Repositories
{
    public interface ICategoryReadOnlyUseCase : IReadOnlyUseCase<Category>
    {
        List<Category> GetAll();
        Category GetById(Guid id);

        IList<Category> GetByFilter(Expression<Func<Category, bool>> filter);
    }
}
