using Accord.MachineLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12
{
   public class ThuatToan
    {
       public ThuatToan()
       {

       }
       public int[] demoTT(double[][] observations, int k)
       {
           Accord.Math.Random.Generator.Seed = 0;

           KMeans kmeans = new KMeans(k: k);
          
           var clusters = kmeans.Learn(observations);

           
           int[] labels = clusters.Decide(observations);

           return labels; 
       }

    }
}
