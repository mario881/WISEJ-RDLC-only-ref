namespace WisejWebDesktopApplication1
{
    partial class MyDesktop
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar1 = new Wisej.Web.MenuBar();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuItem2 = new Wisej.Web.MenuItem();
            this.menuItem3 = new Wisej.Web.MenuItem();
            this.menuItem4 = new Wisej.Web.MenuItem();
            this.checkedMenuItem1 = new Wisej.Web.CheckedMenuItem();
            this.menuBar2 = new Wisej.Web.MenuBar();
            this.menuItem5 = new Wisej.Web.MenuItem();
            this.menuItem6 = new Wisej.Web.MenuItem();
            this.menuItem7 = new Wisej.Web.MenuItem();
            this.desktopTaskBarItemControl1 = new Wisej.Web.DesktopTaskBarItemControl();
            this.SuspendLayout();
            // 
            // menuBar1
            // 
            this.menuBar1.BackColor = System.Drawing.Color.FromName("@highlight");
            this.menuBar1.Dock = Wisej.Web.DockStyle.Top;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem4});
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1111, 40);
            this.menuBar1.TabIndex = 0;
            this.menuBar1.TabStop = false;
            // 
            // menuItem1
            // 
            this.menuItem1.Icon = global::WisejWebDesktopApplication1.Properties.Resources.Calendar_New_24x24;
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "menuItem1";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Text = "menuItem2";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Text = "menuItem3";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.checkedMenuItem1});
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Text = "menuItem4";
            // 
            // checkedMenuItem1
            // 
            this.checkedMenuItem1.Index = 0;
            this.checkedMenuItem1.Name = "checkedMenuItem1";
            this.checkedMenuItem1.Text = "checkedMenuItem1";
            // 
            // menuBar2
            // 
            this.menuBar2.Location = new System.Drawing.Point(5, 2);
            this.menuBar2.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuItem7});
            this.menuBar2.Name = "menuBar2";
            this.menuBar2.Size = new System.Drawing.Size(34, 34);
            this.menuBar2.TabIndex = 1;
            this.menuBar2.TabStop = false;
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Text = "menuItem5";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Name = "menuItem6";
            this.menuItem6.Text = "menuItem6";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Name = "menuItem7";
            this.menuItem7.Text = "menuItem7";
            // 
            // desktopTaskBarItemControl1
            // 
            this.desktopTaskBarItemControl1.Control = this.menuBar2;
            this.desktopTaskBarItemControl1.Name = "desktopTaskBarItemControl1";
            // 
            // MyDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromName("@table-row-background-selected");
            this.Controls.Add(this.menuBar1);
            this.Items.AddRange(new Wisej.Web.DesktopTaskBarItem[] {
            this.desktopTaskBarItemControl1});
            this.Name = "MyDesktop";
            this.Size = new System.Drawing.Size(1111, 692);
            this.Wallpaper = "Resources/Immagine.png";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.MenuBar menuBar1;
        private Wisej.Web.MenuItem menuItem1;
        private Wisej.Web.MenuItem menuItem2;
        private Wisej.Web.MenuItem menuItem3;
        private Wisej.Web.MenuItem menuItem4;
        private Wisej.Web.CheckedMenuItem checkedMenuItem1;
        private Wisej.Web.MenuBar menuBar2;
        private Wisej.Web.MenuItem menuItem5;
        private Wisej.Web.MenuItem menuItem6;
        private Wisej.Web.MenuItem menuItem7;
        private Wisej.Web.DesktopTaskBarItemControl desktopTaskBarItemControl1;
    }
}
