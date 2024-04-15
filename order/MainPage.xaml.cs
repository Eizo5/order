namespace order
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            int num11, num22, num33, num44, num55;
            int.TryParse(num1.Text, out num11);
            int.TryParse(num2.Text, out num22);
            int.TryParse(num3.Text, out num33);
            int.TryParse(num4.Text, out num44);
            int.TryParse(num5.Text, out num55);

            int[] numbers = {num11 , num22, num33, num44, num55};

            if (asc.IsChecked)
            {
                Array.Sort(numbers);
            }
            else if(dec.IsChecked)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
            }
            num1.Text = numbers[0].ToString();
            num2.Text = numbers[1].ToString();
            num3.Text = numbers[2].ToString();
            num4.Text = numbers[3].ToString();
            num5.Text = numbers[4].ToString();
        }
    }

}
