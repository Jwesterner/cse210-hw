using System.Collections.Generic;
using System;

namespace Foundation2 {

    public class Order {
        private Customer _customer;
        private List<Product> _products;

        public Order(Customer customer, List<Product> products) {
            _customer = customer;
            _products = products;
        }

        public double CalculatePrice() {
            double sum = 0;
            foreach (Product product in _products) {
                sum += product.GetPrice();
            }
            if (_customer.InUSA()) {
                sum += 5;
            } else {sum += 35;}
            sum = Math.Round(sum, 2);
            return sum;

        }

        public string GetPackingLabel() {
            string label = $"{_customer.GetName()}";
            foreach (Product product in _products) {
                label += $"\n{product.GetQuantity()} x {product.GetProductId()}";
            }
            return label;
        }

        public string GetShippingLabel() {
            return $"{_customer.GetName()}\n{_customer.GetAddress()}";
        }
    }
}