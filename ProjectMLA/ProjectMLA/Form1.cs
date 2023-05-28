
using DALandBL;
using DALandBL.Snacks;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;

namespace ProjectMLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //AllChechBox();
        }

        List<JunkFood> listOfJunkFood = FuncAndList.FoodList();

        //לחצן השמירה והקניה
        //שולח לפונקציית אקסקיוט שהיא שולחת לקניה ואם זה הלך מחזיר אמת ואם לא שקר
        //ואז מנקה הכל
        private async void button1_Click(object sender, EventArgs e)
        {
            CheckBox v = this.Controls.OfType<CheckBox>().Where(i => i.Checked = true).First();
            string s = v.Text;
            JunkFood j = listOfJunkFood.Where(i => i.Name.CompareTo(s) == 0).FirstOrDefault() ?? throw new Exception("אין כזה מוצר");
            Save save = new();
            if (save.Execute(j))
            {
                MessageBox.Show("good");
            }
            else
            {
                MessageBox.Show("not good");
            }
            Clear();
            //  נעילת כל הכפתורים במסך מלבד הכפתורים
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
            TextPay.Text = "0";
            M.Text = "התשלום בוצע בהצלחה תהנה";
            M.Text += j.Doch();
        }
        // שקית ואריזת מתנה
        private void gift_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextPay.Text);
            a += 1;
            TextPay.Text = " ";
            TextPay.Text += a;
            Bag.Enabled = false;
        }

        private void Bag_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextPay.Text);
            a += 0.20;
            TextPay.Text = " ";
            TextPay.Text += a;
            gift.Enabled = false;
        }

        private void DoritosChe_CheckedChanged(object sender, EventArgs e)
        {
            //זימון פונקצית המחיר
            AllChechBox();
        }

        //זוהי פונקציה שכל הכפתורים משתמשים בה כאשר לוחצים עליהם 
        //והיא סהכ שמה את המחיר של כל מוצר בתיבת טקסט
        public void AllChechBox()
        {
            CheckBox click = this.Controls.OfType<CheckBox>().Where(i => i.Checked = true).First();
            string s = click.Text;
            JunkFood j = listOfJunkFood.Where(i => i.Name.CompareTo(s) == 0).FirstOrDefault() ?? throw new Exception("אין כזה מוצר");
            double a = double.Parse(TextPay.Text);
            a += j.Price;
            TextPay.Text = " ";
            TextPay.Text += a;

        }
        //פונקציה שמנקה הכלל
        public void Clear()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;

            }

        }
        public void InMakeing()
        {
            LIsMakeing.Text = "המכשיר מתחיל בהכנת המוצר אנא המתן";
            Thread.Sleep(2000);
            LIsMakeing.Text = "המוצר באמצע הכנה אנא המתן";
            Thread.Sleep(2000);
            LIsMakeing.Text = "המוצר בסיום הכנה אנא המתן";

        }

        private void LIsMakeing_Click(object sender, EventArgs e)
        {

        }

        private void BDoch_Click(object sender, EventArgs e)
        {
            Meditor meditor = new Meditor();
            meditor.DochToText();
        }
    }
}