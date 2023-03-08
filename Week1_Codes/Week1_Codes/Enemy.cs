using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Codes
{
    internal class Enemy : Character
    {
        public Enemy(int id, string userName, int score) : base(id, userName, score)
        {
        }

        protected override void TakeDamage()
        {
            this.health -= 20;
            if (this.health <= 0)
                setDeath();
        }

        public void doSomethingEnemy()
        {
        }
    }
}
