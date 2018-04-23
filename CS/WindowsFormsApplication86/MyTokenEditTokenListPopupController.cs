using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication86 {
    public class MyTokenEditTokenListPopupController : TokenEditTokenListPopupController {
        public MyTokenEditTokenListPopupController(TokenEdit tokenEdit)
            : base(tokenEdit) {
        }
        protected override void ShowPopupIfNeeded() {
            //if((ControlUtils.IsKeyPressed(Keys.Back))
            if((NativeMethods.GetAsyncKeyState((int)Keys.Back) & 0x8000) != 0)
                return;
            base.ShowPopupIfNeeded();
        }
    }
}
