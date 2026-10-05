using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Windows.Forms;

namespace AUSTROMEX_Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarBaseDeDatos();

            // Agrega esta línea para conectar el evento de carga de la ventana con tu método
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarChoferes();
            CargarVehiculos();
            LlenarComboChoferes();
            CargarReporte();
        }


        //-------------------------------- MÉTODOS DE BASE DE DATOS ---------------------------------
        private void InicializarBaseDeDatos()
        {
            // Definimos el nombre del archivo de la base de datos
            string cadenaConexion = "Data Source=Austromex_Examen.db";

            // Usamos 'using' para que la conexión se cierre y libere memoria automáticamente
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open(); // Esto crea el archivo .db físicamente si no existe

                var comando = conexion.CreateCommand();

                // 1. Crear la tabla Choferes primero (porque Vehiculos depende de ella)
                // Basado en la estructura: Número, Nombre (50), Fecha Ingreso, Sueldo (Moneda)
                comando.CommandText = @"
            CREATE TABLE IF NOT EXISTS Choferes (
                Numero_Chofer INTEGER PRIMARY KEY,
                Nombre_Chofer TEXT NOT NULL,
                Fecha_Ingreso TEXT NOT NULL,
                Sueldo REAL NOT NULL
            );";
                comando.ExecuteNonQuery();

                // 2. Crear la tabla Vehiculos con su Llave Foránea (Integridad Referencial)
                // Basado en la estructura: Placas (7), Modelo (4), Marca (25), Fecha, Costo, No. Chofer, Kilometraje
                comando.CommandText = @"
            CREATE TABLE IF NOT EXISTS Vehiculos (
                Placas TEXT PRIMARY KEY,
                Modelo INTEGER NOT NULL,
                Marca TEXT NOT NULL,
                Fecha_Compra TEXT NOT NULL,
                Costo_Compra REAL NOT NULL,
                Numero_Chofer INTEGER,
                Kilometraje INTEGER NOT NULL,
                FOREIGN KEY (Numero_Chofer) REFERENCES Choferes(Numero_Chofer)
            );";
                comando.ExecuteNonQuery();

                // Opcional: Un mensaje solo para comprobar que funcionó la primera vez
                //MessageBox.Show("¡Base de datos y tablas creadas con éxito!");
            }
        }

        //------------------------------- MÉTODOS DE CARGA Y MANEJO DE DATOS -------------------------------
        private void CargarChoferes()
        {
            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // 1. Consultamos todos los registros de la tabla Choferes
                    comando.CommandText = "SELECT * FROM Choferes";

                    // 2. Ejecutamos la lectura de los datos
                    using (var lector = comando.ExecuteReader())
                    {
                        // 3. Creamos una tabla virtual en memoria y la llenamos con lo que leyó el comando
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        tabla.Load(lector);

                        // 4. Conectamos esa tabla virtual a tu DataGridView visual
                        dataGridView_TabChoferes.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los choferes: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVehiculos()
        {
            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // 1. Consultamos todos los registros de la tabla Vehiculos
                    comando.CommandText = "SELECT * FROM Vehiculos";

                    using (var lector = comando.ExecuteReader())
                    {
                        // 2. Creamos la tabla virtual y la llenamos
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        tabla.Load(lector);

                        // 3. Conectamos los datos a tu DataGridView de la pestaña Vehículos
                        dataGridView_TabVehiculos.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vehículos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboChoferes()
        {
            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // Solo necesitamos el Número (para guardarlo en la tabla Vehículos) y el Nombre (para que el usuario lo lea fácil)
                    comando.CommandText = "SELECT Numero_Chofer, Nombre_Chofer FROM Choferes";

                    using (var lector = comando.ExecuteReader())
                    {
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        tabla.Load(lector);

                        // Conectamos los datos al ComboBox
                        comboBox_NoChofer_TabVehiculos.DataSource = tabla;

                        // Lo que el usuario va a leer
                        comboBox_NoChofer_TabVehiculos.DisplayMember = "Numero_Chofer";

                        // El valor real que se va a guardar por detrás (El número de chofer)
                        comboBox_NoChofer_TabVehiculos.ValueMember = "Numero_Chofer";

                        // Opcional: Dejarlo en blanco por defecto para obligar al usuario a elegir uno
                        comboBox_NoChofer_TabVehiculos.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de choferes: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReporte()
        {
            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // La consulta INNER JOIN:
                    // Seleccionamos datos clave del vehículo y le pegamos el Nombre del chofer de la otra tabla.
                    // Vinculamos ambas tablas (ON) donde el Numero_Chofer coincida.
                    comando.CommandText = @"
                SELECT 
                    V.Placas, 
                    V.Marca, 
                    V.Modelo, 
                    C.Nombre_Chofer AS 'Chofer Asignado', 
                    V.Kilometraje,
                    V.Fecha_Compra,
                    V.Costo_Compra
                FROM Vehiculos V
                INNER JOIN Choferes C ON V.Numero_Chofer = C.Numero_Chofer";

                    using (var lector = comando.ExecuteReader())
                    {
                        System.Data.DataTable tablaReporte = new System.Data.DataTable();
                        tablaReporte.Load(lector);

                        // Conectamos el resultado combinado a la cuadrícula de la pestaña Reportes
                        dataGridView_TabReportes.DataSource = tablaReporte;

                        // Al igual que en las otras tablas, bloqueamos la edición directa
                        dataGridView_TabReportes.ReadOnly = true;
                        dataGridView_TabReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView_TabReportes.AllowUserToAddRows = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la vista previa del reporte: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //------------------------------- EVENTOS DE BOTONES TABLA CHOFERES -------------------------------
        private void btn_Agregar_TabChoferes_Click(object sender, EventArgs e)
        {
            // 1. Validación: El NumericUpDown siempre tiene un número, así que solo validamos que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txt_NombreChofer_TabChoferes.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del chofer.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    comando.CommandText = @"
                INSERT INTO Choferes (Numero_Chofer, Nombre_Chofer, Fecha_Ingreso, Sueldo) 
                VALUES (@numero, @nombre, @fecha, @sueldo)";

                    // 2. Extraemos el valor directamente del nuevo NumericUpDown y lo convertimos a entero
                    comando.Parameters.AddWithValue("@numero", (int)numericUpDown_NoChofer_TabChoferes.Value);
                    comando.Parameters.AddWithValue("@nombre", txt_NombreChofer_TabChoferes.Text);
                    comando.Parameters.AddWithValue("@fecha", dateTimePicker_FechaIngreso_TabChoferes.Value.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@sueldo", numericUpDown_Sueldo_TabChoferes.Value);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("¡Chofer agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. Limpiar los controles visuales preparando para un nuevo registro
                    numericUpDown_NoChofer_TabChoferes.Value = numericUpDown_NoChofer_TabChoferes.Minimum; // O el valor mínimo que le hayas configurado en propiedades
                    txt_NombreChofer_TabChoferes.Clear();
                    dateTimePicker_FechaIngreso_TabChoferes.Value = DateTime.Now;
                    numericUpDown_Sueldo_TabChoferes.Value = numericUpDown_Sueldo_TabChoferes.Minimum;

                    numericUpDown_NoChofer_TabChoferes.Focus(); // Regresa el cursor al nuevo control

                    // Actualizamos la tabla visualmente al instante
                    CargarChoferes();
                    LlenarComboChoferes(); // También actualizamos el ComboBox de choferes en la pestaña Vehículos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el chofer: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_TabChoferes_Click(object sender, EventArgs e)
        {
            // 1. Confirmación de seguridad para evitar borrados accidentales
            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este chofer? Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmacion == DialogResult.No)
            {
                return; // Detenemos el código si el usuario elige "No"
            }

            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // 2. Consulta DELETE parametrizada basada en el Número de Chofer
                    comando.CommandText = "DELETE FROM Choferes WHERE Numero_Chofer = @numero";
                    comando.Parameters.AddWithValue("@numero", (int)numericUpDown_NoChofer_TabChoferes.Value);

                    // 3. Ejecutamos el comando y verificamos si realmente se borró algo
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Chofer eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. Limpiamos la interfaz usando tu configuración de .Minimum para evitar errores
                        numericUpDown_NoChofer_TabChoferes.Value = numericUpDown_NoChofer_TabChoferes.Minimum;
                        txt_NombreChofer_TabChoferes.Clear();
                        dateTimePicker_FechaIngreso_TabChoferes.Value = DateTime.Now;
                        numericUpDown_Sueldo_TabChoferes.Value = numericUpDown_Sueldo_TabChoferes.Minimum;

                        // 5. Refrescamos el DataGridView al instante
                        CargarChoferes();
                        LlenarComboChoferes(); // También actualizamos el ComboBox de choferes en la pestaña Vehículos
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún chofer con ese número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Nota técnica: Si intentas eliminar un chofer que ya tiene vehículos asignados, 
                // SQLite lanzará una excepción protegiendo la Integridad Referencial.
                MessageBox.Show("Error al eliminar (Revisa que el chofer no tenga vehículos asignados): " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Actualizar_TabChoferes_Click(object sender, EventArgs e)
        {
            // 1. Validación básica para asegurar que el nombre no quede en blanco
            if (string.IsNullOrWhiteSpace(txt_NombreChofer_TabChoferes.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del chofer.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // 2. Consulta UPDATE parametrizada. 
                    // IMPORTANTE: Usamos el Numero_Chofer en el WHERE para saber a quién modificar.
                    comando.CommandText = @"
                UPDATE Choferes 
                SET Nombre_Chofer = @nombre, 
                    Fecha_Ingreso = @fecha, 
                    Sueldo = @sueldo 
                WHERE Numero_Chofer = @numero";

                    // 3. Asignamos los valores de los controles
                    comando.Parameters.AddWithValue("@nombre", txt_NombreChofer_TabChoferes.Text);
                    comando.Parameters.AddWithValue("@fecha", dateTimePicker_FechaIngreso_TabChoferes.Value.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@sueldo", numericUpDown_Sueldo_TabChoferes.Value);

                    // La llave primaria (el número de chofer) que le dice a la BD qué fila actualizar
                    comando.Parameters.AddWithValue("@numero", (int)numericUpDown_NoChofer_TabChoferes.Value);

                    // 4. Ejecutamos y verificamos cuántas filas se modificaron
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("¡Chofer actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Limpiamos los controles para dejarlos listos
                        numericUpDown_NoChofer_TabChoferes.Value = numericUpDown_NoChofer_TabChoferes.Minimum;
                        txt_NombreChofer_TabChoferes.Clear();
                        dateTimePicker_FechaIngreso_TabChoferes.Value = DateTime.Now;
                        numericUpDown_Sueldo_TabChoferes.Value = numericUpDown_Sueldo_TabChoferes.Minimum;

                        // 6. Refrescamos la tabla para ver los cambios de inmediato
                        CargarChoferes();
                    }
                    else
                    {
                        // Esto pasa si intentan actualizar un número de chofer que no existe en la base de datos
                        MessageBox.Show("No se encontró ningún chofer con ese número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el chofer: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------ EVENTO DE SELECCIÓN TABLA CHOFERES ----------------------
        private void dataGridView_TabChoferes_SelectionChanged(object sender, EventArgs e)
        {
            // 1. Validamos que realmente haya una fila seleccionada actualmente
            if (dataGridView_TabChoferes.CurrentRow != null && dataGridView_TabChoferes.CurrentRow.Index > -1)
            {
                // Guardamos la fila seleccionada en una variable para facilitar la lectura
                DataGridViewRow fila = dataGridView_TabChoferes.CurrentRow;

                try
                {
                    // 2. Extraemos los valores de las celdas usando los nombres exactos de las columnas de tu BD SQLite
                    // y los convertimos al tipo de dato que acepta cada control visual.

                    // Numero de chofer (a decimal para el NumericUpDown)
                    if (fila.Cells["Numero_Chofer"].Value != DBNull.Value)
                    {
                        numericUpDown_NoChofer_TabChoferes.Value = Convert.ToDecimal(fila.Cells["Numero_Chofer"].Value);
                    }

                    // Nombre (a texto)
                    if (fila.Cells["Nombre_Chofer"].Value != DBNull.Value)
                    {
                        txt_NombreChofer_TabChoferes.Text = fila.Cells["Nombre_Chofer"].Value.ToString();
                    }

                    // Fecha (Convertimos el texto que entrega SQLite de vuelta a un formato DateTime real)
                    if (fila.Cells["Fecha_Ingreso"].Value != DBNull.Value)
                    {
                        dateTimePicker_FechaIngreso_TabChoferes.Value = Convert.ToDateTime(fila.Cells["Fecha_Ingreso"].Value);
                    }

                    // Sueldo (a decimal para el NumericUpDown)
                    if (fila.Cells["Sueldo"].Value != DBNull.Value)
                    {
                        numericUpDown_Sueldo_TabChoferes.Value = Convert.ToDecimal(fila.Cells["Sueldo"].Value);
                    }
                }
                catch (Exception ex)
                {
                    // Atrapa cualquier error de conversión por si la celda viene con formato inesperado
                    Console.WriteLine("Error al leer la celda: " + ex.Message);
                }
            }
        }

        //------------------ EVENTO DE VALIDACIÓN DE TABLA CHOFER ----------------------
        private void txt_NombreChofer_TabChoferes_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Permitir letras (mayúsculas y minúsculas), espacios y la tecla de borrar (BackSpace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // 2. Si la tecla presionada NO es ninguna de las anteriores, se bloquea
                e.Handled = true;

            }
        }



        //------------------------------- EVENTOS DE BOTONES TABLA VEHICULOS -------------------------------
        private void btn_Agregar_TabVehiculos_Click(object sender, EventArgs e)
        {
            // 1. Validaciones de campos vacíos y selección de chofer
            if (string.IsNullOrWhiteSpace(txt_Placas_TabVehiculos.Text) ||
                string.IsNullOrWhiteSpace(txt_Marca_TabVehiculos.Text))
            {
                MessageBox.Show("Por favor, llena los campos de Placas, Marca y Modelo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación estricta de Integridad Referencial: Debe haber un chofer seleccionado
            if (comboBox_NoChofer_TabVehiculos.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un Número de Chofer válido de la lista.", "Falta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // 2. Definir la consulta INSERT con parámetros para los 7 campos de la tabla
                    comando.CommandText = @"
                INSERT INTO Vehiculos (Placas, Modelo, Marca, Fecha_Compra, Costo_Compra, Numero_Chofer, Kilometraje) 
                VALUES (@placas, @modelo, @marca, @fecha, @costo, @numeroChofer, @kilometraje)";

                    // 3. Asignar los valores de los controles
                    comando.Parameters.AddWithValue("@placas", txt_Placas_TabVehiculos.Text);
                    comando.Parameters.AddWithValue("@modelo", dateTimePicker_Modelo_TabVehiculos.Value.Year);
                    comando.Parameters.AddWithValue("@marca", txt_Marca_TabVehiculos.Text);
                    comando.Parameters.AddWithValue("@fecha", dateTimePicker_FechaCompra_TabVehiculos.Value.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@costo", numericUpDown_CostoCompra_TabVehiculos.Value);

                    // Extraemos el ID real del chofer guardado en la memoria del ComboBox
                    comando.Parameters.AddWithValue("@numeroChofer", Convert.ToInt32(comboBox_NoChofer_TabVehiculos.SelectedValue));

                    comando.Parameters.AddWithValue("@kilometraje", numericUpDown_Kilometraje_TabVehiculos.Value);

                    // 4. Ejecutar la inserción
                    comando.ExecuteNonQuery();

                    MessageBox.Show("¡Vehículo agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Limpiar los controles visuales respetando los valores mínimos
                    txt_Placas_TabVehiculos.Clear();
                    txt_Marca_TabVehiculos.Clear();
                    dateTimePicker_Modelo_TabVehiculos.Value = DateTime.Now; // O el año actual
                    dateTimePicker_FechaCompra_TabVehiculos.Value = DateTime.Now;
                    numericUpDown_CostoCompra_TabVehiculos.Value = numericUpDown_CostoCompra_TabVehiculos.Minimum;
                    numericUpDown_Kilometraje_TabVehiculos.Value = numericUpDown_Kilometraje_TabVehiculos.Minimum;

                    // Reiniciamos el ComboBox y por ende se limpiará el TextBox del nombre del chofer
                    comboBox_NoChofer_TabVehiculos.SelectedIndex = -1;

                    txt_Placas_TabVehiculos.Focus();

                    // 6. Actualizamos el DataGridView de vehículos
                    CargarVehiculos();
                    CargarReporte(); // También actualizamos la vista previa del reporte en la pestaña correspondiente
                }
            }
            catch (Exception ex)
            {
                // En caso de que se intente ingresar unas Placas que ya existen (Violación de Primary Key)
                MessageBox.Show("Ocurrió un error (Verifica que las placas no estén repetidas): " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_TabVehiculos_Click(object sender, EventArgs e)
        {
            // 1. Validar que haya unas placas para eliminar
            if (string.IsNullOrWhiteSpace(txt_Placas_TabVehiculos.Text))
            {
                MessageBox.Show("Por favor, selecciona o escribe las Placas del vehículo que deseas eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmación de seguridad
            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar el vehículo con placas " + txt_Placas_TabVehiculos.Text + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
            {
                return;
            }

            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // 3. Consulta DELETE usando la llave primaria (Placas)
                    comando.CommandText = "DELETE FROM Vehiculos WHERE Placas = @placas";
                    comando.Parameters.AddWithValue("@placas", txt_Placas_TabVehiculos.Text);

                    // 4. Ejecutar y verificar
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Vehículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Limpiamos la interfaz al estado original
                        txt_Placas_TabVehiculos.Clear();
                        txt_Marca_TabVehiculos.Clear();
                        dateTimePicker_Modelo_TabVehiculos.Value = DateTime.Now;
                        dateTimePicker_FechaCompra_TabVehiculos.Value = DateTime.Now;
                        numericUpDown_CostoCompra_TabVehiculos.Value = numericUpDown_CostoCompra_TabVehiculos.Minimum;
                        numericUpDown_Kilometraje_TabVehiculos.Value = numericUpDown_Kilometraje_TabVehiculos.Minimum;

                        // Limpiar el combo limpiará automáticamente tu txt_NombreChofer_TabVehiculos gracias al evento que programamos antes
                        comboBox_NoChofer_TabVehiculos.SelectedIndex = -1;

                        txt_Placas_TabVehiculos.Focus();

                        // 6. Refrescamos la tabla al instante
                        CargarVehiculos();
                        CargarReporte(); // También actualizamos la vista previa del reporte en la pestaña correspondiente
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún vehículo con esas placas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el vehículo: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Actualizar_TabVehiculos_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas para asegurar que haya datos que actualizar
            if (string.IsNullOrWhiteSpace(txt_Placas_TabVehiculos.Text) ||
                string.IsNullOrWhiteSpace(txt_Marca_TabVehiculos.Text))
            {
                MessageBox.Show("Por favor, selecciona un vehículo y asegúrate de no dejar Placas, Marca o Modelo en blanco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox_NoChofer_TabVehiculos.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un Número de Chofer válido.", "Falta Chofer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cadenaConexion = "Data Source=Austromex_Examen.db";

            try
            {
                using (var conexion = new SqliteConnection(cadenaConexion))
                {
                    conexion.Open();
                    var comando = conexion.CreateCommand();

                    // 2. Consulta UPDATE utilizando las Placas como identificador único en el WHERE
                    comando.CommandText = @"
                UPDATE Vehiculos 
                SET Modelo = @modelo, 
                    Marca = @marca, 
                    Fecha_Compra = @fecha, 
                    Costo_Compra = @costo, 
                    Numero_Chofer = @numeroChofer, 
                    Kilometraje = @kilometraje 
                WHERE Placas = @placas";

                    // 3. Asignar los parámetros extraídos de los controles
                    comando.Parameters.AddWithValue("@modelo", dateTimePicker_Modelo_TabVehiculos.Value.Year);
                    comando.Parameters.AddWithValue("@marca", txt_Marca_TabVehiculos.Text);
                    comando.Parameters.AddWithValue("@fecha", dateTimePicker_FechaCompra_TabVehiculos.Value.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@costo", numericUpDown_CostoCompra_TabVehiculos.Value);
                    comando.Parameters.AddWithValue("@numeroChofer", Convert.ToInt32(comboBox_NoChofer_TabVehiculos.SelectedValue));
                    comando.Parameters.AddWithValue("@kilometraje", numericUpDown_Kilometraje_TabVehiculos.Value);

                    // Parámetro de la llave primaria (Placas) que le dice a la BD qué fila actualizar
                    comando.Parameters.AddWithValue("@placas", txt_Placas_TabVehiculos.Text);

                    // 4. Ejecutar y verificar si realmente se encontró y actualizó el registro
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("¡Vehículo actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Limpiar los controles a su estado original
                        txt_Placas_TabVehiculos.Clear();
                        txt_Marca_TabVehiculos.Clear();
                        dateTimePicker_Modelo_TabVehiculos.Value = DateTime.Now; // O el año actual
                        dateTimePicker_FechaCompra_TabVehiculos.Value = DateTime.Now;
                        numericUpDown_CostoCompra_TabVehiculos.Value = numericUpDown_CostoCompra_TabVehiculos.Minimum;
                        numericUpDown_Kilometraje_TabVehiculos.Value = numericUpDown_Kilometraje_TabVehiculos.Minimum;

                        // Esto también limpiará el TextBox del nombre del chofer por tu evento programado
                        comboBox_NoChofer_TabVehiculos.SelectedIndex = -1;

                        txt_Placas_TabVehiculos.Focus();

                        // 6. Refrescar la tabla instantáneamente
                        CargarVehiculos();
                        CargarReporte(); // También actualizamos la vista previa del reporte en la pestaña correspondiente
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún vehículo con esas placas para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el vehículo: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------ EVENTO DE SELECCIÓN TABLA VEHICULOS ----------------------
        private void comboBox_NoChofer_TabVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya un ítem seleccionado y extraemos la fila de datos completa que tiene el ComboBox
            if (comboBox_NoChofer_TabVehiculos.SelectedItem is System.Data.DataRowView filaSeleccionada)
            {
                // Extraemos la columna del nombre y la ponemos en el TextBox
                txt_NombreChofer_TabVehiculos.Text = filaSeleccionada["Nombre_Chofer"].ToString();
            }
            else
            {
                // Si se limpia el ComboBox, limpiamos el texto
                txt_NombreChofer_TabVehiculos.Clear();
            }
        }

        private void dataGridView_TabVehiculos_SelectionChanged(object sender, EventArgs e)
        {
            // 1. Validamos que exista una fila seleccionada
            if (dataGridView_TabVehiculos.CurrentRow != null && dataGridView_TabVehiculos.CurrentRow.Index > -1)
            {
                DataGridViewRow fila = dataGridView_TabVehiculos.CurrentRow;

                try
                {
                    // Placas
                    if (fila.Cells["Placas"].Value != DBNull.Value)
                        txt_Placas_TabVehiculos.Text = fila.Cells["Placas"].Value.ToString();

                    // Modelo
                    if (fila.Cells["Modelo"].Value != DBNull.Value)
                    {
                        int anioModelo = Convert.ToInt32(fila.Cells["Modelo"].Value);
                        // Asignamos una fecha válida al DateTimePicker usando el año recuperado de la BD
                        dateTimePicker_Modelo_TabVehiculos.Value = new DateTime(anioModelo, 1, 1);
                    }

                    // Marca
                    if (fila.Cells["Marca"].Value != DBNull.Value)
                        txt_Marca_TabVehiculos.Text = fila.Cells["Marca"].Value.ToString();

                    // Fecha de compra
                    if (fila.Cells["Fecha_Compra"].Value != DBNull.Value)
                        dateTimePicker_FechaCompra_TabVehiculos.Value = Convert.ToDateTime(fila.Cells["Fecha_Compra"].Value);

                    // Costo de compra
                    if (fila.Cells["Costo_Compra"].Value != DBNull.Value)
                        numericUpDown_CostoCompra_TabVehiculos.Value = Convert.ToDecimal(fila.Cells["Costo_Compra"].Value);

                    // Número de Chofer (ComboBox)
                    if (fila.Cells["Numero_Chofer"].Value != DBNull.Value)
                    {
                        // Al asignar este valor, el ComboBox cambiará automáticamente y ejecutará 
                        // tu evento SelectedIndexChanged para llenar el txt_NombreChofer_TabVehiculos
                        comboBox_NoChofer_TabVehiculos.SelectedValue = Convert.ToInt32(fila.Cells["Numero_Chofer"].Value);
                    }

                    // Kilometraje
                    if (fila.Cells["Kilometraje"].Value != DBNull.Value)
                        numericUpDown_Kilometraje_TabVehiculos.Value = Convert.ToDecimal(fila.Cells["Kilometraje"].Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer la celda de vehículos: " + ex.Message);
                }
            }
        }

        private void txt_BusquedaPlacas_TabVehiculos_TextChanged(object sender, EventArgs e)
        {
            // 1. Verificamos que el DataGridView ya tenga datos cargados (que no esté vacío al arrancar)
            if (dataGridView_TabVehiculos.DataSource is System.Data.DataTable tabla)
            {
                // 2. Extraemos el texto que el usuario está escribiendo y le quitamos espacios extra
                string busqueda = txt_BusquedaPlacas_TabVehiculos.Text.Trim();

                // 3. Aplicamos un filtro directo a la vista de la tabla en memoria
                // Usamos LIKE con comodines '%' para que encuentre coincidencias parciales en cualquier parte de la placa
                if (string.IsNullOrEmpty(busqueda))
                {
                    // Si borran todo el texto, quitamos el filtro para mostrar todos los vehículos de nuevo
                    tabla.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    // Filtramos la columna Placas basándonos en el texto escrito
                    tabla.DefaultView.RowFilter = $"Placas LIKE '%{busqueda}%'";
                }
            }
        }

        //------------------ EVENTO DE VALIDACIÓN DE TABLA VEHICULOS ----------------------
        private void txt_Placas_TabVehiculos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //1. Permitir letras (mayúsculas y minúsculas), números, guiones y la tecla de borrar (BackSpace)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                //2. Si la tecla presionada NO es ninguna de las anteriores, se bloquea
                e.Handled = true;
            }

        }

        private void txt_Marca_TabVehiculos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }



        //------------------ EVENTO DE EXPORTAR A EXCEL ----------------------
        private void btn_GenerarExcel_TabReportes_Click(object sender, EventArgs e)
        {
            // 1. Configuramos y abrimos la ventana de diálogo para guardar el archivo
            SaveFileDialog dialogoGuardar = new SaveFileDialog();
            dialogoGuardar.Filter = "Archivo Excel CSV (*.csv)|*.csv";
            dialogoGuardar.FileName = "Reporte_Plantilla_Vehiculos.csv";
            dialogoGuardar.Title = "Exportar Reporte a Excel";

            if (dialogoGuardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 2. Creamos el archivo en la ruta elegida por el usuario
                    using (StreamWriter sw = new StreamWriter(dialogoGuardar.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // 3. Extraemos y escribimos los encabezados de las columnas
                        for (int i = 0; i < dataGridView_TabReportes.Columns.Count; i++)
                        {
                            sw.Write(dataGridView_TabReportes.Columns[i].HeaderText);

                            // Agregamos la coma separadora, excepto en la última columna
                            if (i < dataGridView_TabReportes.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine(); // Salto de línea después de los encabezados

                        // 4. Recorremos fila por fila el DataGridView
                        foreach (DataGridViewRow fila in dataGridView_TabReportes.Rows)
                        {
                            // Ignoramos la fila vacía extra que suele aparecer al final de la cuadrícula
                            if (!fila.IsNewRow)
                            {
                                for (int i = 0; i < dataGridView_TabReportes.Columns.Count; i++)
                                {
                                    // Extraemos el valor de la celda. 
                                    // Reemplazamos las comas internas por espacios para no romper la estructura del archivo .csv
                                    string valorCelda = fila.Cells[i].Value?.ToString().Replace(",", " ") ?? "";
                                    sw.Write(valorCelda);

                                    if (i < dataGridView_TabReportes.Columns.Count - 1)
                                    {
                                        sw.Write(",");
                                    }
                                }
                                sw.WriteLine(); // Salto de línea por cada vehículo registrado
                            }
                        }
                    }

                    MessageBox.Show("Reporte exportado exitosamente a Excel.", "Exportación Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar exportar el reporte: " + ex.Message, "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
