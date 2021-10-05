
namespace DesafíoHerencia_francisco_linan
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
            this.groupTipoInmueble = new System.Windows.Forms.GroupBox();
            this.rbuttonPiso = new System.Windows.Forms.RadioButton();
            this.rbuttonLocal = new System.Windows.Forms.RadioButton();
            this.inputNroPiso = new System.Windows.Forms.TextBox();
            this.pisoNro = new System.Windows.Forms.Label();
            this.inputNroVentanas = new System.Windows.Forms.TextBox();
            this.nroVentanas = new System.Windows.Forms.Label();
            this.inputDireccion = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSuperficie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputAntiguedad = new System.Windows.Forms.TextBox();
            this.inputPrecioBase = new System.Windows.Forms.TextBox();
            this.buttonPrecioFinal = new System.Windows.Forms.Button();
            this.precioFinal = new System.Windows.Forms.Label();
            this.outputPrecioFinal = new System.Windows.Forms.TextBox();
            this.groupTipoInmueble.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTipoInmueble
            // 
            this.groupTipoInmueble.Controls.Add(this.nroVentanas);
            this.groupTipoInmueble.Controls.Add(this.inputNroVentanas);
            this.groupTipoInmueble.Controls.Add(this.pisoNro);
            this.groupTipoInmueble.Controls.Add(this.inputNroPiso);
            this.groupTipoInmueble.Controls.Add(this.rbuttonLocal);
            this.groupTipoInmueble.Controls.Add(this.rbuttonPiso);
            this.groupTipoInmueble.Location = new System.Drawing.Point(21, 23);
            this.groupTipoInmueble.Name = "groupTipoInmueble";
            this.groupTipoInmueble.Size = new System.Drawing.Size(413, 139);
            this.groupTipoInmueble.TabIndex = 0;
            this.groupTipoInmueble.TabStop = false;
            this.groupTipoInmueble.Text = "Tipo de inmueble";
            // 
            // rbuttonPiso
            // 
            this.rbuttonPiso.AutoSize = true;
            this.rbuttonPiso.Location = new System.Drawing.Point(37, 32);
            this.rbuttonPiso.Name = "rbuttonPiso";
            this.rbuttonPiso.Size = new System.Drawing.Size(56, 21);
            this.rbuttonPiso.TabIndex = 0;
            this.rbuttonPiso.TabStop = true;
            this.rbuttonPiso.Text = "Piso";
            this.rbuttonPiso.UseVisualStyleBackColor = true;
            this.rbuttonPiso.Click += new System.EventHandler(this.rbuttonPiso_Click);
            // 
            // rbuttonLocal
            // 
            this.rbuttonLocal.AutoSize = true;
            this.rbuttonLocal.Location = new System.Drawing.Point(260, 32);
            this.rbuttonLocal.Name = "rbuttonLocal";
            this.rbuttonLocal.Size = new System.Drawing.Size(63, 21);
            this.rbuttonLocal.TabIndex = 1;
            this.rbuttonLocal.TabStop = true;
            this.rbuttonLocal.Text = "Local";
            this.rbuttonLocal.UseVisualStyleBackColor = true;
            this.rbuttonLocal.Click += new System.EventHandler(this.rbuttonLocal_Click);
            // 
            // inputNroPiso
            // 
            this.inputNroPiso.Location = new System.Drawing.Point(37, 111);
            this.inputNroPiso.Name = "inputNroPiso";
            this.inputNroPiso.Size = new System.Drawing.Size(69, 22);
            this.inputNroPiso.TabIndex = 2;
            // 
            // pisoNro
            // 
            this.pisoNro.AutoSize = true;
            this.pisoNro.Location = new System.Drawing.Point(34, 91);
            this.pisoNro.Name = "pisoNro";
            this.pisoNro.Size = new System.Drawing.Size(61, 17);
            this.pisoNro.TabIndex = 3;
            this.pisoNro.Text = "Nro piso";
            // 
            // inputNroVentanas
            // 
            this.inputNroVentanas.Location = new System.Drawing.Point(260, 111);
            this.inputNroVentanas.Name = "inputNroVentanas";
            this.inputNroVentanas.Size = new System.Drawing.Size(63, 22);
            this.inputNroVentanas.TabIndex = 4;
            // 
            // nroVentanas
            // 
            this.nroVentanas.AutoSize = true;
            this.nroVentanas.Location = new System.Drawing.Point(257, 91);
            this.nroVentanas.Name = "nroVentanas";
            this.nroVentanas.Size = new System.Drawing.Size(93, 17);
            this.nroVentanas.TabIndex = 5;
            this.nroVentanas.Text = "Nro ventanas";
            // 
            // inputDireccion
            // 
            this.inputDireccion.Location = new System.Drawing.Point(40, 202);
            this.inputDireccion.Name = "inputDireccion";
            this.inputDireccion.Size = new System.Drawing.Size(394, 22);
            this.inputDireccion.TabIndex = 1;
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(37, 182);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(67, 17);
            this.direccion.TabIndex = 2;
            this.direccion.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Superficie";
            // 
            // inputSuperficie
            // 
            this.inputSuperficie.Location = new System.Drawing.Point(43, 266);
            this.inputSuperficie.Name = "inputSuperficie";
            this.inputSuperficie.Size = new System.Drawing.Size(84, 22);
            this.inputSuperficie.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Antiguedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio Base";
            // 
            // inputAntiguedad
            // 
            this.inputAntiguedad.Location = new System.Drawing.Point(170, 265);
            this.inputAntiguedad.Name = "inputAntiguedad";
            this.inputAntiguedad.Size = new System.Drawing.Size(84, 22);
            this.inputAntiguedad.TabIndex = 7;
            // 
            // inputPrecioBase
            // 
            this.inputPrecioBase.Location = new System.Drawing.Point(294, 266);
            this.inputPrecioBase.Name = "inputPrecioBase";
            this.inputPrecioBase.Size = new System.Drawing.Size(84, 22);
            this.inputPrecioBase.TabIndex = 8;
            // 
            // buttonPrecioFinal
            // 
            this.buttonPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrecioFinal.Location = new System.Drawing.Point(43, 317);
            this.buttonPrecioFinal.Name = "buttonPrecioFinal";
            this.buttonPrecioFinal.Size = new System.Drawing.Size(391, 42);
            this.buttonPrecioFinal.TabIndex = 9;
            this.buttonPrecioFinal.Text = "Calcular precio final";
            this.buttonPrecioFinal.UseVisualStyleBackColor = true;
            this.buttonPrecioFinal.Click += new System.EventHandler(this.buttonPrecioFinal_Click);
            // 
            // precioFinal
            // 
            this.precioFinal.AutoSize = true;
            this.precioFinal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.precioFinal.Location = new System.Drawing.Point(43, 400);
            this.precioFinal.Name = "precioFinal";
            this.precioFinal.Size = new System.Drawing.Size(86, 17);
            this.precioFinal.TabIndex = 10;
            this.precioFinal.Text = "Precio final: ";
            // 
            // outputPrecioFinal
            // 
            this.outputPrecioFinal.Location = new System.Drawing.Point(136, 400);
            this.outputPrecioFinal.Name = "outputPrecioFinal";
            this.outputPrecioFinal.Size = new System.Drawing.Size(100, 22);
            this.outputPrecioFinal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.outputPrecioFinal);
            this.Controls.Add(this.precioFinal);
            this.Controls.Add(this.buttonPrecioFinal);
            this.Controls.Add(this.inputPrecioBase);
            this.Controls.Add(this.inputAntiguedad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputSuperficie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.inputDireccion);
            this.Controls.Add(this.groupTipoInmueble);
            this.Name = "Form1";
            this.Text = "Clase 13 - Desafío Herencia";
            this.groupTipoInmueble.ResumeLayout(false);
            this.groupTipoInmueble.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTipoInmueble;
        private System.Windows.Forms.Label nroVentanas;
        private System.Windows.Forms.TextBox inputNroVentanas;
        private System.Windows.Forms.Label pisoNro;
        private System.Windows.Forms.TextBox inputNroPiso;
        private System.Windows.Forms.RadioButton rbuttonLocal;
        private System.Windows.Forms.RadioButton rbuttonPiso;
        private System.Windows.Forms.TextBox inputDireccion;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSuperficie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputAntiguedad;
        private System.Windows.Forms.TextBox inputPrecioBase;
        private System.Windows.Forms.Button buttonPrecioFinal;
        private System.Windows.Forms.Label precioFinal;
        private System.Windows.Forms.TextBox outputPrecioFinal;
    }
}

