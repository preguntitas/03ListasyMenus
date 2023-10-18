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
            this.itSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.itAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.lCursos = new System.Windows.Forms.Label();
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.lAlumnos = new System.Windows.Forms.Label();
            this.laNuevo = new System.Windows.Forms.Label();
            this.tbAlumno = new System.Windows.Forms.TextBox();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.ckOrdenar = new System.Windows.Forms.CheckBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAbajo = new System.Windows.Forms.Button();
            this.btArriba = new System.Windows.Forms.Button();
            this.itNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.itAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btMostrarTodos = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.ckActualizar = new System.Windows.Forms.CheckBox();
            this.pnActualiza = new System.Windows.Forms.Panel();
            this.mnListas.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pnActualiza.SuspendLayout();
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
            // 
            // itSalir
            // 
            this.itSalir.Name = "itSalir";
            this.itSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.itSalir.Size = new System.Drawing.Size(180, 22);
            this.itSalir.Text = "Salir";
            this.itSalir.Click += new System.EventHandler(this.itSalir_Click);
            // 
            // itAyuda
            // 
            this.itAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itAcercade});
            this.itAyuda.Name = "itAyuda";
            this.itAyuda.Size = new System.Drawing.Size(53, 20);
            this.itAyuda.Text = "Ayuda";
            // 
            // itAcercade
            // 
            this.itAcercade.Name = "itAcercade";
            this.itAcercade.Size = new System.Drawing.Size(126, 22);
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
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.itAbrir_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.itNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.itGuardar_Click);
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
            // laNuevo
            // 
            this.laNuevo.AutoSize = true;
            this.laNuevo.Enabled = false;
            this.laNuevo.Location = new System.Drawing.Point(12, 348);
            this.laNuevo.Name = "laNuevo";
            this.laNuevo.Size = new System.Drawing.Size(39, 13);
            this.laNuevo.TabIndex = 6;
            this.laNuevo.Text = "Nuevo";
            // 
            // tbAlumno
            // 
            this.tbAlumno.Enabled = false;
            this.tbAlumno.Location = new System.Drawing.Point(12, 364);
            this.tbAlumno.Name = "tbAlumno";
            this.tbAlumno.Size = new System.Drawing.Size(100, 20);
            this.tbAlumno.TabIndex = 7;
            this.tbAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlumno_KeyPress);
            // 
            // btAnyadir
            // 
            this.btAnyadir.Location = new System.Drawing.Point(14, 14);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(75, 23);
            this.btAnyadir.TabIndex = 0;
            this.btAnyadir.Text = "Añadir";
            this.btAnyadir.UseVisualStyleBackColor = true;
            this.btAnyadir.Click += new System.EventHandler(this.btAnyadir_Click);
            // 
            // ckOrdenar
            // 
            this.ckOrdenar.AutoSize = true;
            this.ckOrdenar.Location = new System.Drawing.Point(266, 186);
            this.ckOrdenar.Name = "ckOrdenar";
            this.ckOrdenar.Size = new System.Drawing.Size(129, 17);
            this.ckOrdenar.TabIndex = 10;
            this.ckOrdenar.Text = "Ordena Lista Alumnos";
            this.ckOrdenar.UseVisualStyleBackColor = true;
            this.ckOrdenar.CheckedChanged += new System.EventHandler(this.ckOrdenar_CheckedChanged);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(14, 48);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 1;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(14, 78);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 23);
            this.btInsertar.TabIndex = 2;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(14, 108);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btAbajo
            // 
            this.btAbajo.Image = global::ListasyMenus.Properties.Resources.abajo1;
            this.btAbajo.Location = new System.Drawing.Point(181, 240);
            this.btAbajo.Name = "btAbajo";
            this.btAbajo.Size = new System.Drawing.Size(64, 75);
            this.btAbajo.TabIndex = 12;
            this.btAbajo.UseVisualStyleBackColor = true;
            this.btAbajo.Click += new System.EventHandler(this.btAbajo_Click);
            // 
            // btArriba
            // 
            this.btArriba.Image = global::ListasyMenus.Properties.Resources.arriba1;
            this.btArriba.Location = new System.Drawing.Point(181, 128);
            this.btArriba.Name = "btArriba";
            this.btArriba.Size = new System.Drawing.Size(64, 75);
            this.btArriba.TabIndex = 11;
            this.btArriba.UseVisualStyleBackColor = true;
            this.btArriba.Click += new System.EventHandler(this.btArriba_Click);
            // 
            // itNuevo
            // 
            this.itNuevo.Image = global::ListasyMenus.Properties.Resources._new;
            this.itNuevo.Name = "itNuevo";
            this.itNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itNuevo.Size = new System.Drawing.Size(180, 22);
            this.itNuevo.Text = "Nuevo";
            this.itNuevo.Click += new System.EventHandler(this.itNuevo_Click);
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
            // btMostrarTodos
            // 
            this.btMostrarTodos.Location = new System.Drawing.Point(181, 348);
            this.btMostrarTodos.Name = "btMostrarTodos";
            this.btMostrarTodos.Size = new System.Drawing.Size(97, 23);
            this.btMostrarTodos.TabIndex = 13;
            this.btMostrarTodos.Text = "Mostrar Todos";
            this.btMostrarTodos.UseVisualStyleBackColor = true;
            this.btMostrarTodos.Click += new System.EventHandler(this.btMostrarTodos_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(297, 348);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 14;
            this.btMostrar.Text = "Mostrar Mas";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // ckActualizar
            // 
            this.ckActualizar.AutoSize = true;
            this.ckActualizar.BackColor = System.Drawing.Color.Red;
            this.ckActualizar.Location = new System.Drawing.Point(583, 344);
            this.ckActualizar.Name = "ckActualizar";
            this.ckActualizar.Size = new System.Drawing.Size(72, 17);
            this.ckActualizar.TabIndex = 15;
            this.ckActualizar.Text = "Actualizar";
            this.ckActualizar.UseVisualStyleBackColor = false;
            this.ckActualizar.CheckedChanged += new System.EventHandler(this.ckActualizar_CheckedChanged);
            // 
            // pnActualiza
            // 
            this.pnActualiza.Controls.Add(this.btBuscar);
            this.pnActualiza.Controls.Add(this.btAnyadir);
            this.pnActualiza.Controls.Add(this.btInsertar);
            this.pnActualiza.Controls.Add(this.btBorrar);
            this.pnActualiza.Location = new System.Drawing.Point(572, 141);
            this.pnActualiza.Name = "pnActualiza";
            this.pnActualiza.Size = new System.Drawing.Size(104, 144);
            this.pnActualiza.TabIndex = 16;
            this.pnActualiza.Visible = false;
            // 
            // fmListasMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnActualiza);
            this.Controls.Add(this.ckActualizar);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btMostrarTodos);
            this.Controls.Add(this.btAbajo);
            this.Controls.Add(this.btArriba);
            this.Controls.Add(this.ckOrdenar);
            this.Controls.Add(this.tbAlumno);
            this.Controls.Add(this.laNuevo);
            this.Controls.Add(this.lAlumnos);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.lbAlumnos);
            this.Controls.Add(this.lCursos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mnListas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmListasMenus";
            this.Text = "Listas y Menus";
            this.Load += new System.EventHandler(this.fmListasMenus_Load);
            this.mnListas.ResumeLayout(false);
            this.mnListas.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnActualiza.ResumeLayout(false);
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
        private System.Windows.Forms.Label laNuevo;
        private System.Windows.Forms.TextBox tbAlumno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btAnyadir;
        private System.Windows.Forms.CheckBox ckOrdenar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btArriba;
        private System.Windows.Forms.Button btAbajo;
        private System.Windows.Forms.Button btMostrarTodos;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.CheckBox ckActualizar;
        private System.Windows.Forms.Panel pnActualiza;
    }
}

