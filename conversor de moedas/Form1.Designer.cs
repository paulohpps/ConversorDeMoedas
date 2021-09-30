
namespace conversor_de_moedas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.box1 = new System.Windows.Forms.ComboBox();
            this.box2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Moedalb1 = new System.Windows.Forms.Label();
            this.Moedalb2 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.AutoCompleteCustomSource.AddRange(new string[] {
            "Dolar",
            "Real",
            "Bitcoin",
            "Euro"});
            this.box1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.FormattingEnabled = true;
            this.box1.Items.AddRange(new object[] {
            "Dolar",
            "Real",
            "Bitcoin",
            "Euro"});
            this.box1.Location = new System.Drawing.Point(119, 201);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(121, 32);
            this.box1.TabIndex = 0;
            // 
            // box2
            // 
            this.box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box2.FormattingEnabled = true;
            this.box2.Items.AddRange(new object[] {
            "Dolar",
            "Real",
            "Bitcoin",
            "Euro"});
            this.box2.Location = new System.Drawing.Point(546, 201);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(121, 32);
            this.box2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Moedalb1
            // 
            this.Moedalb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moedalb1.Location = new System.Drawing.Point(113, 165);
            this.Moedalb1.Name = "Moedalb1";
            this.Moedalb1.Size = new System.Drawing.Size(136, 33);
            this.Moedalb1.TabIndex = 3;
            this.Moedalb1.Text = "Real";
            this.Moedalb1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Moedalb2
            // 
            this.Moedalb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moedalb2.Location = new System.Drawing.Point(540, 165);
            this.Moedalb2.Name = "Moedalb2";
            this.Moedalb2.Size = new System.Drawing.Size(136, 33);
            this.Moedalb2.TabIndex = 4;
            this.Moedalb2.Text = "Dolar";
            this.Moedalb2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valor1
            // 
            this.valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1.Location = new System.Drawing.Point(110, 280);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(148, 31);
            this.valor1.TabIndex = 5;
            // 
            // valor2
            // 
            this.valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2.Location = new System.Drawing.Point(537, 280);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(148, 31);
            this.valor2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::conversor_de_moedas.Properties.Resources.conversor;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(298, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 86);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.Moedalb2);
            this.Controls.Add(this.Moedalb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box1;
        private System.Windows.Forms.ComboBox box2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Moedalb1;
        private System.Windows.Forms.Label Moedalb2;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

