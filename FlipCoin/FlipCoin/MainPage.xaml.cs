namespace FlipCoin
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipCoinBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            // 0 é cara (Heads) e 1 é coroa (Tails)
            Moeda moeda = new Moeda();
            moeda.flipCoin();
            CoinImg.Source = moeda.img;

            Moeda escolha = new Moeda(CoinFacePicker.SelectedIndex);

            if (moeda.tipo == escolha.tipo)
            {
                ResultLabel.Text = "Parabens! Seu palpite estava certo.";
            }
            else
            {
                ResultLabel.Text = "Opa! Seu palpite estava errado...";
            }
            /*
            int coin = new Random().Next(2);
            int selectedFace = CoinFacePicker.SelectedIndex;

            if (coin == 0)
            {
                CoinImg.Source = "head.jpeg";
            }
            if (coin == 1)
            {
                CoinImg.Source = "tail.jpeg";
            }

            if (coin == selectedFace)
            {
                ResultLabel.Text = "Parabens! Seu palpite estava certo";
            }else
            {
                ResultLabel.Text = "Opa! Seu palpite estava errado";
            }
            */
        }
    }

    public class Moeda : Object{
        public TipoMoeda tipo;
        public String img;

        public Moeda() { }

        public Moeda(int tipo) 
        {
            this.tipo = tipo == 0 ? TipoMoeda.Cara : TipoMoeda.Coroa;
            img = tipo == 0 ? "head.jpeg" : "tail.jpeg";
        }

        public void flipCoin()
        {
            tipo = new Random().Next(2) == 0 ? TipoMoeda.Cara : TipoMoeda.Coroa;
            img = tipo == TipoMoeda.Cara ? "head.jpeg" : "tail.jpeg";
        }
    }

    public enum TipoMoeda
    {
        Cara,Coroa
    }
}
