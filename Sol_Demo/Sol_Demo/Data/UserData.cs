using Sol_Demo.Model;

namespace Sol_Demo.Data
{
    public class UserData
    {
        public Task<IReadOnlyList<UserModel>> GetUserListAsync()
        {
            return Task.Run<IReadOnlyList<UserModel>>(() =>
            {
                var userList = new List<UserModel>();
                userList.Add(new UserModel()
                {
                    UserId = 1,
                    FirstName = "Kishor",
                    LastName = "Naik",
                });
                userList.Add(new UserModel()
                {
                    UserId = 2,
                    FirstName = "Eshaan",
                    LastName = "Naik",
                });

                return userList.AsReadOnly();
            });
        }
    }
}