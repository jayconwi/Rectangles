namespace Rectangles
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGrid = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.textSize = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Location = new System.Drawing.Point(12, 12);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(250, 250);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(268, 103);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 25);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(268, 30);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(73, 23);
            this.textLocation.TabIndex = 2;
            this.textLocation.Text = "2,2";
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(268, 74);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(73, 23);
            this.textSize.TabIndex = 4;
            this.textSize.Text = "2,3";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(268, 12);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(53, 15);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Location";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(268, 56);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 15);
            this.labelSize.TabIndex = 11;
            this.labelSize.Text = "Size";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(268, 134);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(73, 25);
            this.buttonFind.TabIndex = 12;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(268, 165);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(73, 25);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(268, 196);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(73, 25);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 274);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelGrid);
            this.Name = "Main";
            this.Text = "Rectangles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelGrid;
        private Button buttonAdd;
        private TextBox textLocation;
        private TextBox textSize;
        private Label labelPosition;
        private Label labelSize;
        private Button buttonFind;
        private Button buttonRemove;
        private Button buttonClear;
    }
}