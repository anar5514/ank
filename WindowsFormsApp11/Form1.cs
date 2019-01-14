using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApp11
{
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void citybox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = String.Empty;
        }

        private void citybox_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == String.Empty) (sender as TextBox).Text = "as";
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            Anket anket = new Anket(firstnamebox.Text, lastnamebox.Text, fathernamebox.Text, countrybox.Text,citybox.Text, phonebox.Text, dateofbirth.Value);
            if (male.Checked) anket.Gender = male.Text;
            else if (female.Checked) anket.Gender = female.Text;

            var json = JsonConvert.SerializeObject(anket);

            using (StreamWriter streamWriter = new StreamWriter("anket.json"))
            {
                streamWriter.Write(json);
            }       


        }

        private void btnok_Click(object sender, EventArgs e)
        {
            var control = File.Exists(deserializebox.Text);
            if (control)
            {
                var str = File.ReadAllText(deserializebox.Text);
                var obj = JsonConvert.DeserializeObject<Anket>(str);

                firstnamebox.Text = obj.Firstname;
                lastnamebox.Text = obj.Lastname;
                fathernamebox.Text = obj.Fathername;
                countrybox.Text = obj.Country;
                citybox.Text = obj.City;
                phonebox.Text = obj.Phone;
                if (obj.Gender == "Male") male.Checked = true;
                else if (obj.Gender == "Female") male.Checked = true;
                dateofbirth.Value = obj.Dateofbirth;
            }

        }
    }
}
