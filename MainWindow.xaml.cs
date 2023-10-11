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

namespace StudentDataEntry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public List<Student> Students { get; set; } = Data.StudentsData;
        public Student CurrentStudent { get; set; } = Data.CurrentStudentData;

        public MainWindow()
        {
            CurrentStudent.Name = "EnterName";  //Change this, Implement this in XAML using Control Template
            CurrentStudent.Branch = BranchNames.None;
            CurrentStudent.Age = 0;


            InitializeComponent();

            DataContext = this;
        }
    }

    public static class Data
    {
        public static List<Student> StudentsData { get; set; } = new List<Student>();
        public static Student CurrentStudentData { get; set; } = new Student();

    }
}
