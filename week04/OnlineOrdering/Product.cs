public class Product
{
    private string _name;
    private int _productId;
    private float _productPrice;
    private int _quantity;

    public Product(string name, int productId, float productPrice, int quantity)
    {
        _name = name;
        _productId = productId;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public float GetTotalCost()
    {
        return _productPrice * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }
}