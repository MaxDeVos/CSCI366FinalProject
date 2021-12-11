using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI366FinalProject
{
    public class DatabaseUtils
    {

        public static List<List<object>> queryTo2DList(DataRow[] rows)
        {
            List<List<object>> outList = new List<List<object>>();
            foreach (DataRow r in rows)
            {
                List<object> rowList = new List<object>();
                foreach (object obj in r.ItemArray) {
                    rowList.Add(obj);
                    //Console.Write(obj + "(" + obj.GetType() + ");");
                }
                //Console.WriteLine();
                outList.Add(rowList);
            }
            return outList;
        }

        public static List<string[]> queryToListOfStringArrays(DataRow[] rows)
        {
            List<string[]> outList = new List<string[]>();
            foreach (DataRow r in rows)
            {
                string[] rowList = new string[r.ItemArray.Length];
                for(int i = 0; i < r.ItemArray.Length; i++)
                {
                    rowList[i] = r.ItemArray[i].ToString();
                    Console.Write(rowList[i]);
                }
                outList.Add(rowList);
                Console.WriteLine();
            }
            return outList;
        }

        public static List<object> getItemArrayFromQuery(DataRow dataRow)
        {
            List<object> outList = new List<object>();
            foreach (object r in dataRow.ItemArray)
            {
                outList.Add(r);
                Console.WriteLine(r);
            }
            return outList;
        }

        public static List<string> OneColumnQuerytoStringList(DataRow[] rows)
        {
            List<string> outList = new List<string>();
            foreach (DataRow r in rows)
            {
                List<object> rowList = new List<object>();
                foreach (object obj in r.ItemArray)
                {
                    rowList.Add(obj);
                    Console.Write(obj + "(" + obj.GetType() + ");");
                }
                Console.WriteLine();
            }
            return outList;
        }

    }
}
