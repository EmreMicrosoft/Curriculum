using System;

namespace UI.ConsoleCore
{
    public static class UsersDatabese
    {
        public static User CreateUser()
        {
            User user = new User
            {
                FirstName = "Mahmut",
                LastName = "Cebeci",
                DateOfBirth = DateTime.Today,
                Gender = true,
                Email = "mahmut.cebeci@gmail.com",
                Username = "mahmutcebeci",
                Password = "mC-12345"
            };

            return user;
        }
    }
}