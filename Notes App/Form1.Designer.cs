
namespace Notes_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.txtNoteMessage = new System.Windows.Forms.TextBox();
            this.dvgStoredNotes = new System.Windows.Forms.DataGridView();
            this.newNoteBtn = new System.Windows.Forms.Button();
            this.readNoteBtn = new System.Windows.Forms.Button();
            this.saveNoteBtn = new System.Windows.Forms.Button();
            this.deleteNoteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStoredNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(81, 100);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(178, 20);
            this.txtNoteTitle.TabIndex = 2;
            // 
            // txtNoteMessage
            // 
            this.txtNoteMessage.Location = new System.Drawing.Point(81, 152);
            this.txtNoteMessage.Multiline = true;
            this.txtNoteMessage.Name = "txtNoteMessage";
            this.txtNoteMessage.Size = new System.Drawing.Size(178, 197);
            this.txtNoteMessage.TabIndex = 3;
            // 
            // dvgStoredNotes
            // 
            this.dvgStoredNotes.AllowUserToAddRows = false;
            this.dvgStoredNotes.AllowUserToDeleteRows = false;
            this.dvgStoredNotes.AllowUserToResizeColumns = false;
            this.dvgStoredNotes.AllowUserToResizeRows = false;
            this.dvgStoredNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStoredNotes.Location = new System.Drawing.Point(322, 100);
            this.dvgStoredNotes.Name = "dvgStoredNotes";
            this.dvgStoredNotes.ReadOnly = true;
            this.dvgStoredNotes.RowHeadersVisible = false;
            this.dvgStoredNotes.Size = new System.Drawing.Size(209, 249);
            this.dvgStoredNotes.TabIndex = 4;
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.Location = new System.Drawing.Point(81, 411);
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(75, 23);
            this.newNoteBtn.TabIndex = 5;
            this.newNoteBtn.Text = "New";
            this.newNoteBtn.UseVisualStyleBackColor = true;
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // readNoteBtn
            // 
            this.readNoteBtn.Location = new System.Drawing.Point(322, 411);
            this.readNoteBtn.Name = "readNoteBtn";
            this.readNoteBtn.Size = new System.Drawing.Size(75, 23);
            this.readNoteBtn.TabIndex = 6;
            this.readNoteBtn.Text = "Read";
            this.readNoteBtn.UseVisualStyleBackColor = true;
            this.readNoteBtn.Click += new System.EventHandler(this.readNoteBtn_Click);
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.Location = new System.Drawing.Point(204, 411);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(75, 23);
            this.saveNoteBtn.TabIndex = 7;
            this.saveNoteBtn.Text = "Save";
            this.saveNoteBtn.UseVisualStyleBackColor = true;
            this.saveNoteBtn.Click += new System.EventHandler(this.saveNoteBtn_Click);
            // 
            // deleteNoteBtn
            // 
            this.deleteNoteBtn.Location = new System.Drawing.Point(435, 411);
            this.deleteNoteBtn.Name = "deleteNoteBtn";
            this.deleteNoteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteNoteBtn.TabIndex = 8;
            this.deleteNoteBtn.Text = "Delete";
            this.deleteNoteBtn.UseVisualStyleBackColor = true;
            this.deleteNoteBtn.Click += new System.EventHandler(this.deleteNoteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Note App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteNoteBtn);
            this.Controls.Add(this.saveNoteBtn);
            this.Controls.Add(this.readNoteBtn);
            this.Controls.Add(this.newNoteBtn);
            this.Controls.Add(this.dvgStoredNotes);
            this.Controls.Add(this.txtNoteMessage);
            this.Controls.Add(this.txtNoteTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgStoredNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.TextBox txtNoteMessage;
        private System.Windows.Forms.DataGridView dvgStoredNotes;
        private System.Windows.Forms.Button newNoteBtn;
        private System.Windows.Forms.Button readNoteBtn;
        private System.Windows.Forms.Button saveNoteBtn;
        private System.Windows.Forms.Button deleteNoteBtn;
        private System.Windows.Forms.Label label3;
    }
}

