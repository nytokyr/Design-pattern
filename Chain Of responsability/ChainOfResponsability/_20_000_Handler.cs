using System;

namespace ChainOfResponsability
{
    public class _20_000_Handler : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20000)
            {
                Console.WriteLine($"{request / 20000} x 20 000");

                request = request % 20000;
            }

            if (_successor is object)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
