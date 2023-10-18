namespace ListasyMenus
{
    partial class fmListasMenus
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnListas = new System.Windows.Forms.MenuStrip();
            this.ItArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.itSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.itAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.itAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.lCursos = new System.Windows.Forms.Label();
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.lAlumnos = new System.Windows.Forms.Label();
            this.lNuevo = new System.Windows.Forms.Label();
            this.tbAlumno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnListas.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnListas
            // 
            this.mnListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItArchivo,
            this.itAyuda});
            this.mnListas.Location = new System.Drawing.Point(0, 0);
            this.mnListas.Name = "mnListas";
            this.mnListas.Size = new System.Drawing.Size(800, 24);
            this.mnListas.TabIndex = 1;
            this.mnListas.Text = "menuStrip2";
            // 
            // ItArchivo
            // 
            this.ItArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itNuevo,
            this.itAbrir,
            this.itGuardar,
            this.itSalir});
            this.ItArchivo.Name = "ItArchivo";
            this.ItArchivo.Size = new System.Drawing.Size(60, 20);
            this.ItArchivo.Text = "A&rchivo";
            this.ItArchivo.Click += new System.EventHandler(this.ItArchivo_Click);
            // 
            // itAyuda
            // 
            this.itAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itAcercade});
            this.itAyuda.Name = "itAyuda";
            this.itAyuda.Size = new System.Drawing.Size(53, 20);
            this.itAyuda.Text = "Ayuda";
            // 
            // itSalir
            // 
            this.itSalir.Name = "itSalir";
            this.itSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.itSalir.Size = new System.Drawing.Size(180, 22);
            this.itSalir.Text = "Salir";
            this.itSalir.Click += new System.EventHandler(this.itSalir_Click);
            // 
            // itNuevo
            // 
            this.itNuevo.Image = global::ListasyMenus.Properties.Resources._new;
            this.itNuevo.Name = "itNuevo";
            this.itNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itNuevo.Size = new System.Drawing.Size(180, 22);
            this.itNuevo.Text = "Nuevo";
            // 
            // itAbrir
            // 
            this.itAbrir.Image = global::ListasyMenus.Properties.Resources.open;
            this.itAbrir.Name = "itAbrir";
            this.itAbrir.Size = new System.Drawing.Size(180, 22);
            this.itAbrir.Text = "A&brir";
            this.itAbrir.Click += new System.EventHandler(this.itAbrir_Click);
            // 
            // itGuardar
            // 
            this.itGuardar.Image = global::ListasyMenus.Properties.Resources.save;
            this.itGuardar.Name = "itGuardar";
            this.itGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.itGuardar.Size = new System.Drawing.Size(180, 22);
            this.itGuardar.Text = "Guardar";
            this.itGuardar.Click += new System.EventHandler(this.itGuardar_Click);
            // 
            // itAcercade
            // 
            this.itAcercade.Name = "itAcercade";
            this.itAcercade.Size = new System.Drawing.Size(180, 22);
            this.itAcercade.Text = "Acerca de";
            // 
            // lCursos
            // 
            this.lCursos.AutoSize = true;
            this.lCursos.Location = new System.Drawing.Point(9, 69);
            this.lCursos.Name = "lCursos";
            this.lCursos.Size = new System.Drawing.Size(39, 13);
            this.lCursos.TabIndex = 2;
            this.lCursos.Text = "Cursos";
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.ContextMenuStrip = this.contextMenuStrip1;
            this.lbAlumnos.FormattingEnabled = true;
            this.lbAlumnos.Location = new System.Drawing.Point(12, 129);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(120, 212);
            this.lbAlumnos.TabIndex = 3;
            // 
            // cbCursos
            // 
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B",
            "3A",
            "3B",
            "4A",
            "4B"});
            this.cbCursos.Location = new System.Drawing.Point(12, 85);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(121, 21);
            this.cbCursos.TabIndex = 4;
            this.cbCursos.TextChanged += new System.EventHandler(this.cbCursos_TextChanged);
            // 
            // lAlumnos
            // 
            this.lAlumnos.AutoSize = true;
            this.lAlumnos.Location = new System.Drawing.Point(12, 113);
            this.lAlumnos.Name = "lAlumnos";
            this.lAlumnos.Size = new System.Drawing.Size(47, 13);
            this.lAlumnos.TabIndex = 5;
            this.lAlumnos.Text = "Alumnos";
            // 
            // lNuevo
            // 
            this.lNuevo.AutoSize = true;
            this.lNuevo.Location = new System.Drawing.Point(12, 348);
            this.lNuevo.Name = "lNuevo";
            this.lNuevo.Size = new System.Drawing.Size(35, 13);
            this.lNuevo.TabIndex = 6;
            this.lNuevo.Text = "label1";
            // 
            // tbAlumno
            // 
            this.tbAlumno.Location = new System.Drawing.Point(12, 364);
            this.tbAlumno.Name = "tbAlumno";
            this.tbAlumno.Size = new System.Drawing.Size(100, 20);
            this.tbAlumno.TabIndex = 7;
            this.tbAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlumno_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 76);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // fmListasMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAlumno);
            this.Controls.Add(this.lNuevo);
            this.Controls.Add(this.lAlumnos);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.lbAlumnos);
            this.Controls.Add(this.lCursos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mnListas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmListasMenus";
            this.Text = "Listas y Menus";
            this.mnListas.ResumeLayout(false);
            this.mnListas.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip mnListas;
        private System.Windows.Forms.ToolStripMenuItem ItArchivo;
        private System.Windows.Forms.ToolStripMenuItem itNuevo;
        private System.Windows.Forms.ToolStripMenuItem itAbrir;
        private System.Windows.Forms.ToolStripMenuItem itGuardar;
        private System.Windows.Forms.ToolStripMenuItem itSalir;
        private System.Windows.Forms.ToolStripMenuItem itAyuda;
        private System.Windows.Forms.ToolStripMenuItem itAcercade;
        private System.Windows.Forms.Label lCursos;
        private System.Windows.Forms.ListBox lbAlumnos;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label lAlumnos;
        private System.Windows.Forms.Label lNuevo;
        private System.Windows.Forms.TextBox tbAlumno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

