using SightFriend.Data.Repo.Interfaces;

namespace SightFriend.Data
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public INewsItemsRepository NewsItems { get; set; }
        public IBooksItemsRepository BooksItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, INewsItemsRepository newsItemsRepository, IBooksItemsRepository booksItemsRepository)
        {
            NewsItems = newsItemsRepository;
            BooksItems = booksItemsRepository;
            TextFields = textFieldsRepository;
        }
    }
}
