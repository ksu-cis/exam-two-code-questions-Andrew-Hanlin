using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ExamTwoCodeQuestions.Data;
using FruitFlavor = ExamTwoCodeQuestions.Data.FruitFilling;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void WithIceCreamBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void FruitButton_Checked(object sender, RoutedEventArgs e)
        {
            FruitFlavor flavor=FruitFlavor.Cherry;

            switch (((RadioButton)sender).Name)
            {
                case "CherryFlavor":
                    flavor = FruitFlavor.Cherry;
                    break;
                case "PeachFlavor":
                    flavor = FruitFlavor.Peach;
                    break;
                case "BlueFlavor":
                    flavor = FruitFlavor.Blueberry;
                    break;
                default:
                    flavor = FruitFlavor.Cherry;
                    break;

            }
            if (DataContext is Cobbler)
            {
                Cobbler c = (Cobbler)DataContext;
                c.Fruit = flavor;
            }
            else
            {
                throw new NotImplementedException("Only Jerked soda should be the datacontext");
            }

        }
    }
}
