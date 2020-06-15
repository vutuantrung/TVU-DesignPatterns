using State.Demo.Class;
using State.Demo.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Demo.ClassState
{
    public class StateA : DemoState
    {
        public override void HandleA( Record record )
        {
            record.StateType = StateType.A;
            record.HandlerType = HandlerType.A;
        }

        public override void HandleB( Record record )
        {
            record.StateType = StateType.A;
            record.HandlerType = HandlerType.B;
        }
    }
}
