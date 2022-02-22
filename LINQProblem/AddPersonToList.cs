using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblem
{/// <summary>
 /// Product Review Management
    /// </summary>
    internal class AddPersonToList
    {/// <summary>
     /// Create Product review class with ProductID, UserID, Rating, Review and isLike fields
    /// </summary>
        public static List<PersonDetails> list=new List<PersonDetails>(); 
        public static List<PersonDetails> AddMultiplePersonDetails()
        {
            List<PersonDetails> list = new List<PersonDetails>()
            {

                new PersonDetails() { ProductId = 1, UserId = 1, Review = "Good", Rating = 17, IsLike = true },
                new PersonDetails() { ProductId = 2, UserId = 2, Review = "bad", Rating = 10, IsLike = false },
                new PersonDetails() { ProductId = 3, UserId = 3, Review = "good", Rating = 18, IsLike = true },
                new PersonDetails() { ProductId = 4, UserId = 4, Review = "good", Rating = 20, IsLike = true },
                new PersonDetails() { ProductId = 5, UserId = 5, Review = "average", Rating = 13, IsLike = false }
            };
            IterateOverProductList(list);
            return list;
        }
        public static void IterateOverProductList(List<PersonDetails> list)
        {
            try
            {
                foreach (PersonDetails person in list)
                {
                    Console.WriteLine("ProductId:" + person.ProductId + "----" + "User Id:" + person.UserId + "-----" + "Review :" + person.Review + "-----" + "Rating :" + person.Rating + "------" + "IsLike :" + person.IsLike);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
