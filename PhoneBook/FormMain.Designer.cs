namespace PhoneBook
{
    partial class FormMain
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsvcfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.firstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.phoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.genderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.femaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyOnClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disablePromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxGender = new System.Windows.Forms.ComboBox();
			this.groupBoxSearch = new System.Windows.Forms.GroupBox();
			this.linkLabelClearPhoneNumber = new System.Windows.Forms.LinkLabel();
			this.linkLabelClearLastName = new System.Windows.Forms.LinkLabel();
			this.linkLabelClearFirstName = new System.Windows.Forms.LinkLabel();
			this.labelPhoneNumber = new System.Windows.Forms.Label();
			this.textBoxSearchPhoneNumber = new System.Windows.Forms.TextBox();
			this.labelGender = new System.Windows.Forms.Label();
			this.textBoxSearchFirstName = new System.Windows.Forms.TextBox();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.textBoxSerachLastName = new System.Windows.Forms.TextBox();
			this.labelLastName = new System.Windows.Forms.Label();
			this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
			this.remove = new System.Windows.Forms.DataGridViewLinkColumn();
			this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
			this.vCard = new System.Windows.Forms.DataGridViewLinkColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contactsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contactsDBDataSet = new PhoneBook.ContactsDBDataSet();
			this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
			this.contactsTableTableAdapter = new PhoneBook.ContactsDBDataSetTableAdapters.ContactsTableTableAdapter();
			this.menuStripMain.SuspendLayout();
			this.groupBoxSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contactsTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contactsDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(911, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStripMain";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsvcfToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveAsvcfToolStripMenuItem
			// 
			this.saveAsvcfToolStripMenuItem.Name = "saveAsvcfToolStripMenuItem";
			this.saveAsvcfToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.saveAsvcfToolStripMenuItem.Text = "Save as .vcf";
			this.saveAsvcfToolStripMenuItem.Click += new System.EventHandler(this.saveAsvcfToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newContactToolStripMenuItem,
            this.removeAllToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.searchBarToolStripMenuItem,
            this.copyOnClickToolStripMenuItem,
            this.disablePromptToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// newContactToolStripMenuItem
			// 
			this.newContactToolStripMenuItem.Name = "newContactToolStripMenuItem";
			this.newContactToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.newContactToolStripMenuItem.Text = "New contact";
			this.newContactToolStripMenuItem.Click += new System.EventHandler(this.newContactToolStripMenuItem_Click);
			// 
			// removeAllToolStripMenuItem
			// 
			this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
			this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.removeAllToolStripMenuItem.Text = "Remove all";
			this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameToolStripMenuItem,
            this.lastNameToolStripMenuItem,
            this.phoneNumberToolStripMenuItem,
            this.genderToolStripMenuItem,
            this.resetSearchToolStripMenuItem});
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.searchToolStripMenuItem.Text = "Search by";
			// 
			// firstNameToolStripMenuItem
			// 
			this.firstNameToolStripMenuItem.Name = "firstNameToolStripMenuItem";
			this.firstNameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.firstNameToolStripMenuItem.Text = "First name";
			this.firstNameToolStripMenuItem.Click += new System.EventHandler(this.firstNameToolStripMenuItem_Click);
			// 
			// lastNameToolStripMenuItem
			// 
			this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
			this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.lastNameToolStripMenuItem.Text = "Last name";
			this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.lastNameToolStripMenuItem_Click);
			// 
			// phoneNumberToolStripMenuItem
			// 
			this.phoneNumberToolStripMenuItem.Name = "phoneNumberToolStripMenuItem";
			this.phoneNumberToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.phoneNumberToolStripMenuItem.Text = "Phone number";
			this.phoneNumberToolStripMenuItem.Click += new System.EventHandler(this.phoneNumberToolStripMenuItem_Click);
			// 
			// genderToolStripMenuItem
			// 
			this.genderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem,
            this.femaleToolStripMenuItem});
			this.genderToolStripMenuItem.Name = "genderToolStripMenuItem";
			this.genderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.genderToolStripMenuItem.Text = "Gender";
			// 
			// maleToolStripMenuItem
			// 
			this.maleToolStripMenuItem.Name = "maleToolStripMenuItem";
			this.maleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.maleToolStripMenuItem.Text = "Male";
			this.maleToolStripMenuItem.Click += new System.EventHandler(this.maleToolStripMenuItem_Click);
			// 
			// femaleToolStripMenuItem
			// 
			this.femaleToolStripMenuItem.Name = "femaleToolStripMenuItem";
			this.femaleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.femaleToolStripMenuItem.Text = "Female";
			this.femaleToolStripMenuItem.Click += new System.EventHandler(this.femaleToolStripMenuItem_Click);
			// 
			// resetSearchToolStripMenuItem
			// 
			this.resetSearchToolStripMenuItem.Name = "resetSearchToolStripMenuItem";
			this.resetSearchToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.resetSearchToolStripMenuItem.Text = "Reset search";
			this.resetSearchToolStripMenuItem.Click += new System.EventHandler(this.resetSearchToolStripMenuItem_Click);
			// 
			// searchBarToolStripMenuItem
			// 
			this.searchBarToolStripMenuItem.Checked = true;
			this.searchBarToolStripMenuItem.CheckOnClick = true;
			this.searchBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.searchBarToolStripMenuItem.Name = "searchBarToolStripMenuItem";
			this.searchBarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.searchBarToolStripMenuItem.Text = "Search bar";
			this.searchBarToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.searchBarToolStripMenuItem_CheckStateChanged);
			// 
			// copyOnClickToolStripMenuItem
			// 
			this.copyOnClickToolStripMenuItem.CheckOnClick = true;
			this.copyOnClickToolStripMenuItem.Name = "copyOnClickToolStripMenuItem";
			this.copyOnClickToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.copyOnClickToolStripMenuItem.Text = "Copy on click";
			this.copyOnClickToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.copyOnClickToolStripMenuItem_CheckStateChanged);
			// 
			// disablePromptToolStripMenuItem
			// 
			this.disablePromptToolStripMenuItem.CheckOnClick = true;
			this.disablePromptToolStripMenuItem.Name = "disablePromptToolStripMenuItem";
			this.disablePromptToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.disablePromptToolStripMenuItem.Text = "Disable prompt";
			this.disablePromptToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.disablePromptToolStripMenuItem_CheckStateChanged);
			// 
			// comboBoxGender
			// 
			this.comboBoxGender.BackColor = System.Drawing.Color.White;
			this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.comboBoxGender.FormattingEnabled = true;
			this.comboBoxGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
			this.comboBoxGender.Location = new System.Drawing.Point(69, 33);
			this.comboBoxGender.Name = "comboBoxGender";
			this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
			this.comboBoxGender.TabIndex = 1;
			this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
			// 
			// groupBoxSearch
			// 
			this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxSearch.Controls.Add(this.linkLabelClearPhoneNumber);
			this.groupBoxSearch.Controls.Add(this.linkLabelClearLastName);
			this.groupBoxSearch.Controls.Add(this.linkLabelClearFirstName);
			this.groupBoxSearch.Controls.Add(this.labelPhoneNumber);
			this.groupBoxSearch.Controls.Add(this.comboBoxGender);
			this.groupBoxSearch.Controls.Add(this.textBoxSearchPhoneNumber);
			this.groupBoxSearch.Controls.Add(this.labelGender);
			this.groupBoxSearch.Controls.Add(this.textBoxSearchFirstName);
			this.groupBoxSearch.Controls.Add(this.labelFirstName);
			this.groupBoxSearch.Controls.Add(this.textBoxSerachLastName);
			this.groupBoxSearch.Controls.Add(this.labelLastName);
			this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.groupBoxSearch.Location = new System.Drawing.Point(12, 27);
			this.groupBoxSearch.Name = "groupBoxSearch";
			this.groupBoxSearch.Size = new System.Drawing.Size(887, 63);
			this.groupBoxSearch.TabIndex = 2;
			this.groupBoxSearch.TabStop = false;
			this.groupBoxSearch.Text = "Search";
			// 
			// linkLabelClearPhoneNumber
			// 
			this.linkLabelClearPhoneNumber.ActiveLinkColor = System.Drawing.Color.Black;
			this.linkLabelClearPhoneNumber.AutoSize = true;
			this.linkLabelClearPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
			this.linkLabelClearPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.linkLabelClearPhoneNumber.ForeColor = System.Drawing.Color.Gray;
			this.linkLabelClearPhoneNumber.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabelClearPhoneNumber.LinkColor = System.Drawing.Color.Gray;
			this.linkLabelClearPhoneNumber.Location = new System.Drawing.Point(855, 35);
			this.linkLabelClearPhoneNumber.Name = "linkLabelClearPhoneNumber";
			this.linkLabelClearPhoneNumber.Size = new System.Drawing.Size(14, 16);
			this.linkLabelClearPhoneNumber.TabIndex = 10;
			this.linkLabelClearPhoneNumber.TabStop = true;
			this.linkLabelClearPhoneNumber.Text = "x";
			this.linkLabelClearPhoneNumber.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkLabelClearPhoneNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearPhoneNumber_LinkClicked);
			// 
			// linkLabelClearLastName
			// 
			this.linkLabelClearLastName.ActiveLinkColor = System.Drawing.Color.Black;
			this.linkLabelClearLastName.AutoSize = true;
			this.linkLabelClearLastName.BackColor = System.Drawing.SystemColors.Window;
			this.linkLabelClearLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.linkLabelClearLastName.ForeColor = System.Drawing.Color.Gray;
			this.linkLabelClearLastName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabelClearLastName.LinkColor = System.Drawing.Color.Gray;
			this.linkLabelClearLastName.Location = new System.Drawing.Point(610, 35);
			this.linkLabelClearLastName.Name = "linkLabelClearLastName";
			this.linkLabelClearLastName.Size = new System.Drawing.Size(14, 16);
			this.linkLabelClearLastName.TabIndex = 9;
			this.linkLabelClearLastName.TabStop = true;
			this.linkLabelClearLastName.Text = "x";
			this.linkLabelClearLastName.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkLabelClearLastName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearLastName_LinkClicked);
			// 
			// linkLabelClearFirstName
			// 
			this.linkLabelClearFirstName.ActiveLinkColor = System.Drawing.Color.Black;
			this.linkLabelClearFirstName.AutoSize = true;
			this.linkLabelClearFirstName.BackColor = System.Drawing.SystemColors.Window;
			this.linkLabelClearFirstName.Cursor = System.Windows.Forms.Cursors.Default;
			this.linkLabelClearFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.linkLabelClearFirstName.ForeColor = System.Drawing.Color.Gray;
			this.linkLabelClearFirstName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabelClearFirstName.LinkColor = System.Drawing.Color.Gray;
			this.linkLabelClearFirstName.Location = new System.Drawing.Point(390, 35);
			this.linkLabelClearFirstName.Name = "linkLabelClearFirstName";
			this.linkLabelClearFirstName.Size = new System.Drawing.Size(14, 16);
			this.linkLabelClearFirstName.TabIndex = 8;
			this.linkLabelClearFirstName.TabStop = true;
			this.linkLabelClearFirstName.Text = "x";
			this.linkLabelClearFirstName.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkLabelClearFirstName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearFirstName_LinkClicked);
			// 
			// labelPhoneNumber
			// 
			this.labelPhoneNumber.AutoSize = true;
			this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPhoneNumber.Location = new System.Drawing.Point(655, 34);
			this.labelPhoneNumber.Name = "labelPhoneNumber";
			this.labelPhoneNumber.Size = new System.Drawing.Size(88, 15);
			this.labelPhoneNumber.TabIndex = 6;
			this.labelPhoneNumber.Text = "phone number";
			// 
			// textBoxSearchPhoneNumber
			// 
			this.textBoxSearchPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxSearchPhoneNumber.Location = new System.Drawing.Point(749, 34);
			this.textBoxSearchPhoneNumber.MaxLength = 12;
			this.textBoxSearchPhoneNumber.Name = "textBoxSearchPhoneNumber";
			this.textBoxSearchPhoneNumber.Size = new System.Drawing.Size(122, 20);
			this.textBoxSearchPhoneNumber.TabIndex = 4;
			this.textBoxSearchPhoneNumber.TextChanged += new System.EventHandler(this.textBoxSearchFirstName_TextChanged);
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGender.Location = new System.Drawing.Point(17, 34);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(46, 15);
			this.labelGender.TabIndex = 7;
			this.labelGender.Text = "gender";
			// 
			// textBoxSearchFirstName
			// 
			this.textBoxSearchFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxSearchFirstName.Location = new System.Drawing.Point(284, 34);
			this.textBoxSearchFirstName.MaxLength = 12;
			this.textBoxSearchFirstName.Name = "textBoxSearchFirstName";
			this.textBoxSearchFirstName.Size = new System.Drawing.Size(122, 20);
			this.textBoxSearchFirstName.TabIndex = 2;
			this.textBoxSearchFirstName.TextChanged += new System.EventHandler(this.textBoxSearchFirstName_TextChanged);
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFirstName.Location = new System.Drawing.Point(217, 34);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(61, 15);
			this.labelFirstName.TabIndex = 4;
			this.labelFirstName.Text = "first name";
			// 
			// textBoxSerachLastName
			// 
			this.textBoxSerachLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxSerachLastName.Location = new System.Drawing.Point(504, 34);
			this.textBoxSerachLastName.MaxLength = 12;
			this.textBoxSerachLastName.Name = "textBoxSerachLastName";
			this.textBoxSerachLastName.Size = new System.Drawing.Size(122, 20);
			this.textBoxSerachLastName.TabIndex = 3;
			this.textBoxSerachLastName.TextChanged += new System.EventHandler(this.textBoxSearchFirstName_TextChanged);
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLastName.Location = new System.Drawing.Point(437, 34);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(61, 15);
			this.labelLastName.TabIndex = 5;
			this.labelLastName.Text = "last name";
			// 
			// dataGridViewContacts
			// 
			this.dataGridViewContacts.AllowUserToAddRows = false;
			this.dataGridViewContacts.AllowUserToDeleteRows = false;
			this.dataGridViewContacts.AllowUserToResizeRows = false;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridViewContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridViewContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewContacts.AutoGenerateColumns = false;
			this.dataGridViewContacts.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.remove,
            this.edit,
            this.vCard,
            this.id,
            this.gender,
            this.firstName,
            this.lastName,
            this.phoneNumber});
			this.dataGridViewContacts.DataSource = this.contactsTableBindingSource;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.MenuBar;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewContacts.DefaultCellStyle = dataGridViewCellStyle20;
			this.dataGridViewContacts.Location = new System.Drawing.Point(12, 96);
			this.dataGridViewContacts.Name = "dataGridViewContacts";
			this.dataGridViewContacts.ReadOnly = true;
			this.dataGridViewContacts.RowHeadersVisible = false;
			this.dataGridViewContacts.RowTemplate.ReadOnly = true;
			this.dataGridViewContacts.Size = new System.Drawing.Size(887, 354);
			this.dataGridViewContacts.TabIndex = 3;
			this.dataGridViewContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContacts_CellContentClick);
			this.dataGridViewContacts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewContacts_CellMouseClick);
			// 
			// remove
			// 
			this.remove.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.remove.DefaultCellStyle = dataGridViewCellStyle17;
			this.remove.HeaderText = "remove";
			this.remove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.remove.MinimumWidth = 60;
			this.remove.Name = "remove";
			this.remove.ReadOnly = true;
			this.remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.remove.Text = "remove";
			this.remove.UseColumnTextForLinkValue = true;
			this.remove.VisitedLinkColor = System.Drawing.Color.Blue;
			this.remove.Width = 60;
			// 
			// edit
			// 
			this.edit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.edit.DefaultCellStyle = dataGridViewCellStyle18;
			this.edit.HeaderText = "edit";
			this.edit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.edit.MinimumWidth = 50;
			this.edit.Name = "edit";
			this.edit.ReadOnly = true;
			this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.edit.Text = "edit";
			this.edit.UseColumnTextForLinkValue = true;
			this.edit.VisitedLinkColor = System.Drawing.Color.Blue;
			this.edit.Width = 50;
			// 
			// vCard
			// 
			this.vCard.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.vCard.DefaultCellStyle = dataGridViewCellStyle19;
			this.vCard.HeaderText = "vCard";
			this.vCard.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.vCard.MinimumWidth = 60;
			this.vCard.Name = "vCard";
			this.vCard.ReadOnly = true;
			this.vCard.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.vCard.Text = "vCard";
			this.vCard.UseColumnTextForLinkValue = true;
			this.vCard.VisitedLinkColor = System.Drawing.Color.Blue;
			this.vCard.Width = 60;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// gender
			// 
			this.gender.DataPropertyName = "gender";
			this.gender.HeaderText = "gender";
			this.gender.MinimumWidth = 100;
			this.gender.Name = "gender";
			this.gender.ReadOnly = true;
			// 
			// firstName
			// 
			this.firstName.DataPropertyName = "firstName";
			this.firstName.HeaderText = "first name";
			this.firstName.MinimumWidth = 100;
			this.firstName.Name = "firstName";
			this.firstName.ReadOnly = true;
			// 
			// lastName
			// 
			this.lastName.DataPropertyName = "lastName";
			this.lastName.HeaderText = "last name";
			this.lastName.MinimumWidth = 100;
			this.lastName.Name = "lastName";
			this.lastName.ReadOnly = true;
			// 
			// phoneNumber
			// 
			this.phoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.phoneNumber.DataPropertyName = "phoneNumber";
			this.phoneNumber.HeaderText = "phone number";
			this.phoneNumber.MinimumWidth = 414;
			this.phoneNumber.Name = "phoneNumber";
			this.phoneNumber.ReadOnly = true;
			// 
			// contactsTableBindingSource
			// 
			this.contactsTableBindingSource.DataMember = "ContactsTable";
			this.contactsTableBindingSource.DataSource = this.contactsDBDataSet;
			// 
			// ContactsDBDataSet
			// 
			this.contactsDBDataSet.DataSetName = "ContactsDBDataSet";
			this.contactsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// saveFileDialogMain
			// 
			this.saveFileDialogMain.DefaultExt = "vcf";
			this.saveFileDialogMain.Filter = "vCard File (*.vcf)|";
			this.saveFileDialogMain.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogMain_FileOk);
			// 
			// contactsTableTableAdapter
			// 
			this.contactsTableTableAdapter.ClearBeforeFill = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 462);
			this.Controls.Add(this.menuStripMain);
			this.Controls.Add(this.groupBoxSearch);
			this.Controls.Add(this.dataGridViewContacts);
			this.MainMenuStrip = this.menuStripMain;
			this.MinimumSize = new System.Drawing.Size(927, 500);
			this.Name = "FormMain";
			this.Text = "Contacts";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.groupBoxSearch.ResumeLayout(false);
			this.groupBoxSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contactsTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contactsDBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearchFirstName;
        private System.Windows.Forms.ToolStripMenuItem searchBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearchPhoneNumber;
        private System.Windows.Forms.TextBox textBoxSerachLastName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.ToolStripMenuItem resetSearchToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private ContactsDBDataSet contactsDBDataSet;
        private System.Windows.Forms.BindingSource contactsTableBindingSource;
        private ContactsDBDataSetTableAdapters.ContactsTableTableAdapter contactsTableTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem saveAsvcfToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.ToolStripMenuItem copyOnClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disablePromptToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabelClearFirstName;
        private System.Windows.Forms.LinkLabel linkLabelClearLastName;
        private System.Windows.Forms.LinkLabel linkLabelClearPhoneNumber;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.DataGridViewLinkColumn remove;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
        private System.Windows.Forms.DataGridViewLinkColumn vCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
    }
}

