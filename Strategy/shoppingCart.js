"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ShoppingCart = void 0;
var ShoppingCart = /** @class */ (function () {
    function ShoppingCart() {
    }
    ShoppingCart.prototype.setPaymentStrategy = function (paymentStrategy, amount) {
        this.paymentStrategy = paymentStrategy;
        this.totalAmount = amount;
    };
    ShoppingCart.prototype.processOrder = function () {
        // Xử lý các bước khác trong quá trình đặt hàng
        // ...
        // Thực hiện thanh toán
        this.paymentStrategy.processPayment(this.totalAmount);
    };
    return ShoppingCart;
}());
exports.ShoppingCart = ShoppingCart;
