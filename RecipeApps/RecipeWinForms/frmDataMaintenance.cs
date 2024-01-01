using CPUFrameWork;
using System.Data;

//AF other than the staff, it asks if you want to delete the record with related records but then the delete doesn't work because there are related records
// The delete should work for ingredient, measurement, cuisine and courses

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Staff, CuisineType, Ingredient, MeasurementType, Course }

        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Staff;
        string deletecolname = "deletecol";
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            SetUpRadioButtons();
            BindData(currenttabletype);
        }



        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }
        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }
        private void Delete(int rowindex)
        {if (currenttabletype == TableTypeEnum.Staff)
            {
                var response = MessageBox.Show("Are you sure you want to delete this user and all related recipes, meals and cookbooks?", Application.ProductName, MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
            }
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.RemoveAt(rowindex);
            }
        }
        private void SetUpRadioButtons()
        {
            foreach (Control c in pnlOptionButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
                optUsers.Tag = TableTypeEnum.Staff;
                optCuisines.Tag = TableTypeEnum.CuisineType;
                optIngredients.Tag = TableTypeEnum.Ingredient;
                optMeasurements.Tag = TableTypeEnum.MeasurementType;
                optCourses.Tag = TableTypeEnum.Course;
            }
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }


        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }
        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        if (Save() == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
