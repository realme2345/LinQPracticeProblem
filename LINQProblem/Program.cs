using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonDetails> list = new List<PersonDetails>();
           // AddPersonToList.AddMultiplePersonDetails();
            AddPersonToList.RetreiveTop3RecordsBasedOnRating(list);
            Console.ReadLine();
        }
    }
}
