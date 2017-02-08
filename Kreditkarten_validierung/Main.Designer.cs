namespace Kreditkarten_validierung
{
  partial class Main
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
			this.txtInput = new System.Windows.Forms.TextBox();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblOut = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(93, 6);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(200, 20);
			this.txtInput.TabIndex = 0;
			// 
			// txtOut
			// 
			this.txtOut.Location = new System.Drawing.Point(244, 34);
			this.txtOut.Name = "txtOut";
			this.txtOut.ReadOnly = true;
			this.txtOut.Size = new System.Drawing.Size(49, 20);
			this.txtOut.TabIndex = 2;
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(12, 32);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 3;
			this.btnGo.Text = "Ausführen";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Kartennummer";
			// 
			// lblOut
			// 
			this.lblOut.AutoSize = true;
			this.lblOut.Location = new System.Drawing.Point(187, 37);
			this.lblOut.Name = "lblOut";
			this.lblOut.Size = new System.Drawing.Size(51, 13);
			this.lblOut.TabIndex = 5;
			this.lblOut.Text = "Gültigkeit";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 64);
			this.Controls.Add(this.lblOut);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.txtOut);
			this.Controls.Add(this.txtInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Main";
			this.Text = "Kartennummer validierung";
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TextBox txtOut;
    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblOut;
  }
}

