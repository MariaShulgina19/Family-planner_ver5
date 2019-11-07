using System;
using System.Collections.Generic;
using System.Linq;//Add new features
using System.IO;

namespace Famplan
{
    class Program
    {
        static void Main(string[] args)
        {

            int response, response2;
            DateTime reservationDay2, reservationStartTime2, reservationEndTime2; // 6.11.to check      HOW to add list to classes nor to main programm?
            List<MEMBERS> membersList = new List<MEMBERS>();                        //CHeck how to add only day in  DATE TIME or only time?
            List<ACTIVITIES> activitiesList = new List<ACTIVITIES>(); 
            List<RESERVATION> reservationList = new List<RESERVATION>();
            List<PARENTS> parentsList = new List<PARENTS>();
            List<KIDS> kidsList = new List<KIDS>();

            Console.WriteLine("WELCOME TO FAMILY PLANNER ver 1.1");
            Console.WriteLine();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine();
            Console.WriteLine("1-Add new member");
            Console.WriteLine("2-Add new activity");
            Console.WriteLine("3-Print member list");
            Console.WriteLine("4-Print activity list");
            Console.WriteLine("5-Delite member");
            Console.WriteLine("6-Delite activity");
            Console.WriteLine("7-Search member");
            Console.WriteLine("8-Search activity");
            Console.WriteLine("9-Add new reservation");
            Console.WriteLine("10-Print reservation list");
            Console.WriteLine();
            Console.WriteLine("0-Stop");
            Console.WriteLine();

            do

            {
            Console.WriteLine("Choose number from MAIN MENU");
            


            response = int.Parse(Console.ReadLine());

                switch (response)

                {
                    case 1:

                        Console.WriteLine();
                        Console.WriteLine("20- create NEW PARENT"); // not included to the programm yet
                        Console.WriteLine("21- create NEW KID");   // not included to the programm yet
                        Console.WriteLine("22- create NEW MEMEBER");
                        Console.WriteLine();

                        response2 = int.Parse(Console.ReadLine());


                        switch (response2)

                        {
                            case 20:


                                Console.WriteLine("Add new Parent name:");

                                string parentName = Console.ReadLine();

                                PARENTS newParent = new PARENTS(parentName);
                                newParent.setName(parentName);


                                parentsList.Add(newParent);
                                membersList.Add(newParent);

                                Console.WriteLine($"CONGRATULATION! New member {newParent.GetName()} created.");
                                Console.WriteLine();

                                break;


                            case 21:
                                Console.WriteLine("Add new KIDS name:");

                                string kidName = Console.ReadLine();

                                KIDS newKid = new KIDS(kidName);
                                newKid.setName(kidName);

                                kidsList.Add(newKid);
                                membersList.Add(newKid);

                                Console.WriteLine($"CONGRATULATION! New member {newKid.GetName()} created.");
                                Console.WriteLine();

                                break;

                            case 22:
                                Console.WriteLine("Add new member name:");

                                 string memberName = Console.ReadLine();
                     
                                    /*try
                                    {
                                        memberName = Console.ReadLine();
                                    }

                                    catch (ArgumentException ex)

                                    {
                                        Console.WriteLine(ex.Message);
                        
                                    }
                                    */

                                    MEMBERS newmember = new MEMBERS(memberName);

                                    newmember.setName(memberName);


                                    membersList.Add(newmember);




                                    Console.WriteLine($"CONGRATULATION! New member {newmember.GetName()} created.");
                                 Console.WriteLine();
                                break;

                        }
                        break;



                    case 2:

                                              

                    Console.WriteLine("Add new activity Name:");
                    string activityName = Console.ReadLine();

                    Console.WriteLine("Add new activity Day:");
                    DateTime activityDay = DateTime.Parse(Console.ReadLine()); // how to set format to days

                    Console.WriteLine("Add new activity Start Time:");
                    DateTime activityStartTime = DateTime.Parse(Console.ReadLine());// how to set format to time

                        Console.WriteLine("Add new activity End Time:");
                    DateTime activityEndTime = DateTime.Parse(Console.ReadLine());
                      
                       


                        //Add who is doing

                        ACTIVITIES newActivity = new ACTIVITIES(activityName);

                        newActivity.SetActivityDay(activityDay);
                        newActivity.SetActivityStartTime(activityStartTime);
                        newActivity.SetActivityEndTime(activityEndTime);

                        activitiesList.Add(newActivity);
                    Console.WriteLine();
                    Console.WriteLine($"CONGRATULATION! \nNew activity {newActivity.GetActivityName()} created\nat:{newActivity.GetActivityDay()} \nfrom:{newActivity.GetActivityStartTime()}    till:{newActivity.GetActivityEndTime()}");
                    Console.WriteLine();

                       

                    //day start and end time deleted from parametrs and eded to setters

                        break;

                    case 3: // tulosta
                              

                        foreach (var item in membersList) //NEW
                        {
                            Console.WriteLine(item.GetName() + " ");
                        }
                        Console.WriteLine();
                        break;



                    case 4: // tulosta


                        foreach (var item in activitiesList) //NEW
                        {
                            Console.WriteLine($"{item.GetActivityName()} + at: {item.GetActivityDay()} ");
                        }
                        Console.WriteLine();
                        break;


                    case 7: // Search member 

                        
                        Console.WriteLine("Give member name:");
                        string searchmemberName = Console.ReadLine();


                        foreach (var item in membersList)
                        {
                            if (item.GetName() == searchmemberName)
                            {
                                //founded
                                Console.WriteLine(item.GetName() + " founded!");
                                
                                break;
                            }
                       
                        }
                               
                        

                        break;

                    case 8: // Search activity

                        Console.WriteLine("Give activity name:");
                        string searchActivityName = Console.ReadLine();
                        

                        foreach (var item in activitiesList)
                        {
                            if (item.GetActivityName() == searchActivityName)
                            {
                                //founded
                                Console.WriteLine(item.GetActivityName() + " founded!");
                                Console.WriteLine($" Day: {item.GetActivityDay()} StartTime: {item.GetActivityStartTime()};  EndTime: {item.GetActivityEndTime()};");
                                break;
                            }
                        }
                      
         
                        break;

                    case 9: // add new reservation

                        Console.WriteLine("Add new reservation:"); // to do just to give automaticaly reservation number
                        string newReservname = Console.ReadLine();

                        RESERVATION newResrvation = new RESERVATION(newReservname);
                      

                        Console.WriteLine("Give member name:");
                        string memberName1 = Console.ReadLine();
                        foreach (var item in membersList)
                        {
                            if (item.GetName() == memberName1)
                            {
                                //founded
                                Console.WriteLine(item.GetName() + " founded!");
                              
                                memberName1 = item.GetName();
                                break;
                            }


                        }
                        foreach (var item in kidsList)
                        {
                            if (item.GetName() == memberName1)
                            {
                                //founded
                                Console.WriteLine(item.GetName() + " Member is Kid,  NEED A PARENT WITH!");

                                memberName1 = item.GetName();
                                break;
                            }


                        }



                        Console.WriteLine("Give activity Name:");
                        string activityName2 = Console.ReadLine();
                      
                        
                        foreach (var item in activitiesList)
                        {
                            if (item.GetActivityName() == activityName2)
                            {
                                //founded
                                Console.WriteLine(item.GetActivityName() + " founded!");

                                activityName2 = item.GetActivityName();
                                reservationDay2 = item.GetActivityDay();
                                reservationStartTime2 = item.GetActivityStartTime();
                                reservationEndTime2 = item.GetActivityEndTime();
                                

                                
                                newResrvation.SetReservationMemberName(memberName1);
                                newResrvation.SetReservationActivityName(activityName2);
                                newResrvation.SetReservationDay(reservationDay2);
                                newResrvation.SetReservationStartTime(reservationStartTime2);
                                newResrvation.SetReservationEndTime(reservationEndTime2);
                                
                                reservationList.Add(newResrvation);
                                break;

                            }
                              
                        }

                      
                     

                            Console.WriteLine($"CONGRATULATION! New reservation {newResrvation.GetReservationName()} created." +
                                $" For:{newResrvation.GetReservationMemberName()} - {newResrvation.GetReservationActivityName()} at: {newResrvation.GetReservationDay()} from:{newResrvation.GetReservtionStartTime()} till: {newResrvation.GetReservationEndTime()} ?");
                            Console.WriteLine();


                        break;
                    case 10: // tulosta


                        foreach (var item in reservationList) //NEW
                            {
                                Console.WriteLine($"{item.GetReservationName()}" +
                                     $" For:{item.GetReservationMemberName()} - {item.GetReservationActivityName()} at: {item.GetReservationDay()} from:{item.GetReservtionStartTime()} till: {item.GetReservationEndTime()} ?");
                                Console.WriteLine();
                            }
                            Console.WriteLine();

                        break;
                    case 0:
                    break;
                    default:
                    break;

                       

                }
         
                } while (response > 0);
        }
     }
 }
