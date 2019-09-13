using System;

namespace TestGoogle.Models
{
    public class BluetoothLeDevice
    {
        public string Id { get; set; }
        public string NameofBeacon { get; set; }
        public int TestNr { get; set; }
        public double Rssi { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public int TxPower { get; set; }
        
        public double X { get; set; }
        public double Y { get; set; }
        public double EstimatedDistance { get; set; }
        public bool IsBeacon { get; set; }
        
    }
}