
namespace AccountsApp
{
    partial class fAccounts
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAccount = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lbInterest = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.lbWithdraw = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.grbAccountType = new System.Windows.Forms.GroupBox();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.rbChecking = new System.Windows.Forms.RadioButton();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.grbAccount.SuspendLayout();
            this.grbAccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAccount
            // 
            this.grbAccount.Controls.Add(this.btnSearch);
            this.grbAccount.Controls.Add(this.txtInterest);
            this.grbAccount.Controls.Add(this.lbInterest);
            this.grbAccount.Controls.Add(this.txtWithdraw);
            this.grbAccount.Controls.Add(this.lbWithdraw);
            this.grbAccount.Controls.Add(this.txtBalance);
            this.grbAccount.Controls.Add(this.lbBalance);
            this.grbAccount.Controls.Add(this.txtName);
            this.grbAccount.Controls.Add(this.lbName);
            this.grbAccount.Controls.Add(this.txtNumber);
            this.grbAccount.Controls.Add(this.lbAccountNumber);
            this.grbAccount.Controls.Add(this.grbAccountType);
            this.grbAccount.Location = new System.Drawing.Point(12, 12);
            this.grbAccount.Name = "grbAccount";
            this.grbAccount.Size = new System.Drawing.Size(773, 333);
            this.grbAccount.TabIndex = 0;
            this.grbAccount.TabStop = false;
            this.grbAccount.Text = "Account Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(346, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(164, 272);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 21);
            this.txtInterest.TabIndex = 10;
            // 
            // lbInterest
            // 
            this.lbInterest.AutoSize = true;
            this.lbInterest.Location = new System.Drawing.Point(60, 275);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(79, 12);
            this.lbInterest.TabIndex = 9;
            this.lbInterest.Text = "Interest Rate:";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(164, 215);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(100, 21);
            this.txtWithdraw.TabIndex = 8;
            // 
            // lbWithdraw
            // 
            this.lbWithdraw.AutoSize = true;
            this.lbWithdraw.Location = new System.Drawing.Point(16, 218);
            this.lbWithdraw.Name = "lbWithdraw";
            this.lbWithdraw.Size = new System.Drawing.Size(123, 12);
            this.lbWithdraw.TabIndex = 7;
            this.lbWithdraw.Text = "Daily Withdraw Limit:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(164, 165);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 21);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(84, 168);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(55, 12);
            this.lbBalance.TabIndex = 5;
            this.lbBalance.Text = "Balance:";
            this.lbBalance.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 21);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(60, 111);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 12);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Client Name:";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(164, 54);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 2;
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Location = new System.Drawing.Point(39, 57);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(104, 12);
            this.lbAccountNumber.TabIndex = 1;
            this.lbAccountNumber.Text = "Account Number:";
            // 
            // grbAccountType
            // 
            this.grbAccountType.Controls.Add(this.rbVisa);
            this.grbAccountType.Controls.Add(this.rbChecking);
            this.grbAccountType.Location = new System.Drawing.Point(594, 20);
            this.grbAccountType.Name = "grbAccountType";
            this.grbAccountType.Size = new System.Drawing.Size(163, 148);
            this.grbAccountType.TabIndex = 0;
            this.grbAccountType.TabStop = false;
            this.grbAccountType.Text = "Type of Account";
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.Location = new System.Drawing.Point(48, 96);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(48, 16);
            this.rbVisa.TabIndex = 1;
            this.rbVisa.Text = "Visa";
            this.rbVisa.UseVisualStyleBackColor = true;
            // 
            // rbChecking
            // 
            this.rbChecking.AutoSize = true;
            this.rbChecking.Checked = true;
            this.rbChecking.Location = new System.Drawing.Point(48, 50);
            this.rbChecking.Name = "rbChecking";
            this.rbChecking.Size = new System.Drawing.Size(76, 16);
            this.rbChecking.TabIndex = 0;
            this.rbChecking.TabStop = true;
            this.rbChecking.Text = "Checking";
            this.rbChecking.UseVisualStyleBackColor = true;
            this.rbChecking.CheckedChanged += new System.EventHandler(this.rbChecking_CheckedChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(645, 359);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(138, 48);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // fAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 419);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grbAccount);
            this.Name = "fAccounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.fAccounts_Load);
            this.grbAccount.ResumeLayout(false);
            this.grbAccount.PerformLayout();
            this.grbAccountType.ResumeLayout(false);
            this.grbAccountType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAccount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.GroupBox grbAccountType;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lbInterest;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Label lbWithdraw;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.RadioButton rbChecking;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnSearch;
    }
}

