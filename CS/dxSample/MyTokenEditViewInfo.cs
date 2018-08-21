using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System.Drawing;

namespace dxSample {
    public class MyTokenEditViewInfo : TokenEditViewInfo {
        public MyTokenEditViewInfo(MyRepositoryItemTokenEdit properties)
            : base(properties) { }        

        protected override int CalcRowCountCore(int clientWidth) {
            return TokenCount;
        }

        protected override Rectangle CalcBounds(Point topPt, TokenEditToken token) {
            if (TokenCount < 1)
                return base.CalcBounds(topPt, token);

            Size itemSize = CalcItemSize(token);
            Rectangle r = new Rectangle(topPt, itemSize);
            r.Location = new Point(ContentRect.X, r.Bottom + IndentBetweenRows);
            return r;                   
        }
    }
}
