using Microsoft.EntityFrameworkCore;

namespace StockApp
{
    public class StockMarketDbContext : DbContext
    {
        DbSet<BuyOrder> BuyOrders;

        DbSet<SellOrder> SellOrders;
    }
}
