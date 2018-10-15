using System.IO;
using UnityEngine;

namespace RepositoryManager.Common
{
    public class ScriptableHelper
    {
        private string _caminhoJson;

        public ScriptableHelper(string caminhoJson)
        {
            _caminhoJson = caminhoJson;
        }

        public void EscreverESalvarJson<T>(T objeto)
        {
            var strJson = JsonUtility.ToJson(objeto);

            if (File.Exists(_caminhoJson))
            {
                File.Delete(_caminhoJson);
            }

            using (var arquivo = File.Open(_caminhoJson, FileMode.OpenOrCreate))
            {
                using (var escritor = new StreamWriter(arquivo))
                {
                    escritor.WriteLine(strJson);
                }
            }
        }

        public T LerJson<T>()
        {
            using (var arquivo = File.Open(_caminhoJson, FileMode.Open))
            {
                using (var leitor = new StreamReader(arquivo))
                {
                    var strJson = leitor.ReadToEnd();
                    T resultado = JsonUtility.FromJson<T>(strJson);
                    return resultado;
                }
            }
        }
    }
}
