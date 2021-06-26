using System;
using System.Collections.Generic;

namespace LearningDesignPattern.DesignPattern.Behavioral.Mediator.Example1
{
    public class Person
    {
        public string Name { get; private set; }
        public ChatRoom Room;
        private List<string> chatLog = new List<string>();
        public Person(string name)
        {
            Name = name;
        }

        public void Receive(string sender,string message)
        {
            string s = $"{sender}: '{message}'";
            Console.WriteLine($"[{Name}'s chat session] {s}");
            chatLog.Add(s);
        }

        public void Send(string message)
        {
            Room.Broadcast(Name, message);
        }

        public void PrivateMessage(string who,string message)
        {
            Room.Message(Name, who, message);
        }
    }
}
