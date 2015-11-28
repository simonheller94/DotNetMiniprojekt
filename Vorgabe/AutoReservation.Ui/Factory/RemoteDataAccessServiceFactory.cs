using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoReservation.Common.Interfaces;
using AutoReservation.Service.Wcf;
using System.ServiceModel;

namespace AutoReservation.Ui.Factory
{
    class RemoteDataAccessServiceFactory : IServiceFactory
    {
        
        public IAutoReservationService GetService()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress("http://localhost:7876/AutoReservationService");
            ChannelFactory<IAutoReservationService> myChannelFactory = new ChannelFactory<IAutoReservationService>(binding, endpoint);

            IAutoReservationService instance = myChannelFactory.CreateChannel();

            return instance;
        }
    }
}
