﻿namespace CapaPresentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.data = new System.Windows.Forms.DataGridView();
            this.estado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.BtnIngresar.FlatAppearance.BorderSize = 2;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.BtnIngresar.ForeColor = System.Drawing.Color.Black;
            this.BtnIngresar.Location = new System.Drawing.Point(299, 229);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(368, 40);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, -98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistema de Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 292);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(18, 10);
            this.data.TabIndex = 10;
            this.data.Visible = false;
            // 
            // estado
            // 
            this.estado.AllowUserToAddRows = false;
            this.estado.AllowUserToDeleteRows = false;
            this.estado.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estado.Location = new System.Drawing.Point(36, 292);
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.RowTemplate.Height = 24;
            this.estado.Size = new System.Drawing.Size(18, 10);
            this.estado.TabIndex = 12;
            this.estado.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 330);
            this.panel1.TabIndex = 137;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 137;
            this.label5.Text = "Version: 1.OO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(64, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IceCreamPartySolid", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 48);
            this.label2.TabIndex = 137;
            this.label2.Text = "Minimarket \r\nLos Chombo\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.bloquear;
            this.pictureBox4.Location = new System.Drawing.Point(290, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 139;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.hombre;
            this.pictureBox3.Location = new System.Drawing.Point(290, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 138;
            this.pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(717, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 33);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 141;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(664, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(47, 33);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 140;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic);
            this.TxtUsuario.Location = new System.Drawing.Point(336, 96);
            this.TxtUsuario.MaxLength = 30;
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(342, 35);
            this.TxtUsuario.TabIndex = 142;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtUsuario_MouseClick);
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter_1);
            this.TxtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave_1);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPassword.Location = new System.Drawing.Point(336, 157);
            this.TxtPassword.MaxLength = 20;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPassword.Size = new System.Drawing.Size(342, 34);
            this.TxtPassword.TabIndex = 143;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.Click += new System.EventHandler(this.TxtPassword_Click);
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter_1);
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(756, 330);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Enter += new System.EventHandler(this.frmLogin_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridView estado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}