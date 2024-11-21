using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;

namespace DAL
{
    public class XuLy
    {
        Connect con = new Connect();
        public DataTable loadDL()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Sheet1$", con.connSQL);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        [Obsolete]
        public double thuatToan(string nmlt, string thnnlt, string lthdt, string thlthdt, string ctdlgt, string thctdlgt, string csdl, string thcsdl, string tcc)
        {
            DataTable data = loadDL();

            Codification codebook = new Codification(data);

            DataTable symbols = codebook.Apply(data);
            int[][] inputs = symbols.ToArray<int>(
                        "dc_nnlt",
                        "dc_th_nnlt",
                        "dc_lthdt",
                        "dc_th_lthdt",
                        "dc_ctdl_gt",
                        "dc_th_ctdlgt",
                        "dc_csdl",
                        "dc_th_csdl",
                        "dc_toancc"
                        );
            int[] outputs = symbols.ToArray<int>("chuyennganh");

            var id3learning = new ID3Learning()
            {
                new DecisionVariable("dc_nnlt", 5),
                new DecisionVariable("dc_th_nnlt", 5),
                new DecisionVariable("dc_lthdt", 5),
                new DecisionVariable("dc_th_lthdt", 5),
                new DecisionVariable("dc_ctdl_gt", 5),
                new DecisionVariable("dc_th_ctdlgt", 5),
                new DecisionVariable("dc_th_ctdlgt", 5),
                new DecisionVariable("dc_csdl", 5),
                new DecisionVariable("dc_toancc", 5)

               
            };

            DecisionTree DecisionTree = id3learning.Learn(inputs, outputs);
            double err = new ZeroOneLoss(outputs).Loss(DecisionTree.Decide(inputs));
            return err;
        }



    }
}
