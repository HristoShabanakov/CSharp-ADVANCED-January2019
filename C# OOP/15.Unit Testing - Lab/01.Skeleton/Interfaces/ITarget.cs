namespace Skeleton.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public  interface ITarget
    {
        void TakeAttack(int damage);

        bool IsDead();

        int GiveExperience();
    }
}
