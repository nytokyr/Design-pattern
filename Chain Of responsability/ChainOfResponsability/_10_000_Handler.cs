using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class _10_000_Handler : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10000)
            {
                Console.WriteLine($"{request / 10000} x 10 000");

                request = request % 10000;
            }

            if (_successor is object)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
