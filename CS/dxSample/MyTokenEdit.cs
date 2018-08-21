using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;

namespace dxSample {
    public class MyTokenEdit : TokenEdit {
        static MyTokenEdit() {
            Register();
        }
        public static void Register() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("MyTokenEdit", typeof(MyTokenEdit), typeof(MyRepositoryItemTokenEdit), typeof(MyTokenEditViewInfo), new TokenEditPainter(), true, null, typeof(DevExpress.Accessibility.MemoEditAccessible)));
        }
        public MyTokenEdit() { }
        public override string EditorTypeName {
            get {
                return "MyTokenEdit";
            }
        }
    }   
}
