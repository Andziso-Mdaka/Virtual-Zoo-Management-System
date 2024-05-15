using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Zoo_Management
{
    public class InvalidDietException : Exception
    {
        public InvalidDietException(string message) : base(message)
        {
        }
    }

    public class AnimalNotFoundException : Exception
    {
        public AnimalNotFoundException(string message) : base(message)
        {
        }
    }

    public class IncompatibleHabitatException : Exception
    {
        public IncompatibleHabitatException(string message) : base(message)
        {
        }
    }

    public class InvalidAnimalAgeException : Exception
    {
        public InvalidAnimalAgeException(string message) : base(message)
        {
        }
    }
    internal class CustomExceptions
    {
    }
}
