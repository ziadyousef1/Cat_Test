namespace Task_4
{
    
        public delegate void EventHandler();

        public class EventManager
        {
            public event EventHandler MyEvent;

            public void AddHandler(EventHandler handler)
            {
                MyEvent += handler;
            }

            public void RemoveHandler(EventHandler handler)
            {
                MyEvent -= handler;
            }

            public void TriggerEvent()
            {
                MyEvent();
            }
        }
    
}