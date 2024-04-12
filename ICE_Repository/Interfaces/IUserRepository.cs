using ICE_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Interfaces
{
    public interface IUserRepository
    {
        Users Create(Users user);
        List<Users> GetAll();
        Users UpdateById(int id, Users updatedUser);
        Users DeleteById(int id);
    }
}
