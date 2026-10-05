namespace AUSTROMEX_Examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_General = new System.Windows.Forms.TabControl();
            this.tabChoferes = new System.Windows.Forms.TabPage();
            this.numericUpDown_NoChofer_TabChoferes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Sueldo_TabChoferes = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_FechaIngreso_TabChoferes = new System.Windows.Forms.DateTimePicker();
            this.txt_NombreChofer_TabChoferes = new System.Windows.Forms.TextBox();
            this.btn_Eliminar_TabChoferes = new System.Windows.Forms.Button();
            this.btn_Actualizar_TabChoferes = new System.Windows.Forms.Button();
            this.btn_Agregar_TabChoferes = new System.Windows.Forms.Button();
            this.label_Sueldo_TabChoferes = new System.Windows.Forms.Label();
            this.label_FechaIngreso_TabChoferes = new System.Windows.Forms.Label();
            this.label_NombreChofer_TabChoferes = new System.Windows.Forms.Label();
            this.label_NoChofer_TabChoferes = new System.Windows.Forms.Label();
            this.dataGridView_TabChoferes = new System.Windows.Forms.DataGridView();
            this.tabVehiculos = new System.Windows.Forms.TabPage();
            this.dateTimePicker_Modelo_TabVehiculos = new System.Windows.Forms.DateTimePicker();
            this.txt_NombreChofer_TabVehiculos = new System.Windows.Forms.TextBox();
            this.label_NombreChofer_TabVehiculos = new System.Windows.Forms.Label();
            this.numericUpDown_Kilometraje_TabVehiculos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CostoCompra_TabVehiculos = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_FechaCompra_TabVehiculos = new System.Windows.Forms.DateTimePicker();
            this.label_BusquedaPlaca_TabVehiculos = new System.Windows.Forms.Label();
            this.txt_BusquedaPlacas_TabVehiculos = new System.Windows.Forms.TextBox();
            this.comboBox_NoChofer_TabVehiculos = new System.Windows.Forms.ComboBox();
            this.label_CostoCompra_TabVehiculos = new System.Windows.Forms.Label();
            this.label_NoChofer_TabVehiculos = new System.Windows.Forms.Label();
            this.label_Kilometraje_TabVehiculos = new System.Windows.Forms.Label();
            this.txt_Marca_TabVehiculos = new System.Windows.Forms.TextBox();
            this.txt_Placas_TabVehiculos = new System.Windows.Forms.TextBox();
            this.btn_Eliminar_TabVehiculos = new System.Windows.Forms.Button();
            this.btn_Actualizar_TabVehiculos = new System.Windows.Forms.Button();
            this.btn_Agregar_TabVehiculos = new System.Windows.Forms.Button();
            this.label_FechaCompra_TabVehiculos = new System.Windows.Forms.Label();
            this.label_Marca_TabVehiculos = new System.Windows.Forms.Label();
            this.label_Modelo_TabVehiculos = new System.Windows.Forms.Label();
            this.label_Placas_TabVehiculos = new System.Windows.Forms.Label();
            this.dataGridView_TabVehiculos = new System.Windows.Forms.DataGridView();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.btn_GenerarExcel_TabReportes = new System.Windows.Forms.Button();
            this.dataGridView_TabReportes = new System.Windows.Forms.DataGridView();
            this.tabControl_General.SuspendLayout();
            this.tabChoferes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoChofer_TabChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sueldo_TabChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabChoferes)).BeginInit();
            this.tabVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Kilometraje_TabVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CostoCompra_TabVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabVehiculos)).BeginInit();
            this.tabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_General
            // 
            this.tabControl_General.Controls.Add(this.tabChoferes);
            this.tabControl_General.Controls.Add(this.tabVehiculos);
            this.tabControl_General.Controls.Add(this.tabReportes);
            this.tabControl_General.Location = new System.Drawing.Point(12, 12);
            this.tabControl_General.Name = "tabControl_General";
            this.tabControl_General.SelectedIndex = 0;
            this.tabControl_General.Size = new System.Drawing.Size(1276, 644);
            this.tabControl_General.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_General.TabIndex = 0;
            // 
            // tabChoferes
            // 
            this.tabChoferes.Controls.Add(this.numericUpDown_NoChofer_TabChoferes);
            this.tabChoferes.Controls.Add(this.numericUpDown_Sueldo_TabChoferes);
            this.tabChoferes.Controls.Add(this.dateTimePicker_FechaIngreso_TabChoferes);
            this.tabChoferes.Controls.Add(this.txt_NombreChofer_TabChoferes);
            this.tabChoferes.Controls.Add(this.btn_Eliminar_TabChoferes);
            this.tabChoferes.Controls.Add(this.btn_Actualizar_TabChoferes);
            this.tabChoferes.Controls.Add(this.btn_Agregar_TabChoferes);
            this.tabChoferes.Controls.Add(this.label_Sueldo_TabChoferes);
            this.tabChoferes.Controls.Add(this.label_FechaIngreso_TabChoferes);
            this.tabChoferes.Controls.Add(this.label_NombreChofer_TabChoferes);
            this.tabChoferes.Controls.Add(this.label_NoChofer_TabChoferes);
            this.tabChoferes.Controls.Add(this.dataGridView_TabChoferes);
            this.tabChoferes.Location = new System.Drawing.Point(4, 29);
            this.tabChoferes.Name = "tabChoferes";
            this.tabChoferes.Padding = new System.Windows.Forms.Padding(3);
            this.tabChoferes.Size = new System.Drawing.Size(1268, 611);
            this.tabChoferes.TabIndex = 0;
            this.tabChoferes.Text = "Choferes";
            this.tabChoferes.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_NoChofer_TabChoferes
            // 
            this.numericUpDown_NoChofer_TabChoferes.Location = new System.Drawing.Point(834, 61);
            this.numericUpDown_NoChofer_TabChoferes.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_NoChofer_TabChoferes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NoChofer_TabChoferes.Name = "numericUpDown_NoChofer_TabChoferes";
            this.numericUpDown_NoChofer_TabChoferes.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_NoChofer_TabChoferes.TabIndex = 14;
            this.numericUpDown_NoChofer_TabChoferes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Sueldo_TabChoferes
            // 
            this.numericUpDown_Sueldo_TabChoferes.Location = new System.Drawing.Point(838, 297);
            this.numericUpDown_Sueldo_TabChoferes.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Sueldo_TabChoferes.Name = "numericUpDown_Sueldo_TabChoferes";
            this.numericUpDown_Sueldo_TabChoferes.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Sueldo_TabChoferes.TabIndex = 13;
            // 
            // dateTimePicker_FechaIngreso_TabChoferes
            // 
            this.dateTimePicker_FechaIngreso_TabChoferes.Location = new System.Drawing.Point(830, 205);
            this.dateTimePicker_FechaIngreso_TabChoferes.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_FechaIngreso_TabChoferes.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_FechaIngreso_TabChoferes.Name = "dateTimePicker_FechaIngreso_TabChoferes";
            this.dateTimePicker_FechaIngreso_TabChoferes.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_FechaIngreso_TabChoferes.TabIndex = 12;
            // 
            // txt_NombreChofer_TabChoferes
            // 
            this.txt_NombreChofer_TabChoferes.Location = new System.Drawing.Point(838, 137);
            this.txt_NombreChofer_TabChoferes.MaxLength = 50;
            this.txt_NombreChofer_TabChoferes.Name = "txt_NombreChofer_TabChoferes";
            this.txt_NombreChofer_TabChoferes.Size = new System.Drawing.Size(100, 26);
            this.txt_NombreChofer_TabChoferes.TabIndex = 9;
            this.txt_NombreChofer_TabChoferes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreChofer_TabChoferes_KeyPress);
            // 
            // btn_Eliminar_TabChoferes
            // 
            this.btn_Eliminar_TabChoferes.Location = new System.Drawing.Point(1075, 337);
            this.btn_Eliminar_TabChoferes.Name = "btn_Eliminar_TabChoferes";
            this.btn_Eliminar_TabChoferes.Size = new System.Drawing.Size(90, 30);
            this.btn_Eliminar_TabChoferes.TabIndex = 7;
            this.btn_Eliminar_TabChoferes.Text = "Eliminar";
            this.btn_Eliminar_TabChoferes.UseVisualStyleBackColor = true;
            this.btn_Eliminar_TabChoferes.Click += new System.EventHandler(this.btn_Eliminar_TabChoferes_Click);
            // 
            // btn_Actualizar_TabChoferes
            // 
            this.btn_Actualizar_TabChoferes.Location = new System.Drawing.Point(940, 336);
            this.btn_Actualizar_TabChoferes.Name = "btn_Actualizar_TabChoferes";
            this.btn_Actualizar_TabChoferes.Size = new System.Drawing.Size(90, 30);
            this.btn_Actualizar_TabChoferes.TabIndex = 6;
            this.btn_Actualizar_TabChoferes.Text = "Actualizar";
            this.btn_Actualizar_TabChoferes.UseVisualStyleBackColor = true;
            this.btn_Actualizar_TabChoferes.Click += new System.EventHandler(this.btn_Actualizar_TabChoferes_Click);
            // 
            // btn_Agregar_TabChoferes
            // 
            this.btn_Agregar_TabChoferes.Location = new System.Drawing.Point(801, 337);
            this.btn_Agregar_TabChoferes.Name = "btn_Agregar_TabChoferes";
            this.btn_Agregar_TabChoferes.Size = new System.Drawing.Size(90, 30);
            this.btn_Agregar_TabChoferes.TabIndex = 5;
            this.btn_Agregar_TabChoferes.Text = "Agregar";
            this.btn_Agregar_TabChoferes.UseVisualStyleBackColor = true;
            this.btn_Agregar_TabChoferes.Click += new System.EventHandler(this.btn_Agregar_TabChoferes_Click);
            // 
            // label_Sueldo_TabChoferes
            // 
            this.label_Sueldo_TabChoferes.AutoSize = true;
            this.label_Sueldo_TabChoferes.Location = new System.Drawing.Point(834, 274);
            this.label_Sueldo_TabChoferes.Name = "label_Sueldo_TabChoferes";
            this.label_Sueldo_TabChoferes.Size = new System.Drawing.Size(59, 20);
            this.label_Sueldo_TabChoferes.TabIndex = 4;
            this.label_Sueldo_TabChoferes.Text = "Sueldo";
            // 
            // label_FechaIngreso_TabChoferes
            // 
            this.label_FechaIngreso_TabChoferes.AutoSize = true;
            this.label_FechaIngreso_TabChoferes.Location = new System.Drawing.Point(830, 182);
            this.label_FechaIngreso_TabChoferes.Name = "label_FechaIngreso_TabChoferes";
            this.label_FechaIngreso_TabChoferes.Size = new System.Drawing.Size(132, 20);
            this.label_FechaIngreso_TabChoferes.TabIndex = 3;
            this.label_FechaIngreso_TabChoferes.Text = "Fecha de ingreso";
            // 
            // label_NombreChofer_TabChoferes
            // 
            this.label_NombreChofer_TabChoferes.AutoSize = true;
            this.label_NombreChofer_TabChoferes.Location = new System.Drawing.Point(830, 113);
            this.label_NombreChofer_TabChoferes.Name = "label_NombreChofer_TabChoferes";
            this.label_NombreChofer_TabChoferes.Size = new System.Drawing.Size(136, 20);
            this.label_NombreChofer_TabChoferes.TabIndex = 2;
            this.label_NombreChofer_TabChoferes.Text = "Nombre de chofer";
            // 
            // label_NoChofer_TabChoferes
            // 
            this.label_NoChofer_TabChoferes.AutoSize = true;
            this.label_NoChofer_TabChoferes.Location = new System.Drawing.Point(826, 38);
            this.label_NoChofer_TabChoferes.Name = "label_NoChofer_TabChoferes";
            this.label_NoChofer_TabChoferes.Size = new System.Drawing.Size(136, 20);
            this.label_NoChofer_TabChoferes.TabIndex = 1;
            this.label_NoChofer_TabChoferes.Text = "Numero de chofer";
            // 
            // dataGridView_TabChoferes
            // 
            this.dataGridView_TabChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TabChoferes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_TabChoferes.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_TabChoferes.Name = "dataGridView_TabChoferes";
            this.dataGridView_TabChoferes.ReadOnly = true;
            this.dataGridView_TabChoferes.RowHeadersWidth = 62;
            this.dataGridView_TabChoferes.RowTemplate.Height = 28;
            this.dataGridView_TabChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TabChoferes.Size = new System.Drawing.Size(756, 599);
            this.dataGridView_TabChoferes.TabIndex = 0;
            this.dataGridView_TabChoferes.SelectionChanged += new System.EventHandler(this.dataGridView_TabChoferes_SelectionChanged);
            // 
            // tabVehiculos
            // 
            this.tabVehiculos.Controls.Add(this.dateTimePicker_Modelo_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.txt_NombreChofer_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_NombreChofer_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.numericUpDown_Kilometraje_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.numericUpDown_CostoCompra_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.dateTimePicker_FechaCompra_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_BusquedaPlaca_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.txt_BusquedaPlacas_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.comboBox_NoChofer_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_CostoCompra_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_NoChofer_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_Kilometraje_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.txt_Marca_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.txt_Placas_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.btn_Eliminar_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.btn_Actualizar_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.btn_Agregar_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_FechaCompra_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_Marca_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_Modelo_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.label_Placas_TabVehiculos);
            this.tabVehiculos.Controls.Add(this.dataGridView_TabVehiculos);
            this.tabVehiculos.Location = new System.Drawing.Point(4, 29);
            this.tabVehiculos.Name = "tabVehiculos";
            this.tabVehiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehiculos.Size = new System.Drawing.Size(1268, 611);
            this.tabVehiculos.TabIndex = 1;
            this.tabVehiculos.Text = "Vehiculos";
            this.tabVehiculos.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Modelo_TabVehiculos
            // 
            this.dateTimePicker_Modelo_TabVehiculos.CustomFormat = "yyyy";
            this.dateTimePicker_Modelo_TabVehiculos.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Modelo_TabVehiculos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_Modelo_TabVehiculos.Location = new System.Drawing.Point(845, 243);
            this.dateTimePicker_Modelo_TabVehiculos.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Modelo_TabVehiculos.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Modelo_TabVehiculos.Name = "dateTimePicker_Modelo_TabVehiculos";
            this.dateTimePicker_Modelo_TabVehiculos.ShowUpDown = true;
            this.dateTimePicker_Modelo_TabVehiculos.Size = new System.Drawing.Size(179, 26);
            this.dateTimePicker_Modelo_TabVehiculos.TabIndex = 39;
            // 
            // txt_NombreChofer_TabVehiculos
            // 
            this.txt_NombreChofer_TabVehiculos.Location = new System.Drawing.Point(1012, 132);
            this.txt_NombreChofer_TabVehiculos.Name = "txt_NombreChofer_TabVehiculos";
            this.txt_NombreChofer_TabVehiculos.ReadOnly = true;
            this.txt_NombreChofer_TabVehiculos.Size = new System.Drawing.Size(100, 26);
            this.txt_NombreChofer_TabVehiculos.TabIndex = 38;
            // 
            // label_NombreChofer_TabVehiculos
            // 
            this.label_NombreChofer_TabVehiculos.AutoSize = true;
            this.label_NombreChofer_TabVehiculos.Location = new System.Drawing.Point(980, 106);
            this.label_NombreChofer_TabVehiculos.Name = "label_NombreChofer_TabVehiculos";
            this.label_NombreChofer_TabVehiculos.Size = new System.Drawing.Size(139, 20);
            this.label_NombreChofer_TabVehiculos.TabIndex = 37;
            this.label_NombreChofer_TabVehiculos.Text = "Nombre del chofer";
            // 
            // numericUpDown_Kilometraje_TabVehiculos
            // 
            this.numericUpDown_Kilometraje_TabVehiculos.Location = new System.Drawing.Point(862, 318);
            this.numericUpDown_Kilometraje_TabVehiculos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_Kilometraje_TabVehiculos.Name = "numericUpDown_Kilometraje_TabVehiculos";
            this.numericUpDown_Kilometraje_TabVehiculos.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Kilometraje_TabVehiculos.TabIndex = 36;
            // 
            // numericUpDown_CostoCompra_TabVehiculos
            // 
            this.numericUpDown_CostoCompra_TabVehiculos.Location = new System.Drawing.Point(1075, 383);
            this.numericUpDown_CostoCompra_TabVehiculos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_CostoCompra_TabVehiculos.Name = "numericUpDown_CostoCompra_TabVehiculos";
            this.numericUpDown_CostoCompra_TabVehiculos.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_CostoCompra_TabVehiculos.TabIndex = 35;
            // 
            // dateTimePicker_FechaCompra_TabVehiculos
            // 
            this.dateTimePicker_FechaCompra_TabVehiculos.Location = new System.Drawing.Point(861, 380);
            this.dateTimePicker_FechaCompra_TabVehiculos.Name = "dateTimePicker_FechaCompra_TabVehiculos";
            this.dateTimePicker_FechaCompra_TabVehiculos.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_FechaCompra_TabVehiculos.TabIndex = 34;
            // 
            // label_BusquedaPlaca_TabVehiculos
            // 
            this.label_BusquedaPlaca_TabVehiculos.AutoSize = true;
            this.label_BusquedaPlaca_TabVehiculos.Location = new System.Drawing.Point(6, 8);
            this.label_BusquedaPlaca_TabVehiculos.Name = "label_BusquedaPlaca_TabVehiculos";
            this.label_BusquedaPlaca_TabVehiculos.Size = new System.Drawing.Size(155, 20);
            this.label_BusquedaPlaca_TabVehiculos.TabIndex = 33;
            this.label_BusquedaPlaca_TabVehiculos.Text = "Busqueda por placa:";
            // 
            // txt_BusquedaPlacas_TabVehiculos
            // 
            this.txt_BusquedaPlacas_TabVehiculos.Location = new System.Drawing.Point(176, 6);
            this.txt_BusquedaPlacas_TabVehiculos.Name = "txt_BusquedaPlacas_TabVehiculos";
            this.txt_BusquedaPlacas_TabVehiculos.Size = new System.Drawing.Size(200, 26);
            this.txt_BusquedaPlacas_TabVehiculos.TabIndex = 32;
            this.txt_BusquedaPlacas_TabVehiculos.TextChanged += new System.EventHandler(this.txt_BusquedaPlacas_TabVehiculos_TextChanged);
            // 
            // comboBox_NoChofer_TabVehiculos
            // 
            this.comboBox_NoChofer_TabVehiculos.FormattingEnabled = true;
            this.comboBox_NoChofer_TabVehiculos.Location = new System.Drawing.Point(1095, 169);
            this.comboBox_NoChofer_TabVehiculos.Name = "comboBox_NoChofer_TabVehiculos";
            this.comboBox_NoChofer_TabVehiculos.Size = new System.Drawing.Size(121, 28);
            this.comboBox_NoChofer_TabVehiculos.TabIndex = 31;
            this.comboBox_NoChofer_TabVehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBox_NoChofer_TabVehiculos_SelectedIndexChanged);
            // 
            // label_CostoCompra_TabVehiculos
            // 
            this.label_CostoCompra_TabVehiculos.AutoSize = true;
            this.label_CostoCompra_TabVehiculos.Location = new System.Drawing.Point(1059, 357);
            this.label_CostoCompra_TabVehiculos.Name = "label_CostoCompra_TabVehiculos";
            this.label_CostoCompra_TabVehiculos.Size = new System.Drawing.Size(130, 20);
            this.label_CostoCompra_TabVehiculos.TabIndex = 26;
            this.label_CostoCompra_TabVehiculos.Text = "Costo de compra";
            // 
            // label_NoChofer_TabVehiculos
            // 
            this.label_NoChofer_TabVehiculos.AutoSize = true;
            this.label_NoChofer_TabVehiculos.Location = new System.Drawing.Point(1115, 146);
            this.label_NoChofer_TabVehiculos.Name = "label_NoChofer_TabVehiculos";
            this.label_NoChofer_TabVehiculos.Size = new System.Drawing.Size(104, 20);
            this.label_NoChofer_TabVehiculos.TabIndex = 25;
            this.label_NoChofer_TabVehiculos.Text = "No. de chofer";
            // 
            // label_Kilometraje_TabVehiculos
            // 
            this.label_Kilometraje_TabVehiculos.AutoSize = true;
            this.label_Kilometraje_TabVehiculos.Location = new System.Drawing.Point(866, 285);
            this.label_Kilometraje_TabVehiculos.Name = "label_Kilometraje_TabVehiculos";
            this.label_Kilometraje_TabVehiculos.Size = new System.Drawing.Size(134, 20);
            this.label_Kilometraje_TabVehiculos.TabIndex = 24;
            this.label_Kilometraje_TabVehiculos.Text = "Kilometraje actual";
            // 
            // txt_Marca_TabVehiculos
            // 
            this.txt_Marca_TabVehiculos.Location = new System.Drawing.Point(1063, 233);
            this.txt_Marca_TabVehiculos.MaxLength = 25;
            this.txt_Marca_TabVehiculos.Name = "txt_Marca_TabVehiculos";
            this.txt_Marca_TabVehiculos.Size = new System.Drawing.Size(100, 26);
            this.txt_Marca_TabVehiculos.TabIndex = 21;
            this.txt_Marca_TabVehiculos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Marca_TabVehiculos_KeyPress);
            // 
            // txt_Placas_TabVehiculos
            // 
            this.txt_Placas_TabVehiculos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Placas_TabVehiculos.Location = new System.Drawing.Point(882, 159);
            this.txt_Placas_TabVehiculos.MaxLength = 7;
            this.txt_Placas_TabVehiculos.Name = "txt_Placas_TabVehiculos";
            this.txt_Placas_TabVehiculos.Size = new System.Drawing.Size(100, 26);
            this.txt_Placas_TabVehiculos.TabIndex = 19;
            this.txt_Placas_TabVehiculos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Placas_TabVehiculos_KeyPress);
            // 
            // btn_Eliminar_TabVehiculos
            // 
            this.btn_Eliminar_TabVehiculos.Location = new System.Drawing.Point(1129, 433);
            this.btn_Eliminar_TabVehiculos.Name = "btn_Eliminar_TabVehiculos";
            this.btn_Eliminar_TabVehiculos.Size = new System.Drawing.Size(90, 30);
            this.btn_Eliminar_TabVehiculos.TabIndex = 18;
            this.btn_Eliminar_TabVehiculos.Text = "Eliminar";
            this.btn_Eliminar_TabVehiculos.UseVisualStyleBackColor = true;
            this.btn_Eliminar_TabVehiculos.Click += new System.EventHandler(this.btn_Eliminar_TabVehiculos_Click);
            // 
            // btn_Actualizar_TabVehiculos
            // 
            this.btn_Actualizar_TabVehiculos.Location = new System.Drawing.Point(984, 433);
            this.btn_Actualizar_TabVehiculos.Name = "btn_Actualizar_TabVehiculos";
            this.btn_Actualizar_TabVehiculos.Size = new System.Drawing.Size(90, 30);
            this.btn_Actualizar_TabVehiculos.TabIndex = 17;
            this.btn_Actualizar_TabVehiculos.Text = "Actualizar";
            this.btn_Actualizar_TabVehiculos.UseVisualStyleBackColor = true;
            this.btn_Actualizar_TabVehiculos.Click += new System.EventHandler(this.btn_Actualizar_TabVehiculos_Click);
            // 
            // btn_Agregar_TabVehiculos
            // 
            this.btn_Agregar_TabVehiculos.Location = new System.Drawing.Point(845, 434);
            this.btn_Agregar_TabVehiculos.Name = "btn_Agregar_TabVehiculos";
            this.btn_Agregar_TabVehiculos.Size = new System.Drawing.Size(90, 30);
            this.btn_Agregar_TabVehiculos.TabIndex = 16;
            this.btn_Agregar_TabVehiculos.Text = "Agregar";
            this.btn_Agregar_TabVehiculos.UseVisualStyleBackColor = true;
            this.btn_Agregar_TabVehiculos.Click += new System.EventHandler(this.btn_Agregar_TabVehiculos_Click);
            // 
            // label_FechaCompra_TabVehiculos
            // 
            this.label_FechaCompra_TabVehiculos.AutoSize = true;
            this.label_FechaCompra_TabVehiculos.Location = new System.Drawing.Point(857, 357);
            this.label_FechaCompra_TabVehiculos.Name = "label_FechaCompra_TabVehiculos";
            this.label_FechaCompra_TabVehiculos.Size = new System.Drawing.Size(133, 20);
            this.label_FechaCompra_TabVehiculos.TabIndex = 15;
            this.label_FechaCompra_TabVehiculos.Text = "Fecha de compra";
            // 
            // label_Marca_TabVehiculos
            // 
            this.label_Marca_TabVehiculos.AutoSize = true;
            this.label_Marca_TabVehiculos.Location = new System.Drawing.Point(1059, 200);
            this.label_Marca_TabVehiculos.Name = "label_Marca_TabVehiculos";
            this.label_Marca_TabVehiculos.Size = new System.Drawing.Size(53, 20);
            this.label_Marca_TabVehiculos.TabIndex = 14;
            this.label_Marca_TabVehiculos.Text = "Marca";
            // 
            // label_Modelo_TabVehiculos
            // 
            this.label_Modelo_TabVehiculos.AutoSize = true;
            this.label_Modelo_TabVehiculos.Location = new System.Drawing.Point(866, 209);
            this.label_Modelo_TabVehiculos.Name = "label_Modelo_TabVehiculos";
            this.label_Modelo_TabVehiculos.Size = new System.Drawing.Size(61, 20);
            this.label_Modelo_TabVehiculos.TabIndex = 13;
            this.label_Modelo_TabVehiculos.Text = "Modelo";
            // 
            // label_Placas_TabVehiculos
            // 
            this.label_Placas_TabVehiculos.AutoSize = true;
            this.label_Placas_TabVehiculos.Location = new System.Drawing.Point(870, 135);
            this.label_Placas_TabVehiculos.Name = "label_Placas_TabVehiculos";
            this.label_Placas_TabVehiculos.Size = new System.Drawing.Size(56, 20);
            this.label_Placas_TabVehiculos.TabIndex = 12;
            this.label_Placas_TabVehiculos.Text = "Placas";
            // 
            // dataGridView_TabVehiculos
            // 
            this.dataGridView_TabVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TabVehiculos.Location = new System.Drawing.Point(6, 36);
            this.dataGridView_TabVehiculos.Name = "dataGridView_TabVehiculos";
            this.dataGridView_TabVehiculos.ReadOnly = true;
            this.dataGridView_TabVehiculos.RowHeadersWidth = 62;
            this.dataGridView_TabVehiculos.RowTemplate.Height = 28;
            this.dataGridView_TabVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TabVehiculos.Size = new System.Drawing.Size(666, 569);
            this.dataGridView_TabVehiculos.TabIndex = 0;
            this.dataGridView_TabVehiculos.SelectionChanged += new System.EventHandler(this.dataGridView_TabVehiculos_SelectionChanged);
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.btn_GenerarExcel_TabReportes);
            this.tabReportes.Controls.Add(this.dataGridView_TabReportes);
            this.tabReportes.Location = new System.Drawing.Point(4, 29);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Size = new System.Drawing.Size(1268, 611);
            this.tabReportes.TabIndex = 2;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // btn_GenerarExcel_TabReportes
            // 
            this.btn_GenerarExcel_TabReportes.AutoSize = true;
            this.btn_GenerarExcel_TabReportes.Location = new System.Drawing.Point(574, 524);
            this.btn_GenerarExcel_TabReportes.Name = "btn_GenerarExcel_TabReportes";
            this.btn_GenerarExcel_TabReportes.Size = new System.Drawing.Size(120, 30);
            this.btn_GenerarExcel_TabReportes.TabIndex = 2;
            this.btn_GenerarExcel_TabReportes.Text = "Generar Excel";
            this.btn_GenerarExcel_TabReportes.UseVisualStyleBackColor = true;
            this.btn_GenerarExcel_TabReportes.Click += new System.EventHandler(this.btn_GenerarExcel_TabReportes_Click);
            // 
            // dataGridView_TabReportes
            // 
            this.dataGridView_TabReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TabReportes.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_TabReportes.Name = "dataGridView_TabReportes";
            this.dataGridView_TabReportes.ReadOnly = true;
            this.dataGridView_TabReportes.RowHeadersWidth = 62;
            this.dataGridView_TabReportes.RowTemplate.Height = 28;
            this.dataGridView_TabReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TabReportes.Size = new System.Drawing.Size(1243, 487);
            this.dataGridView_TabReportes.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 678);
            this.Controls.Add(this.tabControl_General);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl_General.ResumeLayout(false);
            this.tabChoferes.ResumeLayout(false);
            this.tabChoferes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoChofer_TabChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sueldo_TabChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabChoferes)).EndInit();
            this.tabVehiculos.ResumeLayout(false);
            this.tabVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Kilometraje_TabVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CostoCompra_TabVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabVehiculos)).EndInit();
            this.tabReportes.ResumeLayout(false);
            this.tabReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_General;
        private System.Windows.Forms.TabPage tabChoferes;
        private System.Windows.Forms.TabPage tabVehiculos;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.DataGridView dataGridView_TabChoferes;
        private System.Windows.Forms.DataGridView dataGridView_TabVehiculos;
        private System.Windows.Forms.DataGridView dataGridView_TabReportes;
        private System.Windows.Forms.TextBox txt_NombreChofer_TabChoferes;
        private System.Windows.Forms.Button btn_Eliminar_TabChoferes;
        private System.Windows.Forms.Button btn_Actualizar_TabChoferes;
        private System.Windows.Forms.Button btn_Agregar_TabChoferes;
        private System.Windows.Forms.Label label_Sueldo_TabChoferes;
        private System.Windows.Forms.Label label_FechaIngreso_TabChoferes;
        private System.Windows.Forms.Label label_NombreChofer_TabChoferes;
        private System.Windows.Forms.Label label_NoChofer_TabChoferes;
        private System.Windows.Forms.TextBox txt_Marca_TabVehiculos;
        private System.Windows.Forms.TextBox txt_Placas_TabVehiculos;
        private System.Windows.Forms.Button btn_Eliminar_TabVehiculos;
        private System.Windows.Forms.Button btn_Actualizar_TabVehiculos;
        private System.Windows.Forms.Button btn_Agregar_TabVehiculos;
        private System.Windows.Forms.Label label_FechaCompra_TabVehiculos;
        private System.Windows.Forms.Label label_Marca_TabVehiculos;
        private System.Windows.Forms.Label label_Modelo_TabVehiculos;
        private System.Windows.Forms.Label label_Placas_TabVehiculos;
        private System.Windows.Forms.Label label_CostoCompra_TabVehiculos;
        private System.Windows.Forms.Label label_NoChofer_TabVehiculos;
        private System.Windows.Forms.Label label_Kilometraje_TabVehiculos;
        private System.Windows.Forms.TextBox txt_BusquedaPlacas_TabVehiculos;
        private System.Windows.Forms.ComboBox comboBox_NoChofer_TabVehiculos;
        private System.Windows.Forms.Label label_BusquedaPlaca_TabVehiculos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaIngreso_TabChoferes;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaCompra_TabVehiculos;
        private System.Windows.Forms.Button btn_GenerarExcel_TabReportes;
        private System.Windows.Forms.NumericUpDown numericUpDown_Sueldo_TabChoferes;
        private System.Windows.Forms.NumericUpDown numericUpDown_CostoCompra_TabVehiculos;
        private System.Windows.Forms.NumericUpDown numericUpDown_Kilometraje_TabVehiculos;
        private System.Windows.Forms.NumericUpDown numericUpDown_NoChofer_TabChoferes;
        private System.Windows.Forms.TextBox txt_NombreChofer_TabVehiculos;
        private System.Windows.Forms.Label label_NombreChofer_TabVehiculos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Modelo_TabVehiculos;
    }
}

