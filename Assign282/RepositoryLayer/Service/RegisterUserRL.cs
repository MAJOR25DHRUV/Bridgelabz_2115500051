using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using System.Collections.Generic;

namespace RepositoryLayer.Service
{
    public class RegisterUserRL
    {
        private LinkedList<UserDTO> userList = new LinkedList<UserDTO>();

        public bool AddUser(UserDTO user)
        {
            try
            {
                userList.AddLast(user); 
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<UserDTO> GetAllUsers()
        {
            return new List<UserDTO>(userList);
        }
    }
}

