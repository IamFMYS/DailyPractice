﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class EmployeeId : IEquatable<EmployeeId>
    {
        private readonly char prefix;
        private readonly int number;
        public EmployeeId(string id)
        {
            Contract.Requires<ArgumentNullException>(id != null);
            prefix = (id.ToUpper())[0];
            int numLength = id.Length - 1;
            try
            {
                number = int.Parse(id.Substring(1, numLength > 6 ? 6 : numLength));
            }
            catch (FormatException)
            {

                throw new EmployeeException("Invalid EmployeeId format");
            }
        }
        public override string ToString()
        {
            return prefix.ToString() + string.Format("{0,6:000000}", number);
        }
        public override int GetHashCode()
        {
            return (number ^ number << 16) * 0x15051505;
        }
        public bool Equals(EmployeeId other)
        {
            if (other == null) return false;
            return (prefix == other.prefix && number == other.number);
        }

        public override bool Equals(object obj)
        {
            return Equals((EmployeeId)obj);
        }
        //public static bool operator ==(EmployeeId left, EmployeeId right)
        //{
        //    return left.Equals(right);
        //}
        //public static bool operator !=(EmployeeId left, EmployeeId right)
        //{
        //    return !left.Equals(right);
        //}
    }
    public class EmployeeException : Exception
    {
        public EmployeeException(string message) : base(message) { }
    }
}
