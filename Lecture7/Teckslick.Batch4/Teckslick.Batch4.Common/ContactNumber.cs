namespace Teckslick.Batch4.Common
{
    public class ContactNumber
    {
        public int ContactNumberID { get; set; }
        public int CountryCode { get; set; }
        public int NetworkCode { get; set; }
        public int Number { get; set; }
        public ContactNumberType ContactNumberType { get; set; }

        #region Constructors
        public ContactNumber() { }

        public ContactNumber(int cc, int nc, int num, ContactNumberType cnt)
        {
            CountryCode = cc;
            NetworkCode = nc;
            Number = num;
            ContactNumberType = cnt;
        }

        public ContactNumber(int nc, int num) : this(92, nc, num, ContactNumberType.Mobile) { }
            #endregion

            // +92-42-1234567/+92-300-1234567

        }
    }