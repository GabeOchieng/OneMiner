﻿using OneMiner.Core.Interfaces;
using OneMiner.View.v1.MiningInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneMiner.View.v1
{
    public partial class MinerInfo : Form
    {

        public IMiner Miner { get; set; }
        
        MainForm m_Parent = null;
        List<Button> m_tabButtons = new List<Button>();
        public IMinerInfoTab CurrentTab { get; set; }

        

        Form m_Summary = null;
        Form m_Script =null;
        Form m_Logs = null;
        public MinerInfo(IMiner miner, MainForm parent)
        {
            Miner = miner;
            m_Parent = parent;

            m_Summary = new MinerInfoSummary(Miner, this);
            m_Script = new MinerInfoScript(Miner, this);
            m_Logs = new MinerInfoLogs(Miner, this);
            InitializeComponent();
        }
        public void SelectView(Button btn)
        {
            foreach (Button item in m_tabButtons)
            {
                if(btn==item)
                {
                    item.BackColor = Color.SteelBlue;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.LightSteelBlue;
                    item.ForeColor = Color.Black;
                }
            }


        }


        private void MinerInfo_Load(object sender, EventArgs e)
        {
            pbTemplate.Image = Miner.MainCoin.Logo;

            lblMinerType.Text = Miner.MainCoin.Name;
            if (Miner.DualMining)
                lblMinerType.Text = lblMinerType.Text + " + " + Miner.DualCoin.Name;
            lblMinername.Text = Miner.Name;

            m_tabButtons.Add(btntabInfo);
            m_tabButtons.Add(btntabLogs);
            m_tabButtons.Add(btntabScript);
            //btntabInfo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
        }
        public void ShowTabInfo(Form form)
        {
            form.TopLevel = false;
            pnlMinerInfo.Controls.Clear();
            pnlMinerInfo.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            IMinerInfoTab tab = form as IMinerInfoTab;
            if (tab != null)
                tab.UpdateUI();
            CurrentTab = tab;//its ok if its null after cast
            form.Show();
        }
        public void UpdateUI()
        {
            if(CurrentTab!=null)
            {
                CurrentTab.UpdateUI();
            }
        }

        
        private void btntabInfo_Click(object sender, EventArgs e)
        {
            SelectView(sender as Button) ;
            ShowTabInfo(m_Summary);
        }

        private void btntabScript_Click(object sender, EventArgs e)
        {
            SelectView(sender as Button);
            ShowTabInfo(m_Script);


        }

        private void btntabLogs_Click(object sender, EventArgs e)
        {
            SelectView(sender as Button);
            ShowTabInfo(m_Logs);


        }
    }
}
