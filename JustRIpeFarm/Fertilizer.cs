using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRIpeFarm
{
    //By Miss Asia
    class Fertilizer
    {
        private int stockId;
        private int quantity;
        private string typeOfFertilizer;
        private DateTime purchaseDate;
        private DateTime expiryDate;

        public string Type { get => typeOfFertilizer; set => typeOfFertilizer = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int StockId { get => stockId; set => stockId = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
    }
}
