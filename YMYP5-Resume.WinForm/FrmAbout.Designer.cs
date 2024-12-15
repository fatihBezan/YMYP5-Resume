namespace YMYP5_Resume.WinForm;

partial class FrmAbout
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
        groupBox1 = new GroupBox();
        btnAdd = new Button();
        rtbxDescription = new RichTextBox();
        lblDescription = new Label();
        groupBox2 = new GroupBox();
        dgvAbouts = new DataGridView();
        groupBox3 = new GroupBox();
        btnUpdate = new Button();
        cbxIsActive = new CheckBox();
        cbxIsDelete = new CheckBox();
        rtbUpdateAbout = new RichTextBox();
        lblUptDesc = new Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAbouts).BeginInit();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnAdd);
        groupBox1.Controls.Add(rtbxDescription);
        groupBox1.Controls.Add(lblDescription);
        groupBox1.Location = new Point(17, 20);
        groupBox1.Margin = new Padding(4, 5, 4, 5);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 5, 4, 5);
        groupBox1.Size = new Size(479, 297);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Insert About Panel";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(327, 237);
        btnAdd.Margin = new Padding(4, 5, 4, 5);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(143, 50);
        btnAdd.TabIndex = 2;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // rtbxDescription
        // 
        rtbxDescription.Location = new Point(126, 37);
        rtbxDescription.Margin = new Padding(4, 5, 4, 5);
        rtbxDescription.Name = "rtbxDescription";
        rtbxDescription.Size = new Size(343, 187);
        rtbxDescription.TabIndex = 1;
        rtbxDescription.Text = "";
        rtbxDescription.TextChanged += rtbxDescription_TextChanged;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(9, 45);
        lblDescription.Margin = new Padding(4, 0, 4, 0);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(116, 25);
        lblDescription.TabIndex = 0;
        lblDescription.Text = "Description : ";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgvAbouts);
        groupBox2.Location = new Point(17, 327);
        groupBox2.Margin = new Padding(4, 5, 4, 5);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(4, 5, 4, 5);
        groupBox2.Size = new Size(1106, 403);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "About List";
        // 
        // dgvAbouts
        // 
        dgvAbouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAbouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAbouts.Dock = DockStyle.Fill;
        dgvAbouts.Location = new Point(4, 29);
        dgvAbouts.Margin = new Padding(4, 5, 4, 5);
        dgvAbouts.Name = "dgvAbouts";
        dgvAbouts.RowHeadersWidth = 62;
        dgvAbouts.Size = new Size(1098, 369);
        dgvAbouts.TabIndex = 0;
        dgvAbouts.CellContentClick += dgvAbouts_CellContentClick;
        dgvAbouts.CellDoubleClick += dgvAbouts_CellDoubleClick;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(btnUpdate);
        groupBox3.Controls.Add(cbxIsActive);
        groupBox3.Controls.Add(cbxIsDelete);
        groupBox3.Controls.Add(rtbUpdateAbout);
        groupBox3.Controls.Add(lblUptDesc);
        groupBox3.Location = new Point(504, 20);
        groupBox3.Margin = new Padding(4, 5, 4, 5);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(4, 5, 4, 5);
        groupBox3.Size = new Size(619, 297);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Update Panel";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(503, 237);
        btnUpdate.Margin = new Padding(4, 5, 4, 5);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(107, 50);
        btnUpdate.TabIndex = 6;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // cbxIsActive
        // 
        cbxIsActive.AutoSize = true;
        cbxIsActive.Location = new Point(9, 190);
        cbxIsActive.Margin = new Padding(4, 5, 4, 5);
        cbxIsActive.Name = "cbxIsActive";
        cbxIsActive.Size = new Size(104, 29);
        cbxIsActive.TabIndex = 5;
        cbxIsActive.Text = "Is Active";
        cbxIsActive.UseVisualStyleBackColor = true;
        // 
        // cbxIsDelete
        // 
        cbxIsDelete.AutoSize = true;
        cbxIsDelete.Location = new Point(9, 148);
        cbxIsDelete.Margin = new Padding(4, 5, 4, 5);
        cbxIsDelete.Name = "cbxIsDelete";
        cbxIsDelete.Size = new Size(106, 29);
        cbxIsDelete.TabIndex = 4;
        cbxIsDelete.Text = "Is Delete";
        cbxIsDelete.UseVisualStyleBackColor = true;
        // 
        // rtbUpdateAbout
        // 
        rtbUpdateAbout.Location = new Point(127, 37);
        rtbUpdateAbout.Margin = new Padding(4, 5, 4, 5);
        rtbUpdateAbout.Name = "rtbUpdateAbout";
        rtbUpdateAbout.Size = new Size(481, 187);
        rtbUpdateAbout.TabIndex = 3;
        rtbUpdateAbout.Text = "";
        // 
        // lblUptDesc
        // 
        lblUptDesc.AutoSize = true;
        lblUptDesc.Location = new Point(10, 45);
        lblUptDesc.Margin = new Padding(4, 0, 4, 0);
        lblUptDesc.Name = "lblUptDesc";
        lblUptDesc.Size = new Size(116, 25);
        lblUptDesc.TabIndex = 2;
        lblUptDesc.Text = "Description : ";
        // 
        // FrmAbout
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1133, 750);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Margin = new Padding(4, 5, 4, 5);
        Name = "FrmAbout";
        Text = "FrmAbout";
        Load += FrmAbout_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvAbouts).EndInit();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
	private Label lblDescription;
	private Button btnAdd;
	private RichTextBox rtbxDescription;
	private GroupBox groupBox2;
	private DataGridView dgvAbouts;
	private GroupBox groupBox3;
	private RichTextBox rtbUpdateAbout;
	private Label lblUptDesc;
	private CheckBox cbxIsActive;
	private CheckBox cbxIsDelete;
	private Button btnUpdate;
}