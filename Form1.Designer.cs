namespace GestionTareasPendientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_ingreso = new TextBox();
            bot_agregar = new Button();
            lista = new ListBox();
            bot_eliminar = new Button();
            SuspendLayout();
            // 
            // txt_ingreso
            // 
            txt_ingreso.Location = new Point(134, 79);
            txt_ingreso.Name = "txt_ingreso";
            txt_ingreso.Size = new Size(501, 27);
            txt_ingreso.TabIndex = 0;
            // 
            // bot_agregar
            // 
            bot_agregar.Image = Properties.Resources.lista;
            bot_agregar.ImageAlign = ContentAlignment.BottomCenter;
            bot_agregar.Location = new Point(329, 136);
            bot_agregar.Name = "bot_agregar";
            bot_agregar.Size = new Size(147, 87);
            bot_agregar.TabIndex = 1;
            bot_agregar.Text = "Agregar Tarea";
            bot_agregar.TextAlign = ContentAlignment.TopCenter;
            bot_agregar.UseVisualStyleBackColor = true;
            bot_agregar.Click += bot_agregar_Click;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.Location = new Point(272, 229);
            lista.Name = "lista";
            lista.Size = new Size(274, 264);
            lista.TabIndex = 0;
            // 
            // bot_eliminar
            // 
            bot_eliminar.Image = Properties.Resources.clearlist_1191;
            bot_eliminar.ImageAlign = ContentAlignment.BottomCenter;
            bot_eliminar.Location = new Point(329, 512);
            bot_eliminar.Name = "bot_eliminar";
            bot_eliminar.Size = new Size(161, 74);
            bot_eliminar.TabIndex = 1;
            bot_eliminar.Text = "Eliminar Tarea";
            bot_eliminar.TextAlign = ContentAlignment.TopCenter;
            bot_eliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            bot_eliminar.UseVisualStyleBackColor = true;
            bot_eliminar.Click += bot_eliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 621);
            Controls.Add(lista);
            Controls.Add(bot_eliminar);
            Controls.Add(bot_agregar);
            Controls.Add(txt_ingreso);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gestión de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ingreso;
        private Button bot_agregar;
        private ListBox lista;
        private Button bot_eliminar;
    }
}
