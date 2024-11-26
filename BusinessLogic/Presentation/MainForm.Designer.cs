namespace BusinessLogic.Presentation
{
    partial class MainForm
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			mainTabControl = new TabControl();
			warehouses = new TabPage();
			tableLayoutPanel2 = new TableLayoutPanel();
			g_product_warehouse = new DataGridView();
			g_warehouse = new DataGridView();
			panel2 = new Panel();
			p_delete_pw = new Button();
			b_update_pw = new Button();
			b_add_pw = new Button();
			shops = new TabPage();
			tableLayoutPanel3 = new TableLayoutPanel();
			g_shop = new DataGridView();
			g_distance = new DataGridView();
			panel3 = new Panel();
			b_delete_d = new Button();
			b_update_d = new Button();
			b_add_d = new Button();
			products = new TabPage();
			tableLayoutPanel1 = new TableLayoutPanel();
			g_product = new DataGridView();
			g_product_resource = new DataGridView();
			panel1 = new Panel();
			b_delete_pr = new Button();
			b_update_pr = new Button();
			b_add_pr = new Button();
			resourses = new TabPage();
			g_resourse = new DataGridView();
			companies = new TabPage();
			g_company = new DataGridView();
			investments = new TabPage();
			g_investment = new DataGridView();
			b_add = new Button();
			b_edit = new Button();
			b_delete = new Button();
			b_exit = new Button();
			menu = new MenuStrip();
			toolStripMenuItem1 = new ToolStripMenuItem();
			toolStripMenuItem2 = new ToolStripMenuItem();
			toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripMenuItem4 = new ToolStripMenuItem();
			toolTip1 = new ToolTip(components);
			mainTabControl.SuspendLayout();
			warehouses.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)g_product_warehouse).BeginInit();
			((System.ComponentModel.ISupportInitialize)g_warehouse).BeginInit();
			panel2.SuspendLayout();
			shops.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)g_shop).BeginInit();
			((System.ComponentModel.ISupportInitialize)g_distance).BeginInit();
			panel3.SuspendLayout();
			products.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)g_product).BeginInit();
			((System.ComponentModel.ISupportInitialize)g_product_resource).BeginInit();
			panel1.SuspendLayout();
			resourses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)g_resourse).BeginInit();
			companies.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)g_company).BeginInit();
			investments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)g_investment).BeginInit();
			menu.SuspendLayout();
			SuspendLayout();
			// 
			// mainTabControl
			// 
			mainTabControl.Controls.Add(warehouses);
			mainTabControl.Controls.Add(shops);
			mainTabControl.Controls.Add(products);
			mainTabControl.Controls.Add(resourses);
			mainTabControl.Controls.Add(companies);
			mainTabControl.Controls.Add(investments);
			mainTabControl.Location = new Point(12, 38);
			mainTabControl.Name = "mainTabControl";
			mainTabControl.SelectedIndex = 0;
			mainTabControl.Size = new Size(1462, 847);
			mainTabControl.TabIndex = 0;
			// 
			// warehouses
			// 
			warehouses.Controls.Add(tableLayoutPanel2);
			warehouses.Location = new Point(4, 36);
			warehouses.Name = "warehouses";
			warehouses.Padding = new Padding(3);
			warehouses.Size = new Size(1454, 807);
			warehouses.TabIndex = 0;
			warehouses.Text = "Склады";
			warehouses.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(g_product_warehouse, 0, 0);
			tableLayoutPanel2.Controls.Add(g_warehouse, 0, 0);
			tableLayoutPanel2.Controls.Add(panel2, 1, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(1448, 801);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// g_product_warehouse
			// 
			g_product_warehouse.AllowUserToAddRows = false;
			g_product_warehouse.AllowUserToDeleteRows = false;
			g_product_warehouse.AllowUserToResizeRows = false;
			g_product_warehouse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			g_product_warehouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_product_warehouse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_product_warehouse.BackgroundColor = Color.White;
			g_product_warehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_product_warehouse.GridColor = Color.White;
			g_product_warehouse.Location = new Point(727, 3);
			g_product_warehouse.MultiSelect = false;
			g_product_warehouse.Name = "g_product_warehouse";
			g_product_warehouse.ReadOnly = true;
			g_product_warehouse.RowHeadersVisible = false;
			g_product_warehouse.RowHeadersWidth = 51;
			g_product_warehouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_product_warehouse.ShowCellErrors = false;
			g_product_warehouse.ShowCellToolTips = false;
			g_product_warehouse.ShowEditingIcon = false;
			g_product_warehouse.ShowRowErrors = false;
			g_product_warehouse.Size = new Size(718, 715);
			g_product_warehouse.TabIndex = 2;
			// 
			// g_warehouse
			// 
			g_warehouse.AllowUserToAddRows = false;
			g_warehouse.AllowUserToDeleteRows = false;
			g_warehouse.AllowUserToResizeRows = false;
			g_warehouse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			g_warehouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_warehouse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_warehouse.BackgroundColor = Color.White;
			g_warehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_warehouse.GridColor = Color.White;
			g_warehouse.Location = new Point(3, 3);
			g_warehouse.MultiSelect = false;
			g_warehouse.Name = "g_warehouse";
			g_warehouse.ReadOnly = true;
			g_warehouse.RowHeadersVisible = false;
			g_warehouse.RowHeadersWidth = 51;
			tableLayoutPanel2.SetRowSpan(g_warehouse, 2);
			g_warehouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_warehouse.ShowCellErrors = false;
			g_warehouse.ShowCellToolTips = false;
			g_warehouse.ShowEditingIcon = false;
			g_warehouse.ShowRowErrors = false;
			g_warehouse.Size = new Size(718, 795);
			g_warehouse.TabIndex = 1;
			g_warehouse.SelectionChanged += g_warehouse_SelectionChanged;
			// 
			// panel2
			// 
			panel2.Controls.Add(p_delete_pw);
			panel2.Controls.Add(b_update_pw);
			panel2.Controls.Add(b_add_pw);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(727, 724);
			panel2.Name = "panel2";
			panel2.Size = new Size(718, 74);
			panel2.TabIndex = 3;
			// 
			// p_delete_pw
			// 
			p_delete_pw.BackColor = Color.FromArgb(255, 192, 192);
			p_delete_pw.Location = new Point(473, 9);
			p_delete_pw.Name = "p_delete_pw";
			p_delete_pw.Size = new Size(215, 57);
			p_delete_pw.TabIndex = 6;
			p_delete_pw.Text = "🗑️ Удалить";
			toolTip1.SetToolTip(p_delete_pw, "Удалить выбранную запись");
			p_delete_pw.UseVisualStyleBackColor = false;
			p_delete_pw.Click += DeleteProductWarehouse;
			// 
			// b_update_pw
			// 
			b_update_pw.BackColor = Color.FromArgb(175, 225, 255);
			b_update_pw.Location = new Point(252, 9);
			b_update_pw.Name = "b_update_pw";
			b_update_pw.Size = new Size(215, 57);
			b_update_pw.TabIndex = 5;
			b_update_pw.Text = "✏️ Изменить";
			toolTip1.SetToolTip(b_update_pw, "Изменить выбранную запись");
			b_update_pw.UseVisualStyleBackColor = false;
			b_update_pw.Click += UpdateProductWarehouse;
			// 
			// b_add_pw
			// 
			b_add_pw.BackColor = Color.FromArgb(192, 255, 192);
			b_add_pw.Location = new Point(31, 9);
			b_add_pw.Name = "b_add_pw";
			b_add_pw.Size = new Size(215, 57);
			b_add_pw.TabIndex = 4;
			b_add_pw.Text = "+ Добавить";
			toolTip1.SetToolTip(b_add_pw, "Добавить новую запись");
			b_add_pw.UseVisualStyleBackColor = false;
			b_add_pw.Click += AddProductWarehouse;
			// 
			// shops
			// 
			shops.Controls.Add(tableLayoutPanel3);
			shops.Location = new Point(4, 29);
			shops.Name = "shops";
			shops.Padding = new Padding(3);
			shops.Size = new Size(1454, 814);
			shops.TabIndex = 1;
			shops.Text = "Магазины";
			shops.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(g_shop, 0, 0);
			tableLayoutPanel3.Controls.Add(g_distance, 1, 0);
			tableLayoutPanel3.Controls.Add(panel3, 1, 1);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 3);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tableLayoutPanel3.Size = new Size(1448, 808);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// g_shop
			// 
			g_shop.AllowUserToAddRows = false;
			g_shop.AllowUserToDeleteRows = false;
			g_shop.AllowUserToResizeRows = false;
			g_shop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			g_shop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_shop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_shop.BackgroundColor = Color.White;
			g_shop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_shop.GridColor = Color.White;
			g_shop.Location = new Point(3, 3);
			g_shop.MultiSelect = false;
			g_shop.Name = "g_shop";
			g_shop.ReadOnly = true;
			g_shop.RowHeadersVisible = false;
			g_shop.RowHeadersWidth = 51;
			tableLayoutPanel3.SetRowSpan(g_shop, 2);
			g_shop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_shop.ShowCellErrors = false;
			g_shop.ShowCellToolTips = false;
			g_shop.ShowEditingIcon = false;
			g_shop.ShowRowErrors = false;
			g_shop.Size = new Size(718, 802);
			g_shop.TabIndex = 2;
			g_shop.SelectionChanged += g_shop_SelectionChanged;
			// 
			// g_distance
			// 
			g_distance.AllowUserToAddRows = false;
			g_distance.AllowUserToDeleteRows = false;
			g_distance.AllowUserToResizeRows = false;
			g_distance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			g_distance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_distance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_distance.BackgroundColor = Color.White;
			g_distance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_distance.GridColor = Color.White;
			g_distance.Location = new Point(727, 3);
			g_distance.MultiSelect = false;
			g_distance.Name = "g_distance";
			g_distance.ReadOnly = true;
			g_distance.RowHeadersVisible = false;
			g_distance.RowHeadersWidth = 51;
			g_distance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_distance.ShowCellErrors = false;
			g_distance.ShowCellToolTips = false;
			g_distance.ShowEditingIcon = false;
			g_distance.ShowRowErrors = false;
			g_distance.Size = new Size(718, 722);
			g_distance.TabIndex = 3;
			// 
			// panel3
			// 
			panel3.Controls.Add(b_delete_d);
			panel3.Controls.Add(b_update_d);
			panel3.Controls.Add(b_add_d);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(727, 731);
			panel3.Name = "panel3";
			panel3.Size = new Size(718, 74);
			panel3.TabIndex = 4;
			// 
			// b_delete_d
			// 
			b_delete_d.BackColor = Color.FromArgb(255, 192, 192);
			b_delete_d.Location = new Point(473, 9);
			b_delete_d.Name = "b_delete_d";
			b_delete_d.Size = new Size(215, 57);
			b_delete_d.TabIndex = 6;
			b_delete_d.Text = "🗑️ Удалить";
			toolTip1.SetToolTip(b_delete_d, "Удалить выбранную запись");
			b_delete_d.UseVisualStyleBackColor = false;
			b_delete_d.Click += DeleteDistance;
			// 
			// b_update_d
			// 
			b_update_d.BackColor = Color.FromArgb(175, 225, 255);
			b_update_d.Location = new Point(252, 9);
			b_update_d.Name = "b_update_d";
			b_update_d.Size = new Size(215, 57);
			b_update_d.TabIndex = 5;
			b_update_d.Text = "✏️ Изменить";
			toolTip1.SetToolTip(b_update_d, "Изменить выбранную запись");
			b_update_d.UseVisualStyleBackColor = false;
			b_update_d.Click += UpdateDistance;
			// 
			// b_add_d
			// 
			b_add_d.BackColor = Color.FromArgb(192, 255, 192);
			b_add_d.Location = new Point(31, 9);
			b_add_d.Name = "b_add_d";
			b_add_d.Size = new Size(215, 57);
			b_add_d.TabIndex = 4;
			b_add_d.Text = "+ Добавить";
			toolTip1.SetToolTip(b_add_d, "Добавить новую запись");
			b_add_d.UseVisualStyleBackColor = false;
			b_add_d.Click += AddDistance;
			// 
			// products
			// 
			products.Controls.Add(tableLayoutPanel1);
			products.Location = new Point(4, 29);
			products.Name = "products";
			products.Padding = new Padding(3);
			products.Size = new Size(1454, 814);
			products.TabIndex = 3;
			products.Text = "Продукты";
			products.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(g_product, 0, 0);
			tableLayoutPanel1.Controls.Add(g_product_resource, 1, 0);
			tableLayoutPanel1.Controls.Add(panel1, 1, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.Size = new Size(1448, 808);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// g_product
			// 
			g_product.AllowUserToAddRows = false;
			g_product.AllowUserToDeleteRows = false;
			g_product.AllowUserToResizeRows = false;
			g_product.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			g_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_product.BackgroundColor = Color.White;
			g_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_product.GridColor = Color.White;
			g_product.Location = new Point(3, 3);
			g_product.MultiSelect = false;
			g_product.Name = "g_product";
			g_product.ReadOnly = true;
			g_product.RowHeadersVisible = false;
			g_product.RowHeadersWidth = 51;
			tableLayoutPanel1.SetRowSpan(g_product, 2);
			g_product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_product.ShowCellErrors = false;
			g_product.ShowCellToolTips = false;
			g_product.ShowEditingIcon = false;
			g_product.ShowRowErrors = false;
			g_product.Size = new Size(718, 802);
			g_product.TabIndex = 3;
			g_product.SelectionChanged += g_product_SelectionChanged;
			// 
			// g_product_resource
			// 
			g_product_resource.AllowUserToAddRows = false;
			g_product_resource.AllowUserToDeleteRows = false;
			g_product_resource.AllowUserToResizeRows = false;
			g_product_resource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			g_product_resource.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_product_resource.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_product_resource.BackgroundColor = Color.White;
			g_product_resource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_product_resource.GridColor = Color.White;
			g_product_resource.Location = new Point(727, 3);
			g_product_resource.MultiSelect = false;
			g_product_resource.Name = "g_product_resource";
			g_product_resource.ReadOnly = true;
			g_product_resource.RowHeadersVisible = false;
			g_product_resource.RowHeadersWidth = 51;
			g_product_resource.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_product_resource.ShowCellErrors = false;
			g_product_resource.ShowCellToolTips = false;
			g_product_resource.ShowEditingIcon = false;
			g_product_resource.ShowRowErrors = false;
			g_product_resource.Size = new Size(718, 722);
			g_product_resource.TabIndex = 3;
			// 
			// panel1
			// 
			panel1.Controls.Add(b_delete_pr);
			panel1.Controls.Add(b_update_pr);
			panel1.Controls.Add(b_add_pr);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(727, 731);
			panel1.Name = "panel1";
			panel1.Size = new Size(718, 74);
			panel1.TabIndex = 4;
			// 
			// b_delete_pr
			// 
			b_delete_pr.BackColor = Color.FromArgb(255, 192, 192);
			b_delete_pr.Location = new Point(473, 9);
			b_delete_pr.Name = "b_delete_pr";
			b_delete_pr.Size = new Size(215, 57);
			b_delete_pr.TabIndex = 6;
			b_delete_pr.Text = "🗑️ Удалить";
			toolTip1.SetToolTip(b_delete_pr, "Удалить выбранную запись");
			b_delete_pr.UseVisualStyleBackColor = false;
			b_delete_pr.Click += DeleteProductResource;
			// 
			// b_update_pr
			// 
			b_update_pr.BackColor = Color.FromArgb(175, 225, 255);
			b_update_pr.Location = new Point(252, 9);
			b_update_pr.Name = "b_update_pr";
			b_update_pr.Size = new Size(215, 57);
			b_update_pr.TabIndex = 5;
			b_update_pr.Text = "✏️ Изменить";
			toolTip1.SetToolTip(b_update_pr, "Изменить выбранную запись");
			b_update_pr.UseVisualStyleBackColor = false;
			b_update_pr.Click += UpdateProductResource;
			// 
			// b_add_pr
			// 
			b_add_pr.BackColor = Color.FromArgb(192, 255, 192);
			b_add_pr.Location = new Point(31, 9);
			b_add_pr.Name = "b_add_pr";
			b_add_pr.Size = new Size(215, 57);
			b_add_pr.TabIndex = 4;
			b_add_pr.Text = "+ Добавить";
			toolTip1.SetToolTip(b_add_pr, "Добавить новую запись");
			b_add_pr.UseVisualStyleBackColor = false;
			b_add_pr.Click += AddProductResource;
			// 
			// resourses
			// 
			resourses.Controls.Add(g_resourse);
			resourses.Location = new Point(4, 29);
			resourses.Name = "resourses";
			resourses.Padding = new Padding(3);
			resourses.Size = new Size(1454, 814);
			resourses.TabIndex = 4;
			resourses.Text = "Ресурсы";
			resourses.UseVisualStyleBackColor = true;
			// 
			// g_resourse
			// 
			g_resourse.AllowUserToAddRows = false;
			g_resourse.AllowUserToDeleteRows = false;
			g_resourse.AllowUserToResizeRows = false;
			g_resourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_resourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_resourse.BackgroundColor = Color.White;
			g_resourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_resourse.Dock = DockStyle.Fill;
			g_resourse.GridColor = Color.White;
			g_resourse.Location = new Point(3, 3);
			g_resourse.MultiSelect = false;
			g_resourse.Name = "g_resourse";
			g_resourse.ReadOnly = true;
			g_resourse.RowHeadersVisible = false;
			g_resourse.RowHeadersWidth = 51;
			g_resourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_resourse.ShowCellErrors = false;
			g_resourse.ShowCellToolTips = false;
			g_resourse.ShowEditingIcon = false;
			g_resourse.ShowRowErrors = false;
			g_resourse.Size = new Size(1448, 808);
			g_resourse.TabIndex = 4;
			// 
			// companies
			// 
			companies.Controls.Add(g_company);
			companies.Location = new Point(4, 29);
			companies.Name = "companies";
			companies.Size = new Size(1454, 814);
			companies.TabIndex = 5;
			companies.Text = "Компании";
			companies.UseVisualStyleBackColor = true;
			// 
			// g_company
			// 
			g_company.AllowUserToAddRows = false;
			g_company.AllowUserToDeleteRows = false;
			g_company.AllowUserToResizeRows = false;
			g_company.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_company.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_company.BackgroundColor = Color.White;
			g_company.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_company.Dock = DockStyle.Fill;
			g_company.GridColor = Color.White;
			g_company.Location = new Point(0, 0);
			g_company.MultiSelect = false;
			g_company.Name = "g_company";
			g_company.ReadOnly = true;
			g_company.RowHeadersVisible = false;
			g_company.RowHeadersWidth = 51;
			g_company.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_company.ShowCellErrors = false;
			g_company.ShowCellToolTips = false;
			g_company.ShowEditingIcon = false;
			g_company.ShowRowErrors = false;
			g_company.Size = new Size(1454, 814);
			g_company.TabIndex = 5;
			// 
			// investments
			// 
			investments.Controls.Add(g_investment);
			investments.Location = new Point(4, 29);
			investments.Name = "investments";
			investments.Size = new Size(1454, 814);
			investments.TabIndex = 6;
			investments.Text = "Инвестиции";
			investments.UseVisualStyleBackColor = true;
			// 
			// g_investment
			// 
			g_investment.AllowUserToAddRows = false;
			g_investment.AllowUserToDeleteRows = false;
			g_investment.AllowUserToResizeRows = false;
			g_investment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			g_investment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			g_investment.BackgroundColor = Color.White;
			g_investment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			g_investment.Dock = DockStyle.Fill;
			g_investment.GridColor = Color.White;
			g_investment.Location = new Point(0, 0);
			g_investment.MultiSelect = false;
			g_investment.Name = "g_investment";
			g_investment.ReadOnly = true;
			g_investment.RowHeadersVisible = false;
			g_investment.RowHeadersWidth = 51;
			g_investment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g_investment.ShowCellErrors = false;
			g_investment.ShowCellToolTips = false;
			g_investment.ShowEditingIcon = false;
			g_investment.ShowRowErrors = false;
			g_investment.Size = new Size(1454, 814);
			g_investment.TabIndex = 6;
			// 
			// b_add
			// 
			b_add.BackColor = Color.FromArgb(192, 255, 192);
			b_add.Location = new Point(16, 891);
			b_add.Name = "b_add";
			b_add.Size = new Size(215, 57);
			b_add.TabIndex = 1;
			b_add.Text = "+ Добавить";
			toolTip1.SetToolTip(b_add, "Добавить новую запись");
			b_add.UseVisualStyleBackColor = false;
			b_add.Click += b_add_Click;
			// 
			// b_edit
			// 
			b_edit.BackColor = Color.FromArgb(175, 225, 255);
			b_edit.Location = new Point(237, 891);
			b_edit.Name = "b_edit";
			b_edit.Size = new Size(215, 57);
			b_edit.TabIndex = 2;
			b_edit.Text = "✏️ Изменить";
			toolTip1.SetToolTip(b_edit, "Изменить выбранную запись");
			b_edit.UseVisualStyleBackColor = false;
			b_edit.Click += b_edit_Click;
			// 
			// b_delete
			// 
			b_delete.BackColor = Color.FromArgb(255, 192, 192);
			b_delete.Location = new Point(458, 891);
			b_delete.Name = "b_delete";
			b_delete.Size = new Size(215, 57);
			b_delete.TabIndex = 3;
			b_delete.Text = "🗑️ Удалить";
			toolTip1.SetToolTip(b_delete, "Удалить выбранную запись");
			b_delete.UseVisualStyleBackColor = false;
			b_delete.Click += b_delete_Click;
			// 
			// b_exit
			// 
			b_exit.BackColor = Color.LightCoral;
			b_exit.Location = new Point(1328, 891);
			b_exit.Name = "b_exit";
			b_exit.Size = new Size(142, 57);
			b_exit.TabIndex = 4;
			b_exit.Text = "Выход";
			toolTip1.SetToolTip(b_exit, "Выход из приложения");
			b_exit.UseVisualStyleBackColor = false;
			b_exit.Click += b_exit_Click;
			// 
			// menu
			// 
			menu.ImageScalingSize = new Size(20, 20);
			menu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
			menu.Location = new Point(0, 0);
			menu.Name = "menu";
			menu.Size = new Size(1486, 35);
			menu.TabIndex = 5;
			menu.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
			toolStripMenuItem1.Font = new Font("Consolas", 13.8F);
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(208, 31);
			toolStripMenuItem1.Text = "Меню подсистем";
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(397, 32);
			toolStripMenuItem2.Text = "Симплекс";
			// 
			// toolStripMenuItem3
			// 
			toolStripMenuItem3.Name = "toolStripMenuItem3";
			toolStripMenuItem3.Size = new Size(397, 32);
			toolStripMenuItem3.Text = "Обновление оборудования";
			toolStripMenuItem3.Click += toolStripMenuItem3_Click;
			// 
			// toolStripMenuItem4
			// 
			toolStripMenuItem4.Name = "toolStripMenuItem4";
			toolStripMenuItem4.Size = new Size(397, 32);
			toolStripMenuItem4.Text = "Рассчёт кол-ва касс";
			toolStripMenuItem4.Click += toolStripMenuItem4_Click;
			// 
			// toolTip1
			// 
			toolTip1.AutoPopDelay = 5000;
			toolTip1.InitialDelay = 500;
			toolTip1.ReshowDelay = 50;
			toolTip1.ToolTipIcon = ToolTipIcon.Info;
			toolTip1.ToolTipTitle = "Подсказка";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(1486, 960);
			Controls.Add(b_exit);
			Controls.Add(b_delete);
			Controls.Add(b_edit);
			Controls.Add(b_add);
			Controls.Add(mainTabControl);
			Controls.Add(menu);
			Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menu;
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Главное окно";
			Load += MainForm_Load;
			mainTabControl.ResumeLayout(false);
			warehouses.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)g_product_warehouse).EndInit();
			((System.ComponentModel.ISupportInitialize)g_warehouse).EndInit();
			panel2.ResumeLayout(false);
			shops.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)g_shop).EndInit();
			((System.ComponentModel.ISupportInitialize)g_distance).EndInit();
			panel3.ResumeLayout(false);
			products.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)g_product).EndInit();
			((System.ComponentModel.ISupportInitialize)g_product_resource).EndInit();
			panel1.ResumeLayout(false);
			resourses.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)g_resourse).EndInit();
			companies.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)g_company).EndInit();
			investments.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)g_investment).EndInit();
			menu.ResumeLayout(false);
			menu.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl mainTabControl;
        private TabPage warehouses;
        private TabPage shops;
        private Button b_add;
        private Button b_edit;
        private Button b_delete;
        private Button b_exit;
        private TabPage products;
        private TabPage resourses;
        private MenuStrip menu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolTip toolTip1;
		private TabPage companies;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView g_product;
        private DataGridView g_product_resource;
        private DataGridView g_resourse;
        private Panel panel1;
        private Button b_delete_pr;
        private Button b_update_pr;
        private Button b_add_pr;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView g_product_warehouse;
        private DataGridView g_warehouse;
        private DataGridView g_company;
        private Panel panel2;
        private Button p_delete_pw;
        private Button b_update_pw;
        private Button b_add_pw;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView g_shop;
        private DataGridView g_distance;
        private Panel panel3;
        private Button b_delete_d;
        private Button b_update_d;
        private Button b_add_d;
        private TabPage investments;
        private DataGridView g_investment;
    }
}