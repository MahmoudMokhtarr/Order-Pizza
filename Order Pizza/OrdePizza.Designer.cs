namespace WindowsFormsApp2
{
    partial class OrdePizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbSmal = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.gbYourPlugins = new System.Windows.Forms.GroupBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkPepper = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkChickens = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMozzarellacheese = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCrustType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbYourPlugins = new System.Windows.Forms.TextBox();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.tbWhereToEat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnOrderPiza = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbYourPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Always Find Demo", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(963, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza Now ";
            // 
            // rbSmal
            // 
            this.rbSmal.AutoSize = true;
            this.rbSmal.Font = new System.Drawing.Font("Lollypop", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmal.Location = new System.Drawing.Point(34, 42);
            this.rbSmal.Name = "rbSmal";
            this.rbSmal.Size = new System.Drawing.Size(85, 38);
            this.rbSmal.TabIndex = 1;
            this.rbSmal.Tag = "20";
            this.rbSmal.Text = "Smal";
            this.rbSmal.UseVisualStyleBackColor = true;
            this.rbSmal.CheckedChanged += new System.EventHandler(this.rbSmal_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmal);
            this.gbSize.Font = new System.Drawing.Font("Lollypop", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(917, 60);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(176, 184);
            this.gbSize.TabIndex = 2;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Siza";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(34, 130);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(93, 38);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(34, 86);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(122, 38);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCrustType.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.images;
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCrustType.Font = new System.Drawing.Font("Always Find Demo", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(917, 264);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(189, 144);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbThickCrust.Location = new System.Drawing.Point(14, 102);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(169, 29);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Think Crust ";
            this.rbThickCrust.UseVisualStyleBackColor = false;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbThinCrust.Location = new System.Drawing.Point(14, 49);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(149, 29);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = false;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic);
            this.rbEatIn.Location = new System.Drawing.Point(19, 38);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(94, 29);
            this.rbEatIn.TabIndex = 11;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.Click += new System.EventHandler(this.Where_To_Eat_Click);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic);
            this.rbTakeOut.Location = new System.Drawing.Point(19, 82);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(124, 29);
            this.rbTakeOut.TabIndex = 12;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.Click += new System.EventHandler(this.Where_To_Eat_Click);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic);
            this.gbWhereToEat.Location = new System.Drawing.Point(1170, 274);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(211, 134);
            this.gbWhereToEat.TabIndex = 13;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // gbYourPlugins
            // 
            this.gbYourPlugins.Controls.Add(this.chkMushrooms);
            this.gbYourPlugins.Controls.Add(this.chkPepper);
            this.gbYourPlugins.Controls.Add(this.chkOlive);
            this.gbYourPlugins.Controls.Add(this.chkChickens);
            this.gbYourPlugins.Controls.Add(this.chkTomatoes);
            this.gbYourPlugins.Controls.Add(this.chkMozzarellacheese);
            this.gbYourPlugins.Controls.Add(this.chkOnions);
            this.gbYourPlugins.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic);
            this.gbYourPlugins.Location = new System.Drawing.Point(1135, 70);
            this.gbYourPlugins.Name = "gbYourPlugins";
            this.gbYourPlugins.Size = new System.Drawing.Size(348, 174);
            this.gbYourPlugins.TabIndex = 14;
            this.gbYourPlugins.TabStop = false;
            this.gbYourPlugins.Text = "Your Plugins";
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(177, 76);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(152, 29);
            this.chkMushrooms.TabIndex = 17;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkPepper
            // 
            this.chkPepper.AutoSize = true;
            this.chkPepper.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepper.Location = new System.Drawing.Point(177, 41);
            this.chkPepper.Name = "chkPepper";
            this.chkPepper.Size = new System.Drawing.Size(107, 29);
            this.chkPepper.TabIndex = 16;
            this.chkPepper.Tag = "5";
            this.chkPepper.Text = "Pepper";
            this.chkPepper.UseVisualStyleBackColor = true;
            this.chkPepper.CheckedChanged += new System.EventHandler(this.chkPepper_CheckedChanged);
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlive.Location = new System.Drawing.Point(33, 111);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(81, 29);
            this.chkOlive.TabIndex = 15;
            this.chkOlive.Tag = "5";
            this.chkOlive.Text = "Olive";
            this.chkOlive.UseVisualStyleBackColor = true;
            this.chkOlive.CheckedChanged += new System.EventHandler(this.chkOlive_CheckedChanged);
            // 
            // chkChickens
            // 
            this.chkChickens.AutoSize = true;
            this.chkChickens.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChickens.Location = new System.Drawing.Point(33, 76);
            this.chkChickens.Name = "chkChickens";
            this.chkChickens.Size = new System.Drawing.Size(120, 29);
            this.chkChickens.TabIndex = 14;
            this.chkChickens.Tag = "5";
            this.chkChickens.Text = "Chickens";
            this.chkChickens.UseVisualStyleBackColor = true;
            this.chkChickens.CheckedChanged += new System.EventHandler(this.chkChickens_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(177, 117);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(131, 29);
            this.chkTomatoes.TabIndex = 13;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMozzarellacheese
            // 
            this.chkMozzarellacheese.AutoSize = true;
            this.chkMozzarellacheese.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMozzarellacheese.Location = new System.Drawing.Point(33, 146);
            this.chkMozzarellacheese.Name = "chkMozzarellacheese";
            this.chkMozzarellacheese.Size = new System.Drawing.Size(206, 29);
            this.chkMozzarellacheese.TabIndex = 12;
            this.chkMozzarellacheese.Tag = "5";
            this.chkMozzarellacheese.Text = "Mozzarella cheese";
            this.chkMozzarellacheese.UseVisualStyleBackColor = true;
            this.chkMozzarellacheese.CheckedChanged += new System.EventHandler(this.chkMozzarellacheese_CheckedChanged);
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(33, 41);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(99, 29);
            this.chkOnions.TabIndex = 11;
            this.chkOnions.Tag = "5";
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.cbOnions_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marthoni Brush", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1044, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 66);
            this.label2.TabIndex = 15;
            this.label2.Text = "Order summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lollypop", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(840, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 55);
            this.label3.TabIndex = 16;
            this.label3.Text = "Size : ";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(996, 536);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 38);
            this.lbSize.TabIndex = 18;
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSize.ForeColor = System.Drawing.Color.Black;
            this.tbSize.Location = new System.Drawing.Point(965, 472);
            this.tbSize.Multiline = true;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(148, 49);
            this.tbSize.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lollypop", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1134, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 55);
            this.label4.TabIndex = 20;
            this.label4.Text = "Crust Type : ";
            // 
            // tbCrustType
            // 
            this.tbCrustType.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCrustType.ForeColor = System.Drawing.Color.Black;
            this.tbCrustType.Location = new System.Drawing.Point(1370, 478);
            this.tbCrustType.Multiline = true;
            this.tbCrustType.Name = "tbCrustType";
            this.tbCrustType.Size = new System.Drawing.Size(148, 49);
            this.tbCrustType.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lollypop", 18.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(842, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 46);
            this.label5.TabIndex = 22;
            this.label5.Text = "Your Plugins : ";
            // 
            // tbYourPlugins
            // 
            this.tbYourPlugins.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbYourPlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYourPlugins.Font = new System.Drawing.Font("Lollypop", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYourPlugins.ForeColor = System.Drawing.Color.Black;
            this.tbYourPlugins.Location = new System.Drawing.Point(1055, 536);
            this.tbYourPlugins.Multiline = true;
            this.tbYourPlugins.Name = "tbYourPlugins";
            this.tbYourPlugins.Size = new System.Drawing.Size(465, 136);
            this.tbYourPlugins.TabIndex = 23;
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Lollypop", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.Location = new System.Drawing.Point(849, 618);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(207, 42);
            this.lbWhereToEat.TabIndex = 26;
            this.lbWhereToEat.Text = "Where To Eat : ";
            // 
            // tbWhereToEat
            // 
            this.tbWhereToEat.Font = new System.Drawing.Font("Always Find Demo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWhereToEat.Location = new System.Drawing.Point(1057, 626);
            this.tbWhereToEat.Multiline = true;
            this.tbWhereToEat.Name = "tbWhereToEat";
            this.tbWhereToEat.Size = new System.Drawing.Size(148, 49);
            this.tbWhereToEat.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lollypop", 18.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(829, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 46);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total Price";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Marthoni Brush", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPrice.Location = new System.Drawing.Point(1029, 674);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(0, 66);
            this.lbTotalPrice.TabIndex = 29;
            // 
            // btnOrderPiza
            // 
            this.btnOrderPiza.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrderPiza.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._2435292__1_;
            this.btnOrderPiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrderPiza.Location = new System.Drawing.Point(1242, 654);
            this.btnOrderPiza.Name = "btnOrderPiza";
            this.btnOrderPiza.Size = new System.Drawing.Size(107, 89);
            this.btnOrderPiza.TabIndex = 30;
            this.btnOrderPiza.UseVisualStyleBackColor = false;
            this.btnOrderPiza.Click += new System.EventHandler(this.btnOrderPiza_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.icons8_reset_100__1_;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(1412, 654);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 97);
            this.btnReset.TabIndex = 31;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.New_Project__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1582, 787);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrderPiza);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbWhereToEat);
            this.Controls.Add(this.lbWhereToEat);
            this.Controls.Add(this.tbYourPlugins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCrustType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbYourPlugins);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbYourPlugins.ResumeLayout(false);
            this.gbYourPlugins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSmal;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.GroupBox gbYourPlugins;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkPepper;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkChickens;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMozzarellacheese;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCrustType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbYourPlugins;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.TextBox tbWhereToEat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button btnOrderPiza;
        private System.Windows.Forms.Button btnReset;
    }
}

