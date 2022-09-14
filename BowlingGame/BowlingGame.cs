using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class BowlingGame
    {
        public BowlingGame() 
        {
            
        }

        public int Strike(string strike)
        {
            if(strike == "X") 
            {
                return 10;
            }
            return Convert.ToInt32(strike);
            throw new NotImplementedException();
        }
    }
}
