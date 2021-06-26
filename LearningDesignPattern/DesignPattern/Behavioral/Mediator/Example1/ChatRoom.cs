using System.Collections.Generic;
using System.Linq;

namespace LearningDesignPattern.DesignPattern.Behavioral.Mediator.Example1
{
    public class ChatRoom
    {
        private readonly List<Person> people = new List<Person>();

        public void Broadcast(string source,string message)
        {
            foreach (var p in people)
                if (p.Name != source)
                    p.Receive(source, message);
        }

        public void Join(Person person)
        {
            var joinMsg = $"{person.Name} joins the chat";
            Broadcast("room", joinMsg);

            person.Room = this;
            people.Add(person);
        }

        public void Message(string source, string destination,string message)
        {
            people.FirstOrDefault(p => p.Name == destination)
                  ?.Receive(source, message);
        }

    }
}