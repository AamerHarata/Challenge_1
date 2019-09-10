using Microsoft.AspNetCore.Mvc;
using TestGoogle.Data;
using TestGoogle.Models;

namespace TestGoogle.API
{
    [ApiController]
    public class Challenge_2API : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public Challenge_2API(ApplicationDbContext context)
        {
            _context = context;
        }
        
        

        [Route("/api/GetBluetoothDevices")]
        public IActionResult GetBluetoothDevices(string name, int rssi, int txPower, string dist, bool isBeacon,int testNr)
        {
            var bluetoothDevice = new BluetoothLeDevice()
            {
                NameofBeacon = name, Rssi = rssi, TxPower = txPower, EstimatedDistance = dist,IsBeacon = isBeacon, TestNr = testNr
            };
            _context.Add(bluetoothDevice);
            _context.SaveChanges();
            return Ok();
        }
        
    }
}