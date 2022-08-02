using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes_App
{
    public partial class Form1 : Form
    {
        DataTable notesTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notesTable = new DataTable();
            notesTable.Columns.Add("Title", typeof(String));
            notesTable.Columns.Add("Messages", typeof(String));

            dvgStoredNotes.DataSource = notesTable;
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            txtNoteTitle.Clear();
            txtNoteMessage.Clear();
        }

        private void saveNoteBtn_Click(object sender, EventArgs e)
        {
            notesTable.Rows.Add(txtNoteTitle.Text, txtNoteMessage.Text);
            txtNoteTitle.Clear();
            txtNoteMessage.Clear();
        }

        private void readNoteBtn_Click(object sender, EventArgs e)
        {
            int index = dvgStoredNotes.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtNoteTitle.Text = notesTable.Rows[index].ItemArray[0].ToString();
                txtNoteMessage.Text = notesTable.Rows[index].ItemArray[1].ToString();
            }
        }

        private void deleteNoteBtn_Click(object sender, EventArgs e)
        {
            int index = dvgStoredNotes.CurrentCell.RowIndex;

            notesTable.Rows[index].Delete(); 
        }
    }
}
