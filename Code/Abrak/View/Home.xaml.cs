using System;
using System.Windows.Controls;
using System.Windows;
using Abrak.ViewModel;
using System.Windows.Data;
using System.Windows.Input;

namespace Abrak.View;

    public partial class Home : UserControl
    {
        // ✅ Declare the event
        public static event Action<bool> TabChanged;

        public Home()
        {
            InitializeComponent();
            Home_ViewModel vm = new Home_ViewModel();
            DataContext = vm;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl tabControl)
            {
                bool isSearchTab = tabControl.SelectedIndex == 1;
                TabChanged?.Invoke(isSearchTab); // ✅ Fire the event
                Console.WriteLine($"🔥 Tab changed! isSearchTab: {isSearchTab}");
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    BindingExpression binding = textBox.GetBindingExpression(TextBox.TextProperty);
                    if (binding != null)
                    {
                        binding.UpdateSource(); // ✅ Manually updates the binding when Enter is pressed
                    }
                }
            }
        }


    }

