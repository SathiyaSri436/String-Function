using System;
using System.Windows;

namespace StringFunctions
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Replace_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = txtInput.Text.Replace("studing", "working");
        }

        private void StartsWith_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = txtInput.Text.StartsWith("I").ToString();
        }

        private void EndsWith_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = txtInput.Text.EndsWith("studing").ToString();
        }

        private void Contains_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = txtInput.Text.Contains("a").ToString();
        }

        private void Upper_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = txtInput.Text.ToUpper();
        }

        private void Lower_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = txtInput.Text.ToLower();
        }

        // Split Function
        private void Split_Click(object sender, RoutedEventArgs e)
        {
            string[] words = txtInput.Text.Split(' ');
            txtOutput.Text = string.Join(", ", words);
        }

        // Join Function
        private void Join_Click(object sender, RoutedEventArgs e)
        {
            string[] names = { "sathiya", "is", "girl" };
            txtOutput.Text = string.Join(" - ", names);
        }

        // Null Check
        private void Null_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                txtOutput.Text = "String is Null or Empty";
            }
            else
            {
                txtOutput.Text = "String contains value";
            }
        }

        // IndexOf Function
        private void IndexOf_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = txtInput.Text.IndexOf("m").ToString();
        }

        // LastIndexOf Function
        private void LastIndexOf_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = txtInput.Text.LastIndexOf("g").ToString();
        }

      
    }
}