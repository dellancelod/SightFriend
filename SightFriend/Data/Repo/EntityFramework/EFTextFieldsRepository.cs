using Microsoft.EntityFrameworkCore;
using SightFriend.Data.Repo.Interfaces;
using SightFriend.Models;

namespace SightFriend.Data.Repo.EntityFramework
{
    public class EFTExtFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;
        public EFTExtFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteTextField(Guid id)
        {
            context.TextFields.Remove(new TextField { Id = id });
            context.SaveChanges();
        }

        public TextField GetTextFieldByCodeWord(string codeword)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeword);
        }

        public TextField GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<TextField> GetTextFields()
        {
            return context.TextFields;
        }

        public void SaveTextField(TextField entity)
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
