namespace SchoolSystem
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuEstudiante = new FontAwesome.Sharp.IconMenuItem();
            this.MenuEmpleado = new FontAwesome.Sharp.IconMenuItem();
            this.MenuClases = new FontAwesome.Sharp.IconMenuItem();
            this.registrarClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAñoEscolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCalificaciones = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.reporteDeCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(861, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 33);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(861, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(156, 30);
            this.toolStripLabel1.Text = "Sistema Escolar";
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 58);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 73);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuEstudiante
            // 
            this.MenuEstudiante.AutoSize = false;
            this.MenuEstudiante.BackColor = System.Drawing.Color.Gainsboro;
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
            this.MenuEstudiante.Click += new System.EventHandler(this.MenuEstudiante_Click);
            // 
            // MenuEmpleado
            // 
            this.MenuEmpleado.AutoSize = false;
            this.MenuEmpleado.BackColor = System.Drawing.Color.Gainsboro;
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
            this.MenuEmpleado.Click += new System.EventHandler(this.MenuEmpleado_Click);
            // 
            // MenuClases
            // 
            this.MenuClases.AutoSize = false;
            this.MenuClases.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuClases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClasesToolStripMenuItem,
            this.registrarGradoToolStripMenuItem,
            this.registrarAñoEscolarToolStripMenuItem});
            this.MenuClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuClases.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.MenuClases.IconColor = System.Drawing.Color.SteelBlue;
            this.MenuClases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClases.IconSize = 50;
            this.MenuClases.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClases.Name = "MenuClases";
            this.MenuClases.Size = new System.Drawing.Size(122, 69);
            this.MenuClases.Text = "Clases";
            this.MenuClases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarClasesToolStripMenuItem
            // 
            this.registrarClasesToolStripMenuItem.Name = "registrarClasesToolStripMenuItem";
            this.registrarClasesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registrarClasesToolStripMenuItem.Text = "Mantenimiento Clases";
            this.registrarClasesToolStripMenuItem.Click += new System.EventHandler(this.registrarClasesToolStripMenuItem_Click);
            // 
            // registrarGradoToolStripMenuItem
            // 
            this.registrarGradoToolStripMenuItem.Name = "registrarGradoToolStripMenuItem";
            this.registrarGradoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registrarGradoToolStripMenuItem.Text = "Mant, grado";
            this.registrarGradoToolStripMenuItem.Click += new System.EventHandler(this.registrarGradoToolStripMenuItem_Click);
            // 
            // registrarAñoEscolarToolStripMenuItem
            // 
            this.registrarAñoEscolarToolStripMenuItem.Name = "registrarAñoEscolarToolStripMenuItem";
            this.registrarAñoEscolarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registrarAñoEscolarToolStripMenuItem.Text = "Mant. año escolar";
            this.registrarAñoEscolarToolStripMenuItem.Click += new System.EventHandler(this.registrarAñoEscolarToolStripMenuItem_Click);
            // 
            // MenuCalificaciones
            // 
            this.MenuCalificaciones.AutoSize = false;
            this.MenuCalificaciones.BackColor = System.Drawing.Color.Gainsboro;
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
            this.MenuCalificaciones.Click += new System.EventHandler(this.MenuCalificaciones_Click);
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
            this.MenuUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.MenuUsuarios.IconColor = System.Drawing.Color.Violet;
            this.MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuarios.IconSize = 50;
            this.MenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(122, 69);
            this.MenuUsuarios.Text = "Usuarios";
            this.MenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 499);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sistema de escuela";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuEstudiante;
        private FontAwesome.Sharp.IconMenuItem MenuEmpleado;
        private FontAwesome.Sharp.IconMenuItem MenuClases;
        private System.Windows.Forms.ToolStripMenuItem registrarClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarGradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAñoEscolarToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MenuCalificaciones;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private System.Windows.Forms.ToolStripMenuItem reporteDeCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEmpleadosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
    }
}

