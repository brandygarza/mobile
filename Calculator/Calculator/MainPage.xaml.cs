namespace Calculator;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		Title = "Add Master Pro";
	}

    void Add_Clicked(System.Object sender, System.EventArgs e)
    {
        double dblFirst, dblSecond;

        Double.TryParse(txtFirstNum.Text, out dblFirst);
        Double.TryParse(txtSecondNum.Text, out dblSecond);


        txtlblDisplay.Text = (dblFirst + dblSecond).ToString();
    }

    void Clear_Clicked(System.Object sender, System.EventArgs e)
    {
        txtFirstNum.Text = string.Empty;
        txtSecondNum.Text = string.Empty;
        txtlblDisplay.Text = "0";
    }
}


