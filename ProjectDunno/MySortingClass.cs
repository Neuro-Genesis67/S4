using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDunno
{
    class MySortingClass
    {
        private List<int> list = new List<int>();

        public MySortingClass(List<int> Numbers)
        {
            foreach (int num in Numbers)
            {
                list.Add(num);
            }
            System.Console.WriteLine("System writeout");
        }

        public void printMyList()
        {
            foreach(int num in list)
            {
                Console.WriteLine(num);
            }
        }

       
        public List<int> GetList {
            get { return list; }
        }

        public List<int> SortMyList(List<int> list)
        {
            int size = list.Count;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
    }
}
