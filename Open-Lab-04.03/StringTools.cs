﻿using System;
using System.Runtime;
using System.Linq;
namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original_String)
        {
            if (original_String.Length > 2)
            {
                string result = original_String.Substring(1, original_String.Length - 2);
                return result;
            }
            else if (original_String.Length == 1)
            {
                return original_String; 
            }
            else
            {
                return string.Empty; 
            }


        }
    }
}
