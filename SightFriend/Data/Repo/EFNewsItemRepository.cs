using Microsoft.EntityFrameworkCore;
using SightFriend.Models;

namespace SightFriend.Data.Repo
{
    public class EFNewsItemRepository : INewsItemsRepository
    {
        private readonly AppDbContext context;
        public EFNewsItemRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteNews(Guid id)
        {
            context.News.Remove(new News() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<News> GetNews()
        {
            return context.News;
        }

        public News GetNewsById(Guid id)
        {
            return context.News.FirstOrDefault(x => x.Id == id);
        }

        public void SaveNews(News newsItem)
        {
            if (newsItem.Id == default)
                context.Entry(newsItem).State = EntityState.Added;
            else
                context.Entry(newsItem).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
