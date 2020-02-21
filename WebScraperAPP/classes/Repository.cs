using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraperAPP.classes
{
    interface Repository
    {
       void addItem(string item);
       String getFirstItem();
        List<string> retrieve();

    }
}
