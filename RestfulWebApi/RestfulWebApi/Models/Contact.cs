using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulWebApi.Models
{
    public class Contact
    {
        private int id;
        private string name;
        //@todo: need to doing some research on camel case name translation
        private string aVeryLongName;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string AVeryLongName { get { return aVeryLongName; } set { aVeryLongName = value; } }
    }
}