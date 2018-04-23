using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;

namespace WindowsFormsApplication86 {
    public class MyTokenEdit : TokenEdit {
        static MyTokenEdit() {
            Register();
        }
        public static void Register() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("MyTokenEdit", typeof(MyTokenEdit), typeof(MyRepositoryItemTokenEdit), typeof(MyTokenEditViewInfo), new TokenEditPainter(), true, null, typeof(DevExpress.Accessibility.MemoEditAccessible)));
        }
        public MyTokenEdit() {
        }
        public new void SetCaretToEnd() {
            BeginUpdate();
            try {
                base.SetCaretToEnd();
            } finally {
                EndUpdate();
            }
        }
        protected override void UpdateEditValueOnClosePopupCore(TokenEditToken token) {
            base.UpdateEditValueOnClosePopupCore(token);
            SetCaretToEnd();
        }
        protected override bool ShouldFilterSeparators() {
            return false;
        }
        protected override BaseTokenEditPopupController CreatePopupController() {
            return new MyTokenEditTokenListPopupController(this);
        }
        public override string EditorTypeName {
            get {
                return "MyTokenEdit";
            }
        }
    }

   
}
