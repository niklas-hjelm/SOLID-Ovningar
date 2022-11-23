using System;

namespace WorkshopHandsOn16.Chatrooms
{
    class NameExistException : ApplicationException
    {
        public NameExistException(string name)
            :base($"Name {name} already exist!")
        { }
    }
}
