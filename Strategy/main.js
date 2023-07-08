"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var shoppingCart_1 = require("./shoppingCart");
var paymentStrategy_1 = require("./paymentStrategy");
var cart = new shoppingCart_1.ShoppingCart();
cart.setPaymentStrategy(new paymentStrategy_1.CreditCardPaymentStrategy(), 1000); // Chọn phương thức thanh toán qua thẻ tín dụng
cart.processOrder(); // Thực hiện thanh toán qua thẻ tín dụng
cart.setPaymentStrategy(new paymentStrategy_1.PayPalPaymentStrategy(), 2000); // Chọn phương thức thanh toán qua PayPal
cart.processOrder(); // Thực hiện thanh toán qua PayPal
cart.setPaymentStrategy(new paymentStrategy_1.EwalletPaymentStrategy(), 5000); // Chọn phương thức thanh toán qua ví điện tử
cart.processOrder(); // Thực hiện thanh toán qua ví điện tử
