using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using DTO;

namespace DAL
{
    public class DAL_FB_Khoa
    {
        public static IFirebaseClient CreateFirebaseClient()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "Y8RYThss0t57ACgRiudKzsbGOVWo100Fv7Sh4OPk",
                BasePath = "https://qlsinhvien-9fdb4-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client;

            client = new FireSharp.FirebaseClient(config);
            return client;
        }

        public static async Task<Khoa> FirebaseGetThongTinKhoa(IFirebaseClient client, string rootName)
        {

            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);


                return response.ResultAs<Khoa>();
            }
            return null;
        }

        public static async Task<List<Khoa>> GetThongTinKhoa(string rootName)
        {
            IFirebaseClient client = CreateFirebaseClient();

            List<Khoa> ds = new List<Khoa>();

            int stt = 1;
            bool co = true;
            while (co)
            {
                try
                {
                    Khoa tk = await FirebaseGetThongTinKhoa(client, rootName + "/" +
                        stt.ToString() + "/");
                    if (tk == null)
                    {
                        co = false;
                        break;
                    }

                    stt++;
                    ds.Add(tk);
                }
                catch (Exception ex)
                {
                    co = false;
                }
            }
            return ds;

        }


        public static async void FirebaseInsertData(IFirebaseClient client, object data, string rootName)
        {
            if (client != null)
            {
                await client.SetAsync(rootName, data);
            }
        }

        public static async void FirebaseUpdateData(IFirebaseClient client, object data, string rootName)
        {
            if (client != null)
            {
                await client.UpdateAsync(rootName, data);
            }
        }
        public static async void FirebaseDeleteData(IFirebaseClient client, string rootName)
        {
            if (client != null)
            {
                await client.DeleteAsync(rootName);
            }
        }

    }
}
