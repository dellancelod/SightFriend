using SightFriend.Models;

namespace SightFriend.Data.Repo
{
    public interface INewsItemsRepository
    {
        IQueryable<News> GetNews();
        News GetNewsById(Guid id);
        void SaveNews(News newsItem);
        void DeleteNews(Guid id);
    }
}
