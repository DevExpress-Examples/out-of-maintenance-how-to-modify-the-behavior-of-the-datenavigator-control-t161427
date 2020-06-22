Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Namespace DateNavigatorCustomized
	Partial Public Class Form1
		Inherits XtraForm

		Private Const aptDataFileName As String = "..\..\Data\appointments.xml"
		Private Const resDataFileName As String = "..\..\Data\resources.xml"

		Public Sub New()
			InitializeComponent()

			schedulerControl1.Start = New DateTime(2010, 7, 11)

			FillData()

			dateNavigator1.SelectionBehavior = DevExpress.XtraEditors.Controls.CalendarSelectionBehavior.Simple
		End Sub

		#Region "FillData"
		Private Sub FillData()
			Dim customNameMapping As New AppointmentCustomFieldMapping("CustomName", "CustomName")
			Dim customStatusMapping As New AppointmentCustomFieldMapping("CustomStatus", "CustomStatus")
			schedulerStorage1.Appointments.CustomFieldMappings.Add(customNameMapping)
			schedulerStorage1.Appointments.CustomFieldMappings.Add(customStatusMapping)
			FillResourcesStorage(schedulerStorage1.Resources.Items, resDataFileName)
			FillAppointmentsStorage(schedulerStorage1.Appointments.Items, aptDataFileName)
		End Sub

		Private Shared Function GetFileStream(ByVal fileName As String) As Stream
			Return (New StreamReader(fileName)).BaseStream
		End Function

		Private Shared Sub FillAppointmentsStorage(ByVal c As AppointmentCollection, ByVal fileName As String)
			Using stream As Stream = GetFileStream(fileName)
				c.ReadXml(stream)
				stream.Close()
			End Using
		End Sub

		Private Shared Sub FillResourcesStorage(ByVal c As ResourceCollection, ByVal fileName As String)
			Using stream As Stream = GetFileStream(fileName)
				c.ReadXml(stream)
				stream.Close()
			End Using
		End Sub
		#End Region

		Private Sub schedulerStorage_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsInserted, schedulerStorage1.AppointmentsChanged, schedulerStorage1.AppointmentsDeleted
			schedulerStorage1.Appointments.Items.WriteXml(aptDataFileName)
		End Sub
	End Class
End Namespace