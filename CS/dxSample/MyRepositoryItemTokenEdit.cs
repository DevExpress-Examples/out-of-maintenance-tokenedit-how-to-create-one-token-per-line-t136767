using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace dxSample {
    public class MyRepositoryItemTokenEdit : RepositoryItemTokenEdit {
        public MyRepositoryItemTokenEdit() { }
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
