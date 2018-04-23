Imports DevExpress.XtraScheduler
Imports System

Namespace DateNavigatorCustomized
    #Region "#mydatenavigator"
    Public Class MyDateNavigator
        Inherits DateNavigator

        Protected Overrides Function AdjustSelectionEnd(ByVal start As Date, ByVal [end] As Date) As Date
            Return [end]
            'return base.AdjustSelectionEnd(start, end);
        End Function

        Protected Overrides Function AdjustSelectionStart(ByVal start As Date, ByVal [end] As Date) As Date
            Return start
            'return base.AdjustSelectionStart(start, end);
        End Function
    End Class
    #End Region ' #mydatenavigator
End Namespace
