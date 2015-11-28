using AutoReservation.Common.Interfaces;
using System;
using System.Diagnostics;
using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using System.ServiceModel;
using System.Data.Entity.Infrastructure;

namespace AutoReservation.Service.Wcf
{
    public class AutoReservationService : IAutoReservationService
    {
        #pragma warning disable 0649

        private BusinessLayer.AutoReservationBusinessComponent target = new BusinessLayer.AutoReservationBusinessComponent();

        #pragma warning restore 0649

        private static void WriteActualMethod()
        {
            Console.WriteLine("Calling: " + new StackTrace().GetFrame(1).GetMethod().Name);
        }

        public void deleteAuto(AutoDto entity)
        {
            WriteActualMethod();

            target.deleteAuto(entity.ConvertToEntity());
        }

        public void deleteKunde(KundeDto entity)
        {
            WriteActualMethod();

            target.deleteKunde(entity.ConvertToEntity());
        }

        public void deleteReservation(ReservationDto entity)
        {
            WriteActualMethod();

            target.deleteReservation(entity.ConvertToEntity());
        }

        public List<AutoDto> findAllAutos()
        {
            WriteActualMethod();

            return target.findAllAutos().ConvertToDtos();
        }

        public List<KundeDto> findAllKunden()
        {
            WriteActualMethod();

            return target.findAllKunden().ConvertToDtos();
        }

        public List<ReservationDto> findAllReservationen()
        {
            WriteActualMethod();

            return target.findAllReservationen().ConvertToDtos();
        }

        public AutoDto findAuto(int key)
        {
            WriteActualMethod();

            return target.findAuto(key).ConvertToDto();
        }

        public KundeDto findKunde(int key)
        {
            WriteActualMethod();

            return target.findKunde(key).ConvertToDto();
        }

        public ReservationDto findReservation(int key)
        {
            WriteActualMethod();

            return target.findReservation(key).ConvertToDto();
        }

        public void insertAuto(AutoDto entity)
        {
            WriteActualMethod();

            target.insertAuto(entity.ConvertToEntity());
        }

        public void insertKunde(KundeDto entity)
        {
            WriteActualMethod();

            target.insertKunde(entity.ConvertToEntity());
        }

        public void insertReservation(ReservationDto entity)
        {
            WriteActualMethod();

            target.insertReservation(entity.ConvertToEntity());
        }

        public void updateAuto(AutoDto modified, AutoDto original)
        {
            WriteActualMethod();
            UpdateFault myUpdateFault = new UpdateFault();
            try
            {
                target.updateAuto(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (DbUpdateConcurrencyException upex)
            {
                myUpdateFault.Result = true;
                myUpdateFault.ErrorMessage = "Update couldnt complete";
                myUpdateFault.ErrorDetails = upex.ToString();
                throw new FaultException<UpdateFault>(myUpdateFault, upex.ToString());
            }
        }

        public void updateKunde(KundeDto modified, KundeDto original)
        {
            WriteActualMethod();
            UpdateFault myUpdateFault = new UpdateFault();
            try
            {
                target.updateKunde(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (DbUpdateConcurrencyException upex)
            {
                myUpdateFault.Result = true;
                myUpdateFault.ErrorMessage = "Update couldnt complete";
                myUpdateFault.ErrorDetails = upex.ToString();
                throw new FaultException<UpdateFault>(myUpdateFault, upex.ToString());
            }
}

        public void updateReservation(ReservationDto modified, ReservationDto original)
        {
            WriteActualMethod();
            UpdateFault myUpdateFault = new UpdateFault();
            try
            {
                target.updateReservation(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (DbUpdateConcurrencyException upex)
            {
                myUpdateFault.Result = true;
                myUpdateFault.ErrorMessage = "Update couldnt complete";
                myUpdateFault.ErrorDetails = upex.ToString();
                throw new FaultException<UpdateFault>(myUpdateFault, upex.ToString());
            }
        }
    }
}