namespace SchoolApp1;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();

        StudentsList.ItemsSource = new[]
        {
            "Zhannur",
            "Dinara",
            "Aizhan",
            "Korkem",
            "Saida"
        };
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name) return;

        await Shell.Current.GoToAsync($"{nameof(StudentDetailPage)}?name={Uri.EscapeDataString(name)}");

        StudentsList.SelectedItem = null;
    }
}
