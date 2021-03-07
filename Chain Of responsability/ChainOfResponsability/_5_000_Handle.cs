using System;

namespace ChainOfResponsability
{
    public class _5_000_Handler : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 5000)
            {
                Console.WriteLine($"{request / 5000} x 5 000");

                request = request % 5000;
            }

            if (_successor is object)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
