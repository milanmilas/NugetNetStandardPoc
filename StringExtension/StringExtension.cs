﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class StringExtension
    {
        public static string ReverseString45(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}
