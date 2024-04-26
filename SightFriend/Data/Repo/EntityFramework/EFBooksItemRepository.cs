using Microsoft.EntityFrameworkCore;
using SightFriend.Data.Repo.Interfaces;
using SightFriend.Models;

namespace SightFriend.Data.Repo.EntityFramework
{
    public class EFBooksItemsRepository : IBooksItemsRepository
    {
        private readonly AppDbContext context;
        public EFBooksItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteBookItem(Guid id)
        {
            context.BookItems.Remove(new BookItem { Id = id });
            context.SaveChanges();
        }

        public void DeleteBookItem(BookItem BooksItem)
        {
            context.BookItems.Remove(BooksItem);
            context.SaveChanges();
        }

        public BookItem GetBookItemById(Guid id)
        {
            return context.BookItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<BookItem> GetBookItems()
        {
            return context.BookItems;
        }

        public void SaveBookItem(BookItem entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

    }
}
