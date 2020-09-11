
using System.Windows.Forms;

public class NumericUpDownB : NumericUpDown
{
    public NumericUpDownB()
    {
    }

    protected override void UpdateEditText()
    {
        // Append the units to the end of the numeric value
        this.Text = this.Value + " B";
    }
}