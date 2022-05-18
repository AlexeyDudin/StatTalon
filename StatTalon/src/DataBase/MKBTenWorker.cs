using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTalon.src.DataBase
{
    public class MKBTenWorker
    {
        private DataBaseWorker db;
        public MKBTenWorker(ref DataBaseWorker dataBase)
        {
            this.db = dataBase;
        }

        public DataSetStatTalon.mkb_tableRow[] GetParentRows()
        {
            db.FillMkbTable();
            return db.DataSetStatTalon.mkb_table.Select("parent_id is NULL") as DataSetStatTalon.mkb_tableRow[];
        }

        public DataSetStatTalon.mkb_tableRow[] GetChildRows(DataSetStatTalon.mkb_tableRow mkbRow)
        {
            return mkbRow.Getmkb_tableRows();
        }
        public void AddRow(string code, string name, int parent_id = 0)
        {
            DataSetStatTalon.mkb_tableRow parentRow = null;
            if (parent_id != 0)
                parentRow = db.DataSetStatTalon.mkb_table.FindById(parent_id);
            DataSetStatTalon.mkb_tableRow newRow = db.DataSetStatTalon.mkb_table.Addmkb_tableRow(name, code, parentRow);
            db.InsertMkbTableRow(newRow);
        }

        public int GetIdByCodeAndName(string code, string name)
        {
            DataSetStatTalon.mkb_tableRow[] rows = db.DataSetStatTalon.mkb_table.Select(string.Format("code = \'{0}\' AND name = \'{1}\'", code, name)) as DataSetStatTalon.mkb_tableRow[];
            if (rows.Length != 0)
                return rows[0].Id;
            return 0;
        }

        public void EditRow(int editedId, string code, string name)
        {
            DataSetStatTalon.mkb_tableRow editedRow = db.DataSetStatTalon.mkb_table.FindById(editedId);
            editedRow.code = code;
            editedRow.name = name;
            db.UpdateMkbTableRow(db.DataSetStatTalon.mkb_table.FindById(editedId), editedRow);
        }

        public void DeleteRow(int deletedId)
        {
            DataSetStatTalon.mkb_tableRow deletedRow = db.DataSetStatTalon.mkb_table.FindById(deletedId);
            db.DeleteMkbTableRow(deletedRow);

        }
    }
}
