namespace ExactOnline.Client.Models.Sales
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SalesPriceListVolumeDiscount
    {
        /// <summary>
        /// Primary key. Price list ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// ID of the base price. If base price = use the standard sales price, it shows null. If base price = set sales price, it shows ID of the sales price within this volume discount.
        /// </summary>
        public Guid? BasePrice { get; set; }
        /// <summary>
        /// Amount of the base price. If base price = use the standard sales price, it shows the latest item sales price. If base price = set sales price, it shows the base price which defined in price list.
        /// </summary>
        public double? BasePriceAmount { get; set; }
        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// User ID of creator
        /// </summary>
        public Guid? Creator { get; set; }
        /// <summary>
        /// Name of creator
        /// </summary>
        public string CreatorFullName { get; set; }
        /// <summary>
        /// Discount
        /// </summary>
        public double? Discount { get; set; }
        /// <summary>
        /// Division code
        /// </summary>
        public int? Division { get; set; }
        /// <summary>
        /// Indicates whether discount or the new price is leading : 1-Discount, 2-New price.
        /// Scenario
        /// 1. When entry method is Discount and use base price, Discounted price = (1 - SalesPriceListDetails.Discount) * SalesPriceListDetails.BasePriceAmount
        /// 2. When entry method is Discount and use Item's standard sales price, Discounted price = (1 - SalesPriceListDetails.Discount) * SalesItemPrices.Price
        /// 3. When entry method is New price, Discounted price = SalesPriceListDetails.NewPrice
        /// </summary>
        public int? EntryMethod { get; set; }
        /// <summary>
        /// Item ID
        /// </summary>
        public Guid? Item { get; set; }
        /// <summary>
        /// Item code
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// Description of the item
        /// </summary>
        public string ItemDescription { get; set; }
        /// <summary>
        /// Item group ID
        /// </summary>
        public Guid? ItemGroup { get; set; }
        /// <summary>
        /// Item group code
        /// </summary>
        public string ItemGroupCode { get; set; }
        /// <summary>
        /// Item group description
        /// </summary>
        public string ItemGroupDescription { get; set; }
        /// <summary>
        /// Last modified date
        /// </summary>
        public DateTime? Modified { get; set; }
        /// <summary>
        /// User ID of modifier
        /// </summary>
        public Guid? Modifier { get; set; }
        /// <summary>
        /// Name of modifier
        /// </summary>
        public string ModifierFullName { get; set; }
        /// <summary>
        /// New price after discount
        /// </summary>
        public double? NewPrice { get; set; }
        /// <summary>
        /// Number of the item per unit
        /// </summary>
        public double? NumberOfItemsPerUnit { get; set; }
        /// <summary>
        /// Code of the PriceList
        /// </summary>
        public string PriceListCode { get; set; }
        /// <summary>
        /// Description of the PriceList
        /// </summary>
        public string PriceListDescription { get; set; }
        /// <summary>
        /// Price list period ID
        /// </summary>
        public Guid? PriceListPeriod { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        public double? Quantity { get; set; }
        /// <summary>
        /// Default sales unit of the item
        /// </summary>
        public string SalesUnit { get; set; }
        /// <summary>
        /// Unit
        /// </summary>
        public string Unit { get; set; }
    }
}