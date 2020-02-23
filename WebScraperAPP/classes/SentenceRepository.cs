using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraperAPP.classes
{
    class SentenceRepository : Repository
    {
        List<String> sentenceList;
        public SentenceRepository()
        {
            sentenceList = new List<String>();
        }

        public void addItem(string item)
        {
            sentenceList.Add(item);
        }

        public string getFirstItem()
        {
            return sentenceList[0];
        }

        public List<string> retrieve()
        {
            return sentenceList;
        }
        public void removeDubs()
        {
            List<String> sentenceListDubs = sentenceList;
            sentenceList = sentenceListDubs.Distinct().ToList();
        }

        public void set(List<String> Repositorie)
        {
            sentenceList = Repositorie;
        }
        public void add(List<String> listToAdd)
        {
           
        }
    }
}
