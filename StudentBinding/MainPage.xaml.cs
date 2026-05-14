using StudentBinding.Models;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }
        private Student currentStudent;
        public Student CurrentStudent
        {
            get => currentStudent;
            set
            {
                currentStudent = value;
                OnPropertyChanged(nameof(CurrentStudent));
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Student1 = new Student
            {
                Name = "עידו סיטבון המלך",
                Age = 17,
                BirthDate = new DateTime(2009, 3, 18),
                Image = "daniel.png",
                Email = "Ido.sitbon2@gmail.com",
                Phone = "054-1234567"
            };
            Student2 = new Student
            {
                Name = "עידו סיטבון המלך2",
                Age = 71,
                BirthDate = new DateTime(2026, 5, 14),
                Image = "noa.png",
                Email = "Idododo@gmail.com",
                Phone = "054-7654321"
            };
            CurrentStudent = Student1;
            this.BindingContext = this;
        }
        private void OnChangeStudentClicked(object sender, EventArgs e)
        {
            if (CurrentStudent == Student1)
                CurrentStudent = Student2;
            else
                CurrentStudent = Student1;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
