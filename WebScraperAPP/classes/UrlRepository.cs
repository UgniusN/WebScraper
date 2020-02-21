using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraperAPP.classes
{
    class UrlRepository : Repository
    {
        private List<String> urlList;
        public UrlRepository()
        {
            urlList = new List<String>();
        }

        public void addItem(string item)
        {
            urlList.Add(item);
        }

        public String getFirstItem()
        {
            return urlList[0];
        }
        public List<string> retrieve()
        {
            return urlList;
        }
    }
}
