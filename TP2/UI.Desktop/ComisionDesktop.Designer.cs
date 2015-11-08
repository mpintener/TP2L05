namespace UI.Desktop
{
    partial class ComisionDesktop
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDPlan = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblAnioEspecialidad = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbIDPlan = new System.Windows.Forms.ComboBox();
            this.planesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.planesTableAdapter();
            this.mtbAnioEspecialidad = new System.Windows.Forms.MaskedTextBox();
            this.ttAnioEspecialidad = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(97, 146);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblIDPlan
            // 
            this.lblIDPlan.AutoSize = true;
            this.lblIDPlan.Location = new System.Drawing.Point(35, 54);
            this.lblIDPlan.Name = "lblIDPlan";
            this.lblIDPlan.Size = new System.Drawing.Size(28, 13);
            this.lblIDPlan.TabIndex = 3;
            this.lblIDPlan.Text = "Plan";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 84);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblAnioEspecialidad
            // 
            this.lblAnioEspecialidad.AutoSize = true;
            this.lblAnioEspecialidad.Location = new System.Drawing.Point(35, 109);
            this.lblAnioEspecialidad.Name = "lblAnioEspecialidad";
            this.lblAnioEspecialidad.Size = new System.Drawing.Size(89, 13);
            this.lblAnioEspecialidad.TabIndex = 5;
            this.lblAnioEspecialidad.Text = "Año Especialidad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "ID";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 77);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Tag = "Descripción";
            // 
            // cbIDPlan
            // 
            this.cbIDPlan.DataSource = this.planesBindingSource1;
            this.cbIDPlan.DisplayMember = "descripcion";
            this.cbIDPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDPlan.FormattingEnabled = true;
            this.cbIDPlan.Location = new System.Drawing.Point(136, 52);
            this.cbIDPlan.Name = "cbIDPlan";
            this.cbIDPlan.Size = new System.Drawing.Size(100, 21);
            this.cbIDPlan.TabIndex = 2;
            this.cbIDPlan.Tag = "IDPlan";
            this.cbIDPlan.ValueMember = "id_plan";
            // 
            // planesBindingSource1
            // 
            this.planesBindingSource1.DataMember = "planes";
            this.planesBindingSource1.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // mtbAnioEspecialidad
            // 
            this.mtbAnioEspecialidad.Location = new System.Drawing.Point(136, 101);
            this.mtbAnioEspecialidad.Mask = "9999";
            this.mtbAnioEspecialidad.Name = "mtbAnioEspecialidad";
            this.mtbAnioEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.mtbAnioEspecialidad.TabIndex = 4;
            this.mtbAnioEspecialidad.Tag = "AñoEspecialidad";
            this.mtbAnioEspecialidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbAnioEspecialidad_MaskInputRejected);

            // ComisionDesktop

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 188);
            this.Controls.Add(this.mtbAnioEspecialidad);
            this.Controls.Add(this.cbIDPlan);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAnioEspecialidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblIDPlan);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "ComisionDesktop";
            this.Text = "ComisionDesktop";
            this.Load += new System.EventHandler(this.ComisionDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDPlan;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblAnioEspecialidad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbIDPlan;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource planesBindingSource1;
        private tp2_netDataSetTableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.MaskedTextBox mtbAnioEspecialidad;
        private System.Windows.Forms.ToolTip ttAnioEspecialidad;
    }
}