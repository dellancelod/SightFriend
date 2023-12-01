using SightFriend.Models;

namespace SightFriend.Data.Repo.Interfaces
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeword);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
