using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication86 {
    public class MyRepositoryItemTokenEdit : RepositoryItemTokenEdit {
        public MyRepositoryItemTokenEdit() {
        }
        public override BaseEditViewInfo CreateViewInfo() {
            return new MyTokenEditViewInfo(this);
        }
        public override string EditorTypeName {
            get {
                return "MyTokenEdit";
            }
        }
    }
}
