using System;

namespace user_signup.Models {
    public class User {
    // PRIVATE
        
        // FIELDS
        private string username;
        private string password;
        private string email;
        
        // PROPERTIES
        private string Password {
            get => password;
            set {
                if (password.Length > 20) {
                    throw new ArgumentException("Password is too long. Must be less than 20 characters");
                }

                if (password.Length < 5) {
                    throw new ArgumentException("Password is too short. Must be at least 5 characters");
                }
                password = value;
            }
        }

        // METHODS
        
    // PUBLIC
        
        // PROPERTIES
        public string Username {
            get => username;
            set {
                if (value.Length > 15) {
                    throw new ArgumentException("Username is too long. Must be less than 15 characters");
                }
                if (value.Length < 5) {
                    throw new ArgumentException("Username is too short. Must be more than 5 characters");
                }
                username = value;
            }
        }
        
        public string Email {
            get => email;
            set => email = value;
        }
        
        // METHODS
        
        public bool CheckPassword(string formPassword) => Password.Equals(formPassword);  
    
        

    // CONSTRUCTORS
        public User() {
           // empty constructor 
        }
        
        public User(string username, string email, string password) {
            Username = username;
            Email = email;
            Password = password;
        }
        
    }
}