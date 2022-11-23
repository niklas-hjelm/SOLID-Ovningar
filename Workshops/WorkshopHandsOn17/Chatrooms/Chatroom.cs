using System;
using System.Collections.Generic;
using WorkshopHandsOn17.Participants;

namespace WorkshopHandsOn17.Chatrooms
{
    class Chatroom : IChatroom
    {
        private IDictionary<string, IParticipant> _participants = new Dictionary<string, IParticipant>();

        public static IChatroom Create()
        {
            return new Chatroom();
        }

        private Chatroom()
        {
        }

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
            {
                _participants[to].Receive(from, message);
            }
        }

        public void Broadcast(string from, string message)
        {
            foreach (IParticipant p in _participants.Values)
            {
                if (!p.Name.Equals(from))
                    p.Receive(from, message);
            }
        }
    }
}
