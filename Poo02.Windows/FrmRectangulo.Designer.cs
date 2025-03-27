namespace Poo02.Windows
{
    partial class FrmRectangulo
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
            label1 = new Label();
            TxtLadoMayor = new TextBox();
            label2 = new Label();
            TxtLadoMenor = new TextBox();
            BtnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 55);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado Mayor:";
            // 
            // TxtLadoMayor
            // 
            TxtLadoMayor.Location = new Point(109, 55);
            TxtLadoMayor.Name = "TxtLadoMayor";
            TxtLadoMayor.Size = new Size(100, 23);
            TxtLadoMayor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Lado Menor:";
            // 
            // TxtLadoMenor
            // 
            TxtLadoMenor.Location = new Point(109, 94);
            TxtLadoMenor.Name = "TxtLadoMenor";
            TxtLadoMenor.Size = new Size(100, 23);
            TxtLadoMenor.TabIndex = 1;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(36, 157);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 47);
            BtnOK.TabIndex = 2;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // FrmRectangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnOK);
            Controls.Add(TxtLadoMenor);
            Controls.Add(TxtLadoMayor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRectangulo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtLadoMayor;
        private Label label2;
        private TextBox TxtLadoMenor;
        private Button BtnOK;
    }
}
