using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SteamCMD_reGUI_Core.Configs;

namespace XmlTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var XmlSersdf = new XmlSerializer(typeof(ServerList));
            using (var file = File.OpenRead(@"D:\Work\GitHub\SteamCMD_reGUI\source\SteamCMD_reGUI_Client\Servers.xml"))
            {
                var list = (ServerList) XmlSersdf.Deserialize(file);
                Console.WriteLine(list.List.First());
                Console.ReadLine();
            }
        }

        static void TestSsdfghm()
        {
            var test = new ServerList();
            test.Meta = new Meta()
            {
                Version = "0.1",
                Author = "Me",
                Comment = "SS",
                Date = DateTime.Now.Date
            };
            test.List = new[]
            {
                new Server()
                {
                    AnonLogin = true,
                    AppId =  90 ,
                    ModName = "cstrike",
                    MustBePurchased = false,
                    SteamClientRequered = false,
                    WarningMessage = "",
                    Name = "CS 1.6 test"
                }
            };
            var XmlSersdf = new XmlSerializer(typeof(ServerList));
            using (var file = File.OpenWrite("servers.test"))
            {
                XmlSersdf.Serialize(file, test);
            }
        }
    }
}
