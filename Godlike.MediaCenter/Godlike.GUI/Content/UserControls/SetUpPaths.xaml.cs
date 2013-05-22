using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Godlike.GUI.Content.ViewModels;

namespace Godlike.GUI.Content.UserControls
{
    /// <summary>
    /// Interaction logic for SetUpPaths.xaml
    /// </summary>
    public partial class SetUpPaths : UserControl
    {
        public SetUpPaths()
        {
            InitializeComponent();

            this.DataContext = new SetUpPathsViewModel();
        }
    }
}
