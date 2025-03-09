using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300106
{
    class KodePos
    {
        private static Dictionary<string, string> kodePosDict = new Dictionary<string, string>
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

        public static string GetKodePos(string kelurahan)
        {
            return kodePosDict.ContainsKey(kelurahan) ? kodePosDict[kelurahan] : "Kode Pos tidak ditemukan";
        }
    }
}
