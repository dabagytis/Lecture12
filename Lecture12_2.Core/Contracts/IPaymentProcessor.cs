namespace Lecture12_2.Core.Contracts
{
    public interface IPaymentProcessor
    {
        public void ProcessPayment(decimal amount);
    }
}
