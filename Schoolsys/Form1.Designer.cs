namespace Schoolsys
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuEstudiante = new FontAwesome.Sharp.IconMenuItem();
            this.registroDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEmpleado = new FontAwesome.Sharp.IconMenuItem();
            this.registroDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClases = new FontAwesome.Sharp.IconMenuItem();
            this.registrarClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAñoEscolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCalificaciones = new FontAwesome.Sharp.IconMenuItem();
            this.registrarCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCalificacioensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.reporteDeCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.mantenimientoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem9 = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.MenuTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEstudiante,
            this.MenuEmpleado,
            this.MenuClases,
            this.MenuCalificaciones,
            this.MenuReportes,
            this.MenuUsuarios,
            this.toolStripTextBox2,
            this.toolStripTextBox1,
            this.iconMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuEstudiante
            // 
            this.MenuEstudiante.AutoSize = false;
            this.MenuEstudiante.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuEstudiante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeEstudiantesToolStripMenuItem,
            this.listaDeEstudiantesToolStripMenuItem});
            this.MenuEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuEstudiante.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.MenuEstudiante.IconColor = System.Drawing.Color.LightCoral;
            this.MenuEstudiante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuEstudiante.IconSize = 50;
            this.MenuEstudiante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuEstudiante.Name = "MenuEstudiante";
            this.MenuEstudiante.Size = new System.Drawing.Size(122, 69);
            this.MenuEstudiante.Text = "Estudiantes";
            this.MenuEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registroDeEstudiantesToolStripMenuItem
            // 
            this.registroDeEstudiantesToolStripMenuItem.Name = "registroDeEstudiantesToolStripMenuItem";
            this.registroDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.registroDeEstudiantesToolStripMenuItem.Text = "Registro de estudiantes";
            this.registroDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.registroDeEstudiantesToolStripMenuItem_Click);
            // 
            // listaDeEstudiantesToolStripMenuItem
            // 
            this.listaDeEstudiantesToolStripMenuItem.Name = "listaDeEstudiantesToolStripMenuItem";
            this.listaDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.listaDeEstudiantesToolStripMenuItem.Text = "Lista de estudiantes";
            // 
            // MenuEmpleado
            // 
            this.MenuEmpleado.AutoSize = false;
            this.MenuEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuEmpleado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeEmpleadosToolStripMenuItem,
            this.verEmpleadosToolStripMenuItem});
            this.MenuEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuEmpleado.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.MenuEmpleado.IconColor = System.Drawing.Color.DarkCyan;
            this.MenuEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuEmpleado.IconSize = 50;
            this.MenuEmpleado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuEmpleado.Name = "MenuEmpleado";
            this.MenuEmpleado.Size = new System.Drawing.Size(122, 69);
            this.MenuEmpleado.Text = "Empleados";
            this.MenuEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registroDeEmpleadosToolStripMenuItem
            // 
            this.registroDeEmpleadosToolStripMenuItem.Name = "registroDeEmpleadosToolStripMenuItem";
            this.registroDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.registroDeEmpleadosToolStripMenuItem.Text = "Registro de Empleados";
            // 
            // verEmpleadosToolStripMenuItem
            // 
            this.verEmpleadosToolStripMenuItem.Name = "verEmpleadosToolStripMenuItem";
            this.verEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.verEmpleadosToolStripMenuItem.Text = "Ver Empleados";
            // 
            // MenuClases
            // 
            this.MenuClases.AutoSize = false;
            this.MenuClases.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuClases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClasesToolStripMenuItem,
            this.verClasesToolStripMenuItem,
            this.registrarGradoToolStripMenuItem,
            this.registrarAñoEscolarToolStripMenuItem});
            this.MenuClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuClases.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.MenuClases.IconColor = System.Drawing.Color.SteelBlue;
            this.MenuClases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClases.IconSize = 50;
            this.MenuClases.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClases.Name = "MenuClases";
            this.MenuClases.Size = new System.Drawing.Size(80, 69);
            this.MenuClases.Text = "Clases";
            this.MenuClases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarClasesToolStripMenuItem
            // 
            this.registrarClasesToolStripMenuItem.Name = "registrarClasesToolStripMenuItem";
            this.registrarClasesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.registrarClasesToolStripMenuItem.Text = "Registrar clases";
            // 
            // verClasesToolStripMenuItem
            // 
            this.verClasesToolStripMenuItem.Name = "verClasesToolStripMenuItem";
            this.verClasesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.verClasesToolStripMenuItem.Text = "Ver clases";
            this.verClasesToolStripMenuItem.Click += new System.EventHandler(this.verClasesToolStripMenuItem_Click);
            // 
            // registrarGradoToolStripMenuItem
            // 
            this.registrarGradoToolStripMenuItem.Name = "registrarGradoToolStripMenuItem";
            this.registrarGradoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.registrarGradoToolStripMenuItem.Text = "Registrar grado";
            this.registrarGradoToolStripMenuItem.Click += new System.EventHandler(this.registrarGradoToolStripMenuItem_Click);
            // 
            // registrarAñoEscolarToolStripMenuItem
            // 
            this.registrarAñoEscolarToolStripMenuItem.Name = "registrarAñoEscolarToolStripMenuItem";
            this.registrarAñoEscolarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.registrarAñoEscolarToolStripMenuItem.Text = "Registrar año escolar";
            this.registrarAñoEscolarToolStripMenuItem.Click += new System.EventHandler(this.registrarAñoEscolarToolStripMenuItem_Click);
            // 
            // MenuCalificaciones
            // 
            this.MenuCalificaciones.AutoSize = false;
            this.MenuCalificaciones.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuCalificaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCalificacionesToolStripMenuItem,
            this.verCalificacioensToolStripMenuItem});
            this.MenuCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCalificaciones.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.MenuCalificaciones.IconColor = System.Drawing.Color.Gold;
            this.MenuCalificaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCalificaciones.IconSize = 50;
            this.MenuCalificaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCalificaciones.Name = "MenuCalificaciones";
            this.MenuCalificaciones.Size = new System.Drawing.Size(85, 69);
            this.MenuCalificaciones.Text = "Calificaciones";
            this.MenuCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarCalificacionesToolStripMenuItem
            // 
            this.registrarCalificacionesToolStripMenuItem.Name = "registrarCalificacionesToolStripMenuItem";
            this.registrarCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.registrarCalificacionesToolStripMenuItem.Text = "Registrar calificaciones";
            // 
            // verCalificacioensToolStripMenuItem
            // 
            this.verCalificacioensToolStripMenuItem.Name = "verCalificacioensToolStripMenuItem";
            this.verCalificacioensToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.verCalificacioensToolStripMenuItem.Text = "Ver calificaciones";
            this.verCalificacioensToolStripMenuItem.Click += new System.EventHandler(this.verCalificacioensToolStripMenuItem_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeCalificacionesToolStripMenuItem,
            this.reporteDeEstudiantesToolStripMenuItem,
            this.reporteDeProfesoresToolStripMenuItem,
            this.reporteDeClasesToolStripMenuItem,
            this.reporteDeEmpleadosToolStripMenuItem});
            this.MenuReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 50;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(80, 69);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reporteDeCalificacionesToolStripMenuItem
            // 
            this.reporteDeCalificacionesToolStripMenuItem.Name = "reporteDeCalificacionesToolStripMenuItem";
            this.reporteDeCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.reporteDeCalificacionesToolStripMenuItem.Text = "Reporte de calificaciones";
            // 
            // reporteDeEstudiantesToolStripMenuItem
            // 
            this.reporteDeEstudiantesToolStripMenuItem.Name = "reporteDeEstudiantesToolStripMenuItem";
            this.reporteDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.reporteDeEstudiantesToolStripMenuItem.Text = "Reporte de estudiantes ";
            // 
            // reporteDeProfesoresToolStripMenuItem
            // 
            this.reporteDeProfesoresToolStripMenuItem.Name = "reporteDeProfesoresToolStripMenuItem";
            this.reporteDeProfesoresToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.reporteDeProfesoresToolStripMenuItem.Text = "Reporte de profesores";
            // 
            // reporteDeClasesToolStripMenuItem
            // 
            this.reporteDeClasesToolStripMenuItem.Name = "reporteDeClasesToolStripMenuItem";
            this.reporteDeClasesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.reporteDeClasesToolStripMenuItem.Text = "Reporte de clases";
            // 
            // reporteDeEmpleadosToolStripMenuItem
            // 
            this.reporteDeEmpleadosToolStripMenuItem.Name = "reporteDeEmpleadosToolStripMenuItem";
            this.reporteDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.reporteDeEmpleadosToolStripMenuItem.Text = "Reporte de empleados";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.AutoSize = false;
            this.MenuUsuarios.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeUsuariosToolStripMenuItem});
            this.MenuUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.MenuUsuarios.IconColor = System.Drawing.Color.Violet;
            this.MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuarios.IconSize = 50;
            this.MenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(80, 69);
            this.MenuUsuarios.Text = "Usuarios";
            this.MenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mantenimientoDeUsuariosToolStripMenuItem
            // 
            this.mantenimientoDeUsuariosToolStripMenuItem.Name = "mantenimientoDeUsuariosToolStripMenuItem";
            this.mantenimientoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.mantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de usuarios";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 69);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 69);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.AutoSize = false;
            this.iconMenuItem3.BackColor = System.Drawing.Color.Gainsboro;
            this.iconMenuItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconMenuItem3.IconColor = System.Drawing.Color.DarkGray;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 50;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem3.Text = "Acerca de";
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.DimGray;
            this.MenuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem9});
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(800, 48);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // iconMenuItem9
            // 
            this.iconMenuItem9.BackColor = System.Drawing.Color.DimGray;
            this.iconMenuItem9.ForeColor = System.Drawing.SystemColors.Control;
            this.iconMenuItem9.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconMenuItem9.IconColor = System.Drawing.Color.Tomato;
            this.iconMenuItem9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem9.IconSize = 39;
            this.iconMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem9.Name = "iconMenuItem9";
            this.iconMenuItem9.Size = new System.Drawing.Size(80, 44);
            this.iconMenuItem9.Text = "Salir";
            this.iconMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema Escolar";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 121);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(800, 140);
            this.contenedor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MenuTitulo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Escolar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuTitulo.ResumeLayout(false);
            this.MenuTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuEstudiante;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuEmpleado;
        private FontAwesome.Sharp.IconMenuItem MenuClases;
        private FontAwesome.Sharp.IconMenuItem MenuCalificaciones;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem registroDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClasesToolStripMenuItem;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.ToolStripMenuItem registrarClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCalificacioensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAñoEscolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarGradoToolStripMenuItem;
    }
}

