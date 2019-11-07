using System;
using System.Collections.Generic;
using System.Text;

namespace Famplan
{
    class ACTIVITIES
    {


        private string _activityName, _activityPlace;
        private int _activityNameid;
        private DateTime _activityDay, _acticityStartTime, _acticityEndTime;


        static int _amountOfactivity = 1;


        public ACTIVITIES(string activityName) 

        {
           
            _activityName = activityName;
          //  _activityDay = activityDay;
          //  _acticityStartTime = activityStartTime;
           // _acticityEndTime = activityEndTime;

        }
        //getters
        public string GetActivityName()
        {
            return _activityName;
        }

        public DateTime GetActivityDay()
        {
            return _activityDay;
        }

        public DateTime GetActivityStartTime()
        {
            return _acticityStartTime;
        }

        public DateTime GetActivityEndTime()
        {
            return _acticityEndTime;
        }

        //setters
        public void SetActivityDay(DateTime activityDay)
        {
            _activityDay = activityDay;
        }

        public void SetActivityStartTime(DateTime activityStartTime)
        {
            _acticityStartTime = activityStartTime;
        }

        public void SetActivityEndTime(DateTime activityEndTime)
        {
            _acticityEndTime = activityEndTime;
        }


         

    }
}
