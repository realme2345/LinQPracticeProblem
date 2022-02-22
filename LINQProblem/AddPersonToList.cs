﻿using System;
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
            //RetreiveTop3RecordsBasedOnRating(list);
            // RetreiveRecordsBasedOnProduct(list);
            RetreiveRecordsBasedProductCount(list);
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
        /// <summary>
        /// Retrieve top 3 records from the list who’s rating is high using LINQ
        /// </summary>
        /// <param name="list"></param>
        public static void RetreiveTop3RecordsBasedOnRating(List<PersonDetails> list)
        {
            var sortedRatingRes = (from product in list orderby product.Rating descending select product).ToList();
            Console.WriteLine("After Sorting");
            IterateOverProductList(sortedRatingRes);
        }
        /// <summary>
        /// Management - Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 using LINQ
        /// </summary>
        /// <param name="list"></param>
        public static void RetreiveRecordsBasedOnProduct(List<PersonDetails> list)
        {
            var Res =list.Where(p=>p.Rating>3 && (p.ProductId==1 || p.ProductId==4 || p.ProductId==9)).ToList();
            Console.WriteLine("After Sorting");
            IterateOverProductList(Res);
        }
        /// <summary>
        /// Management - Retrieve count of review present for each productID
        /// </summary>
        /// <param name="list"></param>
        public static void RetreiveRecordsBasedProductCount(List<PersonDetails> list)
        {
            var Result = (list.GroupBy(p => p.ProductId).Select(x=> new {productID=x.Key,count=x.Count()})).ToList();
            Console.WriteLine("RetreiveRecordsBasedProductCount");
            foreach(var item in Result)
            {
                Console.WriteLine("ProductId :" + item.productID);
            }
        }
        public static void RetreiveTop5Records(List<PersonDetails> list)
        {
            Console.WriteLine();
            var res=(from num in list select num).Skip(5).ToList();
            IterateOverProductList(res);
        }
    }
}
