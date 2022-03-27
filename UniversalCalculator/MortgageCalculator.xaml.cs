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
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}


		private void CalculationButton_Click(object sender, RoutedEventArgs e)
		{
			double principleLoanAmount = double.Parse(this.principleLoanAmount.Text);
			int numOfYears = int.Parse(this.numOfYears.Text);
			int numOfMonths = int.Parse(this.numOfMonths.Text) + numOfYears * 12;
			double yearlyInterestRate = double.Parse(this.yearlyInterestRate.Text);
			double monthlyInterestRate = yearlyInterestRate / 12.0 /100;
			double monthlyRepayment = principleLoanAmount
				*(monthlyInterestRate* Math.Pow(1 + monthlyInterestRate, numOfMonths))
				/ (Math.Pow(1 + monthlyInterestRate, numOfMonths) - 1);

			this.monthlyInterestRate.Text = monthlyInterestRate.ToString("N4") + "%";
			this.monthlyRepayment.Text = monthlyRepayment.ToString("N2");
		}

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
	}
}
