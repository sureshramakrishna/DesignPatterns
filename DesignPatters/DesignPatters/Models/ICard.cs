namespace DesignPatters.Models
{
    public interface ICard
    {
        string GetCardType();
        int GetLimit();
        int GetAnnualCharge();
    }
}
