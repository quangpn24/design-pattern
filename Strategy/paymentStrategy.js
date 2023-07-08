"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.EwalletPaymentStrategy = exports.PayPalPaymentStrategy = exports.CreditCardPaymentStrategy = void 0;
// Strategy cho thanh toán qua thẻ tín dụng
var CreditCardPaymentStrategy = /** @class */ (function () {
    function CreditCardPaymentStrategy() {
    }
    CreditCardPaymentStrategy.prototype.processPayment = function (amount) {
        // Xử lý thanh toán qua thẻ tín dụng
        // ...
        console.log("Processing credit card payment of amount ".concat(amount));
        return true;
    };
    return CreditCardPaymentStrategy;
}());
exports.CreditCardPaymentStrategy = CreditCardPaymentStrategy;
// Strategy cho thanh toán qua PayPal
var PayPalPaymentStrategy = /** @class */ (function () {
    function PayPalPaymentStrategy() {
    }
    PayPalPaymentStrategy.prototype.processPayment = function (amount) {
        // Xử lý thanh toán qua PayPal
        // ...
        console.log("Processing PayPal payment of amount ".concat(amount));
        return true;
    };
    return PayPalPaymentStrategy;
}());
exports.PayPalPaymentStrategy = PayPalPaymentStrategy;
// Strategy cho thanh toán qua ví điện tử
var EwalletPaymentStrategy = /** @class */ (function () {
    function EwalletPaymentStrategy() {
    }
    EwalletPaymentStrategy.prototype.processPayment = function (amount) {
        // Xử lý thanh toán qua ví điện tử
        // ...
        console.log("Processing e-wallet payment of amount ".concat(amount));
        return true;
    };
    return EwalletPaymentStrategy;
}());
exports.EwalletPaymentStrategy = EwalletPaymentStrategy;
