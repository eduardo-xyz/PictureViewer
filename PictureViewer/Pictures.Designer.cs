namespace PictureViewer
{
    partial class Pictures
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ajustar = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.close = new System.Windows.Forms.Button();
            this.setColor = new System.Windows.Forms.Button();
            this.deleteImage = new System.Windows.Forms.Button();
            this.showImage = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ajustar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 394);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ajustar
            // 
            this.ajustar.AutoSize = true;
            this.ajustar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajustar.Location = new System.Drawing.Point(3, 403);
            this.ajustar.Name = "ajustar";
            this.ajustar.Size = new System.Drawing.Size(76, 39);
            this.ajustar.TabIndex = 1;
            this.ajustar.Text = "Ajustar";
            this.ajustar.UseVisualStyleBackColor = true;
            this.ajustar.CheckedChanged += new System.EventHandler(this.ajustar_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.close);
            this.flowLayoutPanel1.Controls.Add(this.setColor);
            this.flowLayoutPanel1.Controls.Add(this.deleteImage);
            this.flowLayoutPanel1.Controls.Add(this.showImage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(85, 403);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(3, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            this.close.Text = "Cerrar";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // setColor
            // 
            this.setColor.AutoSize = true;
            this.setColor.Location = new System.Drawing.Point(84, 3);
            this.setColor.Name = "setColor";
            this.setColor.Size = new System.Drawing.Size(138, 23);
            this.setColor.TabIndex = 1;
            this.setColor.Text = "Establecer color de fondo";
            this.setColor.UseVisualStyleBackColor = true;
            this.setColor.Click += new System.EventHandler(this.setColor_Click);
            // 
            // deleteImage
            // 
            this.deleteImage.AutoSize = true;
            this.deleteImage.Location = new System.Drawing.Point(228, 3);
            this.deleteImage.Name = "deleteImage";
            this.deleteImage.Size = new System.Drawing.Size(82, 23);
            this.deleteImage.TabIndex = 2;
            this.deleteImage.Text = "Borrar imagen";
            this.deleteImage.UseVisualStyleBackColor = true;
            this.deleteImage.Click += new System.EventHandler(this.deleteImage_Click);
            // 
            // showImage
            // 
            this.showImage.AutoSize = true;
            this.showImage.Location = new System.Drawing.Point(316, 3);
            this.showImage.Name = "showImage";
            this.showImage.Size = new System.Drawing.Size(89, 23);
            this.showImage.TabIndex = 3;
            this.showImage.Text = "Mostrar imagen";
            this.showImage.UseVisualStyleBackColor = true;
            this.showImage.Click += new System.EventHandler(this.showImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JPEG (*.jpg)|*.jpg|Archivos PNG (*.png)|*.png|Archivos BMP (*.bmp)|*.bmp" +
    "";
            this.openFileDialog1.Title = "Seleccionar un archivo de imagen ";
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Pictures";
            this.Text = "Pictures Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ajustar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button setColor;
        private System.Windows.Forms.Button deleteImage;
        private System.Windows.Forms.Button showImage;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

