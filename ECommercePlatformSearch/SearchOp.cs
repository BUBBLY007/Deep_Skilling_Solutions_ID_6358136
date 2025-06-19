public class SearchOp
{
    public static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }
    public static Product BinarySearch(Product[] sortedProducts, int targetId)
    {
        int left = 0;
        int right = sortedProducts.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (sortedProducts[mid].ProductId == targetId)
                return sortedProducts[mid];
                
            if (sortedProducts[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }
}
