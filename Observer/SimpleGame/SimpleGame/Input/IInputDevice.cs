using SimpleGame.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Input
{
    public interface IInputDevice
    {
        void Attach(IAction action);
        void Detach(IAction action);
        void Notify(Keys key);
    }
}
