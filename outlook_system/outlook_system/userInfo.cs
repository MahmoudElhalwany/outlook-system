using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outlook_system
{
    public  class userInfo
    {
        private int id;
        private string name;
        private string mail;
        private DateTime birthday;
        public static userInfo user;
        private userInfo() {
            id = 0;
            name = "";
            mail = "";
            birthday = DateTime.MinValue;
        
        
        }
        public void setId(int id) {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setEmail(string email)
        {
            this.mail = email;
        }
        public void setBirthday(DateTime Birthday)
        {
            this.birthday = Birthday;
        }
        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public string getEmail()
        {
            return this.mail;
        }
        public DateTime getBirthday()
        {
            return this.birthday;
        }


    }
}
