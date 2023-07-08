// Giao diện chung cho tất cả các strategy
interface PaymentStrategy {
  processPayment(amount: number): boolean;
}

// Strategy cho thanh toán qua thẻ tín dụng
class CreditCardPaymentStrategy implements PaymentStrategy {
  processPayment(amount: number): boolean {
    // Xử lý thanh toán qua thẻ tín dụng
    // ...
    console.log(`Processing credit card payment of amount ${amount}`);
    return true;
  }
}

// Strategy cho thanh toán qua PayPal
class PayPalPaymentStrategy implements PaymentStrategy {
  processPayment(amount: number): boolean {
    // Xử lý thanh toán qua PayPal
    // ...
    console.log(`Processing PayPal payment of amount ${amount}`);
    return true;
  }
}

// Strategy cho thanh toán qua ví điện tử
class EwalletPaymentStrategy implements PaymentStrategy {
  processPayment(amount: number): boolean {
    // Xử lý thanh toán qua ví điện tử
    // ...
    console.log(`Processing e-wallet payment of amount ${amount}`);
    return true;
  }
}

export {
  PaymentStrategy,
  CreditCardPaymentStrategy,
  PayPalPaymentStrategy,
  EwalletPaymentStrategy,
};
