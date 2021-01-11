namespace ExactOnline.Client.Models.Sales
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SalesPriceListLinkedAccount
    {
        /// <summary>
        /// Primary key. Customer account ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// Customer account code, fixed length numeric string with leading spaces, length 18. IMPORTANT: When you use OData $filter on this field you have to make sure the filter parameter contains the leading spaces
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
        /// Division code
        /// </summary>
        public int? Division { get; set; }
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
        /// Customer account name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price list ID
        /// </summary>
        public Guid? PriceList { get; set; }
    }
}