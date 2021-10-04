using SimpleGame.Actions;
using SimpleGame.Input;
using System;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputDevice _keyboard = new Keyboard();
            IAction _heroMovement = new HeroMovement();
            IAction _Inventory = new Inventory();

            _keyboard.Attach(_heroMovement);
            _keyboard.Notify(Keys.W);
            _keyboard.Notify(Keys.S);
            _keyboard.Notify(Keys.A);
            _keyboard.Notify(Keys.E);
            _keyboard.Detach(_heroMovement);
            _keyboard.Attach(_Inventory);
            _keyboard.Notify(Keys.W);
            _keyboard.Notify(Keys.E);
            _keyboard.Notify(Keys.E);
        }
    }
}
