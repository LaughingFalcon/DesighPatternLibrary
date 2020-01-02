using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Bridge
{
    public class AbstractBridge : IAbstractBridge
    {
        public IBridge bridge;

        public AbstractBridge()
        {
        }

        public AbstractBridge(IBridge bridge)
        {
            this.bridge = bridge;
        }

        public void CallMethod1()
        {
            this.bridge.Function1();
        }

        public void CallMethod2()
        {
            this.bridge.Function2();
        }
    }
}
