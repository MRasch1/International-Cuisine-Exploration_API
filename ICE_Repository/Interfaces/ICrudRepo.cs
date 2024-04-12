using ICE_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ICE_Repository.Interfaces
{
    public interface ICrudRepo<Crud>
    {
        Crud Create(Crud crud);
        List<Crud> GetAll();
        Crud UpdateById(int id, Crud updatedUser);
        Crud DeleteById(int id);
    }
    public interface IUserRepository : ICrudRepo<Users>
    {
    }
}
