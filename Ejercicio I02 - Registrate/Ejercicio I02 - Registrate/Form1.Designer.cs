
namespace Ejercicio_I02___Registrate
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
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioButtonNoBinario = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.listBoxPais = new System.Windows.Forms.ListBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.checkBoxJavaScript = new System.Windows.Forms.CheckBox();
            this.checkBoxCMas = new System.Windows.Forms.CheckBox();
            this.checkBoxCSharp = new System.Windows.Forms.CheckBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.groupBoxGenero.SuspendLayout();
            this.groupBoxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.numericUpDownEdad);
            this.groupBoxUser.Controls.Add(this.labelEdad);
            this.groupBoxUser.Controls.Add(this.labelDireccion);
            this.groupBoxUser.Controls.Add(this.labelNombre);
            this.groupBoxUser.Controls.Add(this.textBoxDireccion);
            this.groupBoxUser.Controls.Add(this.textBoxNombre);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(262, 173);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Detalles del usuario";
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(125, 132);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownEdad.TabIndex = 6;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(17, 134);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(33, 15);
            this.labelEdad.TabIndex = 5;
            this.labelEdad.Text = "Edad";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(17, 86);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(57, 15);
            this.labelDireccion.TabIndex = 4;
            this.labelDireccion.Text = "Dirección";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(17, 40);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 15);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(125, 83);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 23);
            this.textBoxDireccion.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(125, 37);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 23);
            this.textBoxNombre.TabIndex = 0;
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioButtonNoBinario);
            this.groupBoxGenero.Controls.Add(this.radioButtonFemenino);
            this.groupBoxGenero.Controls.Add(this.radioButtonMasculino);
            this.groupBoxGenero.Location = new System.Drawing.Point(287, 12);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(136, 101);
            this.groupBoxGenero.TabIndex = 1;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Género";
            // 
            // radioButtonNoBinario
            // 
            this.radioButtonNoBinario.AutoSize = true;
            this.radioButtonNoBinario.Location = new System.Drawing.Point(17, 72);
            this.radioButtonNoBinario.Name = "radioButtonNoBinario";
            this.radioButtonNoBinario.Size = new System.Drawing.Size(81, 19);
            this.radioButtonNoBinario.TabIndex = 2;
            this.radioButtonNoBinario.TabStop = true;
            this.radioButtonNoBinario.Text = "No binario";
            this.radioButtonNoBinario.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(17, 47);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(78, 19);
            this.radioButtonFemenino.TabIndex = 1;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(17, 22);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // listBoxPais
            // 
            this.listBoxPais.FormattingEnabled = true;
            this.listBoxPais.ItemHeight = 15;
            this.listBoxPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listBoxPais.Location = new System.Drawing.Point(12, 210);
            this.listBoxPais.Name = "listBoxPais";
            this.listBoxPais.Size = new System.Drawing.Size(262, 94);
            this.listBoxPais.TabIndex = 3;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(314, 272);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(109, 32);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.checkBoxJavaScript);
            this.groupBoxCursos.Controls.Add(this.checkBoxCMas);
            this.groupBoxCursos.Controls.Add(this.checkBoxCSharp);
            this.groupBoxCursos.Location = new System.Drawing.Point(287, 119);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(136, 101);
            this.groupBoxCursos.TabIndex = 5;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Cursos";
            // 
            // checkBoxJavaScript
            // 
            this.checkBoxJavaScript.AutoSize = true;
            this.checkBoxJavaScript.Location = new System.Drawing.Point(17, 72);
            this.checkBoxJavaScript.Name = "checkBoxJavaScript";
            this.checkBoxJavaScript.Size = new System.Drawing.Size(78, 19);
            this.checkBoxJavaScript.TabIndex = 2;
            this.checkBoxJavaScript.Text = "JavaScript";
            this.checkBoxJavaScript.UseVisualStyleBackColor = true;
            // 
            // checkBoxCMas
            // 
            this.checkBoxCMas.AutoSize = true;
            this.checkBoxCMas.Location = new System.Drawing.Point(17, 47);
            this.checkBoxCMas.Name = "checkBoxCMas";
            this.checkBoxCMas.Size = new System.Drawing.Size(50, 19);
            this.checkBoxCMas.TabIndex = 1;
            this.checkBoxCMas.Text = "C++";
            this.checkBoxCMas.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSharp
            // 
            this.checkBoxCSharp.AutoSize = true;
            this.checkBoxCSharp.Location = new System.Drawing.Point(17, 23);
            this.checkBoxCSharp.Name = "checkBoxCSharp";
            this.checkBoxCSharp.Size = new System.Drawing.Size(41, 19);
            this.checkBoxCSharp.TabIndex = 0;
            this.checkBoxCSharp.Text = "C#";
            this.checkBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(12, 192);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(28, 15);
            this.labelPais.TabIndex = 6;
            this.labelPais.Text = "País";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 311);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.groupBoxCursos);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.listBoxPais);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.groupBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.groupBoxCursos.ResumeLayout(false);
            this.groupBoxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.RadioButton radioButtonNoBinario;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.ListBox listBoxPais;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.GroupBox groupBoxCursos;
        private System.Windows.Forms.CheckBox checkBoxJavaScript;
        private System.Windows.Forms.CheckBox checkBoxCMas;
        private System.Windows.Forms.CheckBox checkBoxCSharp;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.Label labelPais;
    }
}

