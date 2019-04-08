namespace DungeonsAndCodeWizards.Contracts
{
    using Characters;

    public interface IAttackable
    {
        void Attack(Character character);
    }
}
