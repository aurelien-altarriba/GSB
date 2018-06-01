namespace GSB
{
    partial class Interface
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.TabControl();
            this.personnel = new System.Windows.Forms.TabPage();
            this.materiel = new System.Windows.Forms.TabPage();
            this.incident = new System.Windows.Forms.TabPage();
            this.visite = new System.Windows.Forms.TabPage();
            this.ac = new System.Windows.Forms.TabPage();
            this.groupBoxAjouterPersonnel = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbVisiteur = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbDéléguéRégional = new System.Windows.Forms.RadioButton();
            this.rbResponsableRégion = new System.Windows.Forms.RadioButton();
            this.rbTechnicien = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbTechnicienSupérieur = new System.Windows.Forms.RadioButton();
            this.rbAutre = new System.Windows.Forms.RadioButton();
            this.btAjouterPersonnel = new System.Windows.Forms.Button();
            this.btModifierPersonnel = new System.Windows.Forms.Button();
            this.listePersonnel = new System.Windows.Forms.ListBox();
            this.btSupprimerPersonnel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nbVisiteurMédical = new System.Windows.Forms.Label();
            this.nbDéléguéRégional = new System.Windows.Forms.Label();
            this.nbResponsableRégion = new System.Windows.Forms.Label();
            this.nbTechnicien = new System.Windows.Forms.Label();
            this.nbTechnicienSupérieur = new System.Windows.Forms.Label();
            this.nbAutre = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menu.SuspendLayout();
            this.personnel.SuspendLayout();
            this.materiel.SuspendLayout();
            this.groupBoxAjouterPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.Controls.Add(this.personnel);
            this.menu.Controls.Add(this.materiel);
            this.menu.Controls.Add(this.incident);
            this.menu.Controls.Add(this.visite);
            this.menu.Controls.Add(this.ac);
            this.menu.Location = new System.Drawing.Point(12, 12);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(760, 537);
            this.menu.TabIndex = 1;
            // 
            // personnel
            // 
            this.personnel.Controls.Add(this.label15);
            this.personnel.Controls.Add(this.nbAutre);
            this.personnel.Controls.Add(this.nbTechnicienSupérieur);
            this.personnel.Controls.Add(this.nbTechnicien);
            this.personnel.Controls.Add(this.nbResponsableRégion);
            this.personnel.Controls.Add(this.nbDéléguéRégional);
            this.personnel.Controls.Add(this.nbVisiteurMédical);
            this.personnel.Controls.Add(this.label14);
            this.personnel.Controls.Add(this.label13);
            this.personnel.Controls.Add(this.label12);
            this.personnel.Controls.Add(this.label11);
            this.personnel.Controls.Add(this.label10);
            this.personnel.Controls.Add(this.label9);
            this.personnel.Controls.Add(this.label8);
            this.personnel.Controls.Add(this.btSupprimerPersonnel);
            this.personnel.Controls.Add(this.listePersonnel);
            this.personnel.Controls.Add(this.groupBoxAjouterPersonnel);
            this.personnel.Location = new System.Drawing.Point(4, 22);
            this.personnel.Name = "personnel";
            this.personnel.Padding = new System.Windows.Forms.Padding(3);
            this.personnel.Size = new System.Drawing.Size(752, 511);
            this.personnel.TabIndex = 0;
            this.personnel.Text = "Personnel";
            this.personnel.UseVisualStyleBackColor = true;
            this.personnel.Click += new System.EventHandler(this.personnel_Click);
            // 
            // materiel
            // 
            this.materiel.Controls.Add(this.groupBox1);
            this.materiel.Location = new System.Drawing.Point(4, 22);
            this.materiel.Name = "materiel";
            this.materiel.Padding = new System.Windows.Forms.Padding(3);
            this.materiel.Size = new System.Drawing.Size(752, 511);
            this.materiel.TabIndex = 1;
            this.materiel.Text = "Matériel";
            this.materiel.UseVisualStyleBackColor = true;
            // 
            // incident
            // 
            this.incident.Location = new System.Drawing.Point(4, 22);
            this.incident.Name = "incident";
            this.incident.Size = new System.Drawing.Size(324, 170);
            this.incident.TabIndex = 2;
            this.incident.Text = "Incident";
            this.incident.UseVisualStyleBackColor = true;
            // 
            // visite
            // 
            this.visite.Location = new System.Drawing.Point(4, 22);
            this.visite.Name = "visite";
            this.visite.Size = new System.Drawing.Size(324, 170);
            this.visite.TabIndex = 3;
            this.visite.Text = "Visite";
            this.visite.UseVisualStyleBackColor = true;
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(4, 22);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(324, 170);
            this.ac.TabIndex = 4;
            this.ac.Text = "Activité complémentaire";
            this.ac.UseVisualStyleBackColor = true;
            // 
            // groupBoxAjouterPersonnel
            // 
            this.groupBoxAjouterPersonnel.Controls.Add(this.btModifierPersonnel);
            this.groupBoxAjouterPersonnel.Controls.Add(this.btAjouterPersonnel);
            this.groupBoxAjouterPersonnel.Controls.Add(this.rbAutre);
            this.groupBoxAjouterPersonnel.Controls.Add(this.rbTechnicienSupérieur);
            this.groupBoxAjouterPersonnel.Controls.Add(this.label7);
            this.groupBoxAjouterPersonnel.Controls.Add(this.rbTechnicien);
            this.groupBoxAjouterPersonnel.Controls.Add(this.rbResponsableRégion);
            this.groupBoxAjouterPersonnel.Controls.Add(this.rbDéléguéRégional);
            this.groupBoxAjouterPersonnel.Controls.Add(this.label6);
            this.groupBoxAjouterPersonnel.Controls.Add(this.rbVisiteur);
            this.groupBoxAjouterPersonnel.Controls.Add(this.label5);
            this.groupBoxAjouterPersonnel.Controls.Add(this.label4);
            this.groupBoxAjouterPersonnel.Controls.Add(this.label3);
            this.groupBoxAjouterPersonnel.Controls.Add(this.label2);
            this.groupBoxAjouterPersonnel.Controls.Add(this.label1);
            this.groupBoxAjouterPersonnel.Controls.Add(this.textBox5);
            this.groupBoxAjouterPersonnel.Controls.Add(this.textBox4);
            this.groupBoxAjouterPersonnel.Controls.Add(this.textBox3);
            this.groupBoxAjouterPersonnel.Controls.Add(this.textBox2);
            this.groupBoxAjouterPersonnel.Controls.Add(this.textBox1);
            this.groupBoxAjouterPersonnel.Location = new System.Drawing.Point(7, 7);
            this.groupBoxAjouterPersonnel.Name = "groupBoxAjouterPersonnel";
            this.groupBoxAjouterPersonnel.Size = new System.Drawing.Size(350, 357);
            this.groupBoxAjouterPersonnel.TabIndex = 0;
            this.groupBoxAjouterPersonnel.TabStop = false;
            this.groupBoxAjouterPersonnel.Text = "Ajouter/Modifier le personnel";
            this.groupBoxAjouterPersonnel.Enter += new System.EventHandler(this.groupBoxAjouterPersonnel_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(103, 127);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date d\'embauche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Région";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mail";
            // 
            // rbVisiteur
            // 
            this.rbVisiteur.AutoSize = true;
            this.rbVisiteur.Location = new System.Drawing.Point(32, 188);
            this.rbVisiteur.Name = "rbVisiteur";
            this.rbVisiteur.Size = new System.Drawing.Size(98, 17);
            this.rbVisiteur.TabIndex = 10;
            this.rbVisiteur.Text = "Visiteur médical";
            this.rbVisiteur.UseVisualStyleBackColor = true;
            this.rbVisiteur.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rôle :";
            // 
            // rbDéléguéRégional
            // 
            this.rbDéléguéRégional.AutoSize = true;
            this.rbDéléguéRégional.Location = new System.Drawing.Point(32, 212);
            this.rbDéléguéRégional.Name = "rbDéléguéRégional";
            this.rbDéléguéRégional.Size = new System.Drawing.Size(105, 17);
            this.rbDéléguéRégional.TabIndex = 12;
            this.rbDéléguéRégional.Text = "Délégué régional";
            this.rbDéléguéRégional.UseVisualStyleBackColor = true;
            // 
            // rbResponsableRégion
            // 
            this.rbResponsableRégion.AutoSize = true;
            this.rbResponsableRégion.Location = new System.Drawing.Point(32, 236);
            this.rbResponsableRégion.Name = "rbResponsableRégion";
            this.rbResponsableRégion.Size = new System.Drawing.Size(119, 17);
            this.rbResponsableRégion.TabIndex = 13;
            this.rbResponsableRégion.Text = "Responsable région";
            this.rbResponsableRégion.UseVisualStyleBackColor = true;
            // 
            // rbTechnicien
            // 
            this.rbTechnicien.AutoSize = true;
            this.rbTechnicien.Location = new System.Drawing.Point(186, 188);
            this.rbTechnicien.Name = "rbTechnicien";
            this.rbTechnicien.Size = new System.Drawing.Size(81, 17);
            this.rbTechnicien.TabIndex = 14;
            this.rbTechnicien.Text = "Technicien ";
            this.rbTechnicien.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "@swiss-galaxy.com";
            // 
            // rbTechnicienSupérieur
            // 
            this.rbTechnicienSupérieur.AutoSize = true;
            this.rbTechnicienSupérieur.Location = new System.Drawing.Point(186, 212);
            this.rbTechnicienSupérieur.Name = "rbTechnicienSupérieur";
            this.rbTechnicienSupérieur.Size = new System.Drawing.Size(124, 17);
            this.rbTechnicienSupérieur.TabIndex = 16;
            this.rbTechnicienSupérieur.Text = "Technicien supérieur";
            this.rbTechnicienSupérieur.UseVisualStyleBackColor = true;
            // 
            // rbAutre
            // 
            this.rbAutre.AutoSize = true;
            this.rbAutre.Checked = true;
            this.rbAutre.Location = new System.Drawing.Point(186, 236);
            this.rbAutre.Name = "rbAutre";
            this.rbAutre.Size = new System.Drawing.Size(50, 17);
            this.rbAutre.TabIndex = 17;
            this.rbAutre.TabStop = true;
            this.rbAutre.Text = "Autre";
            this.rbAutre.UseVisualStyleBackColor = true;
            // 
            // btAjouterPersonnel
            // 
            this.btAjouterPersonnel.Location = new System.Drawing.Point(32, 273);
            this.btAjouterPersonnel.Name = "btAjouterPersonnel";
            this.btAjouterPersonnel.Size = new System.Drawing.Size(278, 23);
            this.btAjouterPersonnel.TabIndex = 18;
            this.btAjouterPersonnel.Text = "Ajouter ce nouveau personnel";
            this.btAjouterPersonnel.UseVisualStyleBackColor = true;
            // 
            // btModifierPersonnel
            // 
            this.btModifierPersonnel.Location = new System.Drawing.Point(32, 302);
            this.btModifierPersonnel.Name = "btModifierPersonnel";
            this.btModifierPersonnel.Size = new System.Drawing.Size(278, 42);
            this.btModifierPersonnel.TabIndex = 21;
            this.btModifierPersonnel.Text = "Modifier le personnel sélectionné dans la liste avec les informations ci-dessus\r\n" +
    "";
            this.btModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // listePersonnel
            // 
            this.listePersonnel.FormattingEnabled = true;
            this.listePersonnel.Location = new System.Drawing.Point(381, 20);
            this.listePersonnel.Name = "listePersonnel";
            this.listePersonnel.Size = new System.Drawing.Size(365, 485);
            this.listePersonnel.TabIndex = 1;
            // 
            // btSupprimerPersonnel
            // 
            this.btSupprimerPersonnel.Location = new System.Drawing.Point(39, 383);
            this.btSupprimerPersonnel.Name = "btSupprimerPersonnel";
            this.btSupprimerPersonnel.Size = new System.Drawing.Size(278, 23);
            this.btSupprimerPersonnel.TabIndex = 2;
            this.btSupprimerPersonnel.Text = "Supprimer le personnel sélectionné dans la liste";
            this.btSupprimerPersonnel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Visiteur médical :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Délégué régional :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Responsable région :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nombre de :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Technicien :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(190, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Technicien supérieur :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(190, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Autre :";
            // 
            // nbVisiteurMédical
            // 
            this.nbVisiteurMédical.AutoSize = true;
            this.nbVisiteurMédical.Location = new System.Drawing.Point(128, 445);
            this.nbVisiteurMédical.Name = "nbVisiteurMédical";
            this.nbVisiteurMédical.Size = new System.Drawing.Size(0, 13);
            this.nbVisiteurMédical.TabIndex = 10;
            // 
            // nbDéléguéRégional
            // 
            this.nbDéléguéRégional.AutoSize = true;
            this.nbDéléguéRégional.Location = new System.Drawing.Point(135, 468);
            this.nbDéléguéRégional.Name = "nbDéléguéRégional";
            this.nbDéléguéRégional.Size = new System.Drawing.Size(0, 13);
            this.nbDéléguéRégional.TabIndex = 11;
            // 
            // nbResponsableRégion
            // 
            this.nbResponsableRégion.AutoSize = true;
            this.nbResponsableRégion.Location = new System.Drawing.Point(149, 492);
            this.nbResponsableRégion.Name = "nbResponsableRégion";
            this.nbResponsableRégion.Size = new System.Drawing.Size(0, 13);
            this.nbResponsableRégion.TabIndex = 12;
            // 
            // nbTechnicien
            // 
            this.nbTechnicien.AutoSize = true;
            this.nbTechnicien.Location = new System.Drawing.Point(262, 445);
            this.nbTechnicien.Name = "nbTechnicien";
            this.nbTechnicien.Size = new System.Drawing.Size(0, 13);
            this.nbTechnicien.TabIndex = 13;
            // 
            // nbTechnicienSupérieur
            // 
            this.nbTechnicienSupérieur.AutoSize = true;
            this.nbTechnicienSupérieur.Location = new System.Drawing.Point(308, 468);
            this.nbTechnicienSupérieur.Name = "nbTechnicienSupérieur";
            this.nbTechnicienSupérieur.Size = new System.Drawing.Size(0, 13);
            this.nbTechnicienSupérieur.TabIndex = 14;
            // 
            // nbAutre
            // 
            this.nbAutre.AutoSize = true;
            this.nbAutre.Location = new System.Drawing.Point(234, 492);
            this.nbAutre.Name = "nbAutre";
            this.nbAutre.Size = new System.Drawing.Size(0, 13);
            this.nbAutre.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(508, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Liste du personnel";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter/Modifier un matériel";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logiciel de gestion GSB";
            this.menu.ResumeLayout(false);
            this.personnel.ResumeLayout(false);
            this.personnel.PerformLayout();
            this.materiel.ResumeLayout(false);
            this.groupBoxAjouterPersonnel.ResumeLayout(false);
            this.groupBoxAjouterPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage personnel;
        private System.Windows.Forms.TabPage materiel;
        private System.Windows.Forms.TabPage incident;
        private System.Windows.Forms.TabPage visite;
        private System.Windows.Forms.TabPage ac;
        private System.Windows.Forms.GroupBox groupBoxAjouterPersonnel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbVisiteur;
        private System.Windows.Forms.RadioButton rbDéléguéRégional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbTechnicien;
        private System.Windows.Forms.RadioButton rbResponsableRégion;
        private System.Windows.Forms.RadioButton rbAutre;
        private System.Windows.Forms.RadioButton rbTechnicienSupérieur;
        private System.Windows.Forms.Button btAjouterPersonnel;
        private System.Windows.Forms.Button btModifierPersonnel;
        private System.Windows.Forms.ListBox listePersonnel;
        private System.Windows.Forms.Button btSupprimerPersonnel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label nbAutre;
        private System.Windows.Forms.Label nbTechnicienSupérieur;
        private System.Windows.Forms.Label nbTechnicien;
        private System.Windows.Forms.Label nbResponsableRégion;
        private System.Windows.Forms.Label nbDéléguéRégional;
        private System.Windows.Forms.Label nbVisiteurMédical;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

