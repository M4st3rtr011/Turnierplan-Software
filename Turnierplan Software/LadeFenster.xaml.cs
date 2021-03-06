﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Turnierplan_Software
{
    /// <summary>
    /// Interaction logic for LadeFenster.xaml
    /// </summary>
    public partial class Veranstaltunsmanager : Window
    {
        public EventHandler Laden { get; set; }
        public EventHandler Loeschen { get; set; }
        public EventHandler Neu { get; set; }
        public ListBox Veranstaltungen { get; private set; }

        public Veranstaltunsmanager()
        {
            InitializeComponent();
            Veranstaltungen = listBox_veranstaltungen;
        }

        private void button_loeschen_Click(object sender, RoutedEventArgs e)
        {
            if (Loeschen != null)
            {
                Loeschen(this, null);
            }
        }

        private void button_laden_Click(object sender, RoutedEventArgs e)
        {
            if (Laden != null)
            {
                Laden(this, null);
            }
        }

        private void button_neu_Click(object sender, RoutedEventArgs e)
        {
            if (Neu != null)
            {
                Neu(this, null);
            }
        }
    }
}
