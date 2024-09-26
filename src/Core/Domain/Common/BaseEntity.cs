namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public string Id { get; set;}

        public string Title { get; set;}

        public string Code { get; set;}

        public int Timestamp  { get; set;}

        public BaseEntity()
        {
            Id =  Guid.NewGuid().ToString("N");

            Timestamp = 1;
        }
    }
}