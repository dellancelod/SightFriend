using SightFriend.Models;

namespace SightFriend.Data.Repo.Interfaces
{
    public interface IBooksItemsRepository
    {
        IQueryable<BookItem> GetBookItems();
        BookItem GetBookItemById(Guid id);
        void SaveBookItem(BookItem entity);
        void DeleteBookItem(Guid id);
        void DeleteBookItem(BookItem BooksItem);
    }
}
