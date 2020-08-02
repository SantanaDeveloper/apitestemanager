using JsonDiffPatchDotNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Apimanager.Helpers
{
    public class StringHelper
    {
        /// <summary>   
        /// Compara o json da esqueda com o da direita.
        /// </summary>
        /// <returns>Retorna uma string informando a igualdade</returns>
        public string Compare(string a, string b)
        {
            if (JToken.DeepEquals(a, b)) {
                return "É Igual";
            } else
            {
               return this.CompareLenghts(a,b);
            }
        }

        /// <summary>   
        /// Compara o json da esqueda com o da direita.
        /// </summary>
        /// <returns>Retorna uma string informando se o tamanho é igual</returns>
        public string CompareLenghts(string a, string b)
        {
            var jsonLeft = JsonConvert.DeserializeObject(a);
            var jsonRight = JsonConvert.DeserializeObject(b);
            var lengthLeft = jsonLeft.ToString().Length;
            var lengthRight = jsonRight.ToString().Length;
            if(lengthLeft != lengthRight)
            {
                return "Tamanho Diferentes";
            } else
            {
                return this.getDiffs(a, b);
            }
        }

        /// <summary>   
        /// Compara as diferenças do json da esqueda com o da direita.
        /// </summary>
        /// <returns>Retorna uma string informando as diferenças</returns>
        public string getDiffs(string a, string b)
        {
            var jdp = new JsonDiffPatch();
            return jdp.Diff(a, b);
        }
    }
}
