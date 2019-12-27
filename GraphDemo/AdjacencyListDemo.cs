using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDS019.GraphDemo
{
    /// <summary>
    /// 图的构建
    /// </summary>
    static class AdjacencyListDemo
    {
        public static AdjacencyList<string> GraphWithAdjacencyList(string [] dian,string [] dian1,string[] dian2)
        {
            var demoList = new AdjacencyList<string>();

            for(int i=0;i< dian.Length;i++)
                {
                    demoList.AddVertex(dian[i]);
                }
           // demoList.AddVertex("A");
           // demoList.AddVertex("B");
          ///  demoList.AddVertex("C");
          ///  demoList.AddVertex("D");
            for(int y=0;y<dian.Length;y++)
                {
                 demoList.AddEdge(dian1[y], dian2[y]);
                }
            /*demoList.AddEdge("A", "B");
            demoList.AddEdge("A", "C");
            demoList.AddEdge("A", "D");
            demoList.AddEdge("B", "D");
            */
            return demoList;
        }

    }
}
