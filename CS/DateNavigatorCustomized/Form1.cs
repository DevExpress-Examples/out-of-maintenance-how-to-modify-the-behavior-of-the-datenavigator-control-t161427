using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DateNavigatorCustomized {
    public partial class Form1 : XtraForm {
        const string aptDataFileName = @"..\..\Data\appointments.xml";
        const string resDataFileName = @"..\..\Data\resources.xml";
        
        public Form1() {
            InitializeComponent();

            schedulerControl1.Start = new DateTime(2010, 7, 11);
                        
            FillData();

            dateNavigator1.SelectionBehavior = DevExpress.XtraEditors.Controls.CalendarSelectionBehavior.Simple;
        }

        #region FillData
        void FillData() {
            AppointmentCustomFieldMapping customNameMapping = new AppointmentCustomFieldMapping("CustomName", "CustomName");
            AppointmentCustomFieldMapping customStatusMapping = new AppointmentCustomFieldMapping("CustomStatus", "CustomStatus");
            schedulerStorage1.Appointments.CustomFieldMappings.Add(customNameMapping);
            schedulerStorage1.Appointments.CustomFieldMappings.Add(customStatusMapping);
            FillResourcesStorage(schedulerStorage1.Resources.Items, resDataFileName);
            FillAppointmentsStorage(schedulerStorage1.Appointments.Items, aptDataFileName);
        }

        static Stream GetFileStream(string fileName) {
            return new StreamReader(fileName).BaseStream;
        }

        static void FillAppointmentsStorage(AppointmentCollection c, string fileName) {
            using (Stream stream = GetFileStream(fileName)) {
                c.ReadXml(stream);
                stream.Close();
            }
        }

        static void FillResourcesStorage(ResourceCollection c, string fileName) {
            using (Stream stream = GetFileStream(fileName)) {
                c.ReadXml(stream);
                stream.Close();
            }
        }
        #endregion

        private void schedulerStorage_AppointmentsChanged(object sender, PersistentObjectsEventArgs e) {
            schedulerStorage1.Appointments.Items.WriteXml(aptDataFileName);
        }    
     }
}