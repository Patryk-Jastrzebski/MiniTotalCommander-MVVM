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

namespace MiniTotalCommander.View
{
    /// <summary>
    /// Logika interakcji dla klasy PanelTC.xaml
    /// </summary>
    /// 
    public partial class PanelTC : UserControl
    {
        public PanelTC()
        {
            InitializeComponent();
        }

        // Drive properties

        public static readonly DependencyProperty DriveProp =
            DependencyProperty.Register(
                    nameof(Drives),
                    typeof(string[]),
                    typeof(PanelTC)
                );


        public string[] Drives
        {
            get { return (string[])GetValue(DriveProp); }
            set
            {
                SetValue(DriveProp, value);
            }
        }

        public static readonly DependencyProperty CurrentDriveProp =
            DependencyProperty.Register(
                    nameof(CurrentDrive),
                    typeof(string),
                    typeof(PanelTC)
                );


        public string CurrentDrive
        {
            get { return (string)GetValue(CurrentDriveProp); }
            set
            {
                SetValue(CurrentDriveProp, value);
            }
        }

        // Paths properites 

        public static readonly DependencyProperty PathProp =
            DependencyProperty.Register(
                    nameof(Paths),
                    typeof(string[]),
                    typeof(PanelTC)
                );


        public string[] Paths
        {
            get { return (string[])GetValue(PathProp); }
            set
            {
                SetValue(PathProp, value);
            }
        }

        public static readonly DependencyProperty CurrentPathProp =
            DependencyProperty.Register(
                    nameof(CurrentPath),
                    typeof(string),
                    typeof(PanelTC)
                );


        public string CurrentPath
        {
            get { return (string)GetValue(CurrentPathProp); }
            set
            {
                SetValue(CurrentPathProp, value);
            }
        }


        /// SELECTED

        public static readonly DependencyProperty SelectedPathProp =
            DependencyProperty.Register(
                    nameof(SelectedPath),
                    typeof(string),
                    typeof(PanelTC)
                );


        public string SelectedPath
        {
            get { return (string)GetValue(SelectedPathProp); }
            set
            {
                SetValue(SelectedPathProp, value);
            }
        }




        // Double click command

        public static readonly DependencyProperty DoubleClickProp =
        DependencyProperty.Register(
            nameof(DoubleClickCommand),
            typeof(ICommand),
            typeof(PanelTC),
            new PropertyMetadata(null));
        public ICommand DoubleClickCommand
        {
            get { return (ICommand)GetValue(DoubleClickProp); }
            set { SetValue(DoubleClickProp, value); }
        }


    }
}
