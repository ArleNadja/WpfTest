using Microsoft.WindowsAPICodePack.Dialogs;
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

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 非公開フィールド

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FolderSelect0_Click(object sender, RoutedEventArgs e)
        {
            //
            CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog()
            {
                Title = "フォルダを選択してください",
                InitialDirectory = @"D:\Users\threeshark",
                // フォルダ選択モードにする
                IsFolderPicker = true,
            };

            if (commonOpenFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            // FileNameで選択されたフォルダを取得する
            System.Windows.MessageBox.Show($"{commonOpenFileDialog.FileName}を選択しました");
        }
    }
}
