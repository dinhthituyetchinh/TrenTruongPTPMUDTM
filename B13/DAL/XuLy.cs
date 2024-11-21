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
        public void thuatToan(string nmlt, string thnnlt, string lthdt, string thlthdt, string ctdlgt, string thctdlgt, string csdl, string thcsdl, string tcc)
        {
            DataTable data = loadDL();

            Codification codebook = new Codification(data);

            DataTable symbols = codebook.Apply(data);
            int[][] inputs = symbols.ToArray<int>(
                        "ds_nnlt",
                        "ds_th_nnlt",
                        "ds_lthdt",
                        "ds_th_lthdt",
                        "ds_ctdl_gt",
                        "ds_th_ctdlgt",
                        "ds_csdl",
                        "ds_th_csdl",
                        "ds_toancc"
                        );
            int[] outputs = symbols.ToArray<int>("chuyennganh");
         
        }
    }
}
