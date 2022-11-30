namespace PrelievoBancario
{
    public partial class InterfaceVersion
    {
        public interface ICircuitoInternazionale  //SOLID ---> segregation
        {
            public void WithDraw( decimal amount);
        }
    }
}
