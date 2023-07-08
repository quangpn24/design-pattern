import { PaymentStrategy } from "./paymentStrategy";

export class ShoppingCart {
  private totalAmount: number;
  private paymentStrategy: PaymentStrategy;

  setPaymentStrategy(paymentStrategy: PaymentStrategy, amount: number) {
    this.paymentStrategy = paymentStrategy;
    this.totalAmount = amount;
  }

  processOrder() {
    // Xử lý các bước khác trong quá trình đặt hàng
    // ...

    // Thực hiện thanh toán
    this.paymentStrategy.processPayment(this.totalAmount);
  }
}
