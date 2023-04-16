using TaskManagement.Database.Models;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public static List<User> Users { get; set; } = new List<User>();

        static DataContext()
        {
            AddUserSeeedings();
        }

        public DataContext()
        {
            AddUserSeeedings();
        }

        private static void AddUserSeeedings()
        {
            Users.Add(new User("Super", "Admin", "123321", "admin@gmail.com", false));
            Users.Add(new User("Sahil", "Babayev", "123321", "sahil@gmail.com", false));
            Users.Add(new User("Esqin", "Ferecov", "123321", "esqin@gmail.com", false));
            Users.Add(new User("Heydar", "Esqin", "123321", "heydar@gmail.com", false));
            Users.Add(new User("Qinyaz", "Babayev", "123321", "qinyaz@gmail.com", false));
            Users.Add(new User("Jeyhun", "Heydar", "123321", "jeyhun@gmail.com", false));
            Users.Add(new User("Yusif", "Sahil", "123321", "yusif@gmail.com", false));
        }
    }
}
