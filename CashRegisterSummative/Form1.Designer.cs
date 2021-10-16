
namespace CashRegisterSummative
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calcTotalButton = new System.Windows.Forms.Button();
            this.recieptProgressBar = new System.Windows.Forms.ProgressBar();
            this.numOfClocksInput = new System.Windows.Forms.TextBox();
            this.numOfPensInput = new System.Windows.Forms.TextBox();
            this.numOfNotesInput = new System.Windows.Forms.TextBox();
            this.clockLabel = new System.Windows.Forms.Label();
            this.pensLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.waitingLabel = new System.Windows.Forms.Label();
            this.subTotalText = new System.Windows.Forms.Label();
            this.taxText = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeText = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.subtotalTitleLabel = new System.Windows.Forms.Label();
            this.taxTitleLabel = new System.Windows.Forms.Label();
            this.totalTitleText = new System.Windows.Forms.Label();
            this.changeTextLabel = new System.Windows.Forms.Label();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcTotalButton
            // 
            this.calcTotalButton.Location = new System.Drawing.Point(104, 126);
            this.calcTotalButton.Name = "calcTotalButton";
            this.calcTotalButton.Size = new System.Drawing.Size(100, 40);
            this.calcTotalButton.TabIndex = 0;
            this.calcTotalButton.Text = "Calculate Total";
            this.calcTotalButton.UseVisualStyleBackColor = true;
            this.calcTotalButton.Click += new System.EventHandler(this.calcTotalButton_Click);
            // 
            // recieptProgressBar
            // 
            this.recieptProgressBar.ForeColor = System.Drawing.Color.SpringGreen;
            this.recieptProgressBar.Location = new System.Drawing.Point(535, 357);
            this.recieptProgressBar.Name = "recieptProgressBar";
            this.recieptProgressBar.Size = new System.Drawing.Size(228, 27);
            this.recieptProgressBar.TabIndex = 1;
            // 
            // numOfClocksInput
            // 
            this.numOfClocksInput.Location = new System.Drawing.Point(104, 43);
            this.numOfClocksInput.Name = "numOfClocksInput";
            this.numOfClocksInput.Size = new System.Drawing.Size(100, 22);
            this.numOfClocksInput.TabIndex = 2;
            // 
            // numOfPensInput
            // 
            this.numOfPensInput.Location = new System.Drawing.Point(104, 70);
            this.numOfPensInput.Name = "numOfPensInput";
            this.numOfPensInput.Size = new System.Drawing.Size(100, 22);
            this.numOfPensInput.TabIndex = 3;
            // 
            // numOfNotesInput
            // 
            this.numOfNotesInput.Location = new System.Drawing.Point(104, 98);
            this.numOfNotesInput.Name = "numOfNotesInput";
            this.numOfNotesInput.Size = new System.Drawing.Size(100, 22);
            this.numOfNotesInput.TabIndex = 4;
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Location = new System.Drawing.Point(9, 46);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(72, 16);
            this.clockLabel.TabIndex = 5;
            this.clockLabel.Text = "# of Clocks";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pensLabel
            // 
            this.pensLabel.AutoSize = true;
            this.pensLabel.Location = new System.Drawing.Point(9, 72);
            this.pensLabel.Name = "pensLabel";
            this.pensLabel.Size = new System.Drawing.Size(62, 16);
            this.pensLabel.TabIndex = 6;
            this.pensLabel.Text = "# of Pens";
            this.pensLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(9, 101);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(67, 16);
            this.notesLabel.TabIndex = 7;
            this.notesLabel.Text = "# of Notes";
            this.notesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Enabled = false;
            this.printReceiptButton.Location = new System.Drawing.Point(402, 32);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(100, 40);
            this.printReceiptButton.TabIndex = 8;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.Location = new System.Drawing.Point(83, -3);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(163, 43);
            this.orderLabel.TabIndex = 9;
            this.orderLabel.Text = "Order Here!";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(532, 24);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(231, 311);
            this.receiptLabel.TabIndex = 10;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waitingLabel
            // 
            this.waitingLabel.BackColor = System.Drawing.Color.Transparent;
            this.waitingLabel.Location = new System.Drawing.Point(393, 75);
            this.waitingLabel.Name = "waitingLabel";
            this.waitingLabel.Size = new System.Drawing.Size(133, 19);
            this.waitingLabel.TabIndex = 11;
            this.waitingLabel.Text = "Waiting For Order...";
            this.waitingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subTotalText
            // 
            this.subTotalText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subTotalText.Location = new System.Drawing.Point(83, 195);
            this.subTotalText.Name = "subTotalText";
            this.subTotalText.Size = new System.Drawing.Size(116, 23);
            this.subTotalText.TabIndex = 12;
            this.subTotalText.Text = "$0.00";
            this.subTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxText
            // 
            this.taxText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taxText.Location = new System.Drawing.Point(83, 227);
            this.taxText.Name = "taxText";
            this.taxText.Size = new System.Drawing.Size(116, 23);
            this.taxText.TabIndex = 13;
            this.taxText.Text = "$0.00";
            this.taxText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalText
            // 
            this.totalText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalText.Location = new System.Drawing.Point(83, 265);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(116, 23);
            this.totalText.TabIndex = 14;
            this.totalText.Text = "$0.00";
            this.totalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(6, 301);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(70, 16);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered:";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Enabled = false;
            this.tenderedInput.Location = new System.Drawing.Point(104, 298);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 22);
            this.tenderedInput.TabIndex = 16;
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(104, 330);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(100, 52);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change:";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeText
            // 
            this.changeText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeText.Location = new System.Drawing.Point(67, 381);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(137, 71);
            this.changeText.TabIndex = 18;
            this.changeText.Text = "$0.00";
            this.changeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Enabled = false;
            this.newOrderButton.Location = new System.Drawing.Point(599, 396);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(100, 40);
            this.newOrderButton.TabIndex = 19;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // subtotalTitleLabel
            // 
            this.subtotalTitleLabel.AutoSize = true;
            this.subtotalTitleLabel.Location = new System.Drawing.Point(9, 198);
            this.subtotalTitleLabel.Name = "subtotalTitleLabel";
            this.subtotalTitleLabel.Size = new System.Drawing.Size(68, 16);
            this.subtotalTitleLabel.TabIndex = 20;
            this.subtotalTitleLabel.Text = "Sub Total:";
            this.subtotalTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxTitleLabel
            // 
            this.taxTitleLabel.AutoSize = true;
            this.taxTitleLabel.Location = new System.Drawing.Point(9, 234);
            this.taxTitleLabel.Name = "taxTitleLabel";
            this.taxTitleLabel.Size = new System.Drawing.Size(33, 16);
            this.taxTitleLabel.TabIndex = 21;
            this.taxTitleLabel.Text = "Tax:";
            this.taxTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalTitleText
            // 
            this.totalTitleText.AutoSize = true;
            this.totalTitleText.Location = new System.Drawing.Point(9, 268);
            this.totalTitleText.Name = "totalTitleText";
            this.totalTitleText.Size = new System.Drawing.Size(41, 16);
            this.totalTitleText.TabIndex = 22;
            this.totalTitleText.Text = "Total:";
            this.totalTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeTextLabel
            // 
            this.changeTextLabel.AutoSize = true;
            this.changeTextLabel.Location = new System.Drawing.Point(12, 408);
            this.changeTextLabel.Name = "changeTextLabel";
            this.changeTextLabel.Size = new System.Drawing.Size(57, 16);
            this.changeTextLabel.TabIndex = 23;
            this.changeTextLabel.Text = "Change:";
            this.changeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bottomLabel
            // 
            this.bottomLabel.BackColor = System.Drawing.Color.DimGray;
            this.bottomLabel.Location = new System.Drawing.Point(-6, 480);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(802, 98);
            this.bottomLabel.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(787, 576);
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.changeTextLabel);
            this.Controls.Add(this.totalTitleText);
            this.Controls.Add(this.taxTitleLabel);
            this.Controls.Add(this.subtotalTitleLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.changeText);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.taxText);
            this.Controls.Add(this.subTotalText);
            this.Controls.Add(this.waitingLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.pensLabel);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.numOfNotesInput);
            this.Controls.Add(this.numOfPensInput);
            this.Controls.Add(this.numOfClocksInput);
            this.Controls.Add(this.recieptProgressBar);
            this.Controls.Add(this.calcTotalButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Store(TM) Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcTotalButton;
        private System.Windows.Forms.ProgressBar recieptProgressBar;
        private System.Windows.Forms.TextBox numOfClocksInput;
        private System.Windows.Forms.TextBox numOfPensInput;
        private System.Windows.Forms.TextBox numOfNotesInput;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Label pensLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label waitingLabel;
        private System.Windows.Forms.Label subTotalText;
        private System.Windows.Forms.Label taxText;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeText;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label subtotalTitleLabel;
        private System.Windows.Forms.Label taxTitleLabel;
        private System.Windows.Forms.Label totalTitleText;
        private System.Windows.Forms.Label changeTextLabel;
        private System.Windows.Forms.Label bottomLabel;
    }
}

