using System.Collections.Generic;
using System.Threading.Tasks;
using BabyApp.API.Models;

// creating a new repository for our API

namespace BabyApp.API.Data
{
    public interface IBabyRepository
    {
        // T is a type of user or a type of a photo
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         // zero or 0< changes to save
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         // get individual user
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
    }
}