import { ShoppingCart } from "./shoppingCart";
import {
  CreditCardPaymentStrategy,
  PayPalPaymentStrategy,
  EwalletPaymentStrategy,
} from "./paymentStrategy";

const cart = new ShoppingCart();

cart.setPaymentStrategy(new CreditCardPaymentStrategy(), 1000); // Chọn phương thức thanh toán qua thẻ tín dụng
cart.processOrder(); // Thực hiện thanh toán qua thẻ tín dụng

cart.setPaymentStrategy(new PayPalPaymentStrategy(), 2000); // Chọn phương thức thanh toán qua PayPal
cart.processOrder(); // Thực hiện thanh toán qua PayPal

cart.setPaymentStrategy(new EwalletPaymentStrategy(), 5000); // Chọn phương thức thanh toán qua ví điện tử
cart.processOrder(); // Thực hiện thanh toán qua ví điện tử
