namespace ChainOfResponsability
{
    public abstract class Handler
    {
        protected Handler _successor;

        public Handler SetSuccessor(Handler successor)
        {
            _successor = successor;
            return _successor;
        }

        public abstract void HandleRequest(int request);

    }
}
