namespace dj.model
{
    public class Tran : GenderData
    {
            Guid id;
        public Tran()
        {
            id= Guid.NewGuid();
        }
        public Guid LoadData()
        {
            return id;
        }
    }
}
