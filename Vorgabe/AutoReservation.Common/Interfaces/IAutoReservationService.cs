using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;

namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService
    {
        //evtl. mehrere Interfaces (pro DTO eines)

        List<AutoDto> findAllAutos();

        AutoDto findAuto(int key);

        void insertAuto(AutoDto entity);

        void updateAuto(AutoDto modified, AutoDto original);

        void deleteAuto(AutoDto entity);



        List<KundeDto> findAllKunden();

        KundeDto findKunde(int key);

        void insertKunde(KundeDto entity);

        void updateKunde(KundeDto modified, KundeDto original);

        void deleteKunde(KundeDto entity);



        List<ReservationDto> findAllReservationen();
    
        ReservationDto findReservation(int key);

        void insertReservation(ReservationDto entity);

        void updateReservation(ReservationDto modified, ReservationDto original);

        void deleteReservation(ReservationDto entity);

    }
}
