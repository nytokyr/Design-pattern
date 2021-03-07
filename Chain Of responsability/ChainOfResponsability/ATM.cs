using System;

namespace ChainOfResponsability
{
    public class ATM
    {
        Handler _basicControllerHandler = new BasicControllerHandler();
        Handler _20000Handler = new _20_000_Handler();
        Handler _10000Handler = new _10_000_Handler();
        Handler _5000Handler = new _5_000_Handler();
        Handler _endOfRequestHandler = new EndOfRequestHandler();

        public ATM()
        {
            _basicControllerHandler
                .SetSuccessor(_20000Handler)
                .SetSuccessor(_10000Handler)
                .SetSuccessor(_5000Handler)
                .SetSuccessor(_endOfRequestHandler);
        }
        public void RetirerArgent(int montant)
        {
            _basicControllerHandler.HandleRequest(montant);
        }
    }
}
