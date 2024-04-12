using ICE_Repository.Context;
using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;
        public UserRepository(DataContext data)
        {
            this.context = data;
        }

        public Users Create(Users user)
        {
            // Context is our Database
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public List<Users> GetAll()
        {
            return context.Users.ToList();
        }

        public Users UpdateById(int id, Users updatedUser)
        {
            var user = context.Users.FirstOrDefault(u => u.UserId == id);

            if (user != null)
            {
                user.Username = updatedUser.Username;
                user.Email = updatedUser.Email;
                user.Password = updatedUser.Password;
                user.DietaryPreferenceId = updatedUser.DietaryPreferenceId;

                context.SaveChanges();
            }

            return user;
        }

        public Users DeleteById(int id)
        {
            var user = context.Users.FirstOrDefault(s => s.UserId == id);

            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            return user;
        }
    }
}
