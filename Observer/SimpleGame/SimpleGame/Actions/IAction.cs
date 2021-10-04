using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Actions
{
    public interface IAction
    {
       public void OnKeyDown(Keys key);
    }
}
