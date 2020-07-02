using System;
using WebForum.Domain.Entities;
namespace WebForum.Application.Repositories
{
    public interface ICategoryWriteOnlyUseCase
    {
        int Save(Category category); /*teste*/
        int Add(Category category);
        int Remove(Category category);
        int Remove(Guid id);
        int Update(Category category);
    }
}
