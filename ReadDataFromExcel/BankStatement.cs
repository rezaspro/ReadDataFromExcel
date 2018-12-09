using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadDataFromExcel
{
    public class BankStatement
    {
        public string Date { get; set; }
        public string TransactionType { get; set; }
        public string TheirType { get; set; }
        public string Narrative { get; set; }
        public string OurRef { get; set; }
        public string TransRef { get; set; }
        public string Debit { get; set; }
        public string Credit { get; set; }
        public string Balance { get; set; }

    }
}
