using System;
using System.Collections.Generic;
using System.Linq;

namespace HaveNoSideEffects {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

        }

        public class Account {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        //this function has a hidden side effect that the session is initialised when the username and password is valid.
        // It should really be called checkPasswordAndInitialise session. But this will violate the single resposibility principle. 

        public bool CheckPasswordWithSideEffect (string username, string password) {
            var users = GetUsers ();
            var isValid = users.Any (u => u.Username == username && u.Password == password);

            if (isValid) {
                InitialiseSession ();
                return true;
            } else {
                return false;
            }
        }
        //better. just call the initialise method in the calling code. 
        public bool CheckPasswordWithoutSideEffect (string username, string password) {
            var users = GetUsers ();
            return users.Any (u => u.Username == username && u.Password == password);
        }

        public Guid InitialiseSession () {
            return Guid.NewGuid ();
        }

        public List<Account> GetUsers () {
            var userCreds = new List<Account> ();
            userCreds.Add (new Account { Username = "hari1", Password = "password1" });
            userCreds.Add (new Account { Username = "hari2", Password = "password2" });
            userCreds.Add (new Account { Username = "hari3", Password = "password3" });
            return userCreds;
        }
    }
}