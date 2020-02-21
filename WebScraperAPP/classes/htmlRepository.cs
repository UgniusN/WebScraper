using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraperAPP.classes
{
    class HtmlRepository: Repository
    {
        private List<String> htmlList;
        public HtmlRepository()
        {
            htmlList = new List<String>();
        }

        public void addItem(string item)
        {
            htmlList.Add(item);
        }

        public String getFirstItem()
        {
            return htmlList[0];
        }

        public List<string> retrieve()
        {
            return htmlList;
        }
    }
}
