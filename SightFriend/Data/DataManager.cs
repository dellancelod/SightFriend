using SightFriend.Data.Repo.Interfaces;

namespace SightFriend.Data
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public INewsItemsRepository NewsItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, INewsItemsRepository newsItemsRepository)
        {
            NewsItems = newsItemsRepository;
            TextFields = textFieldsRepository;
        }
    }
}
