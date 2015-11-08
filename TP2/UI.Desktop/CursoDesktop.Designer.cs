namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDComision = new System.Windows.Forms.Label();
            this.lblIDMateria = new System.Windows.Forms.Label();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbIDMateria = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.comisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comisionesTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.comisionesTableAdapter();
            this.materiasTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.materiasTableAdapter();
            this.mtbCupo = new System.Windows.Forms.MaskedTextBox();
            this.mtbAnioCalendario = new System.Windows.Forms.MaskedTextBox();
            this.ttCupo = new System.Windows.Forms.ToolTip(this.components);
            this.ttAnioCalendario = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(12, 62);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 1;
            this.lblCupo.Text = "Cupo";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "ID";
            // 
            // lblIDComision
            // 
            this.lblIDComision.AutoSize = true;
            this.lblIDComision.Location = new System.Drawing.Point(267, 32);
            this.lblIDComision.Name = "lblIDComision";
            this.lblIDComision.Size = new System.Drawing.Size(49, 13);
            this.lblIDComision.TabIndex = 6;
            this.lblIDComision.Text = "Comision";
            // 
            // lblIDMateria
            // 
            this.lblIDMateria.AutoSize = true;
            this.lblIDMateria.Location = new System.Drawing.Point(267, 58);
            this.lblIDMateria.Name = "lblIDMateria";
            this.lblIDMateria.Size = new System.Drawing.Size(42, 13);
            this.lblIDMateria.TabIndex = 7;
            this.lblIDMateria.Text = "Materia";
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(12, 88);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(79, 13);
            this.lblAnioCalendario.TabIndex = 8;
            this.lblAnioCalendario.Text = "Año Calendario";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(175, 132);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(270, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbIDMateria
            // 
            this.cbIDMateria.DataSource = this.materiasBindingSource;
            this.cbIDMateria.DisplayMember = "desc_materia";
            this.cbIDMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDMateria.Location = new System.Drawing.Point(348, 53);
            this.cbIDMateria.Name = "cbIDMateria";
            this.cbIDMateria.Size = new System.Drawing.Size(162, 21);
            this.cbIDMateria.TabIndex = 5;
            this.cbIDMateria.ValueMember = "id_materia";
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbComision
            // 
            this.cbComision.DataSource = this.comisionesBindingSource;
            this.cbComision.DisplayMember = "desc_comision";
            this.cbComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComision.FormattingEnabled = true;
            this.cbComision.Location = new System.Drawing.Point(348, 26);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(162, 21);
            this.cbComision.TabIndex = 4;
            this.cbComision.ValueMember = "id_comision";
            // 
            // comisionesBindingSource
            // 
            this.comisionesBindingSource.DataMember = "comisiones";
            this.comisionesBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // comisionesTableAdapter
            // 
            this.comisionesTableAdapter.ClearBeforeFill = true;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // mtbCupo
            // 
            this.mtbCupo.Location = new System.Drawing.Point(100, 54);
            this.mtbCupo.Mask = "999";
            this.mtbCupo.Name = "mtbCupo";
            this.mtbCupo.Size = new System.Drawing.Size(150, 20);
            this.mtbCupo.TabIndex = 2;
            this.mtbCupo.Tag = "Cupo";
            // 
            // mtbAnioCalendario
            // 
            this.mtbAnioCalendario.Location = new System.Drawing.Point(100, 80);
            this.mtbAnioCalendario.Mask = "9999";
            this.mtbAnioCalendario.Name = "mtbAnioCalendario";
            this.mtbAnioCalendario.Size = new System.Drawing.Size(150, 20);
            this.mtbAnioCalendario.TabIndex = 3;
            this.mtbAnioCalendario.Tag = "Año Calendario";
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 162);
            this.Controls.Add(this.mtbAnioCalendario);
            this.Controls.Add(this.mtbCupo);
            this.Controls.Add(this.cbComision);
            this.Controls.Add(this.cbIDMateria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAnioCalendario);
            this.Controls.Add(this.lblIDMateria);
            this.Controls.Add(this.lblIDComision);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCupo);
            this.Controls.Add(this.lblID);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.Load += new System.EventHandler(this.CursoDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDComision;
        private System.Windows.Forms.Label lblIDMateria;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbIDMateria;
        private System.Windows.Forms.ComboBox cbComision;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource comisionesBindingSource;
        private tp2_netDataSetTableAdapters.comisionesTableAdapter comisionesTableAdapter;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private tp2_netDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.MaskedTextBox mtbCupo;
        private System.Windows.Forms.MaskedTextBox mtbAnioCalendario;
        private System.Windows.Forms.ToolTip ttCupo;
        private System.Windows.Forms.ToolTip ttAnioCalendario;
    }
}