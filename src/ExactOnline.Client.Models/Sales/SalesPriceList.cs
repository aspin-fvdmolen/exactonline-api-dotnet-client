namespace ExactOnline.Client.Models.Sales
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SalesPriceList
    {
        /// <summary>
        /// Primary key. Price list ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// Price list code
        /// </summary>
        public string Code { get; set; }
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
        /// Price list description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Division code
        /// </summary>
        public int? Division { get; set; }
        /// <summary>
        /// Indicates the entity (1 - Item, 2 - Item group) on which this price list is based
        /// </summary>
        public short Entity { get; set; }
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
        /// Explanation or extra information can be stored in the notes
        /// </summary>
        public string Notes { get; set; }
    }
}