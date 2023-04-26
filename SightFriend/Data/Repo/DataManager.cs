namespace SightFriend.Data.Repo
{
    public class DataManager
    {
        public INewsItemsRepository NewsItems { get; set; }

        public DataManager(INewsItemsRepository newsItemsRepository)
        {
            NewsItems = newsItemsRepository;
        }
    }
}
