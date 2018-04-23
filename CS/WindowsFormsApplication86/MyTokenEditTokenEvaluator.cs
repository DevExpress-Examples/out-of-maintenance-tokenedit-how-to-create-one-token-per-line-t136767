using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication86 {
    public class MyTokenEditTokenEvaluator : TokenEditTokenEvaluator {
        public MyTokenEditTokenEvaluator(TokenEditViewInfo viewInfo)
            : base(viewInfo) {
        }
        public override string GetEditorText() {
            if(EditInfo == null || EditInfo.ItemCount == 0)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach(TokenEditTokenInfo tokenInfo in EditInfo.Items) {
                if(tokenInfo.ItemType != TokenEditItemType.Link)
                    continue;
                sb.Append(tokenInfo.GetToken());
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
