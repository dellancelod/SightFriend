using Microsoft.EntityFrameworkCore;
using SightFriend.Data.Repo.Interfaces;
using SightFriend.Models;

namespace SightFriend.Data.Repo.EntityFramework
{
    public class EFNewsItemsRepository : INewsItemsRepository
    {
        private readonly AppDbContext context;
        public EFNewsItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteNewsItem(Guid id)
        {
            context.NewsItems.Remove(new NewsItem { Id = id });
            context.SaveChanges();
        }

        public void DeleteNewsItem(NewsItem newsItem)
        {
            context.NewsItems.Remove(newsItem);
            context.SaveChanges();
        }

        public NewsItem GetNewsItemById(Guid id)
        {
            return context.NewsItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<NewsItem> GetNewsItems()
        {
            return context.NewsItems;
        }

        public void SaveNewsItem(NewsItem entity)
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
