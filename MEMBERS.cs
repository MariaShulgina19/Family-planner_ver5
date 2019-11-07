using System;
using System.Collections.Generic;
using System.Text;

namespace Famplan
{
    class MEMBERS 
    {

        private string _memberName;
        private int _id;
      

        static int _amountOfmembers = 1;

      //  List<string> membersList1 = new List<string>(); // how to add list here? 
       // List<MEMBERS> membersList2 = new List<MEMBERS>();// how to add list here? 

        public MEMBERS(string memberName)

        {
            _memberName = memberName;
            _id = _amountOfmembers;
            _amountOfmembers++;

            //membersList1.Add(_memberName);
        }

       
        public string GetName()
        {
            return _memberName;
           
        }

        public void setName(string nameSetter)              //ADD checking if same name already exixts
        {
           /* foreach (var item in membersList1)
            {

                if (!nameSetter.Equals(item)) // can be checked if given name exists
                  {
                    throw new ArgumentException("Name already exixts!");
                  }

            }
            */
           
            
            _memberName = nameSetter;   
           
         }

        }
  

}
