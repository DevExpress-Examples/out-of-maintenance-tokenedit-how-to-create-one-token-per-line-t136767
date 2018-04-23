using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication86 {
    public class MyTokenEditViewInfo : TokenEditViewInfo {
        public MyTokenEditViewInfo(MyRepositoryItemTokenEdit properties)
            : base(properties) {
        }
        protected override TokenEditTokenEvaluator CreateTokenEvaluator() {
            return new MyTokenEditTokenEvaluator(this);
        }
    }
}
