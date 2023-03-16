namespace WinFormDBEntity
{
    partial class frmAddEdit2
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtxMake = new System.Windows.Forms.TextBox();
            this.make = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(106, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtxMake
            // 
            this.txtxMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "make", true));
            this.txtxMake.Location = new System.Drawing.Point(92, 51);
            this.txtxMake.Name = "txtxMake";
            this.txtxMake.Size = new System.Drawing.Size(100, 20);
            this.txtxMake.TabIndex = 1;
            // 
            // make
            // 
            this.make.AutoSize = true;
            this.make.Location = new System.Drawing.Point(55, 54);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(37, 13);
            this.make.TabIndex = 2;
            this.make.Text = "Marka";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(55, 89);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(36, 13);
            this.model.TabIndex = 4;
            this.model.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "model", true));
            this.txtModel.Location = new System.Drawing.Point(92, 86);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(55, 128);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(27, 13);
            this.year.TabIndex = 6;
            this.year.Text = "Rok";
            // 
            // txtYear
            // 
            this.txtYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "year", true));
            this.txtYear.Location = new System.Drawing.Point(92, 125);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 5;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(55, 168);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(31, 13);
            this.color.TabIndex = 8;
            this.color.Text = "Kolor";
            // 
            // txtColor
            // 
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "color", true));
            this.txtColor.Location = new System.Drawing.Point(92, 165);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 7;
            this.txtColor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(WinFormDBEntity.car);
            // 
            // frmAddEdit2
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 256);
            this.Controls.Add(this.color);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.year);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.model);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.make);
            this.Controls.Add(this.txtxMake);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddEdit2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEdit2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtxMake;
        private System.Windows.Forms.Label make;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.BindingSource carBindingSource;
    }
}