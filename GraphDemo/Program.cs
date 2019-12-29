using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDS019.GraphDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("请输入顶点的数量");
            int i = Convert.ToInt32( Console.ReadLine());
            string[] shuru = new string[i];//接受用户输入的点名称
            string[] Vertex = new string[100];
            string[] Node = new string[100];
            int count=0;
             Console.WriteLine("请输入顶点的名称");
            for (int x=0; x <i; x++)
            {
                shuru[x] = Console.ReadLine();
            }
            Console.WriteLine("请输入顶点,和普通点。输入完成");
            while(true)
                {
                     str=Console.ReadLine();
                if(str=="输入完成")
                    {
                        break;
                    }
                else 
                    {
                         Vertex[count]=str;
                         Console.WriteLine("|");
                         Node[count]=Console.ReadLine();
                         Console.WriteLine(" ");
                         count++;
                    }
                   
                }
            
            var demoList01= AdjacencyListDemo.GraphWithAdjacencyList(shuru,Vertex,Node);

          //  string s=string.Join(" ",demoList01.ToString());
              
           
            Console.WriteLine(demoList01);
          
            Console.ReadKey();

            //demoList01.InitVisited();
            //demoList01.DepthFirstTraverse(demoList01.GetVertex("A"));
            //Console.ReadKey();

            demoList01.InitVisited();
            demoList01.WidthFirstTraverse(demoList01.GetVertex("A"));
            Console.ReadKey();

        }
    }
}
