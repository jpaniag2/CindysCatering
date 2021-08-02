
namespace Catering
{
    partial class cindysCatering
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
            this.customerName = new System.Windows.Forms.Label();
            this.customerPhoneNumber = new System.Windows.Forms.Label();
            this.numOfGuests = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.guestsTextBox = new System.Windows.Forms.TextBox();
            this.entreeComboBox = new System.Windows.Forms.ComboBox();
            this.entree = new System.Windows.Forms.Label();
            this.sides = new System.Windows.Forms.Label();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.desserts = new System.Windows.Forms.Label();
            this.submitEvent = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(46, 22);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(82, 13);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "Customer Name";
            this.customerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.AutoSize = true;
            this.customerPhoneNumber.Location = new System.Drawing.Point(50, 62);
            this.customerPhoneNumber.Name = "customerPhoneNumber";
            this.customerPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.customerPhoneNumber.TabIndex = 1;
            this.customerPhoneNumber.Text = "Phone Number";
            // 
            // numOfGuests
            // 
            this.numOfGuests.AutoSize = true;
            this.numOfGuests.Location = new System.Drawing.Point(50, 104);
            this.numOfGuests.Name = "numOfGuests";
            this.numOfGuests.Size = new System.Drawing.Size(94, 13);
            this.numOfGuests.TabIndex = 2;
            this.numOfGuests.Text = "Number Of Guests";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(183, 22);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(183, 62);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 4;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTextBox_KeyPress);
            // 
            // guestsTextBox
            // 
            this.guestsTextBox.Location = new System.Drawing.Point(183, 104);
            this.guestsTextBox.Name = "guestsTextBox";
            this.guestsTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestsTextBox.TabIndex = 5;
            this.guestsTextBox.TextChanged += new System.EventHandler(this.guestsTextBox_TextChanged);
            this.guestsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guestsTextBox_KeyPress);
            // 
            // entreeComboBox
            // 
            this.entreeComboBox.FormattingEnabled = true;
            this.entreeComboBox.Items.AddRange(new object[] {
            "Chicken Alfredo",
            "Honey Garlic Salmon",
            "Filet Mignon",
            "Chicken Tikka Massala",
            "Carne Asada Harachera"});
            this.entreeComboBox.Location = new System.Drawing.Point(183, 157);
            this.entreeComboBox.Name = "entreeComboBox";
            this.entreeComboBox.Size = new System.Drawing.Size(121, 21);
            this.entreeComboBox.TabIndex = 6;
            this.entreeComboBox.Text = "Choose One";
            // 
            // entree
            // 
            this.entree.AutoSize = true;
            this.entree.Location = new System.Drawing.Point(50, 165);
            this.entree.Name = "entree";
            this.entree.Size = new System.Drawing.Size(45, 13);
            this.entree.TabIndex = 7;
            this.entree.Text = "Entree\'s";
            // 
            // sides
            // 
            this.sides.AutoSize = true;
            this.sides.Location = new System.Drawing.Point(50, 211);
            this.sides.Name = "sides";
            this.sides.Size = new System.Drawing.Size(118, 13);
            this.sides.TabIndex = 9;
            this.sides.Text = "Sides (**MAX 2 Items**)";
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Fried Ice Cream",
            "Caramel Hazelnut CheeseCake",
            "Tiramisu"});
            this.dessertComboBox.Location = new System.Drawing.Point(183, 324);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(121, 21);
            this.dessertComboBox.TabIndex = 10;
            this.dessertComboBox.Text = "Choose One";
            // 
            // desserts
            // 
            this.desserts.AutoSize = true;
            this.desserts.Location = new System.Drawing.Point(52, 332);
            this.desserts.Name = "desserts";
            this.desserts.Size = new System.Drawing.Size(43, 13);
            this.desserts.TabIndex = 11;
            this.desserts.Text = "Dessert";
            // 
            // submitEvent
            // 
            this.submitEvent.Location = new System.Drawing.Point(183, 380);
            this.submitEvent.Name = "submitEvent";
            this.submitEvent.Size = new System.Drawing.Size(154, 58);
            this.submitEvent.TabIndex = 13;
            this.submitEvent.Text = "Submit";
            this.submitEvent.UseVisualStyleBackColor = true;
            this.submitEvent.Click += new System.EventHandler(this.submitEvent_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Rice",
            "Chips & Salsa",
            "Potatoes",
            "Salad"});
            this.checkedListBox1.Location = new System.Drawing.Point(216, 211);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 14;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(360, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(299, 310);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.submitEvent);
            this.Controls.Add(this.desserts);
            this.Controls.Add(this.dessertComboBox);
            this.Controls.Add(this.sides);
            this.Controls.Add(this.entree);
            this.Controls.Add(this.entreeComboBox);
            this.Controls.Add(this.guestsTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.numOfGuests);
            this.Controls.Add(this.customerPhoneNumber);
            this.Controls.Add(this.customerName);
            this.Name = "Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cindy\'s Catering";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label customerPhoneNumber;
        private System.Windows.Forms.Label numOfGuests;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox guestsTextBox;
        private System.Windows.Forms.ComboBox entreeComboBox;
        private System.Windows.Forms.Label entree;
        private System.Windows.Forms.Label sides;
        private System.Windows.Forms.ComboBox dessertComboBox;
        private System.Windows.Forms.Label desserts;
        private System.Windows.Forms.Button submitEvent;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

