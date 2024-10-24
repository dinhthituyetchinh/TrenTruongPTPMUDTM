using Accord.MachineLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B11
{
    public class KMean
    {
       public void KMeans()
        {
            Accord.Math.Random.Generator.Seed = 0;

            // Declare some observations
            double[][] observations =
        {
            new double[] { -5, -2, -1 },
            new double[] { -5, -5, -6 },
            new double[] {  2,  1,  1 },
            new double[] {  1,  1,  2 },
            new double[] {  1,  2,  2 },
            new double[] {  3,  1,  2 },
            new double[] { 11,  5,  4 },
            new double[] { 15,  5,  6 },
            new double[] { 10,  5,  6 },
        };

            // Create a new K-Means algorithm
            KMeans kmeans = new KMeans(k: 3);

            // Compute and retrieve the data centroids
            var clusters = kmeans.Learn(observations);

            // Use the centroids to parition all the data
            int[] labels = clusters.Decide(observations);  
        }
    }
}
