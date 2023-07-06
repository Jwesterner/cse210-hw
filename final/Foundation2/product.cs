namespace Foundation2 {

    public class Product {
        
        private string _name;
        private int _productId;
        private double _price;
        private int _quantity;

        public Product(string name, int productId, double price, int quantity) {
            _name = name;
            _productId = productId;
            _price = price * quantity;
            _quantity = quantity;
        }

        public int GetProductId() {
            return _productId;
        }

        public int GetQuantity() {
            return _quantity;
        }

        public double GetPrice() {
            return _price;
        }
    }
}