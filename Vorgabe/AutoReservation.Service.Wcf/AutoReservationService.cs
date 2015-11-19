using AutoReservation.Common.Interfaces;
using System;
using System.Diagnostics;
using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using AutoReservation.Dal;

namespace AutoReservation.Service.Wcf
{
    public class AutoReservationService : IAutoReservationService
    {

        private static void WriteActualMethod()
        {
            Console.WriteLine("Calling: " + new StackTrace().GetFrame(1).GetMethod().Name);
        }

        public void deleteAuto(AutoDto entity)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {

            }
            throw new NotImplementedException();
        }

        public void deleteKunde(KundeDto entity)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void deleteReservation(ReservationDto entity)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public List<AutoDto> findAllAutos()
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public List<KundeDto> findAllKunden()
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public List<ReservationDto> findAllReservationen()
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public AutoDto findAuto(int key)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public KundeDto findKunde(int key)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public ReservationDto findReservation(int key)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void insertAuto(AutoDto entity)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void insertKunde(KundeDto entity)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void insertReservation(ReservationDto entity)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void updateAuto(AutoDto modified, AutoDto original)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void updateKunde(KundeDto modified, KundeDto original)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }

        public void updateReservation(ReservationDto modified, ReservationDto original)
        {
            WriteActualMethod();
            throw new NotImplementedException();
        }
    }
}