namespace Ej1
{
    partial class FormCalendario
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tBdesc = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(24, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // tBdesc
            // 
            this.tBdesc.Location = new System.Drawing.Point(326, 12);
            this.tBdesc.Multiline = true;
            this.tBdesc.Name = "tBdesc";
            this.tBdesc.Size = new System.Drawing.Size(199, 86);
            this.tBdesc.TabIndex = 1;
            // 
            // bAgregar
            // 
            this.bAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAgregar.Location = new System.Drawing.Point(326, 125);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(93, 49);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "Agregar/Editar feriado";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(432, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.tBdesc);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAgregar;
        public System.Windows.Forms.TextBox tBdesc;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}