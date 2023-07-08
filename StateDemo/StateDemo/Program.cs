// See https://aka.ms/new-console-template for more information

using StateDemo;

Order order = new Order();

/*order.confirmOrder();  // Xác nhận đơn hàng
order.ship();     // Vận chuyển đơn hàng
order.deliver();  // Giao hàng cho khách hàng
order.cancelOrder(); // Huy don hang*/

//order.deliver();  // Không thể giao hàng khi đơn hàng đã bị hủy

order.ship();