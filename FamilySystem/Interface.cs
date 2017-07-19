using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FamilySystem
{
    public interface INterface
    {
        void ChangeDataGridView(DataTable dt);
    }
    public interface MDiTransfer
    {
        void TransferMdi(FormMain main);
    }
}
