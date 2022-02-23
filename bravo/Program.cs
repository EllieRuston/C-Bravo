using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bravo
{
    class Program
    {
        static List<string> records = new List<string>();
        static void Main(string[] args)
        {
            int Option;
            Console.WriteLine(" ========== Employee Information ========== \n ");

            do
            {
                // User options
                Console.WriteLine(" Please chose from the following options \n");
                Console.WriteLine("  1 - Add Information");
                Console.WriteLine("  2 - Insert Information");
                Console.WriteLine("  3 - Update Information");
                Console.WriteLine("  4 - Delete Information");
                Console.WriteLine("  5 - Search Information");
                Console.WriteLine("  6 - Display Information");
                Console.WriteLine("  0 - Exit");
                
             Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        Console.WriteLine("  Add New Employee Information");
                        AddRecord();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine(" \n Insert New Employee Information");
                        PrintRecord();  
                        InsertRecord();
                        PrintRecord();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("\n Update Employee Information");
                        UpdateRecord();
                        PrintRecord();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine(" \n Delete Employee Information");
                        PrintRecord();
                        DeleteRecord();
                        PrintRecord();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("\n Search for Employee");
                        SearchRecord();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.WriteLine( "\n Display All Employee Information");
                        PrintRecord();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                   
                        // option 0
                    default:
                        Console.WriteLine("\n Exiting Software, \n Bye");
                        Console.ReadKey();
                        break;
                }
            } while (Option != 0);
        }
        // option 1 add new record
        static void AddRecord()
        {
            Console.WriteLine("\n Enter First Name");
                string firstName = Console.ReadLine();
            Console.WriteLine("\n Enter Last Name");
                string lastName = Console.ReadLine();
            records.Add(firstName+" " + lastName);
            Console.WriteLine("\n"+firstName + " " + lastName + " " + "is has been added to Current Employee Records");
          }
        
        // insert new record in specific location
        static void InsertRecord()
        {
            Console.WriteLine("\n Enter First Name");
                 string firstName = Console.ReadLine();
            Console.WriteLine("\n Enter Last Name");
                  string lastName = Console.ReadLine();
            Console.WriteLine("\n Enter desired location");
                int p =Convert.ToInt32(Console.ReadLine());

          // loop to avoid invalid location numbers
            if (p > records.Count)
                 {
                        Console.WriteLine("location is out of range");
                   }
            else
                  {
                        Console.WriteLine(firstName + " " + lastName + " " + "has been added in location " + p);
                        records.Insert(p, firstName +" "+ lastName);
                }
          }
       // Update recoreds - print list, delete records, insert new record in same location.
        static void UpdateRecord()
        {
            int p;
            PrintRecord() ;

         //DeleteRecord - modified from orginal function
            Console.WriteLine(" \n Select Record to Update:");
                p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Updating records from position " + p);
              records.RemoveAt(p);
            Console.WriteLine("\n Enter New details");
           
         //InsertRecord - modified from original function
                Console.WriteLine("Enter First Name");
                    string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                    string lastName = Console.ReadLine();
          
                records.Insert(p, firstName +" "+ lastName);
                Console.WriteLine("Employee Records Upated");
            }

        // Print out all employee records
        static void PrintRecord()
        {
            Console.WriteLine("\n Current Employee Records");
            int p = 0;
           
            foreach (string k in records)
            {
                Console.Write(" Location {0}: ", p);
                Console.WriteLine(" "+k);
                p++;
            }
         }
        
        // delete employee from records
        static void DeleteRecord()
        {
            int p = 0;
            
            Console.WriteLine(" \nEnter Location number to Delete:");
            p= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deleting records from location " + p);
            records.RemoveAt(p); 
          }
       
        //Search records for employee - will return location  of employee
        static void SearchRecord()
        {
            Console.WriteLine("Employee Search");
            Console.WriteLine("Enter Name:");
            string name =(Console.ReadLine());
           
            if (records.Contains(name))
                {
                Console.WriteLine("\n Employee Records Found at location No.  " + records.IndexOf(name));
                }
            else
                {
                Console.WriteLine("This Employee cannot be found, \n Print records for reference");
                }
         }

        

    }
   }

