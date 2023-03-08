using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Codes
{
    internal class Player : Character
    {
        
        public Player(int id, string userName, int score) : base(id, userName, score){
            
        }

        protected override void TakeDamage() {
            this.health -= 10;
            if (this.health <= 0)
                setDeath();
        }

        public void doSomethingPlayer() { 
        }
    }
}
