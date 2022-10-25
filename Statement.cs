namespace BankAccountKata
{
    public class Statement
    {
        protected bool Equals(Statement other)
        {
            return string.Equals(Date, other.Date) && Amount == other.Amount && Balance == other.Balance;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Statement) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Date.GetHashCode();
                hashCode = (hashCode*397) ^ Amount;
                hashCode = (hashCode*397) ^ Balance;
                return hashCode;
            }
        }

        public string Date { get; set; }
        public int Amount { get; set; }
        public int Balance { get; set; }
    }
}