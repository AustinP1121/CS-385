namespace Problem10Chapter10
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.welcomepage = new System.Windows.Forms.TabPage();
            this.Continue1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.TabPage();
            this.totalLabel = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.checkoutbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderTotal = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.otherfood = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Drinks = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PizzaSauce = new System.Windows.Forms.CheckedListBox();
            this.PizzaToppings = new System.Windows.Forms.CheckedListBox();
            this.PizzaSize = new System.Windows.Forms.CheckedListBox();
            this.Checkout = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OrderFinalTotal = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.orderConfirm = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.welcomepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.Checkout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.welcomepage);
            this.tabControl1.Controls.Add(this.menu);
            this.tabControl1.Controls.Add(this.Checkout);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // welcomepage
            // 
            this.welcomepage.BackColor = System.Drawing.Color.MistyRose;
            this.welcomepage.Controls.Add(this.Continue1);
            this.welcomepage.Controls.Add(this.label1);
            this.welcomepage.Controls.Add(this.pictureBox1);
            this.welcomepage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.welcomepage.Location = new System.Drawing.Point(4, 22);
            this.welcomepage.Name = "welcomepage";
            this.welcomepage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomepage.Size = new System.Drawing.Size(621, 394);
            this.welcomepage.TabIndex = 1;
            this.welcomepage.Text = "Welcome";
            // 
            // Continue1
            // 
            this.Continue1.BackColor = System.Drawing.Color.LightYellow;
            this.Continue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Continue1.Location = new System.Drawing.Point(265, 301);
            this.Continue1.Name = "Continue1";
            this.Continue1.Size = new System.Drawing.Size(107, 53);
            this.Continue1.TabIndex = 3;
            this.Continue1.Text = "Order Now";
            this.Continue1.UseVisualStyleBackColor = false;
            this.Continue1.Click += new System.EventHandler(this.Continue1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(97, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thank you for choosing Big Papa\'s Pizzeria!\r\n\r\nPlease press the \'Order Now\' butto" +
    "n below \r\nto choose from our selection of Italian dishes!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.MistyRose;
            this.menu.Controls.Add(this.totalLabel);
            this.menu.Controls.Add(this.reset);
            this.menu.Controls.Add(this.checkoutbutton);
            this.menu.Controls.Add(this.label8);
            this.menu.Controls.Add(this.OrderTotal);
            this.menu.Controls.Add(this.label7);
            this.menu.Controls.Add(this.otherfood);
            this.menu.Controls.Add(this.label6);
            this.menu.Controls.Add(this.Drinks);
            this.menu.Controls.Add(this.label5);
            this.menu.Controls.Add(this.label4);
            this.menu.Controls.Add(this.label3);
            this.menu.Controls.Add(this.PizzaSauce);
            this.menu.Controls.Add(this.PizzaToppings);
            this.menu.Controls.Add(this.PizzaSize);
            this.menu.Location = new System.Drawing.Point(4, 22);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(3);
            this.menu.Size = new System.Drawing.Size(621, 394);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalLabel.Location = new System.Drawing.Point(362, 298);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 20);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total: ";
            // 
            // reset
            // 
            this.reset.Cursor = System.Windows.Forms.Cursors.Default;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.Red;
            this.reset.Location = new System.Drawing.Point(459, 338);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(89, 49);
            this.reset.TabIndex = 14;
            this.reset.Text = "New Order";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbutton.ForeColor = System.Drawing.Color.Lime;
            this.checkoutbutton.Location = new System.Drawing.Point(346, 338);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(89, 49);
            this.checkoutbutton.TabIndex = 13;
            this.checkoutbutton.Text = "Checkout";
            this.checkoutbutton.UseVisualStyleBackColor = true;
            this.checkoutbutton.Click += new System.EventHandler(this.checkoutbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(37, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 180);
            this.label8.TabIndex = 12;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // OrderTotal
            // 
            this.OrderTotal.BackColor = System.Drawing.SystemColors.Info;
            this.OrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTotal.FormattingEnabled = true;
            this.OrderTotal.ItemHeight = 15;
            this.OrderTotal.Location = new System.Drawing.Point(332, 133);
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.Size = new System.Drawing.Size(239, 199);
            this.OrderTotal.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(484, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "More Dishes";
            // 
            // otherfood
            // 
            this.otherfood.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.otherfood.FormattingEnabled = true;
            this.otherfood.Items.AddRange(new object[] {
            "Spaghetti",
            "Meatballs",
            "Bread Sticks",
            "Salad"});
            this.otherfood.Location = new System.Drawing.Point(478, 31);
            this.otherfood.Name = "otherfood";
            this.otherfood.Size = new System.Drawing.Size(120, 64);
            this.otherfood.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(364, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Drinks";
            // 
            // Drinks
            // 
            this.Drinks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Drinks.FormattingEnabled = true;
            this.Drinks.Items.AddRange(new object[] {
            "Soft Drink",
            "Sweet Tea",
            "Unsweetened Tea",
            "Juice"});
            this.Drinks.Location = new System.Drawing.Point(332, 31);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(120, 64);
            this.Drinks.TabIndex = 7;
            this.Drinks.SelectedIndexChanged += new System.EventHandler(this.AddOrRemoveItemDrinks);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(169, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pizza Toppings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(37, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pizza Sauce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(37, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pizza Size";
            // 
            // PizzaSauce
            // 
            this.PizzaSauce.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PizzaSauce.FormattingEnabled = true;
            this.PizzaSauce.Items.AddRange(new object[] {
            "Pesto",
            "Alfredo",
            "Marinara ",
            "Classic ",
            "Chunky"});
            this.PizzaSauce.Location = new System.Drawing.Point(28, 136);
            this.PizzaSauce.Name = "PizzaSauce";
            this.PizzaSauce.Size = new System.Drawing.Size(120, 49);
            this.PizzaSauce.TabIndex = 2;
            // 
            // PizzaToppings
            // 
            this.PizzaToppings.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PizzaToppings.FormattingEnabled = true;
            this.PizzaToppings.Items.AddRange(new object[] {
            "Anchovies ",
            "Black Olives",
            "Green Olives",
            "Bell Peppers",
            "Jalepenos ",
            "Parmasean ",
            "Banana Peppers",
            "Chicken ",
            "Beef",
            "Sausage ",
            "Mushrooms",
            "Buffalo Chicken"});
            this.PizzaToppings.Location = new System.Drawing.Point(172, 31);
            this.PizzaToppings.Name = "PizzaToppings";
            this.PizzaToppings.Size = new System.Drawing.Size(120, 154);
            this.PizzaToppings.TabIndex = 1;
            // 
            // PizzaSize
            // 
            this.PizzaSize.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PizzaSize.FormattingEnabled = true;
            this.PizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.PizzaSize.Location = new System.Drawing.Point(28, 31);
            this.PizzaSize.Name = "PizzaSize";
            this.PizzaSize.Size = new System.Drawing.Size(120, 49);
            this.PizzaSize.TabIndex = 0;
            this.PizzaSize.SelectedValueChanged += new System.EventHandler(this.AddOrRemoveItemPizza);
            // 
            // Checkout
            // 
            this.Checkout.BackColor = System.Drawing.Color.MistyRose;
            this.Checkout.Controls.Add(this.splitContainer1);
            this.Checkout.ForeColor = System.Drawing.Color.MistyRose;
            this.Checkout.Location = new System.Drawing.Point(4, 22);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(621, 394);
            this.Checkout.TabIndex = 2;
            this.Checkout.Text = "Checkout";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OrderFinalTotal);
            this.splitContainer1.Panel1.Controls.Add(this.Total);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Salmon;
            this.splitContainer1.Panel2.Controls.Add(this.back);
            this.splitContainer1.Panel2.Controls.Add(this.orderConfirm);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.Email);
            this.splitContainer1.Panel2.Controls.Add(this.Phone);
            this.splitContainer1.Panel2.Controls.Add(this.Address);
            this.splitContainer1.Panel2.Controls.Add(this.customerName);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Salmon;
            this.splitContainer1.Size = new System.Drawing.Size(621, 394);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 0;
            // 
            // OrderFinalTotal
            // 
            this.OrderFinalTotal.AutoSize = true;
            this.OrderFinalTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderFinalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFinalTotal.ForeColor = System.Drawing.Color.Black;
            this.OrderFinalTotal.Location = new System.Drawing.Point(59, 325);
            this.OrderFinalTotal.Name = "OrderFinalTotal";
            this.OrderFinalTotal.Size = new System.Drawing.Size(59, 20);
            this.OrderFinalTotal.TabIndex = 17;
            this.OrderFinalTotal.Text = "Total: ";
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.Info;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.FormattingEnabled = true;
            this.Total.ItemHeight = 15;
            this.Total.Location = new System.Drawing.Point(28, 17);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(297, 349);
            this.Total.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "label14";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkOrange;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(159, 286);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 46);
            this.back.TabIndex = 10;
            this.back.Text = "Back to Menu";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // orderConfirm
            // 
            this.orderConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.orderConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderConfirm.ForeColor = System.Drawing.Color.Black;
            this.orderConfirm.Location = new System.Drawing.Point(35, 286);
            this.orderConfirm.Name = "orderConfirm";
            this.orderConfirm.Size = new System.Drawing.Size(75, 46);
            this.orderConfirm.TabIndex = 9;
            this.orderConfirm.Text = "Confirm Order";
            this.orderConfirm.UseVisualStyleBackColor = false;
            this.orderConfirm.Click += new System.EventHandler(this.orderConfirm_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(94, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Email Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(94, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Phone Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(112, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(112, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Name";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(35, 177);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(199, 20);
            this.Email.TabIndex = 4;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(35, 140);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(199, 20);
            this.Phone.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(35, 105);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(199, 20);
            this.Address.TabIndex = 2;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(35, 68);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(199, 20);
            this.customerName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Delivery Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(276, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Big Papa\'s Pizzeria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(653, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "Form1";
            this.Text = "Big Papa\'s Pizzeria";
            this.tabControl1.ResumeLayout(false);
            this.welcomepage.ResumeLayout(false);
            this.welcomepage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.Checkout.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage menu;
        private System.Windows.Forms.TabPage welcomepage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Checkout;
        private System.Windows.Forms.Button Continue1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox PizzaSauce;
        private System.Windows.Forms.CheckedListBox PizzaToppings;
        private System.Windows.Forms.CheckedListBox PizzaSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox OrderTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox otherfood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox Drinks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkoutbutton;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label OrderFinalTotal;
        private System.Windows.Forms.ListBox Total;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button orderConfirm;
    }
}

