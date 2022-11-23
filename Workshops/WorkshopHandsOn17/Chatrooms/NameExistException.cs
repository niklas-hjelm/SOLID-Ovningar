using System;

namespace WorkshopHandsOn17.Chatrooms
{
    class NameExistException : ApplicationException
    {
        public NameExistException(string name)
            :base($"Name {name} already exist!")
        { }
    }
}
