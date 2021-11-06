namespace heladeria
{
    partial class FormProductos
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label tipoIdLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.listaProductosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaProductosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1Cancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.categoriaBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            activoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            tipoIdLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingNavigator)).BeginInit();
            this.listaProductosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(80, 276);
            activoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(50, 17);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(80, 172);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(80, 239);
            existenciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(75, 17);
            existenciaLabel.TabIndex = 5;
            existenciaLabel.Text = "Existencia:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(80, 66);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 7;
            idLabel.Text = "id:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(80, 204);
            precioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(52, 17);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(505, 54);
            fotoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(40, 17);
            fotoLabel.TabIndex = 11;
            fotoLabel.Text = "Foto:";
            // 
            // tipoIdLabel
            // 
            tipoIdLabel.AutoSize = true;
            tipoIdLabel.Location = new System.Drawing.Point(77, 94);
            tipoIdLabel.Name = "tipoIdLabel";
            tipoIdLabel.Size = new System.Drawing.Size(55, 17);
            tipoIdLabel.TabIndex = 15;
            tipoIdLabel.Text = "Tipo Id:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(67, 120);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(88, 17);
            categoriaIdLabel.TabIndex = 17;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // listaProductosBindingNavigator
            // 
            this.listaProductosBindingNavigator.AddNewItem = null;
            this.listaProductosBindingNavigator.BindingSource = this.listaProductosBindingSource;
            this.listaProductosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaProductosBindingNavigator.DeleteItem = null;
            this.listaProductosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaProductosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaProductosBindingNavigatorSaveItem,
            this.toolStripButton1Cancelar});
            this.listaProductosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaProductosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaProductosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaProductosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaProductosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaProductosBindingNavigator.Name = "listaProductosBindingNavigator";
            this.listaProductosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaProductosBindingNavigator.Size = new System.Drawing.Size(883, 27);
            this.listaProductosBindingNavigator.TabIndex = 0;
            this.listaProductosBindingNavigator.Text = "bindingNavigator1";
            this.listaProductosBindingNavigator.RefreshItems += new System.EventHandler(this.listaProductosBindingNavigator_RefreshItems);
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.DataSource = typeof(BL.Heladeria.Producto);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaProductosBindingNavigatorSaveItem
            // 
            this.listaProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaProductosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaProductosBindingNavigatorSaveItem.Image")));
            this.listaProductosBindingNavigatorSaveItem.Name = "listaProductosBindingNavigatorSaveItem";
            this.listaProductosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaProductosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaProductosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaProductosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1Cancelar
            // 
            this.toolStripButton1Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1Cancelar.Image")));
            this.toolStripButton1Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Cancelar.Name = "toolStripButton1Cancelar";
            this.toolStripButton1Cancelar.Size = new System.Drawing.Size(70, 24);
            this.toolStripButton1Cancelar.Text = "Cancelar";
            this.toolStripButton1Cancelar.Visible = false;
            this.toolStripButton1Cancelar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProductosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(192, 270);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(261, 30);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(192, 164);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(255, 22);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Existencia", true));
            this.existenciaTextBox.Location = new System.Drawing.Point(192, 230);
            this.existenciaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.Size = new System.Drawing.Size(255, 22);
            this.existenciaTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(192, 58);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(255, 22);
            this.idTextBox.TabIndex = 8;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(192, 196);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(255, 22);
            this.precioTextBox.TabIndex = 10;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaProductosBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(555, 54);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(283, 174);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 12;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 250);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png | *.jpg; *.png  ";
            // 
            // categoriaBLBindingSource
            // 
            this.categoriaBLBindingSource.DataSource = typeof(BL.Heladeria.CategoriaBL);
            // 
            // listaCategoriasBindingSource
            // 
            this.listaCategoriasBindingSource.DataMember = "ListaCategorias";
            this.listaCategoriasBindingSource.DataSource = this.categoriaBLBindingSource;
            // 
            // listaTiposBindingSource
            // 
            this.listaTiposBindingSource.DataSource = typeof(BL.Heladeria.Tipo);
            // 
            // tipoIdComboBox
            // 
            this.tipoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaProductosBindingSource, "TipoId", true));
            this.tipoIdComboBox.DataSource = this.listaCategoriasBindingSource;
            this.tipoIdComboBox.DisplayMember = "Descripcion";
            this.tipoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoIdComboBox.FormattingEnabled = true;
            this.tipoIdComboBox.Location = new System.Drawing.Point(192, 87);
            this.tipoIdComboBox.Name = "tipoIdComboBox";
            this.tipoIdComboBox.Size = new System.Drawing.Size(255, 24);
            this.tipoIdComboBox.TabIndex = 16;
            this.tipoIdComboBox.ValueMember = "Id";
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaProductosBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.DataSource = this.listaTiposBindingSource;
            this.categoriaIdComboBox.DisplayMember = "Descripcion";
            this.categoriaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(192, 117);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(255, 24);
            this.categoriaIdComboBox.TabIndex = 18;
            this.categoriaIdComboBox.ValueMember = "Id";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 358);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdComboBox);
            this.Controls.Add(tipoIdLabel);
            this.Controls.Add(this.tipoIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.existenciaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.listaProductosBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProductos";
            this.Text = "Almacen de Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingNavigator)).EndInit();
            this.listaProductosBindingNavigator.ResumeLayout(false);
            this.listaProductosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.BindingNavigator listaProductosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaProductosBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1Cancelar;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource categoriaBLBindingSource;
        private System.Windows.Forms.BindingSource listaCategoriasBindingSource;
        private System.Windows.Forms.BindingSource listaTiposBindingSource;
        private System.Windows.Forms.ComboBox tipoIdComboBox;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
    }
}