
using System.Windows.Forms;

public class NumericUpDownK : NumericUpDown
{
    public NumericUpDownK()
    {
    }

    protected override void UpdateEditText()
    {
        // Append the units to the end of the numeric value
        this.Text = this.Value + " k";
    }
}