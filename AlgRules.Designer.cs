
namespace _23_variant_CSharp_2_5_3
{
    partial class FormAlgRules
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMatrDim = new System.Windows.Forms.Button();
            this.richTextBoxCondition1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCondition2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(801, 167);
            this.dataGridView1.TabIndex = 22;
            // 
            // buttonMatrDim
            // 
            this.buttonMatrDim.Location = new System.Drawing.Point(590, 40);
            this.buttonMatrDim.Name = "buttonMatrDim";
            this.buttonMatrDim.Size = new System.Drawing.Size(130, 49);
            this.buttonMatrDim.TabIndex = 24;
            this.buttonMatrDim.Text = "Заполнить и рассчитать";
            this.buttonMatrDim.UseVisualStyleBackColor = true;
            this.buttonMatrDim.Click += new System.EventHandler(this.buttonMatrDim_Click);
            // 
            // richTextBoxCondition1
            // 
            this.richTextBoxCondition1.Location = new System.Drawing.Point(0, 12);
            this.richTextBoxCondition1.Name = "richTextBoxCondition1";
            this.richTextBoxCondition1.Size = new System.Drawing.Size(274, 92);
            this.richTextBoxCondition1.TabIndex = 25;
            this.richTextBoxCondition1.Text = "Условие: Разработать алгоритм и программу нисходящим способом, предполагая заданн" +
    "ой матрицу А из 5 строк";
            // 
            // richTextBoxCondition2
            // 
            this.richTextBoxCondition2.Location = new System.Drawing.Point(280, 12);
            this.richTextBoxCondition2.Name = "richTextBoxCondition2";
            this.richTextBoxCondition2.Size = new System.Drawing.Size(274, 92);
            this.richTextBoxCondition2.TabIndex = 26;
            this.richTextBoxCondition2.Text = "Условие: Кроме матрицы А дана матрица В такого же размера, если каждый элемент ма" +
    "трицы А больше соответствующего элемента матрицы В, присвоить элемнтам С1, С2..." +
    "С5 значения по правилу ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 289);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 47;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(801, 167);
            this.dataGridView2.TabIndex = 27;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 464);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 47;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(801, 167);
            this.dataGridView3.TabIndex = 28;
            // 
            // FormAlgRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 575);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.richTextBoxCondition2);
            this.Controls.Add(this.richTextBoxCondition1);
            this.Controls.Add(this.buttonMatrDim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAlgRules";
            this.Text = "Алгоритм нисходящим способом";
            this.Load += new System.EventHandler(this.FormAlgRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMatrDim;
        private System.Windows.Forms.RichTextBox richTextBoxCondition1;
        private System.Windows.Forms.RichTextBox richTextBoxCondition2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

