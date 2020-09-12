using brisi.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brisi
{
    public static class MyDb
    {
        public static List<Buddy> Buddies;

        static MyDb()
        {
            Buddies = new List<Buddy>()
            {
                new Buddy()
                {
                     Id = 1,
                      FullName = "Martin Aleksovski",
                       Mail = "marint@idadija.com",
                        ImgUrl = "https://th.bing.com/th/id/OIP.kWl-4AOpux4hl692KlcvrwHaE8?pid=Api&rs=1"
                },
                new Buddy()
                {
                     Id = 2,
                      FullName = "Nenad Popovski",
                       Mail = "neno@mafija.com",
                        ImgUrl = "http://www.fkrabotnicki.com/en/wp-content/uploads/2015/09/nenad.png"
                },
                new Buddy()
                {
                     Id = 3,
                      FullName = "Darko Nikolic",
                       Mail = "darko@bkw.com",
                        ImgUrl = "https://4.bp.blogspot.com/-_zxgavjHpXE/VzEgyYfoH9I/AAAAAAAAKx8/n2eknb65ghMQahIvaqn9pkXa0unXY4IfwCLcB/s1600/Darko%2BNikolic_080513_Ras%2Bfoto%2BRajko%2BRistic%25281%2529.jpg"
                },
                new Buddy()
                {
                     Id = 4,
                      FullName = "Bojan Dameski",
                       Mail = "boki@inter.com",
                        ImgUrl = "http://ddklaw.com.mk/new/wp-content/uploads/2016/07/Dragan-Dameski.jpg"
                }
            };
        }
    }
}
