
namespace Computerspiel_Verwaltung
{
    partial class Bestand
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestand));
            this.Eingabe_bestätigen = new System.Windows.Forms.Button();
            this.Spielename = new System.Windows.Forms.TextBox();
            this.Erscheinungsjahr = new System.Windows.Forms.TextBox();
            this.Freigabestufe = new System.Windows.Forms.TextBox();
            this.Entwicklerstudio = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Fehlertext = new System.Windows.Forms.Label();
            this.Auflistung = new System.Windows.Forms.ListBox();
            this.Preis = new System.Windows.Forms.TextBox();
            this.Ausgabe = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Bearbeiten = new System.Windows.Forms.Button();
            this.Schluß = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eingabe_bestätigen
            // 
            this.Eingabe_bestätigen.BackColor = System.Drawing.Color.Chartreuse;
            this.Eingabe_bestätigen.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.Eingabe_bestätigen, "Eingabe_bestätigen");
            this.Eingabe_bestätigen.Name = "Eingabe_bestätigen";
            this.Eingabe_bestätigen.UseVisualStyleBackColor = false;
            this.Eingabe_bestätigen.Click += new System.EventHandler(this.Eingabe_bestätigen_Click);
            // 
            // Spielename
            // 
            this.Spielename.AcceptsTab = true;
            this.Spielename.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.Spielename, "Spielename");
            this.Spielename.Name = "Spielename";
            // 
            // Erscheinungsjahr
            // 
            this.Erscheinungsjahr.AcceptsTab = true;
            this.Erscheinungsjahr.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.Erscheinungsjahr, "Erscheinungsjahr");
            this.Erscheinungsjahr.Name = "Erscheinungsjahr";
            // 
            // Freigabestufe
            // 
            this.Freigabestufe.AcceptsTab = true;
            this.Freigabestufe.BackColor = System.Drawing.SystemColors.Window;
            this.Freigabestufe.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.Freigabestufe, "Freigabestufe");
            this.Freigabestufe.Name = "Freigabestufe";
            // 
            // Entwicklerstudio
            // 
            this.Entwicklerstudio.AcceptsTab = true;
            this.Entwicklerstudio.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.Entwicklerstudio, "Entwicklerstudio");
            this.Entwicklerstudio.Name = "Entwicklerstudio";
            // 
            // Genre
            // 
            this.Genre.AcceptsTab = true;
            this.Genre.BackColor = System.Drawing.SystemColors.Window;
            this.Genre.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.Genre, "Genre");
            this.Genre.Name = "Genre";
            // 
            // Fehlertext
            // 
            resources.ApplyResources(this.Fehlertext, "Fehlertext");
            this.Fehlertext.Name = "Fehlertext";
            // 
            // Auflistung
            // 
            this.Auflistung.BackColor = System.Drawing.SystemColors.Window;
            this.Auflistung.FormattingEnabled = true;
            resources.ApplyResources(this.Auflistung, "Auflistung");
            this.Auflistung.Name = "Auflistung";
            this.Auflistung.SelectedIndexChanged += new System.EventHandler(this.Auflistung_SelectedIndexChanged);
            // 
            // Preis
            // 
            resources.ApplyResources(this.Preis, "Preis");
            this.Preis.Name = "Preis";
            // 
            // Ausgabe
            // 
            this.Ausgabe.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Ausgabe.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Ausgabe, "Ausgabe");
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Bearbeiten
            // 
            resources.ApplyResources(this.Bearbeiten, "Bearbeiten");
            this.Bearbeiten.Name = "Bearbeiten";
            this.Bearbeiten.UseVisualStyleBackColor = true;
            this.Bearbeiten.Click += new System.EventHandler(this.Bearbeiten_Click);
            // 
            // Schluß
            // 
            resources.ApplyResources(this.Schluß, "Schluß");
            this.Schluß.Name = "Schluß";
            this.Schluß.UseVisualStyleBackColor = true;
            this.Schluß.Click += new System.EventHandler(this.Schluß_Click);
            // 
            // Bestand
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.Schluß);
            this.Controls.Add(this.Bearbeiten);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.Preis);
            this.Controls.Add(this.Auflistung);
            this.Controls.Add(this.Fehlertext);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Entwicklerstudio);
            this.Controls.Add(this.Freigabestufe);
            this.Controls.Add(this.Erscheinungsjahr);
            this.Controls.Add(this.Spielename);
            this.Controls.Add(this.Eingabe_bestätigen);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Bestand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Eingabe_bestätigen;
        private System.Windows.Forms.TextBox Spielename;
        private System.Windows.Forms.TextBox Erscheinungsjahr;
        private System.Windows.Forms.TextBox Freigabestufe;
        private System.Windows.Forms.TextBox Entwicklerstudio;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label Fehlertext;
        private System.Windows.Forms.ListBox Auflistung;
        private System.Windows.Forms.TextBox Preis;
        private System.Windows.Forms.TextBox Ausgabe;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Bearbeiten;
        private System.Windows.Forms.Button Schluß;
    }
}

