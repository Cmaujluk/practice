using SimpleGame.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Input
{
    class Keyboard : IInputDevice
    {
        List<IAction> _actions = new List<IAction>();
        public void Attach(IAction action)
        {
            _actions.Add(action);
        }

        public void Detach(IAction action)
        {
            _actions.Remove(action);
        }

        public void Notify(Keys key)
        {
           foreach (var action in _actions)
           {
                action.OnKeyDown(key);
           }
        }
    }
}
