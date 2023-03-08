using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Codes
{
     abstract class Character
    {
        public bool isDead { get; set; }
        public int id { get; protected set; }
        public string userName { get; set; }
        public int score { protected set; get; }
        public int health { get; set; } = 100;
        public IGun gun { get; set; }

        public Character(int id, string userName, int score) {
            this.id = id;
            this.userName = userName;
            this.score = score;
        }

        public void MakeScore() {
            score++;
        }

        public void setDeath() {
            if (this.health <= 0)
                this.isDead = true;

        }
        protected abstract void TakeDamage();
    
        public void AttackTo(Character other) {
            this.MakeScore();
            other.TakeDamage();
        }

        public void takeGun(IGun gun) {
            this.gun = gun;
    
        }

        public void removeGun() {
            gun = null;
        }


        public void shoot(Character other) {
            gun.Shoot(other);
        }

        public override string ToString()
        {
            return userName; 
        }

    }
} 