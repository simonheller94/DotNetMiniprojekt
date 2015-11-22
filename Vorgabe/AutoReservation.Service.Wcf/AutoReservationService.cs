using AutoReservation.Common.Interfaces;
using System;
using System.Diagnostics;
using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using AutoReservation.Dal;
using System.Linq;

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
                var autoToDelete = context.Autos.First(a => a.Id == entity.Id);
                context.Autos.Remove(autoToDelete);

                context.SaveChanges();
            }

            throw new NotImplementedException();
        }

        public void deleteKunde(KundeDto entity)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var kundeToDelete = context.Kunden.First(k => k.Id == entity.Id);
                context.Kunden.Remove(kundeToDelete);

                context.SaveChanges();
            }

            throw new NotImplementedException();
        }

        public void deleteReservation(ReservationDto entity)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var reservationToDelete = context.Reservationen.First(r => r.ReservationNr == entity.ReservationNr);
                context.Reservationen.Remove(reservationToDelete);

                context.SaveChanges();
            }

            throw new NotImplementedException();
        }

        public List<AutoDto> findAllAutos()
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var autoList = context.Autos.ToList();
                var autoDtoList = autoList.ConvertToDtos();

                return autoDtoList;
            }

            throw new NotImplementedException();
        }

        public List<KundeDto> findAllKunden()
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var kundeList = context.Kunden.ToList();
                var kundeDtoList = kundeList.ConvertToDtos();

                return kundeDtoList;
            }

            throw new NotImplementedException();
        }

        public List<ReservationDto> findAllReservationen()
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var reservationList = context.Reservationen.ToList();
                var reservationDtoList = reservationList.ConvertToDtos();

                return reservationDtoList;
            }

            throw new NotImplementedException();
        }

        public AutoDto findAuto(int key)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var auto = context.Autos.First();
                var autoDto = auto.ConvertToDto();

                return autoDto;
            }

            throw new NotImplementedException();
        }

        public KundeDto findKunde(int key)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var kunde = context.Kunden.First();
                var kundeDto = kunde.ConvertToDto();

                return kundeDto;
            }

            throw new NotImplementedException();
        }

        public ReservationDto findReservation(int key)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var reservation = context.Reservationen.First();
                var reservationDto = reservation.ConvertToDto();

                return reservationDto;
            }

            throw new NotImplementedException();
        }

        public void insertAuto(AutoDto entity)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var autoToInsert = context.Autos.First(a => a.Id == entity.Id);
                context.Autos.Add(autoToInsert);

                context.SaveChanges();
            }

            throw new NotImplementedException();
        }

        public void insertKunde(KundeDto entity)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var kundeToInsert = context.Kunden.First(k => k.Id == entity.Id);
                context.Kunden.Add(kundeToInsert);

                context.SaveChanges();
            }

            throw new NotImplementedException();
        }

        public void insertReservation(ReservationDto entity)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var reservationToInsert = context.Reservationen.First(r => r.ReservationNr == entity.ReservationNr);
                context.Reservationen.Add(reservationToInsert);

                context.SaveChanges();
            }

            throw new NotImplementedException();
        }

        public void updateAuto(AutoDto modified, AutoDto original)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var autoOriginal = context.Autos.First(a => a.Id == original.Id);
                var autoModified = context.Autos.First(a => a.Id == modified.Id);
                context.Autos.Attach(autoOriginal);
                context.Entry(autoOriginal).CurrentValues.SetValues(autoModified);

                context.SaveChanges();
            }

            throw new NotImplementedException();
        }

        public void updateKunde(KundeDto modified, KundeDto original)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var kundeOriginal = context.Kunden.First(k => k.Id == original.Id);
                var kundeModified = context.Kunden.First(k => k.Id == modified.Id);
                context.Kunden.Attach(kundeOriginal);
                context.Entry(kundeOriginal).CurrentValues.SetValues(kundeModified);

                context.SaveChanges();
            }
            throw new NotImplementedException();
        }

        public void updateReservation(ReservationDto modified, ReservationDto original)
        {
            WriteActualMethod();

            using (var context = new AutoReservationEntities())
            {
                var reservationOriginal = context.Reservationen.First(r => r.ReservationNr == original.ReservationNr);
                var reservationModified = context.Reservationen.First(r => r.ReservationNr == modified.ReservationNr);
                context.Reservationen.Attach(reservationOriginal);
                context.Entry(reservationOriginal).CurrentValues.SetValues(reservationModified);

                context.SaveChanges();
            }

            throw new NotImplementedException();
        }
    }
}