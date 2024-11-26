using BusinessLogic.Entities;
using BusinessLogic.Extensions;
using BusinessLogic.Interfaces;
using BusinessLogic.Presentation.Dialogs;
using System.ComponentModel;

namespace BusinessLogic.Presentation
{
    public partial class MainForm : Form
    {
        //Списки
        private BindingList<Company> listCompanies = [];
        private BindingList<Distance> listDistances = [];
        private BindingList<Product> listProducts = [];
        private BindingList<Resource> listResources = [];
        private BindingList<Shop> listShops = [];
        private BindingList<Warehouse> listWarehouses = [];
        private BindingList<ProductResource> listProductResource = [];
        private BindingList<ProductWarehouse> listProductWarehouse = [];
        private BindingList<Distance> listDistance = [];
        private BindingList<Investment> listInvestments = [];

        //Репозитории
        private readonly IRepository<Company> companyRepository;
        private readonly IRepository<Product> productRepository;
        private readonly IRepository<Resource> resourceRepository;
        private readonly IRepository<Shop> shopRepository;
        private readonly IRepository<Warehouse> warehouseRepository;
        private readonly IRepository<Investment> investmentRepository;
        private readonly IProductResourceRepository productResourceRepository;
        private readonly IProductWarehouseRepository productWarehouseRepository;
        private readonly IDistanceRepository distanceRepository;

        //Сервисы
        private readonly IUnitOfWork unitOfWork;

        public MainForm(IRepository<Company> companyRepository, IRepository<Product> productRepository, IRepository<Resource> resourceRepository, IRepository<Shop> shopRepository, IRepository<Warehouse> warehouseRepository, IRepository<Investment> investmentRepository, IProductResourceRepository productResourceRepository, IProductWarehouseRepository productWarehouseRepository, IDistanceRepository distanceRepository, IUnitOfWork unitOfWork)
        {
            this.companyRepository = companyRepository;
            this.productRepository = productRepository;
            this.resourceRepository = resourceRepository;
            this.shopRepository = shopRepository;
            this.warehouseRepository = warehouseRepository;
            this.investmentRepository = investmentRepository;
            this.productResourceRepository = productResourceRepository;
            this.productWarehouseRepository = productWarehouseRepository;
            this.distanceRepository = distanceRepository;
            this.unitOfWork = unitOfWork;
            InitializeComponent();
        }

        #region Companies

        public async void AddCompany()
        {
            var dialog = new ProductDialog()
            {
                Text = "Добавление компании"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var company = Company.Create(
                    dialog.title.Text,
                    float.Parse(dialog.count.Text.Trim().Replace('.', ',')),
                    []
                );

                if (company.IsFailure)
                    throw new Exception(company.Error);

                await companyRepository.Add(company.Value);
                await unitOfWork.SaveChanges();
                listCompanies.Add(company.Value);
            }
        }

        public async void UpdateCompany()
        {
            int selectedIndex = g_company.SelectedRows[0].Index;
            var company = await companyRepository.GetById(listCompanies[selectedIndex].Id);

            if (company.Value is null)
                throw new Exception("company не найден");

            var dialog = new CompanyDialog
            {
                Text = "Редактирование компании",
                title = { Text = company.Value.Title },
                profit = { Text = company.Value.Profit.ToString() }
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                company.Value.UpdateInfo(
                    dialog.title.Text,
                    float.Parse(dialog.profit.Text.Trim().Replace('.', ',')));

                companyRepository.Save(company.Value);
                await unitOfWork.SaveChanges();
                listCompanies[selectedIndex] = company.Value;
            }
        }

        public async void DeleteCompany()
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_company.SelectedRows[0].Index;
                var company = await companyRepository.GetById(listCompanies[selectedIndex].Id);

                if (company.Value is null)
                    throw new Exception("company не найден");

                companyRepository.Delete(company.Value);
                await unitOfWork.SaveChanges();
                listCompanies.RemoveAt(selectedIndex);
            }
        }

        #endregion

        #region Products

        public async void AddProduct()
        {
            var dialog = new ProductDialog()
            {
                Text = "Добавление товара"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var product = Product.Create(
                    dialog.title.Text,
                    int.Parse(dialog.count.Text),
                    [],
                    []);

                if (product.IsFailure) throw new Exception(product.Error);

                await productRepository.Add(product.Value);
                await unitOfWork.SaveChanges();
                listProducts.Add(product.Value);
            }
        }

        public async void UpdateProduct()
        {
            int selectedIndex = g_product.SelectedRows[0].Index;
            var product = await productRepository.GetById(listProducts[selectedIndex].Id);

            if (product.Value is null) throw new Exception("product не найден");

            var dialog = new ProductDialog
            {
                Text = "Редактирование товара",
                title = { Text = product.Value.Title },
                count = { Text = product.Value.Cost.ToString() }
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                product.Value.UpdateInfo(
                    dialog.title.Text,
                    int.Parse(dialog.count.Text));

                productRepository.Save(product.Value);
                await unitOfWork.SaveChanges();
                listProducts[selectedIndex] = product.Value;
            }
        }

        public async void DeleteProduct()
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_product.SelectedRows[0].Index;
                var product = await productRepository.GetById(listProducts[selectedIndex].Id);

                if (product.Value is null) throw new Exception("product не найден");

                productRepository.Delete(product.Value);
                await unitOfWork.SaveChanges();
                listProducts.RemoveAt(selectedIndex);
            }
        }

        private async void g_product_SelectionChanged(object sender, EventArgs e)
        {
            if (g_product.SelectedRows.Count == 0) return;

            int selectedIndex = g_product.SelectedRows[0].Index;
            var product = await productRepository.GetById(listProducts[selectedIndex].Id);
            if (product.Value is null) throw new Exception("product не найден");

            listProductResource.Clear();
            listProductResource.AddRange(product.Value.ProductResources.ToList());

        }

        #endregion

        #region ProductResources

        public async void AddProductResource(object sender, EventArgs e)
        {
            if (g_product.SelectedRows.Count == 0) return;

            int selectedIndex = g_product.SelectedRows[0].Index;
            var product = await productRepository.GetById(listProducts[selectedIndex].Id);
            if (product.Value is null) throw new Exception("product не найден");

            var dialog = new ProductResourceDialog()
            {
                Text = "Добавление ресурса",
            };

            var resources = await resourceRepository.GetAll();
            dialog.resorces.DataSource = resources.Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedResource = dialog.resorces.SelectedItem as Resource ?? throw new InvalidOperationException("Ресурс не выбран");

                var productResource = ProductResource.Create(
                    product.Value,
                    selectedResource,
                    int.Parse(dialog.quantity.Text));

                if (listProductResource.Any(pr => pr.ProductId == productResource.Value.ProductId && pr.ResourceId == productResource.Value.ResourceId))
                {
                    MessageBox.Show("Запись уже существует!");
                    AddProductResource(sender, e);
                    return;
                }

                if (productResource.IsFailure) throw new Exception(productResource.Error);

                await productResourceRepository.Add(productResource.Value);

                await unitOfWork.SaveChanges();
                listProductResource.Add(productResource.Value);
            }
        }

        public async void UpdateProductResource(object sender, EventArgs e)
        {
            int selectedIndex = g_product_resource.SelectedRows[0].Index;
            var productResource = await productResourceRepository.GetById(listProductResource[selectedIndex].ProductId, listProductResource[selectedIndex].ResourceId);

            if (productResource.Value is null) throw new Exception("productResource не найден");

            var dialog = new ProductResourceDialog
            {
                Text = "Редактирование ресурсов",
                quantity = { Text = productResource.Value.Quantity.ToString() }
            };

            var resources = await resourceRepository.GetAll();
            dialog.resorces.DataSource = resources.Value;
            dialog.resorces.SelectedItem = productResource.Value.Resource;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedResourceId = (dialog.resorces.SelectedItem as Resource ?? throw new InvalidOperationException("Ресурс не выбран")).Id;

                if (productResource.Value.ResourceId != selectedResourceId && listProductResource.Any(pr => pr.ResourceId == selectedResourceId))
                {
                    MessageBox.Show("Запись уже существует!");
                    UpdateProductWarehouse(sender, e);
                    return;
                }

                productResource.Value.UpdateInfo(
                    selectedResourceId,
                    int.Parse(dialog.quantity.Text));

                productResourceRepository.Save(productResource.Value);
                await unitOfWork.SaveChanges();
                listProductResource[selectedIndex] = productResource.Value;
            }
        }

        public async void DeleteProductResource(object sender, EventArgs e)
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_product_resource.SelectedRows[0].Index;
                var productResource = await productResourceRepository.GetById(listProductResource[selectedIndex].ProductId, listProductResource[selectedIndex].ResourceId);

                if (productResource.Value is null) throw new Exception("productResource не найден");

                productResourceRepository.Delete(productResource.Value);
                await unitOfWork.SaveChanges();
                listProductResource.RemoveAt(selectedIndex);
            }
        }


        #endregion

        #region Warehouses

        public async void AddWarehouse()
        {
            var dialog = new WarehouseDialog()
            {
                Text = "Добавление склада"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var warehouse = Warehouse.Create(
                    dialog.title.Text,
                    [],
                    []);

                if (warehouse.IsFailure) throw new Exception(warehouse.Error);

                await warehouseRepository.Add(warehouse.Value);
                await unitOfWork.SaveChanges();
                listWarehouses.Add(warehouse.Value);
            }
        }

        public async void UpdateWarehouse()
        {
            int selectedIndex = g_warehouse.SelectedRows[0].Index;
            var warehouse = await warehouseRepository.GetById(listWarehouses[selectedIndex].Id);

            if (warehouse.Value is null) throw new Exception("warehouse не найден");

            var dialog = new WarehouseDialog
            {
                Text = "Редактирование склада",
                title = { Text = warehouse.Value.Title },
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                warehouse.Value.UpdateInfo(
                    dialog.title.Text);

                warehouseRepository.Save(warehouse.Value);
                await unitOfWork.SaveChanges();
                listWarehouses[selectedIndex] = warehouse.Value;
            }
        }

        public async void DeleteWarehouse()
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_warehouse.SelectedRows[0].Index;
                var warehouse = await warehouseRepository.GetById(listWarehouses[selectedIndex].Id);

                if (warehouse.Value is null) throw new Exception("warehouse не найден");

                warehouseRepository.Delete(warehouse.Value);
                await unitOfWork.SaveChanges();
                listWarehouses.RemoveAt(selectedIndex);
            }
        }

        private async void g_warehouse_SelectionChanged(object sender, EventArgs e)
        {
            if (g_warehouse.SelectedRows.Count == 0) return;

            int selectedIndex = g_warehouse.SelectedRows[0].Index;
            var warehouse = await warehouseRepository.GetById(listWarehouses[selectedIndex].Id);
            if (warehouse.Value is null) throw new Exception("warehouse не найден");

            listProductWarehouse.Clear();
            listProductWarehouse.AddRange(warehouse.Value.ProductWarehouses.ToList());
        }

        #endregion

        #region ProductWarehouses

        public async void AddProductWarehouse(object sender, EventArgs e)
        {
            if (g_warehouse.SelectedRows.Count == 0) return;

            int selectedIndex = g_warehouse.SelectedRows[0].Index;
            var warehouse = await warehouseRepository.GetById(listWarehouses[selectedIndex].Id);
            if (warehouse.Value is null) throw new Exception("warehouse не найден");

            var dialog = new ProductWarehouseDialog()
            {
                Text = "Добавление товаров",
            };

            var products = await productRepository.GetAll();
            dialog.products.DataSource = products.Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedProduct = dialog.products.SelectedItem as Product ?? throw new InvalidOperationException("Товар не выбран");

                var productWarehouse = ProductWarehouse.Create(
                    selectedProduct,
                    warehouse.Value,
                    int.Parse(dialog.quantity.Text));

                if (productWarehouse.IsFailure) throw new Exception(productWarehouse.Error);

                if (listProductWarehouse.Any(pr => pr.ProductId == productWarehouse.Value.ProductId && pr.WarehouseId == productWarehouse.Value.WarehouseId))
                {
                    MessageBox.Show("Запись уже существует!");
                    AddProductWarehouse(sender, e);
                    return;
                }

                await productWarehouseRepository.Add(productWarehouse.Value);

                await unitOfWork.SaveChanges();
                listProductWarehouse.Add(productWarehouse.Value);
            }
        }

        public async void UpdateProductWarehouse(object sender, EventArgs e)
        {
            int selectedIndex = g_product_warehouse.SelectedRows[0].Index;
            var productWarehouse = await productWarehouseRepository.GetById(listProductWarehouse[selectedIndex].ProductId, listProductWarehouse[selectedIndex].WarehouseId);

            if (productWarehouse.Value is null) throw new Exception("productWarehouse не найден");

            var dialog = new ProductWarehouseDialog
            {
                Text = "Редактирование товаров",
                quantity = { Text = productWarehouse.Value.Quantity.ToString() }
            };

            var products = await productRepository.GetAll();
            dialog.products.DataSource = products.Value;
            dialog.products.SelectedItem = productWarehouse.Value.Product;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedProductId = (dialog.products.SelectedItem as Product ?? throw new InvalidOperationException("Товар не выбран")).Id;

                if (productWarehouse.Value.ProductId != selectedProductId && listProductWarehouse.Any(pr => pr.ProductId == selectedProductId))
                {
                    MessageBox.Show("Запись уже существует!");
                    UpdateProductWarehouse(sender, e);
                    return;
                }

                productWarehouse.Value.UpdateInfo(
                    selectedProductId,
                    int.Parse(dialog.quantity.Text));

                productWarehouseRepository.Save(productWarehouse.Value);
                await unitOfWork.SaveChanges();
                listProductWarehouse[selectedIndex] = productWarehouse.Value;
            }
        }

        public async void DeleteProductWarehouse(object sender, EventArgs e)
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_product_warehouse.SelectedRows[0].Index;
                var productWarehouse = await productWarehouseRepository.GetById(listProductWarehouse[selectedIndex].ProductId, listProductWarehouse[selectedIndex].WarehouseId);

                if (productWarehouse.Value is null) throw new Exception("productWarehouse не найден");

                productWarehouseRepository.Delete(productWarehouse.Value);
                await unitOfWork.SaveChanges();
                listProductWarehouse.RemoveAt(selectedIndex);
            }
        }


        #endregion

        #region Shops

        public async void AddShop()
        {
            var dialog = new ShopDialog()
            {
                Text = "Добавление магазина",
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var shop = Shop.Create(
                    dialog.title.Text, []);

                if (shop.IsFailure) throw new Exception(shop.Error);

                await shopRepository.Add(shop.Value);
                await unitOfWork.SaveChanges();
                listShops.Add(shop.Value);
            }
        }

        public async void UpdateShop()
        {
            int selectedIndex = g_shop.SelectedRows[0].Index;
            var shop = await shopRepository.GetById(listShops[selectedIndex].Id);

            if (shop.Value is null) throw new Exception("shop не найден");

            var dialog = new WarehouseDialog
            {
                Text = "Редактирование магазина",
                title = { Text = shop.Value.Title },
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                shop.Value.UpdateInfo(
                    dialog.title.Text);

                shopRepository.Save(shop.Value);
                await unitOfWork.SaveChanges();
                listShops[selectedIndex] = shop.Value;
            }
        }

        public async void DeleteShop()
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_shop.SelectedRows[0].Index;
                var shop = await shopRepository.GetById(listShops[selectedIndex].Id);

                if (shop.Value is null) throw new Exception("shop не найден");

                shopRepository.Delete(shop.Value);
                await unitOfWork.SaveChanges();
                listShops.RemoveAt(selectedIndex);
            }
        }

        private async void g_shop_SelectionChanged(object sender, EventArgs e)
        {
            if (g_shop.SelectedRows.Count == 0) return;

            int selectedIndex = g_shop.SelectedRows[0].Index;
            var shop = await shopRepository.GetById(listShops[selectedIndex].Id);
            if (shop.Value is null) throw new Exception("shop не найден");

            listDistance.Clear();
            listDistance.AddRange(shop.Value.Distances.ToList());
        }

        #endregion

        #region Distances

        public async void AddDistance(object sender, EventArgs e)
        {
            if (g_shop.SelectedRows.Count == 0) return;

            int selectedIndex = g_shop.SelectedRows[0].Index;
            var shop = await shopRepository.GetById(listShops[selectedIndex].Id);
            if (shop.Value is null) throw new Exception("shop не найден");

            var dialog = new DistanceDialog()
            {
                Text = "Добавление дистанции",
            };

            var warehouses = await warehouseRepository.GetAll();
            dialog.warehouses.DataSource = warehouses.Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedWarehouse = dialog.warehouses.SelectedItem as Warehouse ?? throw new InvalidOperationException("Склад не выбран");

                var distance = Distance.Create(
                    shop.Value,
                    selectedWarehouse,
                    int.Parse(dialog.length.Text));

                if (distance.IsFailure) throw new Exception(distance.Error);

                if (listDistance.Any(pr => pr.WarehouseId == distance.Value.WarehouseId && pr.ShopId == distance.Value.ShopId))
                {
                    MessageBox.Show("Запись уже существует!");
                    AddDistance(sender, e);
                    return;
                }

                await distanceRepository.Add(distance.Value);

                await unitOfWork.SaveChanges();
                listDistance.Add(distance.Value);
            }
        }

        public async void UpdateDistance(object sender, EventArgs e)
        {
            int selectedIndex = g_distance.SelectedRows[0].Index;
            var distance = await distanceRepository.GetById(listDistance[selectedIndex].ShopId, listDistance[selectedIndex].WarehouseId);

            if (distance.Value is null) throw new Exception("distance не найден");

            var dialog = new DistanceDialog
            {
                Text = "Редактирование дистанции",
                length = { Text = distance.Value.Length.ToString() }
            };

            var warehouses = await warehouseRepository.GetAll();
            dialog.warehouses.DataSource = warehouses.Value;
            dialog.warehouses.SelectedItem = distance.Value.Warehouse;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedWarehouseId = (dialog.warehouses.SelectedItem as Warehouse ?? throw new InvalidOperationException("Склад не выбран")).Id;

                if (distance.Value.WarehouseId != selectedWarehouseId && listDistance.Any(pr => pr.WarehouseId == selectedWarehouseId))
                {
                    MessageBox.Show("Запись уже существует!");
                    UpdateDistance(sender, e);
                    return;
                }

                distance.Value.UpdateInfo(
                    selectedWarehouseId,
                    int.Parse(dialog.length.Text));

                distanceRepository.Save(distance.Value);
                await unitOfWork.SaveChanges();
                listDistance[selectedIndex] = distance.Value;
            }
        }

        public async void DeleteDistance(object sender, EventArgs e)
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_distance.SelectedRows[0].Index;
                var distance = await distanceRepository.GetById(listDistance[selectedIndex].ShopId, listDistance[selectedIndex].WarehouseId);

                if (distance.Value is null) throw new Exception("distance не найден");

                distanceRepository.Delete(distance.Value);
                await unitOfWork.SaveChanges();
                listDistance.RemoveAt(selectedIndex);
            }
        }

        #endregion

        #region Resources

        public async void AddResource()
        {
            var dialog = new ResourceDialog()
            {
                Text = "Добавление ресурса",
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var resource = Resource.Create(
                    dialog.title.Text,
                    dialog.units.Text,
                    []);

                if (resource.IsFailure) throw new Exception(resource.Error);

                await resourceRepository.Add(resource.Value);
                await unitOfWork.SaveChanges();
                listResources.Add(resource.Value);
            }
        }

        public async void UpdateResource()
        {
            int selectedIndex = g_resourse.SelectedRows[0].Index;
            var resource = await resourceRepository.GetById(listResources[selectedIndex].Id);

            if (resource.Value is null) throw new Exception("resource не найден");

            var dialog = new ResourceDialog
            {
                Text = "Редактирование ресурса",
                title = { Text = resource.Value.Title },
                units = { Text = resource.Value.Unit },
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resource.Value.UpdateInfo(
                    dialog.title.Text,
                    dialog.units.Text);

                resourceRepository.Save(resource.Value);
                await unitOfWork.SaveChanges();
                listResources[selectedIndex] = resource.Value;
            }
        }

        public async void DeleteResource()
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_resourse.SelectedRows[0].Index;
                var resource = await resourceRepository.GetById(listResources[selectedIndex].Id);

                if (resource.Value is null) throw new Exception("resource не найден");

                resourceRepository.Delete(resource.Value);
                await unitOfWork.SaveChanges();
                listResources.RemoveAt(selectedIndex);
            }
        }

        #endregion

        #region Investments

        public async void AddInvestment()
        {
            var dialog = new InvestmentDialog()
            {
                Text = "Добавление инвестиции",
            };

            var companies = await companyRepository.GetAll();
            dialog.companies.DataSource = companies.Value;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedCompany = dialog.companies.SelectedItem as Company ?? throw new InvalidOperationException("Компания не выбран");

                var investment = Investment.Create(
                    selectedCompany,
                    float.Parse(dialog.amount.Text.Trim().Replace('.', ',')),
                    float.Parse(dialog.profit.Text.Trim().Replace('.', ',')));

                if (investment.IsFailure) throw new Exception(investment.Error);

                await investmentRepository.Add(investment.Value);
                await unitOfWork.SaveChanges();
                listInvestments.Add(investment.Value);
            }
        }

        public async void UpdateInvestment()
        {
            int selectedIndex = g_investment.SelectedRows[0].Index;
            var investment = await investmentRepository.GetById(listInvestments[selectedIndex].Id);

            if (investment.Value is null) throw new Exception("investment не найден");

            var dialog = new InvestmentDialog
            {
                Text = "Редактирование инвестиции",
                amount = { Text = investment.Value.Amount.ToString() },
                profit = { Text = investment.Value.Profit.ToString() },
            };

            var companies = await companyRepository.GetAll();
            dialog.companies.DataSource = companies.Value;
            dialog.companies.SelectedItem = investment.Value.Company;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var selectedCompanyId = (dialog.companies.SelectedItem as Company ?? throw new InvalidOperationException("Компания не выбран")).Id;

                investment.Value.UpdateInfo(
                    selectedCompanyId,
                    float.Parse(dialog.amount.Text.Trim().Replace('.', ',')),
                    float.Parse(dialog.profit.Text.Trim().Replace('.', ',')));

                investmentRepository.Save(investment.Value);
                await unitOfWork.SaveChanges();
                listInvestments[selectedIndex] = investment.Value;
            }
        }

        public async void DeleteInvestment()
        {
            if (InvokeDeleteDialog() == DialogResult.Yes)
            {
                int selectedIndex = g_investment.SelectedRows[0].Index;
                var investment = await investmentRepository.GetById(listInvestments[selectedIndex].Id);

                if (investment.Value is null) throw new Exception("investment не найден");

                investmentRepository.Delete(investment.Value);
                await unitOfWork.SaveChanges();
                listInvestments.RemoveAt(selectedIndex);
            }
        }

        #endregion

        #region Shared

        private DialogResult InvokeDeleteDialog() =>
            MessageBox.Show("Вы точно хотите удалить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        private void b_add_Click(object sender, EventArgs e)
        {
            switch (mainTabControl.SelectedIndex)
            {
                case 0: AddWarehouse(); break;
                case 1: AddShop(); break;
                case 2: AddProduct(); break;
                case 3: AddResource(); break;
                case 4: AddCompany(); break;
                case 5: AddInvestment(); break;
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            switch (mainTabControl.SelectedIndex)
            {
                case 0: UpdateWarehouse(); break;
                case 1: UpdateShop(); break;
                case 2: UpdateProduct(); break;
                case 3: UpdateResource(); break;
                case 4: UpdateCompany(); break;
                case 5: UpdateInvestment(); break;
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            switch (mainTabControl.SelectedIndex)
            {
                case 0: DeleteWarehouse(); break;
                case 1: DeleteShop(); break;
                case 2: DeleteProduct(); break;
                case 3: DeleteResource(); break;
                case 4: DeleteCompany(); break;
                case 5: DeleteInvestment(); break;
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            listWarehouses = new BindingList<Warehouse>(warehouseRepository.GetAll().Result.Value);
            g_warehouse.DataSource = listWarehouses;
            g_warehouse.Columns[0].HeaderText = "Название";
            InvisibleColumns(g_warehouse, 1);

            listShops = new BindingList<Shop>(shopRepository.GetAll().Result.Value);
            g_shop.DataSource = listShops;
            g_shop.Columns[0].HeaderText = "Название";
            InvisibleColumns(g_shop, 1);

            listProducts = new BindingList<Product>(productRepository.GetAll().Result.Value);
            g_product.DataSource = listProducts;
            g_product.Columns[0].HeaderText = "Товар";
            g_product.Columns[1].HeaderText = "Стоимость";
            InvisibleColumns(g_product, 2);

            listResources = new BindingList<Resource>(resourceRepository.GetAll().Result.Value);
            g_resourse.DataSource = listResources;
            g_resourse.Columns[0].HeaderText = "Название";
            g_resourse.Columns[1].HeaderText = "Eдиницы измерения";
            InvisibleColumns(g_resourse, 2);

            listCompanies = new BindingList<Company>(companyRepository.GetAll().Result.Value);
            g_company.DataSource = listCompanies;
            g_company.Columns[0].HeaderText = "Название";
            g_company.Columns[1].HeaderText = "Прибыль";
            InvisibleColumns(g_company, 2);


            g_product_resource.AutoGenerateColumns = false;
            g_product_resource.DataSource = listProductResource;
            g_product_resource.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ресурс", DataPropertyName = "ResourceTitle" });
            g_product_resource.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Количество", DataPropertyName = "Quantity" });
            InvisibleColumns(g_product_resource, 2);

            g_product_warehouse.AutoGenerateColumns = false;
            g_product_warehouse.DataSource = listProductWarehouse;
            g_product_warehouse.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Товар", DataPropertyName = "ProductTitle" });
            g_product_warehouse.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Количество", DataPropertyName = "Quantity" });
            InvisibleColumns(g_product_warehouse, 2);

            g_distance.AutoGenerateColumns = false;
            g_distance.DataSource = listDistance;
            g_distance.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Склад", DataPropertyName = "WarehouseTitle" });
            g_distance.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Дистанция", DataPropertyName = "Length" });
            InvisibleColumns(g_distance, 2);

            listInvestments = new BindingList<Investment>(investmentRepository.GetAll().Result.Value);
            g_investment.AutoGenerateColumns = false;
            g_investment.DataSource = listInvestments;
            g_investment.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Компания", DataPropertyName = "CompanyTitle" });
            g_investment.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Вклад", DataPropertyName = "Amount" });
            g_investment.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Прибыль", DataPropertyName = "Profit" });
            InvisibleColumns(g_investment, 3);


            void InvisibleColumns(DataGridView grid, int startIndex)
            {
                for (int i = startIndex; i < grid.Columns.Count; i++)
                    grid.Columns[i].Visible = false;
            }
        }



        #endregion

        #region MenuActions

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new UpdateEquipmentDialog().ShowDialog();
        }

        #endregion



    }
}
