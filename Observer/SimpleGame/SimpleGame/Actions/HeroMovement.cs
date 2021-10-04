using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Actions
{
    class HeroMovement : IAction
    {
        public void OnKeyDown(Keys key)
        {
            var result = "";
            switch (key)
            {
                case Keys.W:
                    result = "Hero moves up";
                    break;   
                case Keys.S:  
                    result = "Hero moves down";
                    break;   
                case Keys.A:  
                    result = "Hero moves left";
                    break;   
                case Keys.D:  
                    result = "Hero moves right";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
