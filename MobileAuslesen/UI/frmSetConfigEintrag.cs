﻿using HtmlAgilityPack;
using MobileAuslesen.Controller.InstanzController;
using MobileAuslesen.Models;
using MobileAuslesen.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAuslesen.UI
{
    public partial class frmSetConfigEintrag : Form
    {
        private WebSocketData _data;
        private string _selectedText = string.Empty;

        internal frmSetConfigEintrag(WebSocketData data)
        {
            InitializeComponent();

            //Vorabüberprüfung
            if (data == null) return;

            _data = data;

            Application.Idle += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;

            //Erstelle TextControl aus den Boxen und füge dem pnlTexte hinzu
            pnlTexte.Controls.Add(new ucTextControl(new List<ucTextBox> { new ucTextBox("Empfangene Nachricht:", _data.HtmlCode, true, "main"), new ucTextBox("Ausgewählte Nachricht:", "", true, "select") }));

            foreach (PropertyInfo property in ConfigController.Instance.Config.HtmlConfig.GetType().GetProperties())
            {
                string name = property.Name;

                checkedListBox1.Items.Add(name);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //hole das erste ucTextControl
            var txtControl = pnlTexte.Controls.OfType<ucTextControl>().FirstOrDefault();
            if (txtControl == null) return;

            //hole den ausgewählten Text
            string selectedText = txtControl.GetTaggedTextBox("select").TextBoxText;
            if (string.IsNullOrEmpty(selectedText)) return;

            Console.WriteLine(selectedText);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //hole das erste ucTextControl
            var txtControl = pnlTexte.Controls.OfType<ucTextControl>().FirstOrDefault();
            if (txtControl == null) return;

            //Hole den ausgewählten text von der main textbox
            string selectedText = txtControl.GetTaggedTextBox("main").GetSelectedText();
            if (string.IsNullOrEmpty(selectedText)) return;

            //setze den text der select textbox auf den selectedText der main textbox
            txtControl.GetTaggedTextBox("select").TextBoxText = selectedText;
            this._selectedText = selectedText;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Vorabüberprüfung
            if (e.NewValue != CheckState.Checked) return;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i == e.Index) continue;

                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
