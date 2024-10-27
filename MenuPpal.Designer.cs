namespace WindowsFormsApp1
{
    partial class MenuPpal
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPpal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEditorial = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTitulo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUbicacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAutor = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CardLibros = new MaterialSkin.Controls.MaterialCard();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtAutorBuscar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cardVenta = new MaterialSkin.Controls.MaterialCard();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVender = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.txtCodigoBuscar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscarCod = new MaterialSkin.Controls.MaterialButton();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.materialTabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.CardLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.cardVenta.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(425, 326);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(124, 67);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Agregar libro";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(596, 548);
            this.materialProgressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(310, 5);
            this.materialProgressBar1.TabIndex = 4;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(468, 598);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(173, 37);
            this.materialSwitch1.TabIndex = 5;
            this.materialSwitch1.Text = "materialSwitch1";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bloqueado.png");
            this.imageList1.Images.SetKeyName(1, "perfil-del-usuario.png");
            this.imageList1.Images.SetKeyName(2, "contrasena.png");
            this.imageList1.Images.SetKeyName(3, "bloqueado.png");
            this.imageList1.Images.SetKeyName(4, "busqueda-de-conocimiento.png");
            this.imageList1.Images.SetKeyName(5, "busqueda.png");
            this.imageList1.Images.SetKeyName(6, "buscar.png");
            this.imageList1.Images.SetKeyName(7, "libro (1).png");
            this.imageList1.Images.SetKeyName(8, "libro.png");
            this.imageList1.Images.SetKeyName(9, "agregar.png");
            this.imageList1.Images.SetKeyName(10, "ventas.png");
            this.imageList1.Images.SetKeyName(11, "flecha-izquierda.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(55, 55);
            this.materialTabControl1.Location = new System.Drawing.Point(4, 98);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(830, 575);
            this.materialTabControl1.TabIndex = 6;
            this.materialTabControl1.Click += new System.EventHandler(this.materialTabControl1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 59);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(822, 512);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Home";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(346, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido libreria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.kisspng_shop_building_facade_retail_clip_art_book_store_5b0c2c1b8b2ed6_8670724815275243795701;
            this.pictureBox1.Location = new System.Drawing.Point(154, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard2);
            this.tabPage1.ImageKey = "libro.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 59);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(822, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar libro";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.txtCodigo);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Controls.Add(this.txtCantidad);
            this.materialCard2.Controls.Add(this.txtEditorial);
            this.materialCard2.Controls.Add(this.txtPrecio);
            this.materialCard2.Controls.Add(this.txtTitulo);
            this.materialCard2.Controls.Add(this.txtUbicacion);
            this.materialCard2.Controls.Add(this.txtAutor);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(84, 22);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard2.Size = new System.Drawing.Size(604, 476);
            this.materialCard2.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.Hint = "Código";
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(73, 11);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(316, 50);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.Hint = "Cantidad";
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(73, 389);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(316, 50);
            this.txtCantidad.TabIndex = 13;
            this.txtCantidad.Text = "";
            this.txtCantidad.TrailingIcon = null;
            // 
            // txtEditorial
            // 
            this.txtEditorial.AnimateReadOnly = false;
            this.txtEditorial.BackColor = System.Drawing.Color.White;
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditorial.Depth = 0;
            this.txtEditorial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditorial.Hint = "Editorial";
            this.txtEditorial.LeadingIcon = null;
            this.txtEditorial.Location = new System.Drawing.Point(73, 200);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditorial.MaxLength = 50;
            this.txtEditorial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditorial.Multiline = false;
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(316, 50);
            this.txtEditorial.TabIndex = 14;
            this.txtEditorial.Text = "";
            this.txtEditorial.TrailingIcon = null;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.Hint = "Precio";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(73, 326);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.MaxLength = 50;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(316, 50);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.Text = "";
            this.txtPrecio.TrailingIcon = null;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AnimateReadOnly = false;
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Depth = 0;
            this.txtTitulo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitulo.Hint = "Título del libro";
            this.txtTitulo.LeadingIcon = null;
            this.txtTitulo.Location = new System.Drawing.Point(73, 74);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(316, 50);
            this.txtTitulo.TabIndex = 7;
            this.txtTitulo.Text = "";
            this.txtTitulo.TrailingIcon = null;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.AnimateReadOnly = false;
            this.txtUbicacion.BackColor = System.Drawing.Color.White;
            this.txtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUbicacion.Depth = 0;
            this.txtUbicacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUbicacion.Hint = "Ubicación";
            this.txtUbicacion.LeadingIcon = null;
            this.txtUbicacion.Location = new System.Drawing.Point(73, 263);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUbicacion.MaxLength = 50;
            this.txtUbicacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUbicacion.Multiline = false;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(316, 50);
            this.txtUbicacion.TabIndex = 10;
            this.txtUbicacion.Text = "";
            this.txtUbicacion.TrailingIcon = null;
            // 
            // txtAutor
            // 
            this.txtAutor.AnimateReadOnly = false;
            this.txtAutor.BackColor = System.Drawing.Color.White;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutor.Depth = 0;
            this.txtAutor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutor.Hint = "Autor";
            this.txtAutor.LeadingIcon = null;
            this.txtAutor.Location = new System.Drawing.Point(73, 137);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAutor.Multiline = false;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(316, 50);
            this.txtAutor.TabIndex = 11;
            this.txtAutor.Text = "";
            this.txtAutor.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CardLibros);
            this.tabPage2.Controls.Add(this.materialCard1);
            this.tabPage2.ImageKey = "busqueda-de-conocimiento.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 59);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(822, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar libro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CardLibros
            // 
            this.CardLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardLibros.Controls.Add(this.dataGridView1);
            this.CardLibros.Depth = 0;
            this.CardLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardLibros.Location = new System.Drawing.Point(41, 142);
            this.CardLibros.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.CardLibros.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardLibros.Name = "CardLibros";
            this.CardLibros.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.CardLibros.Size = new System.Drawing.Size(756, 348);
            this.CardLibros.TabIndex = 11;
            this.CardLibros.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(21, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(714, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtAutorBuscar);
            this.materialCard1.Controls.Add(this.btnBuscar);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(134, 15);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard1.Size = new System.Drawing.Size(562, 108);
            this.materialCard1.TabIndex = 1;
            // 
            // txtAutorBuscar
            // 
            this.txtAutorBuscar.AnimateReadOnly = false;
            this.txtAutorBuscar.BackColor = System.Drawing.Color.White;
            this.txtAutorBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutorBuscar.Depth = 0;
            this.txtAutorBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutorBuscar.Hint = "Ingrese el autor a buscar";
            this.txtAutorBuscar.LeadingIcon = null;
            this.txtAutorBuscar.Location = new System.Drawing.Point(52, 27);
            this.txtAutorBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutorBuscar.MaxLength = 50;
            this.txtAutorBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAutorBuscar.Multiline = false;
            this.txtAutorBuscar.Name = "txtAutorBuscar";
            this.txtAutorBuscar.Size = new System.Drawing.Size(204, 50);
            this.txtAutorBuscar.TabIndex = 10;
            this.txtAutorBuscar.Text = "";
            this.txtAutorBuscar.TrailingIcon = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(321, 37);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(112, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cardVenta);
            this.tabPage3.Controls.Add(this.materialCard3);
            this.tabPage3.ImageKey = "ventas.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 59);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(822, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registrar venta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cardVenta
            // 
            this.cardVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardVenta.Controls.Add(this.lblPrecio);
            this.cardVenta.Controls.Add(this.lblAutor);
            this.cardVenta.Controls.Add(this.lblTitulo);
            this.cardVenta.Controls.Add(this.btnVender);
            this.cardVenta.Depth = 0;
            this.cardVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardVenta.Location = new System.Drawing.Point(128, 167);
            this.cardVenta.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.cardVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardVenta.Name = "cardVenta";
            this.cardVenta.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.cardVenta.Size = new System.Drawing.Size(562, 197);
            this.cardVenta.TabIndex = 11;
            this.cardVenta.Visible = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPrecio.Location = new System.Drawing.Point(57, 160);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(186, 33);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Bienvenido libreria";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAutor.Location = new System.Drawing.Point(57, 102);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(186, 33);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Bienvenido libreria";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(57, 46);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Bienvenido libreria";
            // 
            // btnVender
            // 
            this.btnVender.AutoSize = false;
            this.btnVender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVender.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVender.Depth = 0;
            this.btnVender.HighEmphasis = true;
            this.btnVender.Icon = null;
            this.btnVender.Location = new System.Drawing.Point(391, 79);
            this.btnVender.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnVender.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVender.Name = "btnVender";
            this.btnVender.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVender.Size = new System.Drawing.Size(131, 46);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Registar venta";
            this.btnVender.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVender.UseAccentColor = false;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.txtCodigoBuscar);
            this.materialCard3.Controls.Add(this.btnBuscarCod);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(128, 38);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard3.Size = new System.Drawing.Size(562, 108);
            this.materialCard3.TabIndex = 2;
            // 
            // txtCodigoBuscar
            // 
            this.txtCodigoBuscar.AnimateReadOnly = false;
            this.txtCodigoBuscar.BackColor = System.Drawing.Color.White;
            this.txtCodigoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoBuscar.Depth = 0;
            this.txtCodigoBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoBuscar.Hint = "Ingrese el codigo del libro a vender";
            this.txtCodigoBuscar.LeadingIcon = null;
            this.txtCodigoBuscar.Location = new System.Drawing.Point(25, 27);
            this.txtCodigoBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoBuscar.MaxLength = 50;
            this.txtCodigoBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoBuscar.Multiline = false;
            this.txtCodigoBuscar.Name = "txtCodigoBuscar";
            this.txtCodigoBuscar.Size = new System.Drawing.Size(270, 50);
            this.txtCodigoBuscar.TabIndex = 10;
            this.txtCodigoBuscar.Text = "";
            this.txtCodigoBuscar.TrailingIcon = null;
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.AutoSize = false;
            this.btnBuscarCod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarCod.Depth = 0;
            this.btnBuscarCod.HighEmphasis = true;
            this.btnBuscarCod.Icon = null;
            this.btnBuscarCod.Location = new System.Drawing.Point(391, 41);
            this.btnBuscarCod.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnBuscarCod.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarCod.Size = new System.Drawing.Size(112, 36);
            this.btnBuscarCod.TabIndex = 2;
            this.btnBuscarCod.Text = "Buscar";
            this.btnBuscarCod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarCod.UseAccentColor = false;
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // MenuPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 678);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.materialProgressBar1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPpal";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.CardLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.cardVenta.ResumeLayout(false);
            this.cardVenta.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialTextBox txtAutor;
        private MaterialSkin.Controls.MaterialTextBox txtUbicacion;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtTitulo;
        private MaterialSkin.Controls.MaterialTextBox txtEditorial;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private MaterialSkin.Controls.MaterialTextBox txtAutorBuscar;
        private MaterialSkin.Controls.MaterialCard CardLibros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoBuscar;
        private MaterialSkin.Controls.MaterialButton btnBuscarCod;
        private MaterialSkin.Controls.MaterialCard cardVenta;
        private MaterialSkin.Controls.MaterialButton btnVender;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
    }
}