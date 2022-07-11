using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerationApi
{
    public class Character
    {
        public string gender;
        public string firstName;
        public string lastName;
        public int age;
        public string city;
        public string country;
        public string phone;
        public string email;
        public string username;
        public string password;

        public Character(string gender, string firstName, string lastName, int age, string city, string country, string phone, string email, string username, string password)
        {
            this.gender = gender;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
            this.country = country;
            this.phone = phone;
            this.email = email;
            this.username = username;
            this.password = password;
        }

        public Character()
        {
            gender = null;
            firstName = null;
            lastName = null;
            age = 0;
            city = null;
            country = null;
            phone = null;
            email = null;
            username = null;
            password = null;
        }

        public string generateJson()
        {
            string json = "{" +
                "\"items\":[{" +
                    "\"title\":\"Gender\"," +
                    "\"detail\":\"The character's gender is " + this.gender + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"First Name\"," +
                    "\"detail\":\"The character's first name is " + this.firstName + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"Last Name\"," +
                    "\"detail\":\"The character's last name is " + this.lastName + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"Age\"," +
                    "\"detail\":\"The character's age is " + this.age + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"City\"," +
                    "\"detail\":\"The character's city location is " + this.city + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"Country\"," +
                    "\"detail\":\"The character's country is " + this.country + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"Phone\"," +
                    "\"detail\":\"The character's phone number is " + this.phone + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"Email\"," +
                    "\"detail\":\"The character's email address is " + this.email + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"Username\"," +
                    "\"detail\":\"The character's username is " + this.email + "\"" +
                    "}," +
                    "{" +
                    "\"title\":\"Password\"," +
                    "\"detail\":\"The character's password is " + this.password + "\"" +
                    "}" +
                    "]" +
                "}";

            return json;
        }

    }
}
