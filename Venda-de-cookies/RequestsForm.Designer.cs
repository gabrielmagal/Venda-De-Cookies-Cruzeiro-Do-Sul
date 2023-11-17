namespace Venda_de_cookies
{
    partial class RequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestsForm));
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.btnClose = new ReaLTaiizor.Controls.ForeverButton();
            this.btnUpdateListRequests = new ReaLTaiizor.Controls.ForeverButton();
            this.btnRequests = new ReaLTaiizor.Controls.ForeverButton();
            this.ltvRequests = new ReaLTaiizor.Controls.PoisonListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.themeForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.btnClose);
            this.themeForm1.Controls.Add(this.btnUpdateListRequests);
            this.themeForm1.Controls.Add(this.btnRequests);
            this.themeForm1.Controls.Add(this.ltvRequests);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = global::Venda_de_cookies.Properties.Resources.vecteezy_user_icon_design_9267561_85;
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(886, 676);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Cupcake Service - Pedidos";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.Location = new System.Drawing.Point(828, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rounded = false;
            this.btnClose.Size = new System.Drawing.Size(46, 40);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateListRequests
            // 
            this.btnUpdateListRequests.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateListRequests.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateListRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateListRequests.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateListRequests.Location = new System.Drawing.Point(445, 578);
            this.btnUpdateListRequests.Name = "btnUpdateListRequests";
            this.btnUpdateListRequests.Rounded = false;
            this.btnUpdateListRequests.Size = new System.Drawing.Size(240, 40);
            this.btnUpdateListRequests.TabIndex = 1;
            this.btnUpdateListRequests.Text = "Atualizar Lista de Pedidos";
            this.btnUpdateListRequests.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnUpdateListRequests.Click += new System.EventHandler(this.btnUpdateListRequests_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.BackColor = System.Drawing.Color.Transparent;
            this.btnRequests.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequests.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRequests.Location = new System.Drawing.Point(201, 578);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Rounded = false;
            this.btnRequests.Size = new System.Drawing.Size(240, 40);
            this.btnRequests.TabIndex = 0;
            this.btnRequests.Text = "Novo Pedido";
            this.btnRequests.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // ltvRequests
            // 
            this.ltvRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ltvRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ltvRequests.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ltvRequests.FullRowSelect = true;
            this.ltvRequests.Location = new System.Drawing.Point(104, 94);
            this.ltvRequests.Name = "ltvRequests";
            this.ltvRequests.OwnerDraw = true;
            this.ltvRequests.Size = new System.Drawing.Size(679, 478);
            this.ltvRequests.TabIndex = 1;
            this.ltvRequests.UseCompatibleStateImageBehavior = false;
            this.ltvRequests.UseSelectable = true;
            this.ltvRequests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID - NOME - VALOR";
            this.columnHeader1.Width = 750;
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 676);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "RequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cupcake Service - Pedidos";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.PoisonListView ltvRequests;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private ReaLTaiizor.Controls.ForeverButton btnUpdateListRequests;
        private ReaLTaiizor.Controls.ForeverButton btnRequests;
        private ReaLTaiizor.Controls.ForeverButton btnClose;
    }
}