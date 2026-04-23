namespace PayrollSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtEmployeeStatus = new System.Windows.Forms.TextBox();
            this.lblEmployeeStatus = new System.Windows.Forms.Label();
            this.txtPaydate = new System.Windows.Forms.TextBox();
            this.lblPaydate = new System.Windows.Forms.Label();
            this.txtQualifiedDependents = new System.Windows.Forms.TextBox();
            this.lblQualifiedDependents = new System.Windows.Forms.Label();
            this.txtCivilStatus = new System.Windows.Forms.TextBox();
            this.lblCivilStatus = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtEmployeeNo = new System.Windows.Forms.TextBox();
            this.lblEmployeeNo = new System.Windows.Forms.Label();
            this.grpBasicIncome = new System.Windows.Forms.GroupBox();
            this.txtBasicIncome = new System.Windows.Forms.TextBox();
            this.lblBasicIncome = new System.Windows.Forms.Label();
            this.txtBasicHours = new System.Windows.Forms.TextBox();
            this.lblBasicHours = new System.Windows.Forms.Label();
            this.txtBasicRate = new System.Windows.Forms.TextBox();
            this.lblBasicRate = new System.Windows.Forms.Label();
            this.grpHonorariumIncome = new System.Windows.Forms.GroupBox();
            this.txtHonorIncome = new System.Windows.Forms.TextBox();
            this.lblHonorIncome = new System.Windows.Forms.Label();
            this.txtHonorHours = new System.Windows.Forms.TextBox();
            this.lblHonorHours = new System.Windows.Forms.Label();
            this.txtHonorRate = new System.Windows.Forms.TextBox();
            this.lblHonorRate = new System.Windows.Forms.Label();
            this.grpOtherIncome = new System.Windows.Forms.GroupBox();
            this.txtOtherIncome = new System.Windows.Forms.TextBox();
            this.lblOtherIncome = new System.Windows.Forms.Label();
            this.txtOtherHours = new System.Windows.Forms.TextBox();
            this.lblOtherHours = new System.Windows.Forms.Label();
            this.txtOtherRate = new System.Windows.Forms.TextBox();
            this.lblOtherRate = new System.Windows.Forms.Label();
            this.grpRegularDeductions = new System.Windows.Forms.GroupBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtPagibig = new System.Windows.Forms.TextBox();
            this.lblPagibig = new System.Windows.Forms.Label();
            this.txtPhilHealth = new System.Windows.Forms.TextBox();
            this.lblPhilHealth = new System.Windows.Forms.Label();
            this.txtSSS = new System.Windows.Forms.TextBox();
            this.lblSSS = new System.Windows.Forms.Label();
            this.grpOtherDeductions = new System.Windows.Forms.GroupBox();
            this.txtOtherLoans = new System.Windows.Forms.TextBox();
            this.lblOtherLoans = new System.Windows.Forms.Label();
            this.txtSalaryLoan = new System.Windows.Forms.TextBox();
            this.lblSalaryLoan = new System.Windows.Forms.Label();
            this.txtFacultySavingsLoan = new System.Windows.Forms.TextBox();
            this.lblFacultySavingsLoan = new System.Windows.Forms.Label();
            this.txtFacultySavingsDeposit = new System.Windows.Forms.TextBox();
            this.lblFacultySavingsDeposit = new System.Windows.Forms.Label();
            this.txtPagibigLoan = new System.Windows.Forms.TextBox();
            this.lblPagibigLoan = new System.Windows.Forms.Label();
            this.txtSSSLoan = new System.Windows.Forms.TextBox();
            this.lblSSSLoan = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.txtNetIncome = new System.Windows.Forms.TextBox();
            this.lblNetIncome = new System.Windows.Forms.Label();
            this.txtTotalDeductions = new System.Windows.Forms.TextBox();
            this.lblTotalDeductions = new System.Windows.Forms.Label();
            this.txtGrossIncome = new System.Windows.Forms.TextBox();
            this.lblGrossIncome = new System.Windows.Forms.Label();
            this.btnGrossIncome = new System.Windows.Forms.Button();
            this.btnNetIncome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grpEmployeeInfo.SuspendLayout();
            this.grpBasicIncome.SuspendLayout();
            this.grpHonorariumIncome.SuspendLayout();
            this.grpOtherIncome.SuspendLayout();
            this.grpRegularDeductions.SuspendLayout();
            this.grpOtherDeductions.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1160, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payroll System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpEmployeeInfo
            // 
            this.grpEmployeeInfo.Controls.Add(this.txtDesignation);
            this.grpEmployeeInfo.Controls.Add(this.lblDesignation);
            this.grpEmployeeInfo.Controls.Add(this.txtEmployeeStatus);
            this.grpEmployeeInfo.Controls.Add(this.lblEmployeeStatus);
            this.grpEmployeeInfo.Controls.Add(this.txtPaydate);
            this.grpEmployeeInfo.Controls.Add(this.lblPaydate);
            this.grpEmployeeInfo.Controls.Add(this.txtQualifiedDependents);
            this.grpEmployeeInfo.Controls.Add(this.lblQualifiedDependents);
            this.grpEmployeeInfo.Controls.Add(this.txtCivilStatus);
            this.grpEmployeeInfo.Controls.Add(this.lblCivilStatus);
            this.grpEmployeeInfo.Controls.Add(this.txtSurname);
            this.grpEmployeeInfo.Controls.Add(this.lblSurname);
            this.grpEmployeeInfo.Controls.Add(this.txtMiddleName);
            this.grpEmployeeInfo.Controls.Add(this.lblMiddleName);
            this.grpEmployeeInfo.Controls.Add(this.txtFirstName);
            this.grpEmployeeInfo.Controls.Add(this.lblFirstName);
            this.grpEmployeeInfo.Controls.Add(this.txtDepartment);
            this.grpEmployeeInfo.Controls.Add(this.lblDepartment);
            this.grpEmployeeInfo.Controls.Add(this.txtEmployeeNo);
            this.grpEmployeeInfo.Controls.Add(this.lblEmployeeNo);
            this.grpEmployeeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpEmployeeInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpEmployeeInfo.Location = new System.Drawing.Point(20, 60);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(1140, 170);
            this.grpEmployeeInfo.TabIndex = 1;
            this.grpEmployeeInfo.TabStop = false;
            this.grpEmployeeInfo.Text = "Employee Information";
            // 
            // txtDesignation
            // 
            this.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesignation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDesignation.Location = new System.Drawing.Point(865, 120);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(240, 23);
            this.txtDesignation.TabIndex = 19;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesignation.Location = new System.Drawing.Point(720, 123);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(69, 15);
            this.lblDesignation.TabIndex = 18;
            this.lblDesignation.Text = "Designation";
            // 
            // txtEmployeeStatus
            // 
            this.txtEmployeeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeStatus.Location = new System.Drawing.Point(865, 90);
            this.txtEmployeeStatus.Name = "txtEmployeeStatus";
            this.txtEmployeeStatus.Size = new System.Drawing.Size(240, 23);
            this.txtEmployeeStatus.TabIndex = 17;
            // 
            // lblEmployeeStatus
            // 
            this.lblEmployeeStatus.AutoSize = true;
            this.lblEmployeeStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmployeeStatus.Location = new System.Drawing.Point(720, 93);
            this.lblEmployeeStatus.Name = "lblEmployeeStatus";
            this.lblEmployeeStatus.Size = new System.Drawing.Size(91, 15);
            this.lblEmployeeStatus.TabIndex = 16;
            this.lblEmployeeStatus.Text = "Employee Status";
            // 
            // txtPaydate
            // 
            this.txtPaydate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaydate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaydate.Location = new System.Drawing.Point(865, 60);
            this.txtPaydate.Name = "txtPaydate";
            this.txtPaydate.Size = new System.Drawing.Size(240, 23);
            this.txtPaydate.TabIndex = 15;
            // 
            // lblPaydate
            // 
            this.lblPaydate.AutoSize = true;
            this.lblPaydate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaydate.Location = new System.Drawing.Point(720, 63);
            this.lblPaydate.Name = "lblPaydate";
            this.lblPaydate.Size = new System.Drawing.Size(49, 15);
            this.lblPaydate.TabIndex = 14;
            this.lblPaydate.Text = "Paydate";
            // 
            // txtQualifiedDependents
            // 
            this.txtQualifiedDependents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQualifiedDependents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQualifiedDependents.Location = new System.Drawing.Point(865, 30);
            this.txtQualifiedDependents.Name = "txtQualifiedDependents";
            this.txtQualifiedDependents.Size = new System.Drawing.Size(240, 23);
            this.txtQualifiedDependents.TabIndex = 13;
            // 
            // lblQualifiedDependents
            // 
            this.lblQualifiedDependents.AutoSize = true;
            this.lblQualifiedDependents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQualifiedDependents.Location = new System.Drawing.Point(720, 33);
            this.lblQualifiedDependents.Name = "lblQualifiedDependents";
            this.lblQualifiedDependents.Size = new System.Drawing.Size(126, 15);
            this.lblQualifiedDependents.TabIndex = 12;
            this.lblQualifiedDependents.Text = "Qualified Dependents";
            // 
            // txtCivilStatus
            // 
            this.txtCivilStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCivilStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCivilStatus.Location = new System.Drawing.Point(440, 120);
            this.txtCivilStatus.Name = "txtCivilStatus";
            this.txtCivilStatus.Size = new System.Drawing.Size(240, 23);
            this.txtCivilStatus.TabIndex = 11;
            // 
            // lblCivilStatus
            // 
            this.lblCivilStatus.AutoSize = true;
            this.lblCivilStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCivilStatus.Location = new System.Drawing.Point(300, 123);
            this.lblCivilStatus.Name = "lblCivilStatus";
            this.lblCivilStatus.Size = new System.Drawing.Size(63, 15);
            this.lblCivilStatus.TabIndex = 10;
            this.lblCivilStatus.Text = "Civil Status";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSurname.Location = new System.Drawing.Point(440, 90);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(240, 23);
            this.txtSurname.TabIndex = 9;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSurname.Location = new System.Drawing.Point(300, 93);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(57, 15);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMiddleName.Location = new System.Drawing.Point(440, 60);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(240, 23);
            this.txtMiddleName.TabIndex = 7;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMiddleName.Location = new System.Drawing.Point(300, 63);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(80, 15);
            this.lblMiddleName.TabIndex = 6;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.Location = new System.Drawing.Point(440, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(240, 23);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirstName.Location = new System.Drawing.Point(300, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDepartment.Location = new System.Drawing.Point(130, 65);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(140, 23);
            this.txtDepartment.TabIndex = 3;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDepartment.Location = new System.Drawing.Point(20, 68);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(71, 15);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // txtEmployeeNo
            // 
            this.txtEmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeNo.Location = new System.Drawing.Point(130, 35);
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.Size = new System.Drawing.Size(140, 23);
            this.txtEmployeeNo.TabIndex = 1;
            // 
            // lblEmployeeNo
            // 
            this.lblEmployeeNo.AutoSize = true;
            this.lblEmployeeNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmployeeNo.Location = new System.Drawing.Point(20, 38);
            this.lblEmployeeNo.Name = "lblEmployeeNo";
            this.lblEmployeeNo.Size = new System.Drawing.Size(77, 15);
            this.lblEmployeeNo.TabIndex = 0;
            this.lblEmployeeNo.Text = "Employee No";
            // 
            // grpBasicIncome
            // 
            this.grpBasicIncome.Controls.Add(this.txtBasicIncome);
            this.grpBasicIncome.Controls.Add(this.lblBasicIncome);
            this.grpBasicIncome.Controls.Add(this.txtBasicHours);
            this.grpBasicIncome.Controls.Add(this.lblBasicHours);
            this.grpBasicIncome.Controls.Add(this.txtBasicRate);
            this.grpBasicIncome.Controls.Add(this.lblBasicRate);
            this.grpBasicIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpBasicIncome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpBasicIncome.Location = new System.Drawing.Point(20, 245);
            this.grpBasicIncome.Name = "grpBasicIncome";
            this.grpBasicIncome.Size = new System.Drawing.Size(360, 145);
            this.grpBasicIncome.TabIndex = 2;
            this.grpBasicIncome.TabStop = false;
            this.grpBasicIncome.Text = "Basic Income";
            // 
            // txtBasicIncome
            // 
            this.txtBasicIncome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBasicIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasicIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBasicIncome.Location = new System.Drawing.Point(145, 100);
            this.txtBasicIncome.Name = "txtBasicIncome";
            this.txtBasicIncome.ReadOnly = true;
            this.txtBasicIncome.Size = new System.Drawing.Size(180, 23);
            this.txtBasicIncome.TabIndex = 5;
            // 
            // lblBasicIncome
            // 
            this.lblBasicIncome.AutoSize = true;
            this.lblBasicIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBasicIncome.Location = new System.Drawing.Point(20, 103);
            this.lblBasicIncome.Name = "lblBasicIncome";
            this.lblBasicIncome.Size = new System.Drawing.Size(92, 15);
            this.lblBasicIncome.TabIndex = 4;
            this.lblBasicIncome.Text = "Income / Cutoff";
            // 
            // txtBasicHours
            // 
            this.txtBasicHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasicHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBasicHours.Location = new System.Drawing.Point(145, 65);
            this.txtBasicHours.Name = "txtBasicHours";
            this.txtBasicHours.Size = new System.Drawing.Size(180, 23);
            this.txtBasicHours.TabIndex = 3;
            // 
            // lblBasicHours
            // 
            this.lblBasicHours.AutoSize = true;
            this.lblBasicHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBasicHours.Location = new System.Drawing.Point(20, 68);
            this.lblBasicHours.Name = "lblBasicHours";
            this.lblBasicHours.Size = new System.Drawing.Size(104, 15);
            this.lblBasicHours.TabIndex = 2;
            this.lblBasicHours.Text = "No. of Hours / Cut";
            // 
            // txtBasicRate
            // 
            this.txtBasicRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasicRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBasicRate.Location = new System.Drawing.Point(145, 30);
            this.txtBasicRate.Name = "txtBasicRate";
            this.txtBasicRate.Size = new System.Drawing.Size(180, 23);
            this.txtBasicRate.TabIndex = 1;
            // 
            // lblBasicRate
            // 
            this.lblBasicRate.AutoSize = true;
            this.lblBasicRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBasicRate.Location = new System.Drawing.Point(20, 33);
            this.lblBasicRate.Name = "lblBasicRate";
            this.lblBasicRate.Size = new System.Drawing.Size(62, 15);
            this.lblBasicRate.TabIndex = 0;
            this.lblBasicRate.Text = "Rate / Hour";
            // 
            // grpHonorariumIncome
            // 
            this.grpHonorariumIncome.Controls.Add(this.txtHonorIncome);
            this.grpHonorariumIncome.Controls.Add(this.lblHonorIncome);
            this.grpHonorariumIncome.Controls.Add(this.txtHonorHours);
            this.grpHonorariumIncome.Controls.Add(this.lblHonorHours);
            this.grpHonorariumIncome.Controls.Add(this.txtHonorRate);
            this.grpHonorariumIncome.Controls.Add(this.lblHonorRate);
            this.grpHonorariumIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpHonorariumIncome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpHonorariumIncome.Location = new System.Drawing.Point(20, 405);
            this.grpHonorariumIncome.Name = "grpHonorariumIncome";
            this.grpHonorariumIncome.Size = new System.Drawing.Size(360, 145);
            this.grpHonorariumIncome.TabIndex = 3;
            this.grpHonorariumIncome.TabStop = false;
            this.grpHonorariumIncome.Text = "Honorarium Income";
            // 
            // txtHonorIncome
            // 
            this.txtHonorIncome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHonorIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHonorIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHonorIncome.Location = new System.Drawing.Point(145, 100);
            this.txtHonorIncome.Name = "txtHonorIncome";
            this.txtHonorIncome.ReadOnly = true;
            this.txtHonorIncome.Size = new System.Drawing.Size(180, 23);
            this.txtHonorIncome.TabIndex = 5;
            // 
            // lblHonorIncome
            // 
            this.lblHonorIncome.AutoSize = true;
            this.lblHonorIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHonorIncome.Location = new System.Drawing.Point(20, 103);
            this.lblHonorIncome.Name = "lblHonorIncome";
            this.lblHonorIncome.Size = new System.Drawing.Size(92, 15);
            this.lblHonorIncome.TabIndex = 4;
            this.lblHonorIncome.Text = "Income / Cutoff";
            // 
            // txtHonorHours
            // 
            this.txtHonorHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHonorHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHonorHours.Location = new System.Drawing.Point(145, 65);
            this.txtHonorHours.Name = "txtHonorHours";
            this.txtHonorHours.Size = new System.Drawing.Size(180, 23);
            this.txtHonorHours.TabIndex = 3;
            // 
            // lblHonorHours
            // 
            this.lblHonorHours.AutoSize = true;
            this.lblHonorHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHonorHours.Location = new System.Drawing.Point(20, 68);
            this.lblHonorHours.Name = "lblHonorHours";
            this.lblHonorHours.Size = new System.Drawing.Size(104, 15);
            this.lblHonorHours.TabIndex = 2;
            this.lblHonorHours.Text = "No. of Hours / Cut";
            // 
            // txtHonorRate
            // 
            this.txtHonorRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHonorRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHonorRate.Location = new System.Drawing.Point(145, 30);
            this.txtHonorRate.Name = "txtHonorRate";
            this.txtHonorRate.Size = new System.Drawing.Size(180, 23);
            this.txtHonorRate.TabIndex = 1;
            // 
            // lblHonorRate
            // 
            this.lblHonorRate.AutoSize = true;
            this.lblHonorRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHonorRate.Location = new System.Drawing.Point(20, 33);
            this.lblHonorRate.Name = "lblHonorRate";
            this.lblHonorRate.Size = new System.Drawing.Size(62, 15);
            this.lblHonorRate.TabIndex = 0;
            this.lblHonorRate.Text = "Rate / Hour";
            // 
            // grpOtherIncome
            // 
            this.grpOtherIncome.Controls.Add(this.txtOtherIncome);
            this.grpOtherIncome.Controls.Add(this.lblOtherIncome);
            this.grpOtherIncome.Controls.Add(this.txtOtherHours);
            this.grpOtherIncome.Controls.Add(this.lblOtherHours);
            this.grpOtherIncome.Controls.Add(this.txtOtherRate);
            this.grpOtherIncome.Controls.Add(this.lblOtherRate);
            this.grpOtherIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpOtherIncome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpOtherIncome.Location = new System.Drawing.Point(20, 565);
            this.grpOtherIncome.Name = "grpOtherIncome";
            this.grpOtherIncome.Size = new System.Drawing.Size(360, 145);
            this.grpOtherIncome.TabIndex = 4;
            this.grpOtherIncome.TabStop = false;
            this.grpOtherIncome.Text = "Other Income";
            // 
            // txtOtherIncome
            // 
            this.txtOtherIncome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOtherIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOtherIncome.Location = new System.Drawing.Point(145, 100);
            this.txtOtherIncome.Name = "txtOtherIncome";
            this.txtOtherIncome.ReadOnly = true;
            this.txtOtherIncome.Size = new System.Drawing.Size(180, 23);
            this.txtOtherIncome.TabIndex = 5;
            // 
            // lblOtherIncome
            // 
            this.lblOtherIncome.AutoSize = true;
            this.lblOtherIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOtherIncome.Location = new System.Drawing.Point(20, 103);
            this.lblOtherIncome.Name = "lblOtherIncome";
            this.lblOtherIncome.Size = new System.Drawing.Size(92, 15);
            this.lblOtherIncome.TabIndex = 4;
            this.lblOtherIncome.Text = "Income / Cutoff";
            // 
            // txtOtherHours
            // 
            this.txtOtherHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOtherHours.Location = new System.Drawing.Point(145, 65);
            this.txtOtherHours.Name = "txtOtherHours";
            this.txtOtherHours.Size = new System.Drawing.Size(180, 23);
            this.txtOtherHours.TabIndex = 3;
            // 
            // lblOtherHours
            // 
            this.lblOtherHours.AutoSize = true;
            this.lblOtherHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOtherHours.Location = new System.Drawing.Point(20, 68);
            this.lblOtherHours.Name = "lblOtherHours";
            this.lblOtherHours.Size = new System.Drawing.Size(104, 15);
            this.lblOtherHours.TabIndex = 2;
            this.lblOtherHours.Text = "No. of Hours / Cut";
            // 
            // txtOtherRate
            // 
            this.txtOtherRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOtherRate.Location = new System.Drawing.Point(145, 30);
            this.txtOtherRate.Name = "txtOtherRate";
            this.txtOtherRate.Size = new System.Drawing.Size(180, 23);
            this.txtOtherRate.TabIndex = 1;
            // 
            // lblOtherRate
            // 
            this.lblOtherRate.AutoSize = true;
            this.lblOtherRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOtherRate.Location = new System.Drawing.Point(20, 33);
            this.lblOtherRate.Name = "lblOtherRate";
            this.lblOtherRate.Size = new System.Drawing.Size(62, 15);
            this.lblOtherRate.TabIndex = 0;
            this.lblOtherRate.Text = "Rate / Hour";
            // 
            // grpRegularDeductions
            // 
            this.grpRegularDeductions.Controls.Add(this.txtTax);
            this.grpRegularDeductions.Controls.Add(this.lblTax);
            this.grpRegularDeductions.Controls.Add(this.txtPagibig);
            this.grpRegularDeductions.Controls.Add(this.lblPagibig);
            this.grpRegularDeductions.Controls.Add(this.txtPhilHealth);
            this.grpRegularDeductions.Controls.Add(this.lblPhilHealth);
            this.grpRegularDeductions.Controls.Add(this.txtSSS);
            this.grpRegularDeductions.Controls.Add(this.lblSSS);
            this.grpRegularDeductions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpRegularDeductions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpRegularDeductions.Location = new System.Drawing.Point(410, 245);
            this.grpRegularDeductions.Name = "grpRegularDeductions";
            this.grpRegularDeductions.Size = new System.Drawing.Size(360, 205);
            this.grpRegularDeductions.TabIndex = 5;
            this.grpRegularDeductions.TabStop = false;
            this.grpRegularDeductions.Text = "Regular Deductions";
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTax.Location = new System.Drawing.Point(165, 150);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(170, 23);
            this.txtTax.TabIndex = 7;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTax.Location = new System.Drawing.Point(20, 153);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(120, 15);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Income Tax Cont.";
            // 
            // txtPagibig
            // 
            this.txtPagibig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagibig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPagibig.Location = new System.Drawing.Point(165, 110);
            this.txtPagibig.Name = "txtPagibig";
            this.txtPagibig.Size = new System.Drawing.Size(170, 23);
            this.txtPagibig.TabIndex = 5;
            // 
            // lblPagibig
            // 
            this.lblPagibig.AutoSize = true;
            this.lblPagibig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPagibig.Location = new System.Drawing.Point(20, 113);
            this.lblPagibig.Name = "lblPagibig";
            this.lblPagibig.Size = new System.Drawing.Size(104, 15);
            this.lblPagibig.TabIndex = 4;
            this.lblPagibig.Text = "Pag-IBIG Cont.";
            // 
            // txtPhilHealth
            // 
            this.txtPhilHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhilHealth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhilHealth.Location = new System.Drawing.Point(165, 70);
            this.txtPhilHealth.Name = "txtPhilHealth";
            this.txtPhilHealth.Size = new System.Drawing.Size(170, 23);
            this.txtPhilHealth.TabIndex = 3;
            // 
            // lblPhilHealth
            // 
            this.lblPhilHealth.AutoSize = true;
            this.lblPhilHealth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhilHealth.Location = new System.Drawing.Point(20, 73);
            this.lblPhilHealth.Name = "lblPhilHealth";
            this.lblPhilHealth.Size = new System.Drawing.Size(109, 15);
            this.lblPhilHealth.TabIndex = 2;
            this.lblPhilHealth.Text = "PhilHealth Cont.";
            // 
            // txtSSS
            // 
            this.txtSSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSSS.Location = new System.Drawing.Point(165, 30);
            this.txtSSS.Name = "txtSSS";
            this.txtSSS.Size = new System.Drawing.Size(170, 23);
            this.txtSSS.TabIndex = 1;
            // 
            // lblSSS
            // 
            this.lblSSS.AutoSize = true;
            this.lblSSS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSSS.Location = new System.Drawing.Point(20, 33);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(71, 15);
            this.lblSSS.TabIndex = 0;
            this.lblSSS.Text = "SSS Cont.";
            // 
            // grpOtherDeductions
            // 
            this.grpOtherDeductions.Controls.Add(this.txtOtherLoans);
            this.grpOtherDeductions.Controls.Add(this.lblOtherLoans);
            this.grpOtherDeductions.Controls.Add(this.txtSalaryLoan);
            this.grpOtherDeductions.Controls.Add(this.lblSalaryLoan);
            this.grpOtherDeductions.Controls.Add(this.txtFacultySavingsLoan);
            this.grpOtherDeductions.Controls.Add(this.lblFacultySavingsLoan);
            this.grpOtherDeductions.Controls.Add(this.txtFacultySavingsDeposit);
            this.grpOtherDeductions.Controls.Add(this.lblFacultySavingsDeposit);
            this.grpOtherDeductions.Controls.Add(this.txtPagibigLoan);
            this.grpOtherDeductions.Controls.Add(this.lblPagibigLoan);
            this.grpOtherDeductions.Controls.Add(this.txtSSSLoan);
            this.grpOtherDeductions.Controls.Add(this.lblSSSLoan);
            this.grpOtherDeductions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpOtherDeductions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpOtherDeductions.Location = new System.Drawing.Point(410, 470);
            this.grpOtherDeductions.Name = "grpOtherDeductions";
            this.grpOtherDeductions.Size = new System.Drawing.Size(360, 240);
            this.grpOtherDeductions.TabIndex = 6;
            this.grpOtherDeductions.TabStop = false;
            this.grpOtherDeductions.Text = "Other Deductions";
            // 
            // txtOtherLoans
            // 
            this.txtOtherLoans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherLoans.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOtherLoans.Location = new System.Drawing.Point(165, 190);
            this.txtOtherLoans.Name = "txtOtherLoans";
            this.txtOtherLoans.Size = new System.Drawing.Size(170, 23);
            this.txtOtherLoans.TabIndex = 11;
            // 
            // lblOtherLoans
            // 
            this.lblOtherLoans.AutoSize = true;
            this.lblOtherLoans.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOtherLoans.Location = new System.Drawing.Point(20, 193);
            this.lblOtherLoans.Name = "lblOtherLoans";
            this.lblOtherLoans.Size = new System.Drawing.Size(72, 15);
            this.lblOtherLoans.TabIndex = 10;
            this.lblOtherLoans.Text = "Other Loans";
            // 
            // txtSalaryLoan
            // 
            this.txtSalaryLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalaryLoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalaryLoan.Location = new System.Drawing.Point(165, 158);
            this.txtSalaryLoan.Name = "txtSalaryLoan";
            this.txtSalaryLoan.Size = new System.Drawing.Size(170, 23);
            this.txtSalaryLoan.TabIndex = 9;
            // 
            // lblSalaryLoan
            // 
            this.lblSalaryLoan.AutoSize = true;
            this.lblSalaryLoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSalaryLoan.Location = new System.Drawing.Point(20, 161);
            this.lblSalaryLoan.Name = "lblSalaryLoan";
            this.lblSalaryLoan.Size = new System.Drawing.Size(68, 15);
            this.lblSalaryLoan.TabIndex = 8;
            this.lblSalaryLoan.Text = "Salary Loan";
            // 
            // txtFacultySavingsLoan
            // 
            this.txtFacultySavingsLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacultySavingsLoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFacultySavingsLoan.Location = new System.Drawing.Point(165, 126);
            this.txtFacultySavingsLoan.Name = "txtFacultySavingsLoan";
            this.txtFacultySavingsLoan.Size = new System.Drawing.Size(170, 23);
            this.txtFacultySavingsLoan.TabIndex = 7;
            // 
            // lblFacultySavingsLoan
            // 
            this.lblFacultySavingsLoan.AutoSize = true;
            this.lblFacultySavingsLoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFacultySavingsLoan.Location = new System.Drawing.Point(20, 129);
            this.lblFacultySavingsLoan.Name = "lblFacultySavingsLoan";
            this.lblFacultySavingsLoan.Size = new System.Drawing.Size(119, 15);
            this.lblFacultySavingsLoan.TabIndex = 6;
            this.lblFacultySavingsLoan.Text = "Faculty Savings Loan";
            // 
            // txtFacultySavingsDeposit
            // 
            this.txtFacultySavingsDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacultySavingsDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFacultySavingsDeposit.Location = new System.Drawing.Point(165, 94);
            this.txtFacultySavingsDeposit.Name = "txtFacultySavingsDeposit";
            this.txtFacultySavingsDeposit.Size = new System.Drawing.Size(170, 23);
            this.txtFacultySavingsDeposit.TabIndex = 5;
            // 
            // lblFacultySavingsDeposit
            // 
            this.lblFacultySavingsDeposit.AutoSize = true;
            this.lblFacultySavingsDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFacultySavingsDeposit.Location = new System.Drawing.Point(20, 97);
            this.lblFacultySavingsDeposit.Name = "lblFacultySavingsDeposit";
            this.lblFacultySavingsDeposit.Size = new System.Drawing.Size(134, 15);
            this.lblFacultySavingsDeposit.TabIndex = 4;
            this.lblFacultySavingsDeposit.Text = "Faculty Savings Deposit";
            // 
            // txtPagibigLoan
            // 
            this.txtPagibigLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagibigLoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPagibigLoan.Location = new System.Drawing.Point(165, 62);
            this.txtPagibigLoan.Name = "txtPagibigLoan";
            this.txtPagibigLoan.Size = new System.Drawing.Size(170, 23);
            this.txtPagibigLoan.TabIndex = 3;
            // 
            // lblPagibigLoan
            // 
            this.lblPagibigLoan.AutoSize = true;
            this.lblPagibigLoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPagibigLoan.Location = new System.Drawing.Point(20, 65);
            this.lblPagibigLoan.Name = "lblPagibigLoan";
            this.lblPagibigLoan.Size = new System.Drawing.Size(80, 15);
            this.lblPagibigLoan.TabIndex = 2;
            this.lblPagibigLoan.Text = "Pag-IBIG Loan";
            // 
            // txtSSSLoan
            // 
            this.txtSSSLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSSLoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSSSLoan.Location = new System.Drawing.Point(165, 30);
            this.txtSSSLoan.Name = "txtSSSLoan";
            this.txtSSSLoan.Size = new System.Drawing.Size(170, 23);
            this.txtSSSLoan.TabIndex = 1;
            // 
            // lblSSSLoan
            // 
            this.lblSSSLoan.AutoSize = true;
            this.lblSSSLoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSSSLoan.Location = new System.Drawing.Point(20, 33);
            this.lblSSSLoan.Name = "lblSSSLoan";
            this.lblSSSLoan.Size = new System.Drawing.Size(56, 15);
            this.lblSSSLoan.TabIndex = 0;
            this.lblSSSLoan.Text = "SSS Loan";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.txtNetIncome);
            this.grpSummary.Controls.Add(this.lblNetIncome);
            this.grpSummary.Controls.Add(this.txtTotalDeductions);
            this.grpSummary.Controls.Add(this.lblTotalDeductions);
            this.grpSummary.Controls.Add(this.txtGrossIncome);
            this.grpSummary.Controls.Add(this.lblGrossIncome);
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpSummary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpSummary.Location = new System.Drawing.Point(800, 245);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(360, 205);
            this.grpSummary.TabIndex = 7;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // txtNetIncome
            // 
            this.txtNetIncome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNetIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNetIncome.Location = new System.Drawing.Point(155, 130);
            this.txtNetIncome.Name = "txtNetIncome";
            this.txtNetIncome.ReadOnly = true;
            this.txtNetIncome.Size = new System.Drawing.Size(170, 23);
            this.txtNetIncome.TabIndex = 5;
            // 
            // lblNetIncome
            // 
            this.lblNetIncome.AutoSize = true;
            this.lblNetIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNetIncome.Location = new System.Drawing.Point(20, 133);
            this.lblNetIncome.Name = "lblNetIncome";
            this.lblNetIncome.Size = new System.Drawing.Size(69, 15);
            this.lblNetIncome.TabIndex = 4;
            this.lblNetIncome.Text = "Net Income";
            // 
            // txtTotalDeductions
            // 
            this.txtTotalDeductions.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTotalDeductions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDeductions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalDeductions.Location = new System.Drawing.Point(155, 80);
            this.txtTotalDeductions.Name = "txtTotalDeductions";
            this.txtTotalDeductions.ReadOnly = true;
            this.txtTotalDeductions.Size = new System.Drawing.Size(170, 23);
            this.txtTotalDeductions.TabIndex = 3;
            // 
            // lblTotalDeductions
            // 
            this.lblTotalDeductions.AutoSize = true;
            this.lblTotalDeductions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalDeductions.Location = new System.Drawing.Point(20, 83);
            this.lblTotalDeductions.Name = "lblTotalDeductions";
            this.lblTotalDeductions.Size = new System.Drawing.Size(99, 15);
            this.lblTotalDeductions.TabIndex = 2;
            this.lblTotalDeductions.Text = "Total Deductions";
            // 
            // txtGrossIncome
            // 
            this.txtGrossIncome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGrossIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrossIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGrossIncome.Location = new System.Drawing.Point(155, 30);
            this.txtGrossIncome.Name = "txtGrossIncome";
            this.txtGrossIncome.ReadOnly = true;
            this.txtGrossIncome.Size = new System.Drawing.Size(170, 23);
            this.txtGrossIncome.TabIndex = 1;
            // 
            // lblGrossIncome
            // 
            this.lblGrossIncome.AutoSize = true;
            this.lblGrossIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGrossIncome.Location = new System.Drawing.Point(20, 33);
            this.lblGrossIncome.Name = "lblGrossIncome";
            this.lblGrossIncome.Size = new System.Drawing.Size(78, 15);
            this.lblGrossIncome.TabIndex = 0;
            this.lblGrossIncome.Text = "Gross Income";
            // 
            // btnGrossIncome
            // 
            this.btnGrossIncome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGrossIncome.FlatAppearance.BorderSize = 0;
            this.btnGrossIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrossIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGrossIncome.ForeColor = System.Drawing.Color.White;
            this.btnGrossIncome.Location = new System.Drawing.Point(800, 490);
            this.btnGrossIncome.Name = "btnGrossIncome";
            this.btnGrossIncome.Size = new System.Drawing.Size(160, 40);
            this.btnGrossIncome.TabIndex = 8;
            this.btnGrossIncome.Text = "GROSS INCOME";
            this.btnGrossIncome.UseVisualStyleBackColor = false;
            this.btnGrossIncome.Click += new System.EventHandler(this.btnGrossIncome_Click);
            // 
            // btnNetIncome
            // 
            this.btnNetIncome.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNetIncome.FlatAppearance.BorderSize = 0;
            this.btnNetIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNetIncome.ForeColor = System.Drawing.Color.White;
            this.btnNetIncome.Location = new System.Drawing.Point(1000, 490);
            this.btnNetIncome.Name = "btnNetIncome";
            this.btnNetIncome.Size = new System.Drawing.Size(160, 40);
            this.btnNetIncome.TabIndex = 9;
            this.btnNetIncome.Text = "NET INCOME";
            this.btnNetIncome.UseVisualStyleBackColor = false;
            this.btnNetIncome.Click += new System.EventHandler(this.btnNetIncome_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(800, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1000, 550);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.IndianRed;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(900, 610);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(160, 40);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNetIncome);
            this.Controls.Add(this.btnGrossIncome);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpOtherDeductions);
            this.Controls.Add(this.grpRegularDeductions);
            this.Controls.Add(this.grpOtherIncome);
            this.Controls.Add(this.grpHonorariumIncome);
            this.Controls.Add(this.grpBasicIncome);
            this.Controls.Add(this.grpEmployeeInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System";
            this.grpEmployeeInfo.ResumeLayout(false);
            this.grpEmployeeInfo.PerformLayout();
            this.grpBasicIncome.ResumeLayout(false);
            this.grpBasicIncome.PerformLayout();
            this.grpHonorariumIncome.ResumeLayout(false);
            this.grpHonorariumIncome.PerformLayout();
            this.grpOtherIncome.ResumeLayout(false);
            this.grpOtherIncome.PerformLayout();
            this.grpRegularDeductions.ResumeLayout(false);
            this.grpRegularDeductions.PerformLayout();
            this.grpOtherDeductions.ResumeLayout(false);
            this.grpOtherDeductions.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtEmployeeStatus;
        private System.Windows.Forms.Label lblEmployeeStatus;
        private System.Windows.Forms.TextBox txtPaydate;
        private System.Windows.Forms.Label lblPaydate;
        private System.Windows.Forms.TextBox txtQualifiedDependents;
        private System.Windows.Forms.Label lblQualifiedDependents;
        private System.Windows.Forms.TextBox txtCivilStatus;
        private System.Windows.Forms.Label lblCivilStatus;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtEmployeeNo;
        private System.Windows.Forms.Label lblEmployeeNo;

        private System.Windows.Forms.GroupBox grpBasicIncome;
        private System.Windows.Forms.TextBox txtBasicIncome;
        private System.Windows.Forms.Label lblBasicIncome;
        private System.Windows.Forms.TextBox txtBasicHours;
        private System.Windows.Forms.Label lblBasicHours;
        private System.Windows.Forms.TextBox txtBasicRate;
        private System.Windows.Forms.Label lblBasicRate;

        private System.Windows.Forms.GroupBox grpHonorariumIncome;
        private System.Windows.Forms.TextBox txtHonorIncome;
        private System.Windows.Forms.Label lblHonorIncome;
        private System.Windows.Forms.TextBox txtHonorHours;
        private System.Windows.Forms.Label lblHonorHours;
        private System.Windows.Forms.TextBox txtHonorRate;
        private System.Windows.Forms.Label lblHonorRate;

        private System.Windows.Forms.GroupBox grpOtherIncome;
        private System.Windows.Forms.TextBox txtOtherIncome;
        private System.Windows.Forms.Label lblOtherIncome;
        private System.Windows.Forms.TextBox txtOtherHours;
        private System.Windows.Forms.Label lblOtherHours;
        private System.Windows.Forms.TextBox txtOtherRate;
        private System.Windows.Forms.Label lblOtherRate;

        private System.Windows.Forms.GroupBox grpRegularDeductions;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtPagibig;
        private System.Windows.Forms.Label lblPagibig;
        private System.Windows.Forms.TextBox txtPhilHealth;
        private System.Windows.Forms.Label lblPhilHealth;
        private System.Windows.Forms.TextBox txtSSS;
        private System.Windows.Forms.Label lblSSS;

        private System.Windows.Forms.GroupBox grpOtherDeductions;
        private System.Windows.Forms.TextBox txtOtherLoans;
        private System.Windows.Forms.Label lblOtherLoans;
        private System.Windows.Forms.TextBox txtSalaryLoan;
        private System.Windows.Forms.Label lblSalaryLoan;
        private System.Windows.Forms.TextBox txtFacultySavingsLoan;
        private System.Windows.Forms.Label lblFacultySavingsLoan;
        private System.Windows.Forms.TextBox txtFacultySavingsDeposit;
        private System.Windows.Forms.Label lblFacultySavingsDeposit;
        private System.Windows.Forms.TextBox txtPagibigLoan;
        private System.Windows.Forms.Label lblPagibigLoan;
        private System.Windows.Forms.TextBox txtSSSLoan;
        private System.Windows.Forms.Label lblSSSLoan;

        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.TextBox txtNetIncome;
        private System.Windows.Forms.Label lblNetIncome;
        private System.Windows.Forms.TextBox txtTotalDeductions;
        private System.Windows.Forms.Label lblTotalDeductions;
        private System.Windows.Forms.TextBox txtGrossIncome;
        private System.Windows.Forms.Label lblGrossIncome;

        private System.Windows.Forms.Button btnGrossIncome;
        private System.Windows.Forms.Button btnNetIncome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
    }
}