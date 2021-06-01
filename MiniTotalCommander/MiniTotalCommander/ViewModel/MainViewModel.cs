using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using MiniTotalCommander.ViewModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;



using MiniTotalCommander.ViewModel.BaseClass;

namespace MiniTotalCommander.ViewModel
{

    using BaseClass;
    using Model;
    using System.Collections.ObjectModel;

    class MainViewModel : BaseViewModel
    {

        public MainViewModel()
        {
            Left = new PanelTCVM();
            Right = new PanelTCVM();
            
            
        }

        private PanelTCVM left;
        public PanelTCVM Left
        {
            get { return left; }
            set => SetProperty(ref left, value);
        }
        private PanelTCVM right;
        public PanelTCVM Right
        {
            get { return right; }
            set => SetProperty(ref right, value);
        }

     



        private ICommand copy;
        public ICommand Copy => copy ?? (copy = new RelayCommand((p) => { copyFile(); }, p => true));

        /// <summary>
        /// Functions
        /// </summary>

        
        //string[] test()
        //{

        //    string[] drives = new string[35];
        //    drives = Directory.GetLogicalDrives();
        //    Console.WriteLine(drives);
            
        //    return drives;

        //}

        //string write()
        //{
        //    string[] drives = new string[35];
        //    drives = Directory.GetLogicalDrives();


        //    string[] directories = null;
        //    string path = @"D:\";
        //    directories = Directory.GetDirectories(path);


        //    return path;
        //}

        void copyFile()
        {
            string leftFile = Left.CurrentPath;
            string rightFile = Right.CurrentPath;
            File.Copy(Left.CurrentPath, $@"{rightFile}\{System.IO.Path.GetFileName(leftFile)}");
            Right.Update();
            //File.Copy($@"{Left.CurrentPath}\{Left.SelectedFile}", $@"D:\Lab");

        }
    }
}