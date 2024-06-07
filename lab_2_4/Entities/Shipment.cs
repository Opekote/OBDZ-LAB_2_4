namespace lab_2_3.Entities
{
    public class Shipment
    {
        public virtual long ShipmentID { get; set; }
        public virtual string TrackingNumber { get; set; }
        public virtual Customer Sender { get; set; }
        public virtual Customer Recipient { get; set; }
        public virtual decimal Weight { get; set; }
        public virtual string Dimensions { get; set; }
        public virtual DateTime? ShipmentDate { get; set; }
        public virtual DateTime? DeliveryDate { get; set; }
        public virtual string Status { get; set; }
        public virtual string SenderAddress { get; set; }
        public virtual string RecipientAddress { get; set; }
        public virtual IList<Review> Reviews { get; set; }
        public virtual Package Package { get; set; } // Added Package property

        public Shipment()
        {
            Reviews = new List<Review>();
        }
    }
}