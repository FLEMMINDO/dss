using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT7
{
    public partial class ExpertSystemForm : Form
    {
        private ExpertSystemData data = new ExpertSystemData();
        private string filename;
        public string text1;
        public string text2;
        public int numberofdata;
        public ExpertSystemForm()
        {
            InitializeComponent();
        }
        public void UpdatePropositions()
        {
            propositionsGrid.Rows.Clear();
            var count = data.Propositions.Count;
            if (count > 0)
            {
                propositionsGrid.RowCount = count;
                for (int i = 0; i < count; ++i)
                {
                    var item = data.Propositions[i];
                    propositionsGrid.Rows[i].Cells[0].Value = item.Caption;
                }
            }
        }
        public void UpdateOutcome()
        {
            var text1 = data.Outcomes[0];
            Outcome1.Text = text1.Caption;
            var text2 = data.Outcomes[1];
            Outcome2.Text = text2.Caption;
            var text3 = data.Outcomes[2];
            Outcome3.Text = text3.Caption;
            var text4 = data.Outcomes[3];
            Outcome4.Text = text4.Caption;
            var text5 = data.Outcomes[4];
            Outcome5.Text = text5.Caption;
            var text6 = data.Outcomes[5];
            Outcome6.Text = text6.Caption;
            var text7 = data.Outcomes[6];
            Outcome7.Text = text7.Caption;
            var text8 = data.Outcomes[7];
            Outcome8.Text = text8.Caption;
            var text9 = data.Outcomes[8];
            Outcome9.Text = text9.Caption;
            var text10 = data.Outcomes[9];
            Outcome10.Text = text10.Caption;
        }
        private void openMenu_Click(object sender, EventArgs e)
        {

            var dialog = new OpenFileDialog();
            dialog.Title = "Открыть проект...";
            dialog.Filter = "Файлы экспертных систем|*.es|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Open);
                var formatter = new BinaryFormatter();
                data = (ExpertSystemData)formatter.Deserialize(file);
                FileInfo fileInfo = new FileInfo(dialog.FileName);
                if ( fileInfo.Name == "Животные.es")
                {
                    numberofdata = 1;
                }
                if (fileInfo.Name == "Числа.es")
                {
                    numberofdata = 2;
                }
                if (fileInfo.Name == "Карты.es")
                {
                    numberofdata = 3;
                }
                if (fileInfo.Name == "Одежда.es")
                {
                    numberofdata = 4;
                }
                if (fileInfo.Name == "Машины.es")
                {
                    numberofdata = 5;
                }
                file.Close();
                UpdateOutcome();
                UpdatePropositions();
            }
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            var text1 = new Outcome();
            var text2 = new Outcome();
            var text3 = new Outcome();
            var text4 = new Outcome();
            var text5 = new Outcome();
            var text6 = new Outcome();
            var text7 = new Outcome();
            var text8 = new Outcome();
            var text9 = new Outcome();
            var text10 = new Outcome();
            text1.Caption = Outcome1.Text;
            text2.Caption = Outcome2.Text;
            text3.Caption = Outcome3.Text;
            text4.Caption = Outcome4.Text;
            text5.Caption = Outcome5.Text;
            text6.Caption = Outcome6.Text;
            text7.Caption = Outcome7.Text;
            text8.Caption = Outcome8.Text;
            text9.Caption = Outcome9.Text;
            text10.Caption = Outcome10.Text;
            data.Outcomes.Add(text1);
            data.Outcomes.Add(text2);
            data.Outcomes.Add(text3);
            data.Outcomes.Add(text4);
            data.Outcomes.Add(text5);
            data.Outcomes.Add(text6);
            data.Outcomes.Add(text7);
            data.Outcomes.Add(text8);
            data.Outcomes.Add(text9);
            data.Outcomes.Add(text10);
            if (filename == null)
            {
                saveAsMenu_Click(sender, e);
                return;
            }
            var file = new FileStream(filename, FileMode.OpenOrCreate);
            var formatter = new BinaryFormatter();
            formatter.Serialize(file, data);
            file.Close();

        }

        private void saveAsMenu_Click(object sender, EventArgs e)
        {

            var dialog = new SaveFileDialog();
            dialog.Title = "Сохранение проекта...";
            dialog.Filter = "Файлы экспертных систем|*.es|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
                saveMenu_Click(sender, e);
            }

        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            var dialog = new AddForm();
            dialog.ShowDialog(this);
            if (dialog.DialogResult == DialogResult.OK)
            {
                var prop = new Proposition();
                prop.Caption = dialog.InputBox.Text;
                prop.Valid = false;
                data.Propositions.Add(prop);
                data.rules.Add(0);

                UpdatePropositions();
            }
        }

        private void startMenu_Click(object sender, EventArgs e)
        {
            var text = "Не нашли ничего";
            DialogResult result;
            if (numberofdata == 1)
            {
                for (int i = 0; i < data.Propositions.Count;)
                {
                    result = MessageBox.Show(data.Propositions[i].Caption, "Это утверждение верно?",
                   MessageBoxButtons.YesNo);
                    if (i == 0 && result == DialogResult.Yes)
                    {
                        i = 1;
                        result = 0;
                    }
                    if (i == 0 && result == DialogResult.No)
                    {
                        i = 3;
                        result = 0;
                    }
                    if (i == 1 && result == DialogResult.Yes)
                    {
                        i = 2;
                        result = 0;
                    }
                    if (i == 1 && result == DialogResult.No)
                    {
                        text = Outcome3.Text;
                        break;
                    }
                    if (i == 2 && result == DialogResult.Yes)
                    {
                        text = Outcome1.Text;
                        break;
                    }
                    if (i == 2 && result == DialogResult.No)
                    {
                        text = Outcome2.Text;
                        break;
                    }
                    if (i == 3 && result == DialogResult.Yes)
                    {
                        i = 4;
                        result = 0;
                    }
                    if (i == 3 && result == DialogResult.No)
                    {
                        i = 5;
                        result = 0;
                    }
                    if (i == 4 && result == DialogResult.Yes)
                    {
                        text = Outcome4.Text;
                        break;
                    }
                    if (i == 4 && result == DialogResult.No)
                    {
                        text = Outcome5.Text;
                        break;
                    }
                    if (i == 5 && result == DialogResult.Yes)
                    {
                        i = 6;
                        result = 0;
                    }
                    if (i == 5 && result == DialogResult.No)
                    {
                        i = 7;
                        result = 0;
                    }
                    if (i == 6 && result == DialogResult.Yes)
                    {
                        text = Outcome6.Text;
                        break;
                    }
                    if (i == 6 && result == DialogResult.No)
                    {
                        text = Outcome7.Text;
                        break;
                    }
                    if (i == 7 && result == DialogResult.Yes)
                    {
                        i = 8;
                        result = 0;
                    }
                    if (i == 7 && result == DialogResult.No)
                    {
                        break;
                    }
                    if (i == 8 && result == DialogResult.Yes)
                    {
                        text = Outcome8.Text;
                        break;
                    }
                    if (i == 8 && result == DialogResult.No)
                    {
                        text = Outcome9.Text;
                        break;
                    }
                }
            }
            if (numberofdata == 2)
            {
                for (int i = 0; i < data.Propositions.Count;)
                {
                    result = MessageBox.Show(data.Propositions[i].Caption, "Это утверждение верно?",
                   MessageBoxButtons.YesNo);
                    if (i == 0 && result == DialogResult.Yes)
                    {
                        i = 1;
                        result = 0;
                    }
                    if (i == 0 && result == DialogResult.No)
                    {
                        text = Outcome10.Text;
                        break;
                    }
                    if (i == 1 && result == DialogResult.Yes)
                    {
                        i = 2;
                        result = 0;
                    }
                    if (i == 1 && result == DialogResult.No)
                    {
                        i = 5;
                        result = 0;
                    }
                    if (i == 2 && result == DialogResult.Yes)
                    {
                        i = 3;
                        result = 0;
                    }
                    if (i == 2 && result == DialogResult.No)
                    {
                        i = 4;
                        result = 0;
                    }
                    if (i == 3 && result == DialogResult.Yes)
                    {
                        text = Outcome1.Text;
                        break;
                    }
                    if (i == 3 && result == DialogResult.No)
                    {
                        text = Outcome2.Text;
                        break;
                    }
                    if (i == 4 && result == DialogResult.Yes)
                    {
                        text = Outcome3.Text;
                        break;
                    }
                    if (i == 4 && result == DialogResult.No)
                    {
                        text = Outcome4.Text;
                        break;
                    }
                    if (i == 5 && result == DialogResult.Yes)
                    {
                        i = 6;
                        result = 0;
                    }
                    if (i == 5 && result == DialogResult.No)
                    {
                        i = 8;
                        result = 0;
                    }
                    if (i == 6 && result == DialogResult.Yes)
                    {
                        i = 7;
                        result = 0;
                    }
                    if (i == 6 && result == DialogResult.No)
                    {
                        text = Outcome7.Text;
                        break;
                    }
                    if (i == 7 && result == DialogResult.Yes)
                    {
                        text = Outcome5.Text;
                        break;
                    }
                    if (i == 7 && result == DialogResult.No)
                    {
                        text = Outcome6.Text;
                        break;
                    }
                    if (i == 8 && result == DialogResult.Yes)
                    {
                        text = Outcome8.Text;
                        break;
                    }
                    if (i == 8 && result == DialogResult.No)
                    {
                        text = Outcome9.Text;
                        break;
                    }
                }
            }
            if (numberofdata == 3)
            {
                for (int i = 0; i < data.Propositions.Count;)
                {
                    result = MessageBox.Show(data.Propositions[i].Caption, "Это утверждение верно?",
                   MessageBoxButtons.YesNo);
                    if (i == 0 && result == DialogResult.Yes)
                    {
                        i = 1;
                        result = 0;
                    }
                    if (i == 0 && result == DialogResult.No)
                    {
                        i = 2;
                        result = 0;
                    }
                    if (i == 1 && result == DialogResult.Yes)
                    {
                        text = Outcome1.Text;
                        break;
                    }
                    if (i == 1 && result == DialogResult.No)
                    {
                        text = Outcome2.Text;
                        break;
                    }
                    if (i == 2 && result == DialogResult.Yes)
                    {
                        i = 3;
                        result = 0;
                    }
                    if (i == 2 && result == DialogResult.No)
                    {
                        i = 4;
                        result = 0;
                    }
                    if (i == 3 && result == DialogResult.Yes)
                    {
                        text = Outcome3.Text;
                        break;
                    }
                    if (i == 3 && result == DialogResult.No)
                    {
                        text = Outcome4.Text;
                        break;
                    }
                    if (i == 4 && result == DialogResult.Yes)
                    {
                        i = 5;
                        result = 0;
                    }
                    if (i == 4 && result == DialogResult.No)
                    {
                        i = 6;
                        result = 0;
                    }
                    if (i == 5 && result == DialogResult.Yes)
                    {
                        text = Outcome5.Text;
                        break;
                    }
                    if (i == 5 && result == DialogResult.No)
                    {
                        text = Outcome6.Text;
                        break;
                    }
                    if (i == 6 && result == DialogResult.Yes)
                    {
                        i = 7;
                        result = 0;
                    }
                    if (i == 6 && result == DialogResult.No)
                    {
                        break;
                    }
                    if (i == 7 && result == DialogResult.Yes)
                    {
                        text = Outcome7.Text;
                        break;
                    }
                    if (i == 7 && result == DialogResult.No)
                    {
                        text = Outcome8.Text;
                        break;
                    }
                }
            }
            if (numberofdata == 4)
            {
                for (int i = 0; i < data.Propositions.Count;)
                {
                    result = MessageBox.Show(data.Propositions[i].Caption, "Это утверждение верно?",
                   MessageBoxButtons.YesNo);
                    if (i == 0 && result == DialogResult.Yes)
                    {
                        i = 1;
                        result = 0;
                    }
                    if (i == 0 && result == DialogResult.No)
                    {
                        i = 3;
                        result = 0;
                    }
                    if (i == 1 && result == DialogResult.Yes)
                    {
                        text = Outcome1.Text;
                        break;
                    }
                    if (i == 1 && result == DialogResult.No)
                    {
                        i = 2;
                        result = 0;
                    }
                    if (i == 2 && result == DialogResult.Yes)
                    {
                        text = Outcome2.Text;
                        break;
                    }
                    if (i == 2 && result == DialogResult.No)
                    {
                        break;
                    }
                    if (i == 3 && result == DialogResult.Yes)
                    {
                        i = 4;
                        result = 0;
                    }
                    if (i == 3 && result == DialogResult.No)
                    {
                        i = 6;
                        result = 0;
                    }
                    if (i == 4 && result == DialogResult.Yes)
                    {
                        text = Outcome3.Text;
                        break;
                    }
                    if (i == 4 && result == DialogResult.No)
                    {
                        i = 5;
                        result = 0;
                    }
                    if (i == 5 && result == DialogResult.Yes)
                    {
                        text = Outcome4.Text;
                        break;
                    }
                    if (i == 5 && result == DialogResult.No)
                    {
                        break;
                    }
                    if (i == 6 && result == DialogResult.Yes)
                    {
                        i = 7;
                        result = 0;
                    }
                    if (i == 6 && result == DialogResult.No)
                    {
                        break;
                    }
                    if (i == 7 && result == DialogResult.Yes)
                    {
                        text = Outcome5.Text;
                        break;
                    }
                    if (i == 7 && result == DialogResult.No)
                    {
                        i = 8;
                        result = 0;
                    }
                    if (i == 8 && result == DialogResult.Yes)
                    {
                        text = Outcome6.Text;
                        break;
                    }
                    if (i == 8 && result == DialogResult.No)
                    {
                        break;
                    }
                }
            }
            if (numberofdata == 5)
            {
                for (int i = 0; i < data.Propositions.Count;)
                {
                    result = MessageBox.Show(data.Propositions[i].Caption, "Это утверждение верно?",
                   MessageBoxButtons.YesNo);
                    if (i == 0 && result == DialogResult.Yes)
                    {
                        i = 1;
                        result = 0;
                    }
                    if (i == 0 && result == DialogResult.No)
                    {
                        i = 7;
                        result = 0;
                    }
                    if (i == 1 && result == DialogResult.Yes)
                    {
                        text = Outcome1.Text;
                        break;
                    }
                    if (i == 1 && result == DialogResult.No)
                    {
                        i = 2;
                        result = 0;
                    }
                    if (i == 2 && result == DialogResult.Yes)
                    {
                        text = Outcome2.Text;
                        break;
                    }
                    if (i == 2 && result == DialogResult.No)
                    {
                        i = 3;
                        result = 0;
                    }
                    if (i == 3 && result == DialogResult.Yes)
                    {
                        text = Outcome3.Text;
                        break;
                    }
                    if (i == 3 && result == DialogResult.No)
                    {
                        i = 4;
                        result = 0;
                    }
                    if (i == 4 && result == DialogResult.Yes)
                    {
                        text = Outcome4.Text;
                        break;
                    }
                    if (i == 4 && result == DialogResult.No)
                    {
                        i = 5;
                        result = 0;
                    }
                    if (i == 5 && result == DialogResult.Yes)
                    {
                        text = Outcome5.Text;
                        break;
                    }
                    if (i == 5 && result == DialogResult.No)
                    {
                        i = 6;
                        result = 0;
                    }
                    if (i == 6 && result == DialogResult.Yes)
                    {
                        text = Outcome6.Text;
                        break;
                    }
                    if (i == 6 && result == DialogResult.No)
                    {
                        break;
                    }
                    if (i == 7 && result == DialogResult.Yes)
                    {
                        i = 8;
                        result = 0;
                    }
                    if (i == 7 && result == DialogResult.No)
                    {
                        break;
                    }
                    if (i == 8 && result == DialogResult.Yes)
                    {
                        text = Outcome7.Text;
                        break;
                    }
                    if (i == 8 && result == DialogResult.No)
                    {
                        i = 9;
                        result = 0;
                    }
                    if (i == 9 && result == DialogResult.Yes)
                    {
                        text = Outcome8.Text;
                        break;
                    }
                    if (i == 9 && result == DialogResult.No)
                    {
                        i = 10;
                        result = 0;
                    }
                    if (i == 10 && result == DialogResult.Yes)
                    {
                        text = Outcome9.Text;
                        break;
                    }
                    if (i == 10 && result == DialogResult.No)
                    {
                        i = 11;
                        result = 0;
                    }
                    if (i == 11 && result == DialogResult.Yes)
                    {
                        text = Outcome10.Text;
                        break;
                    }
                    if (i == 11 && result == DialogResult.No)
                    {
                        break;
                    }
                }
            }
                    result = MessageBox.Show(text, "Возможный исход", MessageBoxButtons.OK);
        }
    }
}
