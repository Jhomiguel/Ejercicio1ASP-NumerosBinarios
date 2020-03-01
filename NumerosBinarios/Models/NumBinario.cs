using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumerosBinarios.Models
{
    public class NumBinario
    {
        public List<int> Numeros { get; set; }
        public List<string> NBinarios { get; set; }
        public static List<string>Binario(IEnumerable<int> Nums)
        {
            List<string> BNum = new List<string>();
            foreach (int num in Nums)
            {
                string binario = Convert.ToString(num, 2);
                while (binario.Length < 8)
                {
                    binario = 0 + binario;
                }
                BNum.Add(binario);
            }
            return BNum;
        }
    }
}
