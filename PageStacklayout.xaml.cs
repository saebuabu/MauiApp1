namespace MauiApp1;

public partial class PageStacklayout : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public PageStacklayout()
	{
		InitializeComponent();
        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
    }

    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
        message.Text = "Aantekening is opgeslagen";
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
            editor.Text = string.Empty;
            message.Text = "Aantekening verwijderd";
        }
    }

}