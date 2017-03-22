using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using SQLLibrary;


namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SQL mySQL = new SQL();

            List<Contact> contacts = mySQL.GetAllContactNames();
            List<Address> addressList = mySQL.GetAddresses();

            Contact myContact = mySQL.GetContact("2");

            Console.WriteLine(myContact);
                        

            //foreach (var contact in contacts)
            //{
            //    //foreach (var address in addressList)
            //    //{
            //        if (contact.ID == id)
            //        {
            //            Console.WriteLine(contact.ToString());
            //            //Console.WriteLine(address.Street + " " + address.City);
            //        }

            //    //}

            //}






            //List<Contact> updatedContacts = new List<Contact>();

            //updatedContacts = mySQL.UpdateContact(11, "Hilda", "Ek");

            //contacts = mySQL.GetAllContactNames();

            //List<Contact> foundContacts = mySQL.FindContactIdByName("l", "");

            //foreach (var contact in foundContacts)
            //{
            //    Console.WriteLine(contact.ToString());
            //}

            //int AID = mySQL.AddAddress(8,"Kransbindarvägen 21", "Hägersten");

            //Console.WriteLine($"CTA id är {AID}");

        }
    }
}
