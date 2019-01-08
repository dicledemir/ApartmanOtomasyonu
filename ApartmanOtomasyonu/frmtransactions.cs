using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonu
{
    public partial class frmtransactions : Form
    {
        public frmtransactions()
        {
            InitializeComponent();
        }

        ApartmantAutomationEntities1 db = new ApartmantAutomationEntities1();
        public void SelectedTab()
        {
            tabControl1.SelectedTab = tpExpenses;
        }

        private void btnInsertInComes_Click(object sender, EventArgs e)
        {
            tblIncomes cm = new tblIncomes();
            cm.Amount = Convert.ToDecimal(tbInComesAmount.Text);
            cm.Date = Convert.ToDateTime(dtpIncomesDate.Text);
            cm.RoomNo = Convert.ToInt32(nudRoomsNo.Text);
            db.tblIncomes.Add(cm);
            db.SaveChanges();
            frmtransactions_Load(sender, e);
        }

        private void ClearControls()
        {
            tbExpensesAmount.Clear();
            nudRoomsNo.Value = 0;
            tbInComesAmount.Clear();
            dtpExpensesDate.Value = DateTime.Now;
            dtpIncomesDate.Value = DateTime.Now;
            rbCleaning.Checked = false;
            rbElectricity.Checked = false;
            rbelevator.Checked = false;
            rbWater.Checked = false;

        }
        private void frmtransactions_Load(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tpIncomes)
            {
                GetIncomesTable();
            }
            else
                GetExpensesTable();

            ClearControls();


        }

        private void GetExpensesTable()
        {
            dgwExpense.DataSource = null;
            dgwExpense.DataSource = (from a in db.tblExpenses join b in db.tblExpenseTypes on a.ExpenseType equals b.TypeID select new { a.Date, a.Amount, b.TypeName }).ToList().Select(x => new

            {
                x.TypeName,
                Tutar = x.Amount,
                Tarih = x.Date,
            }).ToList();
        }

        private void GetIncomesTable()
        {
            dgwIncomes.DataSource = null;
            dgwIncomes.DataSource = db.tblIncomes.Select(x => new
            {
                x.Date,
                x.Amount,
                x.RoomNo
            }).ToList();
        }

        public int ExpenseType()
        {
            if (rbElectricity.Checked)
                return 1;
            else if (rbWater.Checked)
            {
                return 2;
            }
            else if (rbelevator.Checked)
                return 3;
            else
                return 4;
        }

        private void btnInsertExpenses_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbExpensesAmount.Text))
            {
                if (rbElectricity.Checked || rbWater.Checked || rbelevator.Checked || rbCleaning.Checked)
                {
                    tblExpenses expense = new tblExpenses();
                    expense.Amount = Convert.ToDecimal(tbExpensesAmount.Text);
                    expense.Date = Convert.ToDateTime(dtpExpensesDate.Text);
                    expense.ExpenseType = ExpenseType();
                    db.tblExpenses.Add(expense);
                    db.SaveChanges();
                    frmtransactions_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("Gider Türünü Seciniz!");
                }
            }
            else
            {
                MessageBox.Show("Tutarı gidiriniz!");
            }
        }

        private void frmtransactions_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void tbExpensesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbInComesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}