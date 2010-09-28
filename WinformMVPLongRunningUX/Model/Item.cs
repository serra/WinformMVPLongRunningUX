namespace Serra.Micros.MVP.Model
{
    public class Item
    {
        public int SequenceNumber { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("{0:0000} - {1}", SequenceNumber, Name);
        }
    }
}