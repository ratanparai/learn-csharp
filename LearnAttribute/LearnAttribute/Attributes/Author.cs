using System;
using System.Collections.Generic;
using System.Text;

namespace LearnAttribute.Attributes
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class AuthorAttribute : System.Attribute
    {
        private string _name;
        public double version;

        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        public AuthorAttribute(string name)
        {
            _name = name;
        }

        public string GetAuthorName()
        {
            return _name;
        }

    }
}
