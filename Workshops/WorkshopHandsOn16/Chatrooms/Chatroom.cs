using System;
using System.Collections.Generic;
using WorkshopHandsOn16.Participants;

namespace WorkshopHandsOn16.Chatrooms
{
    class Chatroom : IChatroom
    {
        private IDictionary<string, IParticipant> _participants = new Dictionary<string, IParticipant>();

        public static IChatroom Create()
        {
            return new Chatroom();
        }

        private Chatroom()
        {}

        public void Register(IParticipant participant)
        {
            if (!_participants.ContainsKey(participant.Name))
                _participants.Add(participant.Name, participant);
            else
            {
                throw new NameExistException(participant.Name);
            }
        }

        public void UnRegister(IParticipant participant)
        {
            if (_participants.ContainsKey(participant.Name))
                _participants.Remove(participant.Name);
        }

        public void Send(string from, string to, string message)
        {
            if (_participants.ContainsKey(to) && !from.Equals(to))
                _participants[to].Receive(from, message);
        }
    }
}
