using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Element_Table_Creator
{
    public class TableLoader
    {
        private string _tableXmlPath = "";

        public void SetXml(string s)
        {
            _tableXmlPath = s;
        }

        public string GetXml()
        {
            return _tableXmlPath;
        }

        public void Load(DataGridView dtv)
        {
            
        }
    }
}
