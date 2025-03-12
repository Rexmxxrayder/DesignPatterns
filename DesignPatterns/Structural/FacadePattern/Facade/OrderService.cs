using System;

namespace DesignPatterns.Structural.FacadePattern;

public class OrderService
{
    public void Order(OrderRequest orderRequest)
    {
        var auth = new Authentificate();

        var inventory = new Inventory();
        foreach (var id in orderRequest.ItemsIds)
        {
            inventory.CheckInventory(id);
        }

        var payment = new Payment(orderRequest.Name, orderRequest.CardNumber, orderRequest.Amount);
        payment.Pay();

        var OrderFulfillment = new OrderFulfillment(inventory);
        OrderFulfillment.Fullfill(orderRequest.Name, orderRequest.Address, orderRequest.ItemsIds);
    }
}
