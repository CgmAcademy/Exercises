using static PrelievoBancario.InterfaceVersion;

namespace PrelievoBancario
{
    public interface ICircuito : ICircuitoInternazionale
    {
        public void Deposit( decimal amount);
        public void CheckConto();
    }
}
