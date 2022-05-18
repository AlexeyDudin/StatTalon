using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTalon.src.DataBase
{
    public interface IDataBase
    {
        void FillAllTable();
        void FillMkbTable();
        void InsertMkbTableRow(DataSetStatTalon.mkb_tableRow mkb_TableRow);
        void UpdateMkbTableRow(DataSetStatTalon.mkb_tableRow oldMkb_TableRow, DataSetStatTalon.mkb_tableRow newMkb_TableRow);
        void DeleteMkbTableRow(DataSetStatTalon.mkb_tableRow mkb_TableRow);
    }
}
