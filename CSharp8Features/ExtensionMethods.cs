using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features
{
    public static class ExtensionMethods
    {        
        public static bool IsValid(this Student student)
        {
            return student != null && !string.IsNullOrEmpty(student.FirstName);
        }
    }
}
