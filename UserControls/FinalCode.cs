using System.Drawing.Text;
using System.Windows.Forms;

namespace SQLconstructor.UserControls
{
    public partial class FinalCode : UserControl
    {
        public FinalCode()
        {
            InitializeComponent();
        }
        public void UpdateText(string onText)
        {
            this.richTextBox.Text = onText;
        }
        private void LoadFont()
        {
            PrivateFontCollection customFont = new PrivateFontCollection();
            customFont.AddFontFile("JetBrains Mono.ttf");
        }
        private void UpdateColors()
        {
            //this.richTextBox.Text.IndexOf()
        }
    }
}
