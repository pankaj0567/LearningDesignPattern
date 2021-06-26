namespace LearningDesignPattern.DesignPattern.Behavioral.Mediator.Example1
{
    // client
    public class ProgramMediatorExample1
    {
        public void ChatApp()
        {
            var chatRoom = new ChatRoom();

            var pankaj = new Person("Pankaj");
            var sahil = new Person("Sahil");

            chatRoom.Join(pankaj);
            chatRoom.Join(sahil);

            pankaj.Send("hi room");
            sahil.Send("oh, hey pankaj");

            var chirag = new Person("Chirag");
            chatRoom.Join(chirag);
            chirag.Send("hi everyone");

            sahil.PrivateMessage("Chirag", "glad you could join us!");
        }
    }
}
