namespace CapaPresentacion
{
    partial class FormPrueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrueba));
            System.Windows.Forms.Label id_AsistenciaLabel;
            System.Windows.Forms.Label codEstudianteLabel;
            System.Windows.Forms.Label codTutoriasLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label id_EstudianteLabel;
            System.Windows.Forms.Label matricula_EstudianteLabel;
            this.bD_Registro_TutoriasDataSet = new CapaPresentacion.BD_Registro_TutoriasDataSet();
            this.aSISTENCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSISTENCIATableAdapter = new CapaPresentacion.BD_Registro_TutoriasDataSetTableAdapters.ASISTENCIATableAdapter();
            this.tableAdapterManager = new CapaPresentacion.BD_Registro_TutoriasDataSetTableAdapters.TableAdapterManager();
            this.aSISTENCIABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aSISTENCIABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_AsistenciaTextBox = new System.Windows.Forms.TextBox();
            this.codEstudianteLabel1 = new System.Windows.Forms.Label();
            this.codTutoriasTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mostrarAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarAsistenciaTableAdapter = new CapaPresentacion.BD_Registro_TutoriasDataSetTableAdapters.MostrarAsistenciaTableAdapter();
            this.mostrarAsistencia4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarAsistencia4TableAdapter = new CapaPresentacion.BD_Registro_TutoriasDataSetTableAdapters.MostrarAsistencia4TableAdapter();
            this.mostrarAsistencia4DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mostrarMatriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarMatriculaTableAdapter = new CapaPresentacion.BD_Registro_TutoriasDataSetTableAdapters.MostrarMatriculaTableAdapter();
            this.id_EstudianteTextBox = new System.Windows.Forms.TextBox();
            this.matricula_EstudianteLabel1 = new System.Windows.Forms.Label();
            id_AsistenciaLabel = new System.Windows.Forms.Label();
            codEstudianteLabel = new System.Windows.Forms.Label();
            codTutoriasLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            id_EstudianteLabel = new System.Windows.Forms.Label();
            matricula_EstudianteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Registro_TutoriasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingNavigator)).BeginInit();
            this.aSISTENCIABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarAsistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarAsistencia4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarAsistencia4DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarMatriculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_Registro_TutoriasDataSet
            // 
            this.bD_Registro_TutoriasDataSet.DataSetName = "BD_Registro_TutoriasDataSet";
            this.bD_Registro_TutoriasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aSISTENCIABindingSource
            // 
            this.aSISTENCIABindingSource.DataMember = "ASISTENCIA";
            this.aSISTENCIABindingSource.DataSource = this.bD_Registro_TutoriasDataSet;
            // 
            // aSISTENCIATableAdapter
            // 
            this.aSISTENCIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASIGNAR_TUTORIATableAdapter = null;
            this.tableAdapterManager.ASISTENCIATableAdapter = this.aSISTENCIATableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CARRERATableAdapter = null;
            this.tableAdapterManager.CICLOTableAdapter = null;
            this.tableAdapterManager.CREAR_TUTORIATableAdapter = null;
            this.tableAdapterManager.DIASTableAdapter = null;
            this.tableAdapterManager.ESTUDIANTETableAdapter = null;
            this.tableAdapterManager.HORARIOSTableAdapter = null;
            this.tableAdapterManager.HORARIOTableAdapter = null;
            this.tableAdapterManager.MAESTRO_MATERIATableAdapter = null;
            this.tableAdapterManager.MAESTROTableAdapter = null;
            this.tableAdapterManager.MATERIATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.BD_Registro_TutoriasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // aSISTENCIABindingNavigator
            // 
            this.aSISTENCIABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aSISTENCIABindingNavigator.BindingSource = this.aSISTENCIABindingSource;
            this.aSISTENCIABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aSISTENCIABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aSISTENCIABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aSISTENCIABindingNavigatorSaveItem});
            this.aSISTENCIABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aSISTENCIABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aSISTENCIABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aSISTENCIABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aSISTENCIABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aSISTENCIABindingNavigator.Name = "aSISTENCIABindingNavigator";
            this.aSISTENCIABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aSISTENCIABindingNavigator.Size = new System.Drawing.Size(1016, 25);
            this.aSISTENCIABindingNavigator.TabIndex = 0;
            this.aSISTENCIABindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // aSISTENCIABindingNavigatorSaveItem
            // 
            this.aSISTENCIABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aSISTENCIABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aSISTENCIABindingNavigatorSaveItem.Image")));
            this.aSISTENCIABindingNavigatorSaveItem.Name = "aSISTENCIABindingNavigatorSaveItem";
            this.aSISTENCIABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aSISTENCIABindingNavigatorSaveItem.Text = "Save Data";
            this.aSISTENCIABindingNavigatorSaveItem.Click += new System.EventHandler(this.aSISTENCIABindingNavigatorSaveItem_Click);
            // 
            // id_AsistenciaLabel
            // 
            id_AsistenciaLabel.AutoSize = true;
            id_AsistenciaLabel.Location = new System.Drawing.Point(31, 44);
            id_AsistenciaLabel.Name = "id_AsistenciaLabel";
            id_AsistenciaLabel.Size = new System.Drawing.Size(70, 13);
            id_AsistenciaLabel.TabIndex = 1;
            id_AsistenciaLabel.Text = "Id Asistencia:";
            // 
            // id_AsistenciaTextBox
            // 
            this.id_AsistenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "Id_Asistencia", true));
            this.id_AsistenciaTextBox.Location = new System.Drawing.Point(119, 41);
            this.id_AsistenciaTextBox.Name = "id_AsistenciaTextBox";
            this.id_AsistenciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_AsistenciaTextBox.TabIndex = 2;
            // 
            // codEstudianteLabel
            // 
            codEstudianteLabel.AutoSize = true;
            codEstudianteLabel.Location = new System.Drawing.Point(31, 64);
            codEstudianteLabel.Name = "codEstudianteLabel";
            codEstudianteLabel.Size = new System.Drawing.Size(82, 13);
            codEstudianteLabel.TabIndex = 3;
            codEstudianteLabel.Text = "Cod Estudiante:";
            // 
            // codEstudianteLabel1
            // 
            this.codEstudianteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mostrarMatriculaBindingSource, "Matricula_Estudiante", true));
            this.codEstudianteLabel1.Location = new System.Drawing.Point(119, 64);
            this.codEstudianteLabel1.Name = "codEstudianteLabel1";
            this.codEstudianteLabel1.Size = new System.Drawing.Size(102, 23);
            this.codEstudianteLabel1.TabIndex = 4;
            this.codEstudianteLabel1.Text = "label1";
            // 
            // codTutoriasLabel
            // 
            codTutoriasLabel.AutoSize = true;
            codTutoriasLabel.Location = new System.Drawing.Point(31, 93);
            codTutoriasLabel.Name = "codTutoriasLabel";
            codTutoriasLabel.Size = new System.Drawing.Size(70, 13);
            codTutoriasLabel.TabIndex = 5;
            codTutoriasLabel.Text = "Cod Tutorias:";
            // 
            // codTutoriasTextBox
            // 
            this.codTutoriasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "CodTutorias", true));
            this.codTutoriasTextBox.Location = new System.Drawing.Point(119, 90);
            this.codTutoriasTextBox.Name = "codTutoriasTextBox";
            this.codTutoriasTextBox.Size = new System.Drawing.Size(200, 20);
            this.codTutoriasTextBox.TabIndex = 6;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(31, 120);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aSISTENCIABindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(119, 116);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // mostrarAsistenciaBindingSource
            // 
            this.mostrarAsistenciaBindingSource.DataMember = "MostrarAsistencia";
            this.mostrarAsistenciaBindingSource.DataSource = this.bD_Registro_TutoriasDataSet;
            // 
            // mostrarAsistenciaTableAdapter
            // 
            this.mostrarAsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarAsistencia4BindingSource
            // 
            this.mostrarAsistencia4BindingSource.DataMember = "MostrarAsistencia4";
            this.mostrarAsistencia4BindingSource.DataSource = this.bD_Registro_TutoriasDataSet;
            // 
            // mostrarAsistencia4TableAdapter
            // 
            this.mostrarAsistencia4TableAdapter.ClearBeforeFill = true;
            // 
            // mostrarAsistencia4DataGridView
            // 
            this.mostrarAsistencia4DataGridView.AutoGenerateColumns = false;
            this.mostrarAsistencia4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarAsistencia4DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.mostrarAsistencia4DataGridView.DataSource = this.mostrarAsistencia4BindingSource;
            this.mostrarAsistencia4DataGridView.Location = new System.Drawing.Point(0, 152);
            this.mostrarAsistencia4DataGridView.Name = "mostrarAsistencia4DataGridView";
            this.mostrarAsistencia4DataGridView.Size = new System.Drawing.Size(996, 220);
            this.mostrarAsistencia4DataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Asistencia";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Asistencia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodEstudiante";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodEstudiante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Matricula_Estudiante";
            this.dataGridViewTextBoxColumn3.HeaderText = "Matricula_Estudiante";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodTutorias";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodTutorias";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombre_Materia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre_Materia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombre_Dias";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre_Dias";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombre_Horario";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre_Horario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nombre_Maestro";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre_Maestro";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Periodo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn10.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // mostrarMatriculaBindingSource
            // 
            this.mostrarMatriculaBindingSource.DataMember = "MostrarMatricula";
            this.mostrarMatriculaBindingSource.DataSource = this.bD_Registro_TutoriasDataSet;
            // 
            // mostrarMatriculaTableAdapter
            // 
            this.mostrarMatriculaTableAdapter.ClearBeforeFill = true;
            // 
            // id_EstudianteLabel
            // 
            id_EstudianteLabel.AutoSize = true;
            id_EstudianteLabel.Location = new System.Drawing.Point(394, 48);
            id_EstudianteLabel.Name = "id_EstudianteLabel";
            id_EstudianteLabel.Size = new System.Drawing.Size(72, 13);
            id_EstudianteLabel.TabIndex = 10;
            id_EstudianteLabel.Text = "Id Estudiante:";
            // 
            // id_EstudianteTextBox
            // 
            this.id_EstudianteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mostrarMatriculaBindingSource, "Id_Estudiante", true));
            this.id_EstudianteTextBox.Location = new System.Drawing.Point(506, 45);
            this.id_EstudianteTextBox.Name = "id_EstudianteTextBox";
            this.id_EstudianteTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_EstudianteTextBox.TabIndex = 11;
            // 
            // matricula_EstudianteLabel
            // 
            matricula_EstudianteLabel.AutoSize = true;
            matricula_EstudianteLabel.Location = new System.Drawing.Point(394, 68);
            matricula_EstudianteLabel.Name = "matricula_EstudianteLabel";
            matricula_EstudianteLabel.Size = new System.Drawing.Size(106, 13);
            matricula_EstudianteLabel.TabIndex = 12;
            matricula_EstudianteLabel.Text = "Matricula Estudiante:";
            // 
            // matricula_EstudianteLabel1
            // 
            this.matricula_EstudianteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mostrarMatriculaBindingSource, "Matricula_Estudiante", true));
            this.matricula_EstudianteLabel1.Location = new System.Drawing.Point(506, 68);
            this.matricula_EstudianteLabel1.Name = "matricula_EstudianteLabel1";
            this.matricula_EstudianteLabel1.Size = new System.Drawing.Size(100, 23);
            this.matricula_EstudianteLabel1.TabIndex = 13;
            this.matricula_EstudianteLabel1.Text = "label1";
            // 
            // FormPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 408);
            this.Controls.Add(id_EstudianteLabel);
            this.Controls.Add(this.id_EstudianteTextBox);
            this.Controls.Add(matricula_EstudianteLabel);
            this.Controls.Add(this.matricula_EstudianteLabel1);
            this.Controls.Add(this.mostrarAsistencia4DataGridView);
            this.Controls.Add(id_AsistenciaLabel);
            this.Controls.Add(this.id_AsistenciaTextBox);
            this.Controls.Add(codEstudianteLabel);
            this.Controls.Add(this.codEstudianteLabel1);
            this.Controls.Add(codTutoriasLabel);
            this.Controls.Add(this.codTutoriasTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.aSISTENCIABindingNavigator);
            this.Name = "FormPrueba";
            this.Text = "FormPrueba";
            this.Load += new System.EventHandler(this.FormPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_Registro_TutoriasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingNavigator)).EndInit();
            this.aSISTENCIABindingNavigator.ResumeLayout(false);
            this.aSISTENCIABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarAsistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarAsistencia4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarAsistencia4DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarMatriculaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_Registro_TutoriasDataSet bD_Registro_TutoriasDataSet;
        private System.Windows.Forms.BindingSource aSISTENCIABindingSource;
        private BD_Registro_TutoriasDataSetTableAdapters.ASISTENCIATableAdapter aSISTENCIATableAdapter;
        private BD_Registro_TutoriasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aSISTENCIABindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aSISTENCIABindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_AsistenciaTextBox;
        private System.Windows.Forms.Label codEstudianteLabel1;
        private System.Windows.Forms.TextBox codTutoriasTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource mostrarAsistenciaBindingSource;
        private BD_Registro_TutoriasDataSetTableAdapters.MostrarAsistenciaTableAdapter mostrarAsistenciaTableAdapter;
        private System.Windows.Forms.BindingSource mostrarAsistencia4BindingSource;
        private BD_Registro_TutoriasDataSetTableAdapters.MostrarAsistencia4TableAdapter mostrarAsistencia4TableAdapter;
        private System.Windows.Forms.DataGridView mostrarAsistencia4DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource mostrarMatriculaBindingSource;
        private BD_Registro_TutoriasDataSetTableAdapters.MostrarMatriculaTableAdapter mostrarMatriculaTableAdapter;
        private System.Windows.Forms.TextBox id_EstudianteTextBox;
        private System.Windows.Forms.Label matricula_EstudianteLabel1;
    }
}