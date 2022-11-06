using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    internal class MyProperties
    {
        string date = null;
        public string Date { private get => date; set => date = value.ToLower(); }
        public DateTime RecorderAt { private get; set; }

        public string Num { private get; set; } = null;

        public string To { private get; set; } = null;

        public string From { private get; set; } = null;

        private decimal total;
        public decimal Total { private get => total; set => total = value; }

        public string strokeeeperSurname { private get; set; } = null;

        public string forwarderSurname { private get; set; } = null;

        public override string ToString() =>
            $"Data: {Date}\n" +
            $"Recorder: {RecorderAt: M/d/yyyy}\n" +
            $"Num: {Num}\n" +
            $"To: {To}\n" +
            $"From: {From}\n" +
            $"Total: {Total}\n" +
            $"strokeeperSurname: {strokeeeperSurname}\n" +
            $"forwarderSurname: {forwarderSurname} \n";
    }
}
