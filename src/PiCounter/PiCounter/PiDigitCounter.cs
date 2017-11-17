using System;
using System.Windows.Forms;

namespace PiCounter
{
    public partial class PiDigitCounter : Form
    {
        private int currentCount = 0;
        private const short totalDigits = 1000; // Upper limit established for PiCounter
        private const string piStrArray = "3141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011330530548820466521384146951941511609433057270365759591953092186117381932611793105118548074462379962749567351885752724891227938183011949129833673362440656643086021394946395224737190702179860943702770539217176293176752384674818467669405132000568127145263560827785771342757789609173637178721468440901224953430146549585371050792279689258923542019956112129021960864034418159813629774771309960518707211349999998372978049951059731732816096318595024459455346908302642522308253344685035261931188171010003137838752886587533208381420617177669147303598253490428755468731159562863882353787593751957781857780532171226806613001927876611195909216420198";
        private short[] piArray = new short[totalDigits];

        public PiDigitCounter()
        {
            InitializeComponent();
        }
                
        private void PiDigitCounter_Load(object sender, EventArgs e)
        {
            // Initializing number array and setting the upper limit established for PiCounter.
            for (int i = 0; i < totalDigits; i++)
            {
                piArray[i] = Convert.ToInt16(piStrArray[i].ToString());
            }
        }

        private void buttonPlus_MouseDown(object sender, MouseEventArgs e)
        {
            // Add to counter
            if (currentCount < totalDigits)
            {
                currentCount++;
                labelPiDigit.Text = piArray[currentCount - 1].ToString();
                labelTotal.Text = currentCount.ToString();
            }
        }

        private void buttonMinus_MouseDown(object sender, MouseEventArgs e)
        {
            // Subtract to counter
            if (currentCount <= 1)
            {
                Reset();
            }
            else
            {
                currentCount--;
                labelPiDigit.Text = piArray[currentCount - 1].ToString();

                labelTotal.Text = currentCount.ToString();
            }
        }

        private void linkLabelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Reset counter
            Reset();
        }

        private void Reset()
        {
            currentCount = 0;
            labelPiDigit.Text = "-";
            labelTotal.Text = "0";
        }
           
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // In case keyboard keys are being used instead: Add {"Right", "+"}, or Subtract {"Left", "-"}
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Add:
                    if (currentCount < totalDigits)
                    {
                        currentCount++;
                        labelPiDigit.Text = piArray[currentCount - 1].ToString();
                        labelTotal.Text = currentCount.ToString();
                    }
                    return true;
                    break;
                case Keys.Left:
                case Keys.Subtract:
                    if (currentCount <= 1)
                    {
                        Reset();
                    }
                    else
                    {
                        currentCount--;
                        labelPiDigit.Text = piArray[currentCount - 1].ToString();

                        labelTotal.Text = currentCount.ToString();
                    }
                    return true;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
