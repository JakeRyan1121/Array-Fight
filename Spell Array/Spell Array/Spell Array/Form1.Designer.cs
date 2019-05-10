namespace Spell_Array
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
            this.lstbxSpells = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxArray = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxSpells
            // 
            this.lstbxSpells.FormattingEnabled = true;
            this.lstbxSpells.Items.AddRange(new object[] {
            "Basic Punch\tA basic punch from the dominant hand\t\t\t\t\t1\tPhysical\t             30",
            "Basic Kick               A basic kick from the dominant leg\t\t\t\t\t1\tPhysical\t      " +
                "       30",
            "Tackle\t                A full-body charge attack\t\t\t\t\t\t2\tPhysical\t             25",
            "Flying Kick\tA running kick at the opponent\t\t\t\t\t2\tPhysical\t             25",
            "Harden Skin\tHardens the outer layer of skin to resist physical damage\t\t\tN/A\tPhysi" +
                "cal\t             15",
            "Fireball \t\tCreates and shoot a fireball from hands\t\t\t\t\t5\tFire\t             10",
            "Firestorm  \tCreates a storm of fire around the enemy\t\t\t\t\t7\tFire\t              8",
            "Fire Punch\tThrows a powerful fire punch on the opponent\t\t\t\t4\tPhysical/Fire       " +
                "  10",
            "Incinerate\tExtremely powerful blast of fire at the opponent\t\t\t\t12\tFire\t          " +
                "    3",
            "Lighting Bolt\tThrows a bolt of lighting at the opponent\t\t\t\t\t5\tLighting\t          " +
                "   10",
            "Chain Lighting\tA powerful lighting attack that deals significant damage\t\t\t10\tLigh" +
                "ting                  5",
            "Ice Spike\t\tCreates a sharp spike of ice to throw at the opponent\t\t\t6\tIce\t        " +
                "     10",
            "Ice Blast\t\tA blast of ice at the opponent\t\t\t\t\t\t7\tIce\t              8",
            "Stoneflesh\tTurns skin to stone to better protect against elemental attacks\t\tN/A  " +
                "       Stone\t             10",
            "Stone Throw\tLevitates a large stone and throws at opponent\t\t\t\t7\tStone\t           " +
                "  10",
            "Stone Armor\tCovers body with an armor of stone that significantly increases defen" +
                "sive stats\tN/A\tStone\t              5",
            "Stone Storm\tHurls downpour of stones upon the opponent\t\t\t\t5\tStone\t             15" +
                ""});
            this.lstbxSpells.Location = new System.Drawing.Point(12, 43);
            this.lstbxSpells.Name = "lstbxSpells";
            this.lstbxSpells.Size = new System.Drawing.Size(668, 238);
            this.lstbxSpells.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Spells";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Damage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Damage Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mana Cost";
            // 
            // cmbxArray
            // 
            this.cmbxArray.FormattingEnabled = true;
            this.cmbxArray.Items.AddRange(new object[] {
            "Position 1",
            "Position 2",
            "Position 3",
            "Position 4"});
            this.cmbxArray.Location = new System.Drawing.Point(15, 287);
            this.cmbxArray.Name = "cmbxArray";
            this.cmbxArray.Size = new System.Drawing.Size(121, 21);
            this.cmbxArray.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbxArray);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxSpells);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxSpells;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxArray;
        private System.Windows.Forms.Button btnAdd;
    }
}

