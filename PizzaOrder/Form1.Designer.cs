namespace PizzaOrder
{
    partial class frm_front
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
            this.label1 = new System.Windows.Forms.Label();
            this.orderBT = new System.Windows.Forms.Button();
            this.exitBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Stelios pizza";
            // 
            // orderBT
            // 
            this.orderBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBT.Location = new System.Drawing.Point(331, 199);
            this.orderBT.Name = "orderBT";
            this.orderBT.Size = new System.Drawing.Size(182, 100);
            this.orderBT.TabIndex = 1;
            this.orderBT.Text = "Order Now";
            this.orderBT.UseVisualStyleBackColor = true;
            this.orderBT.Click += new System.EventHandler(this.orderBT_Click);
            // 
            // exitBT
            // 
            this.exitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBT.Location = new System.Drawing.Point(331, 305);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(182, 106);
            this.exitBT.TabIndex = 3;
            this.exitBT.Text = "Exit";
            this.exitBT.UseVisualStyleBackColor = true;
            this.exitBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // frm_front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(866, 517);
            this.Controls.Add(this.exitBT);
            this.Controls.Add(this.orderBT);
            this.Controls.Add(this.label1);
            this.Name = "frm_front";
            this.Text = "Front";
            this.Load += new System.EventHandler(this.frm_front_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderBT;
        private System.Windows.Forms.Button exitBT;
    }
}

