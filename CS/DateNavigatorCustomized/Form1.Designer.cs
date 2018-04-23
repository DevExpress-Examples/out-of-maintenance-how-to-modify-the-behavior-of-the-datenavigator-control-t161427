// Developer Express Code Central Example:
// How to customize the tooltips shown for appointments
// 
// Problem: How can I control the tooltip appearance and a tooltip message which is
// shown for each appointment? For instance, I want to change the font color and
// backcolor of every tooltip, and make them show not only the appointment's
// description, but also its subject and location. How can this be done? Solution:
// A SchedulerControl provides the TooltipController property. Use it to specify
// the tooltip controller, which controls the appearance of the appointment
// tooltips. You should create a new TooltipController, assign it to the
// SchedulerControl.TooltipController property, and then set the values of the
// required properties. Also, you can handle the TooltipController.BeforeShow event
// to specify a custom text for the tooltips. The following example illustrates
// this approach.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E155

namespace DateNavigatorCustomized
{
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.dateNavigator1 = new DateNavigatorCustomized.MyDateNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage_AppointmentsChanged);
            this.schedulerStorage1.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage_AppointmentsChanged);
            this.schedulerStorage1.AppointmentsDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage_AppointmentsChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(605, 561);
            this.schedulerControl1.Start = new System.DateTime(2014, 10, 14, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 5;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(605, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.Size = new System.Drawing.Size(179, 561);
            this.dateNavigator1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.dateNavigator1);
            this.Name = "Form1";
            this.Text = "DateNavigator with Modified Behavior";
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private MyDateNavigator dateNavigator1;
    }
}

