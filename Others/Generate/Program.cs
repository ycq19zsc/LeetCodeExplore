using System;
using System.Collections.Generic;

namespace Generate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Generate(5);
        }

        static IList<IList<int>> Generate(int numRows) {
            var list = new List<IList<int>>();
            
            for (int i = 0; i < numRows; i++){
                var items = new List<int>();
                for(int j = 0;j < i ;j++){
                    if(j==0)
                    {
                        items.Add(1);
                    }
                    else
                    {
                        items.Add(list[i-1][j-1]+list[i-1][j]);   
                    }
                }
                items.Add(1);
                
                list.Add(items);
            }
            
            return list;

            // var arr = new int[numRows][];

            // for (int i = 0; i < numRows; i++){
            //     arr[i]= new int[i+1];
            //     for(int j = 0;j < i ;j++){
            //         if(j==0 )
            //         {
            //             arr[i][j] =1;
            //         }
            //         else
            //         {
            //             arr[i][j]=arr[i-1][j-1]+arr[i-1][j];   
            //         }
            //     }
            //     arr[i][i] = 1;
            // }

            // return arr;
        }
    }
}
