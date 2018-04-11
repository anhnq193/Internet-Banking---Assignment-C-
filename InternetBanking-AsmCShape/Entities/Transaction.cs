using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Transaction
    {
        private int ID;
        private long timeCreated;
        private string fromNumAcc ;
        private string toNumAcc;
        private long amount;
        private long timeSuccess;


        public int ID1 { get => ID; set => ID = value; }
        public long TimeCreated { get => timeCreated; set => timeCreated = value; }
        public string FromNumAcc { get => fromNumAcc; set => fromNumAcc = value; }
        public string ToNumAcc { get => toNumAcc; set => toNumAcc = value; }
        public long Amount { get => amount; set => amount = value; }
        public long TimeSuccess { get => timeSuccess; set => timeSuccess = value; }
       

        static DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        static long ms = (long)(DateTime.UtcNow - epoch).TotalMilliseconds;

        public Transaction()
        {
        }
        

        public Transaction(long timeCreated, string fromNumAcc, string toNumAcc, long amount)
        {
            this.timeCreated = ms;
            this.fromNumAcc = fromNumAcc;
            this.toNumAcc = toNumAcc;
            this.amount = amount;
        }

        public DateTime getTimeCreated() {
            long dateNumber = ms;
            long beginTicks = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
            DateTime dateValue = new DateTime(beginTicks + dateNumber * 10000);

            return dateValue;
        }

        public DateTime getTimeSuccess() {
            long dateNumber = timeSuccess;
            long beginTicks = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
            DateTime dateValue = new DateTime(beginTicks + dateNumber * 10000);

            return dateValue;
        }

        public bool isSuccess() {
            if (timeSuccess == 0)
            {

                return false;

            }
            return true;
        }

        public bool isWithdrawTransection() {
            if (toNumAcc == null)
            {

                return true;

            }
            return false;
        }
    }
}
