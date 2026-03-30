namespace AssetManagementSystem
{
    public partial class Form1 : Form
    {
        private AssetService service = new AssetService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            comboCountry.Items.Add("Germany");
            comboCountry.Items.Add("Sweden");
            comboCountry.Items.Add("USA");
            dgvAssets.AutoGenerateColumns = true;
            dgvAssets.ClearSelection();

        }
        private void ClearFields()
        {
            // Clear text fields
            brandTxt.Text = "";
            modelTxt.Text = "";

            // Reset NumericUpDown
            priceNum.Value = 0;

            // Reset DateTimePicker to today
            dateTimePicker.Value = DateTime.Now;

            // Reset ComboBoxes
            typeTxt.Text = "";
            comboCountry.SelectedIndex = -1;

        }
        public void LoadAssets()
        {

            dgvAssets.DataSource = null;
            dgvAssets.DataSource = service.GetAllAssets();
            if (dgvAssets.Columns["Office"] != null)
                dgvAssets.Columns["Office"].Visible = false; // hide the original column

            dgvAssets.Columns["Country"].HeaderText = "Country";
        }
        private void RefreshGrid()
        {
            
            var sortedList = service.GetAllAssets().OrderBy(a => a.Country)
                .ThenBy(a => a.PurchaseDate).ToList();
            dgvAssets.DataSource = null;
            dgvAssets.DataSource = sortedList;

            // Hide Office object column
            if (dgvAssets.Columns["Office"] != null)
                dgvAssets.Columns["Office"].Visible = false;

            // Clear default selection
            dgvAssets.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Read Data 
            string brand = brandTxt.Text;
            string model = modelTxt.Text;

            //double price = (double)priceNum.Value;

            DateTime purchaseDate = dateTimePicker.Value;

            string country = comboCountry.Text;
            string currency = "";

            switch (country)
            {
                case "Germany":
                    currency = "EUR";
                    break;
                case "Sweden":
                    currency = "SEK";
                    break;
                case "USA":
                    currency = "USD";
                    break;
            }

            

            // 3. Create office 
            Office office = new Office(country, currency);
            double converted = office.ConvertToUSD((double)priceNum.Value, currency);

            // 4. Determine the Asset type
            Asset asset = null;

            if (typeTxt.Text.ToLower() == "mobile")
            {
                asset = new Mobile(brand, model, converted, purchaseDate, office);
            }
            else if (typeTxt.Text.ToLower() == "computer")
            {
                asset = new Computer(brand, model, converted, purchaseDate, office);
            }
            else
            {
                MessageBox.Show("Type missed");
                return;
            }

            if (asset != null)
            {
                service.AddAsset(asset);
                RefreshGrid();
                ClearFields();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            // Check if user selected a row
            if (dgvAssets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete");
                return;
            }

            // Confirmation message
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            try
            {
                // Get the selected asset from DataGridView
                Asset selectedAsset = (Asset)dgvAssets.SelectedRows[0].DataBoundItem;

                // Delete the asset
                service.DeleteAsset(selectedAsset);

                // Refresh the grid after deletion
                RefreshGrid();

            }
            catch
            {
                MessageBox.Show("An error occurred while deleting");
            }
        }

        private void dgvAssets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var asset = dgvAssets.Rows[e.RowIndex].DataBoundItem as Asset;

            if (asset == null) return;

            var status = asset.GetStatus();

            if (status == Asset.AssetStatus.Red)
                dgvAssets.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;

            else if (status == Asset.AssetStatus.Orange)
                dgvAssets.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkOrange;

            else if (status == Asset.AssetStatus.Yellow)
                dgvAssets.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
        }
    }

}
