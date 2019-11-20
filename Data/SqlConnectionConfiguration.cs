using System;

namespace WebApplication.Data
{
    public class SqlConnectionConfiguration  
    {  
        public SqlConnectionConfiguration(string value) => Value = value;  
        public string Value { get; }  
    } 

}
