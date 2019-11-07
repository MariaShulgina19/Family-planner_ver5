using System;
using System.Collections.Generic;
using System.Text;

namespace Famplan
{
    class RESERVATION // : ACTIVITIES
    {

        private string _reservationName;
       // private int _reservationId;
        private DateTime _reservationDay, _reservationStartTime, _reservationEndTime;
        private string _reservationMemberName;
        private string _reservationActivityName;


        //static int _amountOfReservations = 1;


        public RESERVATION(string reservationName)


        {

            _reservationName = reservationName;
           
           // _reservationId = reservationId;
           // _reservationDay = reservationDay;
           // _reservationStartTime = reservationStartTime;
           // _reservationEndTime = reservationEndTime;
            
          //   _reservationMemberName = reservationMemberName;

        }

        //getters
        public string GetReservationName()
        {
            return _reservationName;
        }

        public DateTime GetReservationDay()
        {
            return _reservationDay;
        }

        public DateTime GetReservtionStartTime()
        {
            return _reservationStartTime;
        }

        public DateTime GetReservationEndTime()
        {
            return _reservationEndTime;

        }

        public string GetReservationMemberName()
        {
            return _reservationMemberName;
        }

        public string GetReservationActivityName()
        {
            return _reservationActivityName;
        }

        //setters
        public void SetReservationDay(DateTime reservationDay)
        {
            _reservationDay = reservationDay;
        }

        public void SetReservationStartTime(DateTime reservationStartTime)
        {
            _reservationStartTime = reservationStartTime;
        }

        public void SetReservationEndTime(DateTime reservationEndTime)
        {
            _reservationEndTime = reservationEndTime;
        }

        public void SetReservationMemberName(string reservationMemberName)
        {
            _reservationMemberName = reservationMemberName;
        }

        public void SetReservationActivityName(string reservationActivityName)
        {
            _reservationActivityName = reservationActivityName;
        }
      
    }
}
