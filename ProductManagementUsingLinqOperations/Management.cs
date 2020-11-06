using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductManagementUsingLinqOperations
{
    public class Management
    {
        public readonly DataTable table = new DataTable();

        public void GetTopRecords(List<ProductReview> productReviews)
        {
            var records = (from reviews in productReviews orderby reviews.Rating descending select reviews).Take(3);
            Console.WriteLine("\nTop 3 Records : ");
            foreach (var list in records)
            {
                Console.WriteLine("Product ID: " + list.ProductID + "\tUser ID: " + list.UserID + "\tRating: " + list.Rating + "\tReview: " + list.Review + "\tIsLike: " + list.IsLike);
            }
        }

        public void GetSelectedRecords(List<ProductReview> productReviews)
        {
            var records = from products in productReviews
                          where (products.ProductID == 1 || products.ProductID == 4 || products.ProductID == 9) && products.Rating > 3
                          select products;
            foreach (var list in records)
            {
                Console.WriteLine("Product ID: " + list.ProductID + "\tUser ID: " + list.UserID + "\tRating: " + list.Rating + "\tReview: " + list.Review + "\tIsLike: " + list.IsLike);
            }
        }
    }
}
