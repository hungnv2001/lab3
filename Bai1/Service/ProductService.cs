using Bai1.Models;

namespace Bai1.Service
{
    public class ProductService : IProduct
    {
        List<ProductViewModel> productServices;
        public ProductService()
        {

            SeedData();
        }

        private void SeedData()
        {
            productServices = new List<ProductViewModel>
            {
                new ProductViewModel { Id = 1, Name = "Nguyen Van A" },
                new ProductViewModel { Id = 2, Name = "Nguyen Van B" },
                new ProductViewModel { Id = 3, Name = "Nguyen Van C" }
        // Thêm các đối tượng ProductService khác nếu cần
             };
        }



        public List<ProductViewModel> GetALl()
        {
           return productServices;
        }
    }
}
