namespace Forms_Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AktualnaPogoda = new System.Windows.Forms.ListBox();
            this.getData = new System.Windows.Forms.Button();
            this.getCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.showQuery = new System.Windows.Forms.Button();
            this.IDToDelete = new System.Windows.Forms.TextBox();
            this.showData = new System.Windows.Forms.Button();
            this.tempThresh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AktualnaPogoda
            // 
            this.AktualnaPogoda.FormattingEnabled = true;
            this.AktualnaPogoda.Location = new System.Drawing.Point(11, 36);
            this.AktualnaPogoda.Margin = new System.Windows.Forms.Padding(2);
            this.AktualnaPogoda.Name = "AktualnaPogoda";
            this.AktualnaPogoda.Size = new System.Drawing.Size(663, 290);
            this.AktualnaPogoda.TabIndex = 0;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(725, 305);
            this.getData.Margin = new System.Windows.Forms.Padding(2);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(82, 21);
            this.getData.TabIndex = 2;
            this.getData.Text = "Pobierz dane";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.button2_Click);
            // 
            // getCity
            // 
            this.getCity.Location = new System.Drawing.Point(707, 252);
            this.getCity.Name = "getCity";
            this.getCity.Size = new System.Drawing.Size(100, 20);
            this.getCity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Miasto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj do bazy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Location = new System.Drawing.Point(733, 129);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(75, 23);
            this.deleteRecord.TabIndex = 6;
            this.deleteRecord.Text = "Usuń rekord";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click_1);
            // 
            // showQuery
            // 
            this.showQuery.Location = new System.Drawing.Point(707, 210);
            this.showQuery.Name = "showQuery";
            this.showQuery.Size = new System.Drawing.Size(100, 23);
            this.showQuery.TabIndex = 7;
            this.showQuery.Text = "Pokaż wybrane";
            this.showQuery.UseVisualStyleBackColor = true;
            this.showQuery.Click += new System.EventHandler(this.showQuery_Click);
            // 
            // IDToDelete
            // 
            this.IDToDelete.Location = new System.Drawing.Point(707, 103);
            this.IDToDelete.Name = "IDToDelete";
            this.IDToDelete.Size = new System.Drawing.Size(100, 20);
            this.IDToDelete.TabIndex = 8;
            this.IDToDelete.Text = "ID rekordu";
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(698, 36);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(110, 23);
            this.showData.TabIndex = 9;
            this.showData.Text = "Pokaż całą bazę";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // tempThresh
            // 
            this.tempThresh.Location = new System.Drawing.Point(707, 184);
            this.tempThresh.Name = "tempThresh";
            this.tempThresh.Size = new System.Drawing.Size(100, 20);
            this.tempThresh.TabIndex = 10;
            this.tempThresh.Text = "Próg temperatury";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 155);
            this.label2.MaximumSize = new System.Drawing.Size(120, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Powyżej jakiej temp. pokazać miasta?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Który rekord usunąć?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempThresh);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.IDToDelete);
            this.Controls.Add(this.showQuery);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getCity);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.AktualnaPogoda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Check your weather!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AktualnaPogoda;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.TextBox getCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button showQuery;
        private System.Windows.Forms.TextBox IDToDelete;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.TextBox tempThresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

