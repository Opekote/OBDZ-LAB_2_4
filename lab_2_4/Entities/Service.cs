namespace lab_2_4.Entities
{
    public class Service
    {
        public virtual long ServiceID { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
    }
}