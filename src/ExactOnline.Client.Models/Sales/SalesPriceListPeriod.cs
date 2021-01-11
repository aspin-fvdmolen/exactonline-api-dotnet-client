namespace ExactOnline.Client.Models.Sales
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SalesPriceListPeriod
    {
        /// <summary>
        /// Primary key. Price list period ID 
        /// </summary>
        public Guid ID { get; set; }
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
        /// All prices in the price list are stored in this currency
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// Division code
        /// </summary>
        public int? Division { get; set; }
        /// <summary>
        /// Date when the price list should become inactive
        /// </summary>
        public DateTime? EndDate { get; set; }
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
        /// Price list ID
        /// </summary>
        public Guid? PriceList { get; set; }
        /// <summary>
        /// Date for the price list start activate
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Indicate the type of price list : 1-Basic, 2-Special offer
        /// </summary>
        public short? Type { get; set; }
    }
}