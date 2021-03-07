using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class BasicControllerHandler : Handler
    {
        public override void HandleRequest(int request)
        {

            if (_successor is object)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
