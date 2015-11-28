using AutoReservation.Common.DataTransferObjects;
using AutoReservation.Common.Interfaces;
using AutoReservation.Dal;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace AutoReservation.BusinessLayer
{
    public class AutoReservationBusinessComponent
    {
        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }

        public void deleteAuto(Auto entity)
        {
            
            using (var context = new AutoReservationEntities())
            {
                context.Autos.Remove(entity);

                context.SaveChanges();
            }

        }

        public void deleteKunde(Kunde entity)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunden.Remove(entity);

                context.SaveChanges();
            }

        }

        public void deleteReservation(Reservation entity)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservationen.Remove(entity);

                context.SaveChanges();
            }
        }

        public List<Auto> findAllAutos()
        {
           using (var context = new AutoReservationEntities())
            {
                
                var autoList = context.Autos.ToList();

                return autoList;
            }
        }

        public List<Kunde> findAllKunden()
        {
            using (var context = new AutoReservationEntities())
            {
                var kundeList = context.Kunden.ToList();

                return kundeList;
            }
        }

        public List<Reservation> findAllReservationen()
        {
            using (var context = new AutoReservationEntities())
            {
                var reservationList = context.Reservationen.ToList();

                return reservationList;
            }
        }

        public Auto findAuto(int key)
        {
            using (var context = new AutoReservationEntities())
            {
                var auto = context.Autos.First();

                return auto;
            }
        }

        public Kunde findKunde(int key)
        {
            using (var context = new AutoReservationEntities())
            {
                var kunde = context.Kunden.First();

                return kunde;
            }
        }

        public Reservation findReservation(int key)
        {
            using (var context = new AutoReservationEntities())
            {
                var reservation = context.Reservationen.First();
                
                return reservation;
            }
        }

        public void insertAuto(Auto entity)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Autos.Add(entity);

                context.SaveChanges();
            }
        }

        public void insertKunde(Kunde entity)
        {
           using (var context = new AutoReservationEntities())
            {
                context.Kunden.Add(entity);

                context.SaveChanges();
            }
        }

        public void insertReservation(Reservation entity)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservationen.Add(entity);

                context.SaveChanges();
            }
        }

        public void updateAuto(Auto modified, Auto original)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Autos.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, original);
                }
                
            }
        }

        public void updateKunde(Kunde modified, Kunde original)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunden.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, original);
                }
            }
        }

        public void updateReservation(Reservation modified, Reservation original)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservationen.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException(context, original);
                }
            }
        }



    }
}