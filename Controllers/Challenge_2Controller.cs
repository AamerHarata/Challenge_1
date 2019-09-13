using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestGoogle.Data;
using TestGoogle.Models;

namespace TestGoogle.Controllers
{
    public class Challenge_2Controller : Controller
    {
        private readonly ApplicationDbContext _context;
        public Challenge_2Controller(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var results = _context.BluetoothLeDevices.OrderBy(x=>x.TestNr).ToList();
            
            return View(results);
        }

        [Route("/Challenge_2/CreateList")]
        public IActionResult CreateList()
        {
            var beacons = new List<Beacon>()
            {
                new Beacon(){Id = 1, MACAdress = "C0:04:9E:17:BE:D9", X = 31.3499981689452, Y = 25.41225, Name = "MiniBeacon_189"},
                new Beacon(){Id = 2, MACAdress = "C0:F9:12:41:5F:A9", X = 24.93, Y = 18.7258495445254, Name = "MiniBeacon_53"},
                new Beacon(){Id = 3, MACAdress = "C1:2E:10:29:F9:13", X = 18.51000183, Y = 11.14394909, Name = "MiniBeacon_79"},
                new Beacon(){Id = 4, MACAdress = "C2:9F:BC:DE:DC:9F", X = 12.87000092, Y = 12.87525, Name = "MiniBeacon_228"},
                
                new Beacon(){Id= 5, MACAdress	= "C3:4E:3E:20:7F:43"	, X = 25.83	, Y= 11.44244909, Name = "MiniBeacon_130"},
                
                
                new Beacon(){Id= 6, MACAdress	= "C6:0B:DB:B2:09:1A", X=12.80999954, Y=	23.08395023	, Name = "MiniBeacon_00136"},
                    new Beacon(){Id= 7	, MACAdress	="C7:AC:35:77:9B:D2", X=18.63, Y=	1.83075	, Name = "MiniBeacon_0069"},
                    new Beacon(){Id=8	, MACAdress	="C8:10:F4:81:53:97", X=45.27000092 , Y=	5.353050911	, Name = "MiniBeacon_00231"},
                    new Beacon(){Id=9	, MACAdress	="C9:43:31:A6:1B:AE", X=48.87000092	 , Y=18.66615046	, Name = "MiniBeacon_00173"},
                        new Beacon(){Id=10, MACAdress	=	"CA:AB:02:07:3E:20", X=37.77000092, Y=	0.696449089	, Name = "MiniBeacon_00220"},
                        new Beacon(){Id=11	, MACAdress	="CC:42:31:8A:84:21", X=38.73, Y=	36.87465003	, Name = "MiniBeacon_00142"},
                        new Beacon(){Id=12, MACAdress	=	"CD:22:2D:53:67:25", X=18.98999908	, Y=25.35254977	, Name = "MiniBeacon_00253"},
                        new Beacon(){Id=13	, MACAdress	="CE:9A:FE:F7:91:C9", X=11.73, Y=	36.51644994	, Name = "MiniBeacon_0015"},
                        new Beacon(){Id=14, MACAdress	=	"D3:8C:81:8D:DF:4D", X=11.90999954	, Y=26.30775	, Name = "MiniBeacon_00230"},
                        new Beacon(){Id=15, MACAdress	=	"D3:E7:FC:EF:69:37", X=7.409999542, Y=	21.88995023	, Name = "MiniBeacon_0052"},
                        new Beacon(){Id=16, MACAdress	=	"D7:6D:FA:46:35:30", X=22.77000092	, Y=36.75525	, Name = "MiniBeacon_00144"},
                        new Beacon(){Id=17	, MACAdress	="D7:A9:3F:4D:E0:65", X=31.04999817, Y=	35.80005006	, Name = "MiniBeacon_00265"},
                        new Beacon(){Id=18, MACAdress	=	"D7:D0:CF:53:AC:7D", X=28.41000183, Y=	1.23375	, Name = "MiniBeacon_00139"},
                        new Beacon(){Id=19, MACAdress	=	"DA:86:F7:AB:4F:84", X=49.64999817, Y=	32.51654977	, Name = "MiniBeacon_00229"},
                        new Beacon(){Id=20, MACAdress	=	"DB:F8:A2:DE:71:72", X=6.389999084	, Y=1.830747723	, Name = "MiniBeacon_0061"},
                        new Beacon(){Id=21	, MACAdress	="DD:30:13:2A:AC:DF", X=36.27000092	, Y=17.65125	, Name = "MiniBeacon_00223"},
                        new Beacon(){Id=22, MACAdress	=	"DD:C1:08:42:A0:A5", X=1.110000687, Y=	36.27765003	, Name = "MiniBeacon_003"},
                        new Beacon(){Id=23, MACAdress	=	"DE:86:6F:2B:75:08", X=13.47000092, Y=	30.30764989	, Name = "MiniBeacon_00258"},
                        new Beacon(){Id=24, MACAdress	=	"DF:4E:F9:40:47:6E", X=44.78999908, Y=	32.15835011	, Name = "MiniBeacon_00221"},
                        new Beacon(){Id=25	, MACAdress	="DF:BA:E2:04:BA:AA", X=1.23	, Y=6.248550911	, Name = "MiniBeacon_0060"},
                        new Beacon(){Id=26, MACAdress	=	"DF:D6:58:03:6A:02", X=7.169999771, Y=	9.472349545	, Name = "MiniBeacon_0054"},
                        new Beacon(){Id=27, MACAdress	=	"E0:B3:02:38:52:D4", X=37.77000092, Y=	25.05404977	, Name = "MiniBeacon_00178"},
                        new Beacon(){Id=28	, MACAdress	="E1:72:CD:69:DF:AE", X=44.07000092	, Y=12.03944909	, Name = "MiniBeacon_00172"},
                        new Beacon(){Id=29, MACAdress	=	"E1:81:BB:19:45:E4", X=19.05000046, Y=	31.80014989	, Name = "MiniBeacon_00207"},
                        new Beacon(){Id=30	, MACAdress	="E1:9C:D4:55:35:3C", X=25.17000092 , Y=	30.12854977	, Name = "MiniBeacon_00252"},
                        new Beacon(){Id=31	, MACAdress	="E4:9D:85:AE:AF:D7", X=37.71000183	 , Y=30.00914989	, Name = "MiniBeacon_00188"},
                        new Beacon(){Id=32, MACAdress	=	"E5:97:F7:EC:29:EB", X=14.67000092	, Y=36.69554999	, Name = "MiniBeacon_00174"},
                        new Beacon(){Id=33, MACAdress	=	"E6:07:91:46:11:CF", X=49.83	, Y=25.47195023	, Name = "MiniBeacon_00135"},
                        new Beacon(){Id=34, MACAdress	=	"E6:83:B6:DE:68:1A", X=0.990000229, Y=	26.42715046	, Name = "MiniBeacon_004"},
                        new Beacon(){Id=35, MACAdress	=	"E7:26:6C:14:B8:46", X=31.28999908	, Y=18.78554977	, Name = "MiniBeacon_00134"},
                        new Beacon(){Id=36	, MACAdress	="E8:B4:C0:66:90:E4", X=12.87000092 , Y=	17.94975	, Name = "MiniBeacon_0024"},
                        new Beacon(){Id=37	, MACAdress	="EB:3A:B7:0D:8C:EC", X=1.169999771 , Y=	31.44195023	, Name = "MiniBeacon_00191"},
                        new Beacon(){Id=38, MACAdress	=	"EE:08:39:97:3E:44", X=38.90999725, Y=	6.069449089	, Name = "MiniBeacon_00141"},
                        new Beacon(){Id=39, MACAdress	=	"EE:B3:DC:D0:14:4F", X=48.93	, Y=2.845650455	, Name = "MiniBeacon_00171"},
                        new Beacon(){Id=40, MACAdress	=	"EF:8F:D1:F1:EA:C6", X=18.93, Y=	18.66615046	, Name = "MiniBeacon_00183"},
                        new Beacon(){Id=41, MACAdress	=	"F5:06:44:0C:B0:35", X=38.13, Y=	12.09915046	, Name = "MiniBeacon_00108"},
                        new Beacon(){Id=42, MACAdress	=	"F1:29:96:FA:7B:0F", X=44.13	, Y=0.875550911	, Name = "MiniBeacon_00182"},
                        new Beacon(){Id=43, MACAdress	=	"F3:E6:9D:87:E7:AC", X=31.28999908	, Y=30.48675	, Name = "MiniBeacon_00190"},
                        new Beacon(){Id=44, MACAdress	=	"F5:AA:53:C3:80:D3", X=49.64999817, Y=	12.57675	, Name = "MiniBeacon_00177"},
                        new Beacon(){Id=45, MACAdress	=	"F6:7C:C5:55:0A:5B", X=25.40999954	, Y=5.890349545	, Name = "MiniBeacon_00125"},
                        new Beacon(){Id=46, MACAdress	=	"FE:A9:5D:FF:C6:3E", X=31.41000183	, Y=11.50215046	, Name = "MiniBeacon_00116"},
                        new Beacon(){Id=47, MACAdress	=	"F8:7F:DF:27:16:01", X=7.23 , Y=	12.75584954	, Name = "MiniBeacon_00143"},
                        new Beacon(){Id=48, MACAdress	=	"FA:72:90:9F:E2:B0", X=44.07000092, Y=	25.11375	, Name = "MiniBeacon_00180"},
                        new Beacon(){Id=49	, MACAdress	="FF:22:49:6F:32:53", X=48.33	, Y=36.81495001	, Name = "MiniBeacon_00181"},
                
                
            };


            if (_context.Beacons.Any()) return Ok("Already exist");
            _context.Beacons.AddRange(beacons);
            _context.SaveChanges();
            return Ok("Added New Data");




        }


        [Route("/Challenge_2/Delete/{testNr?}")]
        public IActionResult Delete(int testNr)
        {
            _context.RemoveRange(_context.BluetoothLeDevices.ToList());
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [Route("/Challenge_2/GetDistance")]
        public IActionResult GetDistance()
        {
            var list = _context.BluetoothLeDevices.OrderByDescending(x => x.DateTime).Take(10).ToList();
            
//            int n = list.Count;
//            Random rng = new Random();
//            while (n > 1) {  
//                n--;  
//                int k = rng.Next(n + 1);  
//                var value = list[k];  
//                list[k] = list[n];  
//                list[n] = value;  
//            }
//            
            var minDist = list.OrderBy(x=>x.EstimatedDistance).Take(3).ToList();
            foreach (var device in minDist)
            {
                var temp = _context.Beacons.SingleOrDefault(x => x.Name == device.NameofBeacon);
                device.X = temp.X;
                device.Y = temp.Y;
                
            }
            
            return Ok(new {B1 = minDist[0], B2 = minDist[1], B3 = minDist[2]});
        }

        public IActionResult Map()
        {
            return View();
        }
        
        public bool AnyIntersection(double x1, double y1, double r1, double x2, double y2, double r2,double x3, double y3, double r3) {
            //Calculate the distance between circles' centers

            var d_1_2 = Math.Sqrt( sq2(x2 - x1) + sq2(y2 -y1));
            var d_1_3 = Math.Sqrt( sq2(x3 - x1) + sq2(y3 - y1));
            var d_2_3 = Math.Sqrt( sq2(x3 - x2) + sq2(y3 - y1));
                
            if (d_1_2 >= (r1 + r2))
                return false;

            if (d_1_3 >= (r1 + r3))
                return false;

            if (d_2_3 >= (r2 + r3))
                return false;
                

            return true;
        }

        private double sq2(double nm)
        {
            return nm * nm;
        }
        
    }
}