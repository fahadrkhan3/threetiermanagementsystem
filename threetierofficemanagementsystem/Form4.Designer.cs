namespace threetierofficemanagementsystem
{
    partial class Form4
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
            this.txtssince = new System.Windows.Forms.TextBox();
            this.ssince = new System.Windows.Forms.Label();
            this.txtslname = new System.Windows.Forms.TextBox();
            this.txtsfname = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.slname = new System.Windows.Forms.Label();
            this.sfname = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(618, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 202);
            this.dataGridView1.TabIndex = 49;
            // 
            // btnviewall
            // 
            this.btnviewall.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnviewall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewall.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnviewall.Location = new System.Drawing.Point(618, 118);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(75, 35);
            this.btnviewall.TabIndex = 48;
            this.btnviewall.Text = "View All";
            this.btnviewall.UseVisualStyleBackColor = false;
            this.btnviewall.Click += new System.EventHandler(this.btnviewall_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnclear.Location = new System.Drawing.Point(328, 319);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 35);
            this.btnclear.TabIndex = 47;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnsearch.Location = new System.Drawing.Point(510, 319);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 35);
            this.btnsearch.TabIndex = 46;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnupdate.Location = new System.Drawing.Point(510, 253);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 35);
            this.btnupdate.TabIndex = 45;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btndelete.Location = new System.Drawing.Point(510, 187);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 35);
            this.btndelete.TabIndex = 44;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnsave.Location = new System.Drawing.Point(510, 118);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 35);
            this.btnsave.TabIndex = 43;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtssince
            // 
            this.txtssince.Location = new System.Drawing.Point(243, 268);
            this.txtssince.Name = "txtssince";
            this.txtssince.Size = new System.Drawing.Size(160, 20);
            this.txtssince.TabIndex = 42;
            // 
            // ssince
            // 
            this.ssince.AutoSize = true;
            this.ssince.BackColor = System.Drawing.SystemColors.ControlText;
            this.ssince.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssince.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ssince.Location = new System.Drawing.Point(95, 269);
            this.ssince.Name = "ssince";
            this.ssince.Size = new System.Drawing.Size(58, 19);
            this.ssince.TabIndex = 41;
            this.ssince.Text = "S Since";
            // 
            // txtslname
            // 
            this.txtslname.Location = new System.Drawing.Point(243, 229);
            this.txtslname.Name = "txtslname";
            this.txtslname.Size = new System.Drawing.Size(160, 20);
            this.txtslname.TabIndex = 40;
            // 
            // txtsfname
            // 
            this.txtsfname.Location = new System.Drawing.Point(243, 186);
            this.txtsfname.Name = "txtsfname";
            this.txtsfname.Size = new System.Drawing.Size(160, 20);
            this.txtsfname.TabIndex = 39;
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(243, 145);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(160, 20);
            this.txtsid.TabIndex = 38;
            this.txtsid.TextChanged += new System.EventHandler(this.txtsid_TextChanged);
            // 
            // slname
            // 
            this.slname.AutoSize = true;
            this.slname.BackColor = System.Drawing.SystemColors.ControlText;
            this.slname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.slname.Location = new System.Drawing.Point(95, 230);
            this.slname.Name = "slname";
            this.slname.Size = new System.Drawing.Size(68, 19);
            this.slname.TabIndex = 37;
            this.slname.Text = "SLName";
            // 
            // sfname
            // 
            this.sfname.AutoSize = true;
            this.sfname.BackColor = System.Drawing.SystemColors.ControlText;
            this.sfname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sfname.Location = new System.Drawing.Point(95, 187);
            this.sfname.Name = "sfname";
            this.sfname.Size = new System.Drawing.Size(67, 19);
            this.sfname.TabIndex = 36;
            this.sfname.Text = "SFName";
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.BackColor = System.Drawing.SystemColors.ControlText;
            this.sid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sid.Location = new System.Drawing.Point(95, 146);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(36, 19);
            this.sid.TabIndex = 35;
            this.sid.Text = "SID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(227, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "SUPPLIER TABLE";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtssince);
            this.Controls.Add(this.ssince);
            this.Controls.Add(this.txtslname);
            this.Controls.Add(this.txtsfname);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.slname);
            this.Controls.Add(this.sfname);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
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
        private System.Windows.Forms.TextBox txtssince;
        private System.Windows.Forms.Label ssince;
        private System.Windows.Forms.TextBox txtslname;
        private System.Windows.Forms.TextBox txtsfname;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.Label slname;
        private System.Windows.Forms.Label sfname;
        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.Label label1;
    }
}