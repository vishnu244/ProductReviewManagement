using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        
        public static void Top3Records(List<ProductReview> productReviewList)
        {
            

            var ProductData = (from ProductReview in productReviewList orderby ProductReview.Rating descending select ProductReview).Take(3);


            foreach (var list in ProductData)
            {
                Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.isLike);
            }
        }
    }
}
