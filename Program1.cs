using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp5
{
    class Program
    {
        public interface IOrder
        {
            int Id { get; set; }
            string Name { get; set; }
        }

        public interface IBasket
        {
            int Id { get; set; }
            int OrderId { get; set; }
            long Total { get; set; }
        }

        public interface IPersonService
        {
            IReadOnlyList<IOrder> GetPersonsByThisDay();
        }

        public interface ICalculationService
        {
            long CalculateOrders(IReadOnlyList<IOrder> orders);
        }

    }
}
