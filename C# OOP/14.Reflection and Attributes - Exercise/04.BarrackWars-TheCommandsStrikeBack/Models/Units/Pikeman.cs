namespace _04.BarrackWars_TheCommandsStrikeBack.Models.Units
{
    public class Pikeman : Unit
    {
        private const int DefaultHealth = 30;
        private const int DefaultDamage = 15;

        public Pikeman() 
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
