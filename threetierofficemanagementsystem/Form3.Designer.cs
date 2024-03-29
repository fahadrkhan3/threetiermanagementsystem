namespace threetierofficemanagementsystem
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnviewall = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtcsince = new System.Windows.Forms.TextBox();
            this.csince = new System.Windows.Forms.Label();
            this.txtclname = new System.Windows.Forms.TextBox();
            this.txtcfname = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.clname = new System.Windows.Forms.Label();
            this.cfname = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(617, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 202);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnviewall
            // 
            this.btnviewall.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnviewall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewall.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnviewall.Location = new System.Drawing.Point(617, 111);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(75, 35);
            this.btnviewall.TabIndex = 32;
            this.btnviewall.Text = "View All";
            this.btnviewall.UseVisualStyleBackColor = false;
            this.btnviewall.Click += new System.EventHandler(this.btnviewall_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnclear.Location = new System.Drawing.Point(327, 312);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 35);
            this.btnclear.TabIndex = 31;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnsearch.Location = new System.Drawing.Point(509, 312);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 35);
            this.btnsearch.TabIndex = 30;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnupdate.Location = new System.Drawing.Point(509, 246);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 35);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btndelete.Location = new System.Drawing.Point(509, 180);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 35);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnsave.Location = new System.Drawing.Point(509, 111);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 35);
            this.btnsave.TabIndex = 27;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcsince
            // 
            this.txtcsince.Location = new System.Drawing.Point(242, 261);
            this.txtcsince.Name = "txtcsince";
            this.txtcsince.Size = new System.Drawing.Size(160, 20);
            this.txtcsince.TabIndex = 26;
            // 
            // csince
            // 
            this.csince.AutoSize = true;
            this.csince.BackColor = System.Drawing.SystemColors.ControlText;
            this.csince.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csince.ForeColor = System.Drawing.SystemColors.Desktop;
            this.csince.Location = new System.Drawing.Point(94, 262);
            this.csince.Name = "csince";
            this.csince.Size = new System.Drawing.Size(60, 19);
            this.csince.TabIndex = 25;
            this.csince.Text = "C Since";
            // 
            // txtclname
            // 
            this.txtclname.Location = new System.Drawing.Point(242, 222);
            this.txtclname.Name = "txtclname";
            this.txtclname.Size = new System.Drawing.Size(160, 20);
            this.txtclname.TabIndex = 24;
            // 
            // txtcfname
            // 
            this.txtcfname.Location = new System.Drawing.Point(242, 179);
            this.txtcfname.Name = "txtcfname";
            this.txtcfname.Size = new System.Drawing.Size(160, 20);
            this.txtcfname.TabIndex = 23;
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(242, 138);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(160, 20);
            this.txtcid.TabIndex = 22;
            // 
            // clname
            // 
            this.clname.AutoSize = true;
            this.clname.BackColor = System.Drawing.SystemColors.ControlText;
            this.clname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clname.Location = new System.Drawing.Point(94, 223);
            this.clname.Name = "clname";
            this.clname.Size = new System.Drawing.Size(70, 19);
            this.clname.TabIndex = 21;
            this.clname.Text = "CLName";
            // 
            // cfname
            // 
            this.cfname.AutoSize = true;
            this.cfname.BackColor = System.Drawing.SystemColors.ControlText;
            this.cfname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cfname.Location = new System.Drawing.Point(94, 180);
            this.cfname.Name = "cfname";
            this.cfname.Size = new System.Drawing.Size(69, 19);
            this.cfname.TabIndex = 20;
            this.cfname.Text = "CFName";
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.BackColor = System.Drawing.SystemColors.ControlText;
            this.cid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cid.Location = new System.Drawing.Point(94, 139);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(38, 19);
            this.cid.TabIndex = 19;
            this.cid.Text = "CID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(226, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "CUSTOMER TABLE";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1230, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtcsince);
            this.Controls.Add(this.csince);
            this.Controls.Add(this.txtclname);
            this.Controls.Add(this.txtcfname);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.clname);
            this.Controls.Add(this.cfname);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnviewall;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtcsince;
        private System.Windows.Forms.Label csince;
        private System.Windows.Forms.TextBox txtclname;
        private System.Windows.Forms.TextBox txtcfname;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label clname;
        private System.Windows.Forms.Label cfname;
        private System.Windows.Forms.Label cid;
        private System.Windows.Forms.Label label1;
    }
}