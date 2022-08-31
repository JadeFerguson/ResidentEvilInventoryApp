using NAudio.Wave;
using ResidentEvilInventoryApp.Classes;
using ResidentEvilInventoryApp.Data;

namespace ResidentEvilInventoryApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            backgroundMusic = new WaveFileReader(Properties.Resources.Doom_Style_Industrial_Metal___Torn_Flesh____Royalty_Free_No_Copyright_Background_Music);
            out1 = new WaveOut();
            out1.Init(backgroundMusic);
            onclick = new WaveFileReader(Properties.Resources.Resident_Evil_4___Sound_Effect);
            out2 = new WaveOut();
            out2.Init(onclick);
        }
        private WaveStream onclick;
        private WaveOut out1;
        private WaveStream backgroundMusic;
        private WaveOut out2;


        private System.Windows.Forms.DataGridView myNewGrid;  // Declare a grid for this form
        private List<ResidentEvilInventory> inventoryGrid; // Declare this here so that you can use it later to manipulate the cell contents
        public void Form1_Load(object sender, EventArgs e)
        {
            myNewGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(myNewGrid)).BeginInit();
            this.SuspendLayout();
            myNewGrid.Parent = this;  // You have to set the parent manually so that the grid is displayed on the form
            myNewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myNewGrid.Location = new System.Drawing.Point(100, 100);  // You will need to calculate this position based on your other controls.  
            myNewGrid.Name = "myNewGrid";
            myNewGrid.Size = new System.Drawing.Size(400, 400);  // You said you need the grid to be 12x12.  You can change the size here.
            myNewGrid.TabIndex = 0;
            myNewGrid.ColumnHeadersVisible = false; // You could turn this back on if you wanted, but this hides the headers that would say, "Cell1, Cell2...."
            myNewGrid.RowHeadersVisible = false;
            myNewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            myNewGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            myNewGrid.CellClick += MyNewGrid_CellClick;  // Set up an event handler for CellClick.  You handle this in the MyNewGrid_CellClick method, below
            ((System.ComponentModel.ISupportInitialize)(myNewGrid)).EndInit();
            this.ResumeLayout(false);
            myNewGrid.Visible = true;
            LoadGridData();

            //This sets up the background music
            backgroundMusic.CurrentTime = new TimeSpan(0, 0, 0, 0);
            out1.Play();

            PopulateInventoryListBox();
        }

        private void PopulateInventoryListBox()
        {
            InventoryContext dbContext = new();
            List<UserInventory> userInventories = (from item in dbContext.UserInventories
                                                   select item).ToList();
            foreach (UserInventory item in userInventories)
            {
                lstInventory.Items.Add(item);
            }
        }

        public class ResidentEvilInventory
        {
            public string Cell1 { get; set; }
            public string Cell2 { get; set; }
            public string Cell3 { get; set; }
            public string Cell4 { get; set; }
            public string Cell5 { get; set; }
            public string Cell6 { get; set; }
            public string Cell7 { get; set; }
            public string Cell8 { get; set; }
            public string Cell9 { get; set; }
            public string Cell10 { get; set; }
            public string Cell11 { get; set; }
            public string Cell12 { get; set; }
        }

        private void LoadGridData()
        {
            inventoryGrid = new List<ResidentEvilInventory>();
            for (var i = 0; i < 12; i++)
            {
                inventoryGrid.Add(new ResidentEvilInventory());
            }
            myNewGrid.DataSource = inventoryGrid;
        }

        private void MyNewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // this will play a sound each time it is clicked
            onclick.CurrentTime = new TimeSpan(0, 0, 0, 0);
            out2.Play();
            // on click this will either drop an item into a specific block or certain amount of blocks

            // or this will pick up an item to move

            // or this will delete an item from the inventory
        }

        private void btnFuel_Click(object sender, EventArgs e)
        {
            frmFuel fuelForm = new();
            fuelForm.ShowDialog();
            PopulateInventoryListBox();
        }

        private void btnMisc_Click(object sender, EventArgs e)
        {
            frmMisc miscForm = new();
            miscForm.ShowDialog();
            PopulateInventoryListBox();
        }

        private void btnHerbs_Click(object sender, EventArgs e)
        {
            frmHerbs herbsForm = new();
            herbsForm.ShowDialog();
            PopulateInventoryListBox();
        }

        private void btnSupplements_Click(object sender, EventArgs e)
        {
            frmSupplements supplementsForm = new();
            supplementsForm.ShowDialog();
            PopulateInventoryListBox();
        }

        private void Ammo_Click(object sender, EventArgs e)
        {
            frmAmmo frmAmmo = new();
            frmAmmo.ShowDialog();
            PopulateInventoryListBox();
        }

        private void btnFirstAid_Click(object sender, EventArgs e)
        {
            frmFirstAid frmFirstAid = new();
            frmFirstAid.ShowDialog();
            PopulateInventoryListBox();
        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {
            frmWeapons frmWeapons = new();
            frmWeapons.ShowDialog();
            PopulateInventoryListBox();
        }
    }
}