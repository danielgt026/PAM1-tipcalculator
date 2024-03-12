using System.Diagnostics.Metrics;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void slider_change(object sender, ValueChangedEventArgs e)
        {
            double value = (double)e.NewValue;
        }

        private void OnQuinzeBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void OnVinteBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void OnRounddownBtn_Clicked(object sender, EventArgs e)
        {
            //calcular a gorjeta, arredondand para baixo
            double result = calculatetip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double TotalValue = roundedResult + amount;

            //exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = TotalValue.ToString();
        }

        private void OnRoundupBtn_Clicked(object sender, EventArgs e)
        {
            //calcular a gorjeta, arredondand para baixo
            double result = calculatetip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double TotalValue = roundedResult + amount;

            //exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = TotalValue.ToString();
        }

        private double calculatetip()
        {

            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;

            //calculo da gorjeta
            double result = amount * (percent / 100);
            return result;
        }
    }
}


