using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginsys
{
    
    internal class demo
    {
     
        static char hour;
        static string reason;

       
        
        public string heading()
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string timingg = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("\n\n\t\t\t\tEmployee LoginSystem\t\t\tDate:" + date + "\n" + "\t\t\t\t\t\t\t\t\t" + DateTime.Now.ToString("h:mm:ss tt"));
            return timingg;
        }
        public String Name()
        {
            string name;
            Console.Write("\n\nEnter Your Name:");
            name = Console.ReadLine();
            for (int i = 0; i <= name.Length - 1; i++)
            {
                if (name[i] < 65 || name[i] > 123)
                {
                    Console.Write("\n\t\t<<<Invalid format!Please Enter your name>>>");
                    Console.Write("\n\nEnter Your Name:");
                    name = Console.ReadLine();
                }
            }
            return name;
        }
        public String timing()
        {
            string times = DateTime.Now.ToString("t");
           
            for(int j=0;j<times.Length;j++)
            {
                hour = times[1];
                break;  
            }
            int hours = (int)Char.GetNumericValue(hour);
            if (hours > 10||hours<6)
            {

                Console.Write("\n\t\t\t(Office Timing:9.00 Am - 6.00 Pm) Please Login Before 10.00 Am");              
                Console.Write("\n\nKindly Provide the Reason for Delay:");
                reason = Console.ReadLine();
                while(reason.Length==0)
                {
                    Console.Write("\n\t\t\t<<<Required Information*>>>");
                    Console.Write("\n\nKindly Provide the Reason for Delay:");
                    reason = Console.ReadLine();
                }
            }
            Console.Write("\n\n\t\t\tThank You :) Your Data Registered Successfully");
            return reason;
            
        }
        
    }
    }
