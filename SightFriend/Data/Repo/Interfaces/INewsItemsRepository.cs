using SightFriend.Models;

namespace SightFriend.Data.Repo.Interfaces
{
    public interface INewsItemsRepository
    {
        IQueryable<NewsItem> GetNewsItems();
        NewsItem GetNewsItemById(Guid id);
        void SaveNewsItem(NewsItem entity);
        void DeleteNewsItem(Guid id);
        void DeleteNewsItem(NewsItem newsItem);
    }
}
