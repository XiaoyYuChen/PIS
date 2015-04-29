using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IData
{
    public enum DataType
    {
        CPRS = 1,
        WPI = 2,
        EPODOC = 3
    }
    public interface IDataImport : IDisposable
    {
        string ztName { get; set; }
        int Zid { get; set; }
        string FilePath { get; set; }
        DataType Type { get; set; }
        Dictionary<string, string> Row { get; set; }
        event ValueChangedEventHandler ShowProcess;
        event SetMaxValueEventHander SetMaxProcess;
        bool Import();
        Dictionary<string, string> GetRowData();
        bool CancelImport();

    }

}
