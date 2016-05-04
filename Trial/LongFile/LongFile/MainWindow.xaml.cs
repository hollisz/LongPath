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
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;


namespace LongFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string networkPrefix = @"\\?\UNC\gaminglabs.net\GLIMAIN\Home\Gli_Co\Zachary_H\";
        private string localPrefix = @"\\?\c:\Users\Zack\Desktop\LongPath\";
        private string newCopyDirectory;
        private string originalFile;
        private string copyDestinationFile;
        private string newMoveDirectory;
        private string moveDestinationFile;
        private string renameDestinationFile;

        
        public MainWindow()
        {
            InitializeComponent();

            string prefix = this.localPrefix;

            this.newCopyDirectory = prefix + @"test\Testname12345678910111213141516171819202122232425262728\test0987654321123456789012343456657867890\test0192837465747238292193837465748389392892478\test2134512345342590908728979087239486509879870897609263405769872";
            this.originalFile = prefix + @"test\Testname12345678910111213141516171819202122232425262728\test0987654321123456789012343456657867890\test0192837465747238292193837465748389392892478\name12345678910111213141516171819202122232425262728.txt";
            this.copyDestinationFile = prefix + @"test\Testname12345678910111213141516171819202122232425262728\test0987654321123456789012343456657867890\test0192837465747238292193837465748389392892478\test2134512345342590908728979087239486509879870897609263405769872\name123456789101112131415161718192asdfasdfasfasfasdfasdfasdfsadfasdfasdfsdafasdfasdfasdfasdfasdfsdafsdafasdfasdfsdaf021222324252622345252352345234523452345728.txt";
            this.newMoveDirectory = prefix + @"test\Testname12345678910111213141516171819202122232425262728\test0987654321123456789012343456657867890\test0192837465747238292193837465748389392892478\test2134512345342590908728979087239486509879870897609263405769872\movedirectory123489760971234597980789712357897901871209347897987128934789789712348907890721349879087123498798071239487987124389798712348979087214";
            this.moveDestinationFile = prefix + @"test\Testname12345678910111213141516171819202122232425262728\test0987654321123456789012343456657867890\test0192837465747238292193837465748389392892478\test2134512345342590908728979087239486509879870897609263405769872\movedirectory123489760971234597980789712357897901871209347897987128934789789712348907890721349879087123498798071239487987124389798712348979087214\name123456789101112131415161718192asdfasdfasfasfasdfasdfasdfsadfasdfasdfsdafasdfasdfasdfasdfasdfsdafsdafasdfasdfsdaf021222324252622345252352345234523452345728.txt";
            this.renameDestinationFile = prefix + @"test\Testname12345678910111213141516171819202122232425262728\test0987654321123456789012343456657867890\test0192837465747238292193837465748389392892478\test2134512345342590908728979087239486509879870897609263405769872\movedirectory123489760971234597980789712357897901871209347897987128934789789712348907890721349879087123498798071239487987124389798712348979087214\newnameandstuffname123456789101112131415161718192asdfasdfasfasfasdfasdfasdfsadfasdfasdfsdafasdfasdfasdfasdfasdfsdafsdafasdfasdfsdaf021222324252622345252352345234523452345728newnameandstuff.txt";

            testCreateDirectory(this.newCopyDirectory);
            testCopy(this.originalFile, this.copyDestinationFile);
            testCreateDirectory(this.newMoveDirectory);
            testMove(this.copyDestinationFile, this.moveDestinationFile);
            testRename(this.moveDestinationFile, this.renameDestinationFile);
            testDelete(this.renameDestinationFile);

        }


        private int testCreateDirectory(string newDirectory)
        {
            //System.IO.LongPath.Directory d = new System.IO.LongPath.Directory();

            //d = newDirectory;

            //bool result = CopyFile(originalFile, this.destinationFile, true);
            //int lastWin32Error = Marshal.GetLastWin32Error();
            //if (!result)
            //{
            //    throw new System.ComponentModel.Win32Exception(lastWin32Error);
            //}

            try
            {
                System.IO.LongPath.Directory.CreateDirectory(newDirectory, System.IntPtr.Zero);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        private int testCopy(string oldFile, string newFile)
        {
            System.IO.LongPath.File f = new System.IO.LongPath.File();

            //bool result = CopyFile(originalFile, this.destinationFile, true);
            //int lastWin32Error = Marshal.GetLastWin32Error();
            //if (!result)
            //{
            //    throw new System.ComponentModel.Win32Exception(lastWin32Error);
            //}

            try
            {
                System.IO.LongPath.File.CopyFile(oldFile, newFile, true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return 0;
        }


        private int testMove(string oldFile, string newFile)
        {
            System.IO.LongPath.File f = new System.IO.LongPath.File();

            //bool result = CopyFile(originalFile, this.destinationFile, true);
            //int lastWin32Error = Marshal.GetLastWin32Error();
            //if (!result)
            //{
            //    throw new System.ComponentModel.Win32Exception(lastWin32Error);
            //}

            try
            {
                System.IO.LongPath.File.Move(oldFile, newFile, true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        private int testRename(string oldFile, string newFile)
        {
            System.IO.LongPath.File f = new System.IO.LongPath.File();

            //bool result = CopyFile(originalFile, this.destinationFile, true);
            //int lastWin32Error = Marshal.GetLastWin32Error();
            //if (!result)
            //{
            //    throw new System.ComponentModel.Win32Exception(lastWin32Error);
            //}

            try
            {
                System.IO.LongPath.File.Move(oldFile, newFile, true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        private int testDelete(string deleteFile)
        {

            System.IO.LongPath.File f = new System.IO.LongPath.File();

            //bool result = CopyFile(originalFile, this.destinationFile, true);
            //int lastWin32Error = Marshal.GetLastWin32Error();
            //if (!result)
            //{
            //    throw new System.ComponentModel.Win32Exception(lastWin32Error);
            //}

            try
            {
                System.IO.LongPath.File.DeleteFile(deleteFile);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);
    }
}
