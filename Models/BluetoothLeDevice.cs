namespace TestGoogle.Models
{
    public class BluetoothLeDevice
    {
        public string Id { get; set; }
        public string NameofBeacon { get; set; }
        public int TestNr { get; set; }
        public int Rssi { get; set; }
        public int TxPower { get; set; }
        public string EstimatedDistance { get; set; }
        public bool IsBeacon { get; set; }
        
    }
}