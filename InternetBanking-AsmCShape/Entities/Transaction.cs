using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace Entities
{
    class Transaction
    {
        private int id;
        private long timeCreated;
        private string fromNumAcc;
        private string toNumAcc;
        private long amount;
        private long timeSuccess;

        public Transaction(string fromNumAcc, string toNumAcc, long amount)
        {
            this.fromNumAcc = fromNumAcc;
            this.toNumAcc = toNumAcc;
            this.amount = amount;
            this.timeCreated = TimeUltility.CurrentEpochMilli;
        }

        public Transaction(int id, long timeCreated, string fromNumAcc, string toNumAcc, long amount, long timeSuccess)
        {
            this.id = id;
            this.timeCreated = timeCreated;
            this.fromNumAcc = fromNumAcc;
            this.toNumAcc = toNumAcc;
            this.amount = amount;
            this.timeSuccess = timeSuccess;
        }

        public int Id { get => id; }
        public long TimeCreated { get => timeCreated; }
        public string FromNumAcc { get => fromNumAcc; }
        public string ToNumAcc { get => toNumAcc; }
        public long Amount { get => amount; }
        public long TimeSuccess { get => timeSuccess; set => timeSuccess = value; }

        public bool isWithdrawTransection()
        {
            if (toNumAcc.Equals(""))
            {
                return true;
            }
            return false;
        }

        public bool isSuccess()
        {
            if (timeSuccess == 0 || timeSuccess <= timeCreated)
            {
                return false;
            }
            return true;
        }
    }
}
