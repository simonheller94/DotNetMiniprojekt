using AutoReservation.Common.Interfaces;
using AutoReservation.Service.Wcf;
using Moq;

namespace AutoReservation.Ui.Factory
{
    public class NullServiceFactory : IServiceFactory
    {
        public IAutoReservationService GetService()
        {

            return new Mock<IAutoReservationService>().Object;
        }
    }
}
