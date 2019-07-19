using NewsPortal.Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Logic.Manager
{
    public class NewsManager
    {
        public static List<News> GetNews()
        {
            using (var db = new DB())
            {
                return db.News.OrderBy(n => n.Title).ToList();
            }
        }
        public static News GetNews(int id)
        {
            using (var db = new DB())
            {
                return db.News.Find(id);
            }
        }
    }
}
