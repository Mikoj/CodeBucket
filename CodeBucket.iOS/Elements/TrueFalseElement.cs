using System;

namespace CodeBucket.Elements
{
    public class TrueFalseElement : BooleanElement
    {
        public TrueFalseElement(string caption, bool value, Action<BooleanElement> changeAction = null)
            : base(caption, value)
        {
            if (changeAction != null)
                this.ValueChanged += (object sender, EventArgs e) => changeAction(this);
        }

        public override UIKit.UITableViewCell GetCell(UIKit.UITableView tv)
        {
            var cell = base.GetCell(tv);
            cell.BackgroundColor = StyledStringElement.BgColor;
            cell.TextLabel.Font = StyledStringElement.DefaultTitleFont.WithSize(StyledStringElement.DefaultTitleFont.PointSize * Element.FontSizeRatio);
            cell.TextLabel.TextColor = StyledStringElement.DefaultTitleColor;
            return cell;
        }
    }
}

