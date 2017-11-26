﻿namespace OneMiner.View.v1
{
    partial class MinerInfo
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
            this.lblMinername = new System.Windows.Forms.Label();
            this.btntabScript = new System.Windows.Forms.Button();
            this.btntabLogs = new System.Windows.Forms.Button();
            this.btntabInfo = new System.Windows.Forms.Button();
            this.lblMinerType = new System.Windows.Forms.Label();
            this.pbTemplate = new System.Windows.Forms.PictureBox();
            this.pnlMinerInfo = new System.Windows.Forms.Panel();
            this.lblTotalHashrate = new System.Windows.Forms.Label();
            this.lblShares = new System.Windows.Forms.Label();
            this.btnStartMining = new System.Windows.Forms.Button();
            this.lblMinerState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinername
            // 
            this.lblMinername.AutoSize = true;
            this.lblMinername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinername.Location = new System.Drawing.Point(82, 24);
            this.lblMinername.Name = "lblMinername";
            this.lblMinername.Size = new System.Drawing.Size(97, 20);
            this.lblMinername.TabIndex = 0;
            this.lblMinername.Text = "Defaultname";
            // 
            // btntabScript
            // 
            this.btntabScript.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btntabScript.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntabScript.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntabScript.Location = new System.Drawing.Point(310, 12);
            this.btntabScript.Name = "btntabScript";
            this.btntabScript.Size = new System.Drawing.Size(75, 23);
            this.btntabScript.TabIndex = 10;
            this.btntabScript.Text = "Script";
            this.btntabScript.UseVisualStyleBackColor = false;
            this.btntabScript.Click += new System.EventHandler(this.btntabScript_Click);
            // 
            // btntabLogs
            // 
            this.btntabLogs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btntabLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntabLogs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntabLogs.Location = new System.Drawing.Point(381, 12);
            this.btntabLogs.Name = "btntabLogs";
            this.btntabLogs.Size = new System.Drawing.Size(75, 23);
            this.btntabLogs.TabIndex = 9;
            this.btntabLogs.Text = "Logs";
            this.btntabLogs.UseVisualStyleBackColor = false;
            this.btntabLogs.Click += new System.EventHandler(this.btntabLogs_Click);
            // 
            // btntabInfo
            // 
            this.btntabInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.btntabInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntabInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntabInfo.ForeColor = System.Drawing.Color.White;
            this.btntabInfo.Location = new System.Drawing.Point(238, 12);
            this.btntabInfo.Name = "btntabInfo";
            this.btntabInfo.Size = new System.Drawing.Size(75, 23);
            this.btntabInfo.TabIndex = 8;
            this.btntabInfo.Text = "Summary";
            this.btntabInfo.UseVisualStyleBackColor = false;
            this.btntabInfo.Click += new System.EventHandler(this.btntabInfo_Click);
            // 
            // lblMinerType
            // 
            this.lblMinerType.AutoSize = true;
            this.lblMinerType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinerType.Location = new System.Drawing.Point(83, 50);
            this.lblMinerType.Name = "lblMinerType";
            this.lblMinerType.Size = new System.Drawing.Size(68, 13);
            this.lblMinerType.TabIndex = 11;
            this.lblMinerType.Text = "DefaultType";
            // 
            // pbTemplate
            // 
            this.pbTemplate.Image = global::OneMiner.Properties.Resources.ethereum;
            this.pbTemplate.Location = new System.Drawing.Point(0, 24);
            this.pbTemplate.Name = "pbTemplate";
            this.pbTemplate.Size = new System.Drawing.Size(77, 63);
            this.pbTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTemplate.TabIndex = 12;
            this.pbTemplate.TabStop = false;
            // 
            // pnlMinerInfo
            // 
            this.pnlMinerInfo.BackColor = System.Drawing.Color.White;
            this.pnlMinerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMinerInfo.Location = new System.Drawing.Point(238, 41);
            this.pnlMinerInfo.Name = "pnlMinerInfo";
            this.pnlMinerInfo.Size = new System.Drawing.Size(841, 265);
            this.pnlMinerInfo.TabIndex = 14;
            // 
            // lblTotalHashrate
            // 
            this.lblTotalHashrate.AutoSize = true;
            this.lblTotalHashrate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHashrate.Location = new System.Drawing.Point(83, 85);
            this.lblTotalHashrate.Name = "lblTotalHashrate";
            this.lblTotalHashrate.Size = new System.Drawing.Size(91, 25);
            this.lblTotalHashrate.TabIndex = 15;
            this.lblTotalHashrate.Text = "Hashrate";
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShares.Location = new System.Drawing.Point(85, 119);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(84, 13);
            this.lblShares.TabIndex = 16;
            this.lblShares.Text = "Shares: 0 S, 0 R";
            // 
            // btnStartMining
            // 
            this.btnStartMining.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMining.Location = new System.Drawing.Point(15, 119);
            this.btnStartMining.Name = "btnStartMining";
            this.btnStartMining.Size = new System.Drawing.Size(53, 25);
            this.btnStartMining.TabIndex = 17;
            this.btnStartMining.Text = "Start";
            this.btnStartMining.UseVisualStyleBackColor = true;
            this.btnStartMining.Click += new System.EventHandler(this.btnStartMining_Click);
            // 
            // lblMinerState
            // 
            this.lblMinerState.AutoSize = true;
            this.lblMinerState.BackColor = System.Drawing.Color.White;
            this.lblMinerState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinerState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMinerState.Location = new System.Drawing.Point(14, 95);
            this.lblMinerState.Name = "lblMinerState";
            this.lblMinerState.Size = new System.Drawing.Size(54, 15);
            this.lblMinerState.TabIndex = 18;
            this.lblMinerState.Text = "Stopped";
            // 
            // MinerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 335);
            this.Controls.Add(this.lblMinerState);
            this.Controls.Add(this.btnStartMining);
            this.Controls.Add(this.lblShares);
            this.Controls.Add(this.lblTotalHashrate);
            this.Controls.Add(this.pnlMinerInfo);
            this.Controls.Add(this.pbTemplate);
            this.Controls.Add(this.lblMinerType);
            this.Controls.Add(this.btntabScript);
            this.Controls.Add(this.btntabLogs);
            this.Controls.Add(this.btntabInfo);
            this.Controls.Add(this.lblMinername);
            this.Name = "MinerInfo";
            this.Text = "MinerInfo";
            this.Load += new System.EventHandler(this.MinerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinername;
        private System.Windows.Forms.Button btntabScript;
        private System.Windows.Forms.Button btntabLogs;
        private System.Windows.Forms.Button btntabInfo;
        private System.Windows.Forms.Label lblMinerType;
        private System.Windows.Forms.PictureBox pbTemplate;
        private System.Windows.Forms.Panel pnlMinerInfo;
        private System.Windows.Forms.Label lblTotalHashrate;
        private System.Windows.Forms.Label lblShares;
        private System.Windows.Forms.Button btnStartMining;
        private System.Windows.Forms.Label lblMinerState;
    }
}