using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrencyCalculator : Page
	{
		public CurrencyCalculator()
		{
			this.InitializeComponent();
		}
		private void currencyCovButton_Click(object sender, RoutedEventArgs e)
		{
			decimal amount;
			double Rate;





			amount = decimal.Parse(amountTextBox.Text);
			double currencyAmount = decimal.ToDouble(amount);
			Rate = calConversionRate(currencyAmount);

			if (ComboBox1.SelectedIndex == 0 && ComboBox2.SelectedIndex == 1)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "US Dollars=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "Euro");
				con3Textblock.Text = System.Convert.ToString("1 USD= 0.85189982 Euro");
				con4Textblock.Text = System.Convert.ToString("1 Euro =1.1739732");
			}

			else if (ComboBox1.SelectedIndex == 0 && ComboBox2.SelectedIndex == 2)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "US Dollars=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + " British Pounds");
				con3Textblock.Text = System.Convert.ToString("1 USD= 0.872436 British Pounds");
				con4Textblock.Text = System.Convert.ToString("1 British Pound =1.371907");
			}

			else if (ComboBox1.SelectedIndex == 0 && ComboBox2.SelectedIndex == 3)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "US Dollars=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "Indian Rupee");
				con3Textblock.Text = System.Convert.ToString("1 USD= 74.257327 Indian Rupee");
				con4Textblock.Text = System.Convert.ToString("1 Indian Rupee =0.011492628 US Dollars");
			}


			else if (ComboBox1.SelectedIndex == 1 && ComboBox2.SelectedIndex == 0)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "Euro=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "US Dollars");
				con3Textblock.Text = System.Convert.ToString("1 Euro= 1.1739732US Dollars");
				con4Textblock.Text = System.Convert.ToString("1 US Dollars = 0.85189982 Euro");
			}

			else if (ComboBox1.SelectedIndex == 1 && ComboBox2.SelectedIndex == 2)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "Euro=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "British Pounds");
				con3Textblock.Text = System.Convert.ToString("1 Euro= 0.8556672 Indian Rupee");
				con4Textblock.Text = System.Convert.ToString("1 British Pounds =1.1686692 Euro");
			}

			else if (ComboBox1.SelectedIndex == 1 && ComboBox2.SelectedIndex == 3)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "Euro=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "Indian Rupee");
				con3Textblock.Text = System.Convert.ToString("1 Euro= 87.00755 Indian Rupee");
				con4Textblock.Text = System.Convert.ToString("1 Indian Rupee =0.013492774 Euro");
			}

			else if (ComboBox1.SelectedIndex == 2 && ComboBox2.SelectedIndex == 0)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "British Pounds=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "US Dollars");
				con3Textblock.Text = System.Convert.ToString("1 British Pounds= 1.371907 Dollars");
				con4Textblock.Text = System.Convert.ToString("1 US Dollars =0.011492628British Pounds");
			}

			else if (ComboBox1.SelectedIndex == 2 && ComboBox2.SelectedIndex == 1)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "British Pounds=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "Euros");
				con3Textblock.Text = System.Convert.ToString("1 British Pounds= 1.11686692 Euro");
				con4Textblock.Text = System.Convert.ToString("1 Euro =0.8556672 British Pounds");
			}

			else if (ComboBox1.SelectedIndex == 2 && ComboBox2.SelectedIndex == 3)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "British Pounds=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "Indian Rupee");
				con3Textblock.Text = System.Convert.ToString("1 British Pounds= 74.257327 Indian Rupee");
				con4Textblock.Text = System.Convert.ToString("1 Indian Rupee =0.011492628 British Pounds");
			}

			else if (ComboBox1.SelectedIndex == 3 && ComboBox2.SelectedIndex == 0)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "Indian Rupee=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "US Dollars");
				con3Textblock.Text = System.Convert.ToString("1 USD= 74.257327 Indian Rupee");
				con4Textblock.Text = System.Convert.ToString("1 Indian Rupee =0.011492628 US Dollars");
			}

			else if (ComboBox1.SelectedIndex == 3 && ComboBox2.SelectedIndex == 1)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "Indian Rupee=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "Euros");
				con3Textblock.Text = System.Convert.ToString("1 Euro= 87.00755 Indian Rupee");
				con4Textblock.Text = System.Convert.ToString("1 Indian Rupee =0.13492774 Euros");
			}

			else if (ComboBox1.SelectedIndex == 3 && ComboBox2.SelectedIndex == 2)
			{
				con1Textblock.Text = System.Convert.ToString(currencyAmount + "Indian Rupee=");
				con2Textblock.Text = System.Convert.ToString("$" + Rate + "British Pounds");
				con3Textblock.Text = System.Convert.ToString("1 British Pound= 101.68635 Indian Rupee");
				con4Textblock.Text = System.Convert.ToString("1 Indian Rupee =0.0098339397 British Pounds ");
			}


		}

		private double calConversionRate(double currencyAmount)
		{
			double Rate;
			const double USD_TO_EUR = 0.85189982;
			const double USD_TO_GBP = 0.72872436;
			const double USD_TO_INR = 74.257327;
			const double EUR_TO_USD = 1.1739732;
			const double EUR_TO_GBP = 0.8556672;
			const double EUR_TO_INR = 87.00755;
			const double GBP_TO_USD = 1.371907;
			const double GBP_TO_EUR = 1.1686692;
			const double GBP_TO_INR = 101.68635;
			const double INR_TO_USD = 0.011492628;
			const double INR_TO_EUR = 0.013492774;
			const double INR_TO_GBP = 0.0098339397;
			const double VIOD_RATE = 1;


			if (ComboBox1.SelectedIndex == 0 && ComboBox2.SelectedIndex == 1)
			{
				Rate = USD_TO_EUR;
			}

			else if (ComboBox1.SelectedIndex == 0 && ComboBox2.SelectedIndex == 2)
			{
				Rate = USD_TO_GBP;
			}

			else if (ComboBox1.SelectedIndex == 0 && ComboBox2.SelectedIndex == 3)
			{
				Rate = USD_TO_INR;
			}

			else if (ComboBox1.SelectedIndex == 1 && ComboBox2.SelectedIndex == 0)
			{
				Rate = EUR_TO_USD;
			}

			else if (ComboBox1.SelectedIndex == 1 && ComboBox2.SelectedIndex == 2)
			{
				Rate = EUR_TO_GBP;
			}

			else if (ComboBox1.SelectedIndex == 1 && ComboBox2.SelectedIndex == 3)
			{
				Rate = EUR_TO_INR;
			}

			else if (ComboBox1.SelectedIndex == 2 && ComboBox2.SelectedIndex == 0)
			{
				Rate = GBP_TO_USD;
			}

			else if (ComboBox1.SelectedIndex == 2 && ComboBox2.SelectedIndex == 1)
			{
				Rate = GBP_TO_EUR;
			}

			else if (ComboBox1.SelectedIndex == 2 && ComboBox2.SelectedIndex == 3)
			{
				Rate = GBP_TO_INR;
			}

			else if (ComboBox1.SelectedIndex == 3 && ComboBox2.SelectedIndex == 0)
			{
				Rate = INR_TO_USD;
			}

			else if (ComboBox1.SelectedIndex == 3 && ComboBox2.SelectedIndex == 1)
			{
				Rate = INR_TO_EUR;
			}

			else if (ComboBox1.SelectedIndex == 3 && ComboBox2.SelectedIndex == 2)
			{
				Rate = INR_TO_GBP;
			}
			else
				Rate = VIOD_RATE;

			return Rate * currencyAmount;
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}

	}
}
