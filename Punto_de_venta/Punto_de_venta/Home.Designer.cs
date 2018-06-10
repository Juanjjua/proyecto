namespace Punto_de_venta
{
    partial class Home
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_ventas = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 602);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.bt_ventas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Productos, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 602);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // bt_ventas
            // 
            this.bt_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_ventas.BackgroundImage = global::Punto_de_venta.Properties.Resources.sale;
            this.bt_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_ventas.ForeColor = System.Drawing.SystemColors.Menu;
            this.bt_ventas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_ventas.Location = new System.Drawing.Point(3, 3);
            this.bt_ventas.Name = "bt_ventas";
            this.bt_ventas.Size = new System.Drawing.Size(204, 114);
            this.bt_ventas.TabIndex = 0;
            this.bt_ventas.Text = "VENTAS";
            this.bt_ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ventas.UseVisualStyleBackColor = false;
            this.bt_ventas.Click += new System.EventHandler(this.bt_ventas_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Productos.ForeColor = System.Drawing.Color.White;
            this.btn_Productos.Image = global::Punto_de_venta.Properties.Resources.bodega;
            this.btn_Productos.Location = new System.Drawing.Point(3, 123);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(204, 114);
            this.btn_Productos.TabIndex = 1;
            this.btn_Productos.Text = "INVENTARIO";
            this.btn_Productos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Productos.UseVisualStyleBackColor = false;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(219, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 602);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Home";
            this.Text = "PUNTO DE VENTA";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_ventas;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}