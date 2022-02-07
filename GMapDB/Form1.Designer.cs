
namespace GMapDB
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveMarkerBtn = new System.Windows.Forms.Button();
            this.deleteMarkerBtn = new System.Windows.Forms.Button();
            this.markerNameTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lngTextBox = new System.Windows.Forms.TextBox();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(12, 12);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(505, 426);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseDoubleClick);
            this.gMapControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseDown);
            this.gMapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseMove);
            this.gMapControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.saveMarkerBtn);
            this.panel1.Controls.Add(this.deleteMarkerBtn);
            this.panel1.Controls.Add(this.markerNameTBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lngTextBox);
            this.panel1.Controls.Add(this.latTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(536, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 426);
            this.panel1.TabIndex = 1;
            // 
            // saveMarkerBtn
            // 
            this.saveMarkerBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.saveMarkerBtn.Location = new System.Drawing.Point(6, 43);
            this.saveMarkerBtn.Name = "saveMarkerBtn";
            this.saveMarkerBtn.Size = new System.Drawing.Size(243, 38);
            this.saveMarkerBtn.TabIndex = 8;
            this.saveMarkerBtn.Text = "Сохранить изменения";
            this.saveMarkerBtn.UseVisualStyleBackColor = false;
            this.saveMarkerBtn.Click += new System.EventHandler(this.saveMarkerBtn_Click);
            // 
            // deleteMarkerBtn
            // 
            this.deleteMarkerBtn.BackColor = System.Drawing.Color.Red;
            this.deleteMarkerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteMarkerBtn.Location = new System.Drawing.Point(40, 87);
            this.deleteMarkerBtn.Name = "deleteMarkerBtn";
            this.deleteMarkerBtn.Size = new System.Drawing.Size(165, 33);
            this.deleteMarkerBtn.TabIndex = 7;
            this.deleteMarkerBtn.Text = "Удалить";
            this.deleteMarkerBtn.UseVisualStyleBackColor = false;
            this.deleteMarkerBtn.Click += new System.EventHandler(this.deleteMarkerBtn_Click);
            // 
            // markerNameTBox
            // 
            this.markerNameTBox.Location = new System.Drawing.Point(4, 16);
            this.markerNameTBox.Name = "markerNameTBox";
            this.markerNameTBox.Size = new System.Drawing.Size(246, 20);
            this.markerNameTBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название этого маркера:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Создать маркер (также это возможно двойным щелчком по карте)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lngTextBox
            // 
            this.lngTextBox.Location = new System.Drawing.Point(149, 292);
            this.lngTextBox.Name = "lngTextBox";
            this.lngTextBox.Size = new System.Drawing.Size(100, 20);
            this.lngTextBox.TabIndex = 3;
            // 
            // latTextBox
            // 
            this.latTextBox.Location = new System.Drawing.Point(149, 266);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.Size = new System.Drawing.Size(100, 20);
            this.latTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Долгота (longitude):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина (latitude):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private global::GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lngTextBox;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteMarkerBtn;
        private System.Windows.Forms.TextBox markerNameTBox;
        private System.Windows.Forms.Button saveMarkerBtn;
    }
}

