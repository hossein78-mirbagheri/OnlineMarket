using OnlineMarket.Models;

namespace OnlineMarket.Services
{
    public class Services
    {
        public class UserService
        {
            public void RegisterUser(Users user) { /* ثبت کاربر */ }
        }

        public class ProductService
        {
            public void AddProduct(Product product) { /* اضافه کردن محصول */ }
            public void StartAuction(Product product, DateTime endDate) { /* شروع مزایده */ }
            public void CloseAuction(Product product) { /* بستن مزایده */ }
        }

        public class TransactionService
        {
            public void PerformTransaction(Product product, Users buyer) { /* انجام معامله */ }
        }
        public class BuyerService
        {
            public void ViewProductsBySeller(Users seller) { /* مشاهده محصولات فروشنده */ }
            public void ViewProductsByCategory(string category) { /* مشاهده محصولات در یک دسته بندی */ }
            public void PurchaseProduct(Product product, Buyer buyer) { /* خرید محصول */ }
            public void PlaceBid(Product product, decimal bidAmount, Buyer buyer) { /* ثبت پیشنهاد در مزایده */ }
            public void GetLatestBidAmount(Product product) { /* دریافت آخرین قیمت ثبت شده در مزایده */ }
            public void LeaveReview(Product product, Buyer buyer, string reviewText) { /* ثبت نظر برای فروشنده */ }
        }
        public class BuyerProfileService
        {
            //public List<Product> GetPurchaseHistory(Buyer buyer) { /* مشاهده تاریخچه خرید */ }
            public void EditUserProfile(Buyer buyer, Users profile) { /* ویرایش پروفایل کاربری */ }
        }
        public class AdminService
        {
            public void ApproveProduct(Product product) { /* تایید کالا توسط ادمین */ }
            public void RejectProduct(Product product) { /* رد کالا توسط ادمین */ }
            public void ApproveReview(Product review) { /* تایید نظر توسط ادمین */ }
            public void RejectReview(Product review) { /* رد نظر توسط ادمین */ }
        }
        public class AdminControlService
        {
            public void DeleteUser(Users user) { /* حذف کاربر توسط ادمین */ }
            public void EditUser(Users user) { /* ویرایش کاربر توسط ادمین */ }
            public void DeleteSeller(Users seller) { /* حذف فروشنده توسط ادمین */ }
            public void EditSeller(Users seller) { /* ویرایش فروشنده توسط ادمین */ }
            public void GetSellerEarnings(Users seller) { /* مشاهده کارمزد‌های دریافتی توسط فروشنده */ }
        }
        public class AdminReportService
        {
            public void GetEarningsFromSellers() { /* مشاهده کارمزد‌های دریافتی از فروشنده‌ها */ }
        }


    }
}
