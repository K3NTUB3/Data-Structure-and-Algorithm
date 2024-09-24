using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data_Structure_and_Algorithm
{
    internal class LessonOne
    {
        public static void Lesson1()
        {
            User user = new User();
            bool toloop = true;
            Console.WriteLine("EMERGENCY CONTACT LIST\n");
            while (toloop)
            {
                Console.WriteLine("[0] Exit");
                Console.WriteLine("[1] Add Contact");
                Console.WriteLine("[2] Search Contact");
                Console.WriteLine("[3] Edit Contact");
                Console.WriteLine("[4] Remove Contact");

                Console.Write("\nChoose: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number == 0)
                    {
                        toloop = false;
                        Console.WriteLine("\nThank you for your usage!\nPress any key to continue.");
                        Console.ReadKey();
                    }
                    if (number == 1)
                    {
                        Console.Write("Enter Name           : ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Contact Number : ");
                        string contact = Console.ReadLine();

                        Console.Write("Enter Age            : ");
                        string age = Console.ReadLine();

                        user.AddUserDetails(name.ToUpper(), contact, age);
                        Console.WriteLine("\nContact person successfully added. Press any key to continue. \n");
                        Console.ReadKey();
                    }
                    if(number == 2)
                    {
                        Console.Write("\nEnter Name/Contact Number : ");
                        string search = Console.ReadLine();
                        user.SearchIndex(search.ToUpper());
                    }
                    if (number == 3)
                    {
                        user.DisplayAllContacts();
                        Console.Write("\n---------INPUT '-1' TO CANCEL---------");
                        Console.Write("\nEnter the ID of the Contact that you want to edit: ");
                        if (int.TryParse(Console.ReadLine(), out int choice))
                        {
                            if(choice == -1)
                            {
                                Console.WriteLine("\nEdit Contact has been cancelled.\n");
                            }
                            else
                            {
                                user.GetIndexToUpdate(choice);
                            } 
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input. Enter a valid Number\n");
                        }

                    }
                    if (number == 4)
                    {
                        user.DisplayAllContacts();
                        Console.Write("\n---------INPUT '-1' TO CANCEL---------");
                        Console.Write("\nEnter the ID of the Contact that you want to remove: ");

                        if (int.TryParse(Console.ReadLine(), out int choice))
                        {
                            if (choice == -1)
                            {
                                Console.WriteLine("\nRemove Contact has been cancelled.\n");
                            }
                            else
                            {
                                user.RemoveContact(choice);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input. Enter a valid Number\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Input. Please enter a valid Integer.\n");
                }
            }
        }
    }
    class User
    {
        private List<string> fullname;
        private List<string> contact;
        private List<string> age;

        public User()
        {
            fullname = new List<string>();
            contact = new List<string>();
            age = new List<string>();
        }

        public void AddUserDetails(string fullname, string contact, string age)
        {
            this.fullname.Add(fullname);
            this.contact.Add(contact);     
            this.age.Add(age);
        }

        public void GetIndexToUpdate(int input)
        {
            if (input >= 0 && input < contact.Count)
            {
                Console.Write("Enter Contact Number: ");
                string contact = Console.ReadLine();
                Console.Write("Enter Age: ");
                string age = Console.ReadLine();

                UpdateUserDetail(input, contact, age);
            }
            else
            {
                Console.WriteLine("\nInvalid Index.\n");
            }
        }

        public void UpdateUserDetail(int index, string newContact, string newAge)
        {
                contact[index] = newContact;  
                age[index] = newAge;

                Console.WriteLine("\nDetails Successfully Changed!\n");  
        }

        public void RemoveContact(int index)
        {
            if (index >= 0 && index < contact.Count)
            {
                fullname.RemoveAt(index);
                contact.RemoveAt(index);
                age.RemoveAt(index);

                Console.WriteLine("\nContact Removed Successfully!\n");
            }
            else
            {
                Console.WriteLine("\nInvalid Index\n");
            }
        }
        public void SearchIndex(string input)
        {
            int index;

            index = fullname.IndexOf(input);
            if (index != -1)
            {
                DisplaySpecificInfo(index);
                return;
            }

            index = contact.IndexOf(input);
            if (index != -1)
            {
                DisplaySpecificInfo(index);
                return;
            }

            Console.WriteLine("\nThe details you entered does not exist. Please add the contact if it doesn't exist yet.\n");
        }

        public void DisplaySpecificInfo(int index)
        {
            Console.WriteLine("\nUser Found!\n");
            Console.WriteLine("\nName    : " + fullname[index]);
            Console.WriteLine("\nContact : " + contact[index]);
            Console.WriteLine("\nAge     : " + age[index]);
        }

        public void DisplayAllContacts()
        {
            Console.WriteLine("\n------------------ User Information ------------------\n");
            Console.WriteLine("ID\t\tName\t\tContact Number\t\tAge");
            Console.WriteLine("------------------------------------------------------------");
            for (int i = 0; i < fullname.Count; i++) 
            {
                  Console.WriteLine("["+ i + "]\t " + fullname[i] +"\t" + contact[i] + "\t\t" + age[i]);   
            }
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
