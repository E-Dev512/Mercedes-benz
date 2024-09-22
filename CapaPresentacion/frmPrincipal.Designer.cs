namespace CapaPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pExistencias = new System.Windows.Forms.Panel();
            this.btnSESalidas = new System.Windows.Forms.Button();
            this.btnSEEntradas = new System.Windows.Forms.Button();
            this.btnExistencias = new System.Windows.Forms.Button();
            this.pProducto = new System.Windows.Forms.Panel();
            this.btnSPProveedor = new System.Windows.Forms.Button();
            this.btnSPProducto = new System.Windows.Forms.Button();
            this.btnSPCategoria = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pDesarrollo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.roundPictureBox1 = new CapaPresentacion.RoundPictureBox();
            this.pMenu.SuspendLayout();
            this.pExistencias.SuspendLayout();
            this.pProducto.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.AutoScroll = true;
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pMenu.Controls.Add(this.pExistencias);
            this.pMenu.Controls.Add(this.btnExistencias);
            this.pMenu.Controls.Add(this.pProducto);
            this.pMenu.Controls.Add(this.btnProductos);
            this.pMenu.Controls.Add(this.btnClientes);
            this.pMenu.Controls.Add(this.btnDashboard);
            this.pMenu.Controls.Add(this.pInfo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(306, 1080);
            this.pMenu.TabIndex = 3;
            // 
            // pExistencias
            // 
            this.pExistencias.AutoSize = true;
            this.pExistencias.BackColor = System.Drawing.Color.Transparent;
            this.pExistencias.Controls.Add(this.btnSESalidas);
            this.pExistencias.Controls.Add(this.btnSEEntradas);
            this.pExistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.pExistencias.Location = new System.Drawing.Point(0, 516);
            this.pExistencias.Name = "pExistencias";
            this.pExistencias.Size = new System.Drawing.Size(306, 88);
            this.pExistencias.TabIndex = 9;
            // 
            // btnSESalidas
            // 
            this.btnSESalidas.BackColor = System.Drawing.Color.Transparent;
            this.btnSESalidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSESalidas.FlatAppearance.BorderSize = 0;
            this.btnSESalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnSESalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSESalidas.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSESalidas.ForeColor = System.Drawing.Color.White;
            this.btnSESalidas.Location = new System.Drawing.Point(0, 44);
            this.btnSESalidas.Name = "btnSESalidas";
            this.btnSESalidas.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSESalidas.Size = new System.Drawing.Size(306, 44);
            this.btnSESalidas.TabIndex = 1;
            this.btnSESalidas.Text = "Salidas/Facturacion";
            this.btnSESalidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSESalidas.UseVisualStyleBackColor = false;
            this.btnSESalidas.Click += new System.EventHandler(this.btnSESalidas_Click);
            // 
            // btnSEEntradas
            // 
            this.btnSEEntradas.BackColor = System.Drawing.Color.Transparent;
            this.btnSEEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSEEntradas.FlatAppearance.BorderSize = 0;
            this.btnSEEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnSEEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEEntradas.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSEEntradas.ForeColor = System.Drawing.Color.White;
            this.btnSEEntradas.Location = new System.Drawing.Point(0, 0);
            this.btnSEEntradas.Name = "btnSEEntradas";
            this.btnSEEntradas.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSEEntradas.Size = new System.Drawing.Size(306, 44);
            this.btnSEEntradas.TabIndex = 0;
            this.btnSEEntradas.Text = "Entradas";
            this.btnSEEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEEntradas.UseVisualStyleBackColor = false;
            this.btnSEEntradas.Click += new System.EventHandler(this.btnSEEntradas_Click);
            // 
            // btnExistencias
            // 
            this.btnExistencias.BackColor = System.Drawing.Color.Transparent;
            this.btnExistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExistencias.FlatAppearance.BorderSize = 0;
            this.btnExistencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnExistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistencias.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExistencias.ForeColor = System.Drawing.Color.White;
            this.btnExistencias.Location = new System.Drawing.Point(0, 470);
            this.btnExistencias.Name = "btnExistencias";
            this.btnExistencias.Size = new System.Drawing.Size(306, 46);
            this.btnExistencias.TabIndex = 8;
            this.btnExistencias.Text = "Gestión de Existencias";
            this.btnExistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExistencias.UseVisualStyleBackColor = false;
            this.btnExistencias.Click += new System.EventHandler(this.btnExistencias_Click);
            // 
            // pProducto
            // 
            this.pProducto.AutoSize = true;
            this.pProducto.BackColor = System.Drawing.Color.Transparent;
            this.pProducto.Controls.Add(this.btnSPProveedor);
            this.pProducto.Controls.Add(this.btnSPProducto);
            this.pProducto.Controls.Add(this.btnSPCategoria);
            this.pProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pProducto.Location = new System.Drawing.Point(0, 338);
            this.pProducto.Name = "pProducto";
            this.pProducto.Size = new System.Drawing.Size(306, 132);
            this.pProducto.TabIndex = 7;
            // 
            // btnSPProveedor
            // 
            this.btnSPProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnSPProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSPProveedor.FlatAppearance.BorderSize = 0;
            this.btnSPProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnSPProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPProveedor.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSPProveedor.ForeColor = System.Drawing.Color.White;
            this.btnSPProveedor.Location = new System.Drawing.Point(0, 88);
            this.btnSPProveedor.Name = "btnSPProveedor";
            this.btnSPProveedor.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSPProveedor.Size = new System.Drawing.Size(306, 44);
            this.btnSPProveedor.TabIndex = 2;
            this.btnSPProveedor.Text = "Proveedores";
            this.btnSPProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSPProveedor.UseVisualStyleBackColor = false;
            this.btnSPProveedor.Click += new System.EventHandler(this.btnSPProveedor_Click);
            // 
            // btnSPProducto
            // 
            this.btnSPProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnSPProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSPProducto.FlatAppearance.BorderSize = 0;
            this.btnSPProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnSPProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPProducto.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSPProducto.ForeColor = System.Drawing.Color.White;
            this.btnSPProducto.Location = new System.Drawing.Point(0, 44);
            this.btnSPProducto.Name = "btnSPProducto";
            this.btnSPProducto.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSPProducto.Size = new System.Drawing.Size(306, 44);
            this.btnSPProducto.TabIndex = 1;
            this.btnSPProducto.Text = "Productos";
            this.btnSPProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSPProducto.UseVisualStyleBackColor = false;
            this.btnSPProducto.Click += new System.EventHandler(this.btnSPProducto_Click);
            // 
            // btnSPCategoria
            // 
            this.btnSPCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnSPCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSPCategoria.FlatAppearance.BorderSize = 0;
            this.btnSPCategoria.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnSPCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnSPCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPCategoria.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSPCategoria.ForeColor = System.Drawing.Color.White;
            this.btnSPCategoria.Location = new System.Drawing.Point(0, 0);
            this.btnSPCategoria.Name = "btnSPCategoria";
            this.btnSPCategoria.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSPCategoria.Size = new System.Drawing.Size(306, 44);
            this.btnSPCategoria.TabIndex = 0;
            this.btnSPCategoria.Text = "Categorias";
            this.btnSPCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSPCategoria.UseVisualStyleBackColor = false;
            this.btnSPCategoria.Click += new System.EventHandler(this.btnSPCategoria_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 292);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(306, 46);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Gestión de Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 246);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(306, 46);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 200);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(306, 46);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.Color.Transparent;
            this.pInfo.Controls.Add(this.label4);
            this.pInfo.Controls.Add(this.roundPictureBox1);
            this.pInfo.Controls.Add(this.label2);
            this.pInfo.Controls.Add(this.label3);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInfo.Location = new System.Drawing.Point(0, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(306, 200);
            this.pInfo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Garamond", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sistema Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hola, Yonatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Conectado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(306, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1614, 61);
            this.panel2.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1795, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 53);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1444, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1467, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yonatan";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pDesarrollo
            // 
            this.pDesarrollo.BackColor = System.Drawing.Color.White;
            this.pDesarrollo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDesarrollo.Location = new System.Drawing.Point(306, 118);
            this.pDesarrollo.Name = "pDesarrollo";
            this.pDesarrollo.Size = new System.Drawing.Size(1614, 962);
            this.pDesarrollo.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(306, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1614, 57);
            this.panel1.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(6, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 30);
            this.lblTitulo.TabIndex = 4;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.e_user;
            this.roundPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundPictureBox1.Location = new System.Drawing.Point(24, 96);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(62, 62);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roundPictureBox1.TabIndex = 4;
            this.roundPictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pDesarrollo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            this.pExistencias.ResumeLayout(false);
            this.pProducto.ResumeLayout(false);
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pExistencias;
        private System.Windows.Forms.Button btnSESalidas;
        private System.Windows.Forms.Button btnSEEntradas;
        private System.Windows.Forms.Button btnExistencias;
        private System.Windows.Forms.Panel pProducto;
        private System.Windows.Forms.Button btnSPProveedor;
        private System.Windows.Forms.Button btnSPProducto;
        private System.Windows.Forms.Button btnSPCategoria;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pDesarrollo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
    }
}