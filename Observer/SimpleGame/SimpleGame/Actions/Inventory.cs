using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Actions
{
    class Inventory : IAction
    {
        private bool _isOpen;
        public Inventory()
        {
            _isOpen = false;
        }
        public void OnKeyDown(Keys key)
        {
            if(key==Keys.E)
            {
                _isOpen = !_isOpen;
                Console.WriteLine($"inventory status: {(_isOpen?"openned":"closed")}.");
            }
        }
    }
}
