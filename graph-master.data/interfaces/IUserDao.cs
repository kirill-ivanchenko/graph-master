using System;
using System.Threading.Tasks;

using graph_master.models;

namespace graph_master.data.interfaces
{
    public interface IUserDao
    {
        Task<User> CreateUser(User user);
        Task<Guid> CreateConfirmCode(int userId);
        Task<bool> ConfirmUser(Guid userCode);
        Task<User> UpdateUser(User user);
        Task<UserAuthenticated> SignIn(string userName, string password);
    }
}