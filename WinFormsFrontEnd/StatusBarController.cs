using System.Drawing;
using System.Windows.Forms;

namespace UnitConverter
{
    public class StatusBarController
    {
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;

        private readonly Color errorColour = Color.FromArgb(192, 0, 0);
        private readonly Color standardColour = Color.FromArgb(210, 90, 0);
        private readonly Color positiveColour = Color.FromArgb(0, 128, 0);

        public StatusBarController(StatusStrip pStatusStrip, ToolStripStatusLabel pStatusLabel)
        {
            statusStrip = pStatusStrip;
            statusLabel = pStatusLabel;
        }

        public void SetToReady()
        {
            statusStrip.BackColor = standardColour;
            statusLabel.BackColor = standardColour;
            statusLabel.Text = "Ready";
        }

        public void SetToDone()
        {
            statusStrip.BackColor = positiveColour;
            statusLabel.BackColor = positiveColour;
            statusLabel.Text = "Done";
        }

        public void SetToInvalidInput()
        {
            statusStrip.BackColor = errorColour;
            statusLabel.BackColor = errorColour;
            statusLabel.Text = "Invalid input(s)!";
        }

        public void SetToRoundOffValueSet()
        {
            statusStrip.BackColor = positiveColour;
            statusLabel.BackColor = positiveColour;
            statusLabel.Text = "Round-off setting updated";
        }

        public void SetToSettingUpdated()
        {
            statusStrip.BackColor = positiveColour;
            statusLabel.BackColor = positiveColour;
            statusLabel.Text = "Setting updated";
        }
    }
}
