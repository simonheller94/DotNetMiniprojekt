using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace AutoReservation.Common.Interfaces
{
    [ServiceContract]
    public interface IAutoReservationService
    {
        [OperationContract]
        List<AutoDto> findAllAutos();

        [OperationContract]
        AutoDto findAuto(int key);

        [OperationContract]
        void insertAuto(AutoDto entity);

        [OperationContract]
        [FaultContract(typeof(UpdateFault))]
        void updateAuto(AutoDto modified, AutoDto original);

        [OperationContract]
        void deleteAuto(AutoDto entity);


        [OperationContract]
        List<KundeDto> findAllKunden();

        [OperationContract]
        KundeDto findKunde(int key);

        [OperationContract]
        void insertKunde(KundeDto entity);

        [OperationContract]
        [FaultContract(typeof(UpdateFault))]
        void updateKunde(KundeDto modified, KundeDto original);

        [OperationContract]
        void deleteKunde(KundeDto entity);


        [OperationContract]
        List<ReservationDto> findAllReservationen();
    
        [OperationContract]
        ReservationDto findReservation(int key);

        [OperationContract]
        void insertReservation(ReservationDto entity);

        [OperationContract]
        [FaultContract(typeof(UpdateFault))]
        void updateReservation(ReservationDto modified, ReservationDto original);

        [OperationContract]
        void deleteReservation(ReservationDto entity);

    }

    [DataContract]
    public class UpdateFault
    {
        [DataMember]
        public bool Result { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string ErrorDetails { get; set; }


    }
}
