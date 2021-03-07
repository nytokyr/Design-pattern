using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class EndOfRequestHandler : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 0)
                throw new InvalidOperationException($"{request} not handled");
        }
    }
}
