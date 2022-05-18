using StatTalon.DataSetStatTalonTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTalon.src.DataBase
{
    public class DataBaseWorker : IDataBase
    {
        private DataSetStatTalon _dataSetStatTalon = null;
        private DataSetStatTalonTableAdapters.mkb_tableTableAdapter _mkb_TableTableAdapter = null;

        public DataSetStatTalon DataSetStatTalon { get => _dataSetStatTalon; set => _dataSetStatTalon = value; }
        public mkb_tableTableAdapter Mkb_TableTableAdapter { get => _mkb_TableTableAdapter; set => _mkb_TableTableAdapter = value; }

        public void DeleteMkbTableRow(DataSetStatTalon.mkb_tableRow mkb_TableRow)
        {
            _mkb_TableTableAdapter.Delete(mkb_TableRow.Id, mkb_TableRow.name, mkb_TableRow.code, mkb_TableRow.parent_id);
            FillMkbTable();
        }

        public void FillAllTable()
        {
            FillMkbTable();
        }

        public void FillMkbTable()
        {
            _mkb_TableTableAdapter.Fill(_dataSetStatTalon.mkb_table);
        }

        public void InsertMkbTableRow(DataSetStatTalon.mkb_tableRow mkb_TableRow)
        {
            _mkb_TableTableAdapter.Insert(mkb_TableRow.name, mkb_TableRow.code, mkb_TableRow.parent_id);
            FillMkbTable();
        }

        public void UpdateMkbTableRow(DataSetStatTalon.mkb_tableRow oldMkb_TableRow, DataSetStatTalon.mkb_tableRow newMkb_TableRow)
        {
            _mkb_TableTableAdapter.Update(newMkb_TableRow.name, newMkb_TableRow.code, newMkb_TableRow.parent_id, oldMkb_TableRow.Id, oldMkb_TableRow.name, oldMkb_TableRow.code, oldMkb_TableRow.parent_id);
            FillMkbTable();
        }
    }
}
