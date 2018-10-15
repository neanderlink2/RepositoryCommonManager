using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryManager.Common
{
    [Serializable]
    public class JsonWrapper<T>
    {
        public T[] objetos;
    }
}
