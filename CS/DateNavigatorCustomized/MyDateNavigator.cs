using DevExpress.XtraScheduler;
using System;

namespace DateNavigatorCustomized
{
    #region #mydatenavigator
    public class MyDateNavigator : DateNavigator
    {
        protected override DateTime AdjustSelectionEnd(DateTime start, DateTime end)
        {
            return end;
            //return base.AdjustSelectionEnd(start, end);
        }

        protected override DateTime AdjustSelectionStart(DateTime start, DateTime end)
        {
            return start;
            //return base.AdjustSelectionStart(start, end);
        }
    }
    #endregion #mydatenavigator
}
