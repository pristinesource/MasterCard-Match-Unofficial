using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MasterCar_Match_Unofficial.Tests {
    public static class Util {

        public static string GetCurrenyAssemblyPath() {
            return Path.GetDirectoryName(typeof(Util).GetTypeInfo().Assembly.CodeBase).Remove(0, "file:\\".Length);
        }
    }
}
