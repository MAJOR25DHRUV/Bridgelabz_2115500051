using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class RegisterUserBL
    {
        private RegisterUserRL _registerUserRL;

        public RegisterUserBL(RegisterUserRL registerUserRL)
        {
            _registerUserRL = registerUserRL;
        }

        public bool Register(UserDTO user)
        {
            try
            {
                
                List<UserDTO> existingUsers = _registerUserRL.GetAllUsers();

                
                foreach (var u in existingUsers)
                {
                    if (u.Email == user.Email)
                    {
                        return false; 
                    }
                }

                
                return _registerUserRL.AddUser(user);
            }
            catch
            {
                return false;
            }
        }

        public List<UserDTO> GetUsers()
        {
            return _registerUserRL.GetAllUsers();
        }
    }
}
