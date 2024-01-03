﻿namespace StockApp.DTO
{
    public class SellOrderRequestDTO
    {
        public string StockSymbol { get; set; }

        public string StockName { get; set; }

        public DateTime DateAndTimeOfOrder { get; set; }

        public uint Quantity { get; set; }

        public double Price { get; set; }
    }
}
