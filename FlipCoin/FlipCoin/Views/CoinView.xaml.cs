namespace FlipCoin.Views;
using FlipCoin.Models;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		CoinFacePicker.SelectedIndex = 0;
	}

    private void FlipCoinBtn_Clicked(object sender, EventArgs e)
    {
		string ladoSelecionado = CoinFacePicker.SelectedItem.ToString();
		Coin coin = new Coin();
		string resultado = coin.Jogar(ladoSelecionado);
		//Jogar a moeda
		//Pegar o resultado da Moeda e escreve no Label
		ResultLabel.Text = resultado;
		CoinImg.Source = $"{coin.Lado}.jpeg";
    }
}