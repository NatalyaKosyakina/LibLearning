namespace LibLearning
{
    public interface IMessageSource<T>
    {
        void Send(ChatMessage message, T toAddr);
        ChatMessage Receive(ref T fromAddr);
        public T CreateNewT();

        public T CopyT(T t);
    }
}
