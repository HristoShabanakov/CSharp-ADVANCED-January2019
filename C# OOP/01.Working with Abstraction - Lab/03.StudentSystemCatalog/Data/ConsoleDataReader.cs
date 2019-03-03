

namespace StudentSystemCatalog.Data
{
    using System;
    //Interface specify what current class should have, but does not implement it.
    public class ConsoleDataReader : IDataReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
