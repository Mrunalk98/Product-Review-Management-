using System;
using System.Collections.Generic;
using System.Data;

namespace ProductManagementUsingLinqOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management - Linq Operations!");
            List<ProductReview> reviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1, UserID=1, Rating=5, Review="Good", IsLike=true},
                new ProductReview(){ProductID=2, UserID=1, Rating=4, Review="Good", IsLike=true},
                new ProductReview(){ProductID=3, UserID=2, Rating=5, Review="Good", IsLike=true},
                new ProductReview(){ProductID=4, UserID=2, Rating=4, Review="Good", IsLike=true},
                new ProductReview(){ProductID=5, UserID=3, Rating=2, Review="Nice", IsLike=false},
                new ProductReview(){ProductID=6, UserID=3, Rating=5, Review="Good", IsLike=true},
                new ProductReview(){ProductID=7, UserID=5, Rating=5, Review="Good", IsLike=true},
                new ProductReview(){ProductID=1, UserID=4, Rating=4, Review="Good", IsLike=true},
                new ProductReview(){ProductID=11, UserID=6, Rating=2, Review="Nice", IsLike=false},
                new ProductReview(){ProductID=12, UserID=6, Rating=2, Review="Nice", IsLike=false},
                new ProductReview(){ProductID=13, UserID=8, Rating=4, Review="Good", IsLike=true},
                new ProductReview(){ProductID=14, UserID=7, Rating=5, Review="Good", IsLike=true},
                new ProductReview(){ProductID=15, UserID=9, Rating=1, Review="Bad", IsLike=false},
                new ProductReview(){ProductID=16, UserID=10, Rating=5, Review="Good", IsLike=true}
            };

            foreach (var list in reviewList)
            {
                Console.WriteLine("Product ID: " + list.ProductID + "\tUser ID: " + list.UserID + "\tRating: " + list.Rating + "\tReview: " + list.Review + "\tIsLike: " + list.IsLike);
            }
        }

    }
}
