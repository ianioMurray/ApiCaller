using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiTester
{
    public partial class Form1 : Form
    {
        CallType callType;

        public Form1()
        {
            InitializeComponent();
            callType = CallType.GET;
        }

        private void Getbutton_CheckedChanged(object sender, EventArgs e)
        {
            callType = CallType.GET;
        }

        private void PostButton_CheckedChanged(object sender, EventArgs e)
        {
            callType = CallType.POST;
        }

        private void putButton_CheckedChanged(object sender, EventArgs e)
        {
            callType = CallType.PUT;
        }

        private void deleteButton_CheckedChanged(object sender, EventArgs e)
        {
            callType = CallType.DELETE;
        }

        async void button1_Click(object sender, EventArgs e)
        {
            callApiButton.Enabled = false;
            outputText.Text = "";
            await ApiCallGenerator.ApiCall(baseUrlText.Text, addtionalUrlText.Text, tokenText.Text, callType, bodyText.Text);
            outputText.Text = ApiCallGenerator.Output;
            callApiButton.Enabled = true;
        }

        private void beautifierButton_Click(object sender, EventArgs e)
        {
            //open the site
            System.Diagnostics.Process.Start("https://jsonbeautifier.org/json-viewer/");
        }

        private void baseUrlHelp_Click(object sender, EventArgs e)
        {
            List<string> messageParagraphs = new List<string>();
            messageParagraphs.Add("The Base URL is the main part of the web address i.e. for an API call to [https://api.spotify.com/v1/me/following[ "
               + "the Base URL would be [https://api.spotify.com/[");
            messageParagraphs.Add("[NOTE[ the Base URL MUST end with a forward slash.");
            Form2 helpForm = new Form2("Help", messageParagraphs);
            helpForm.Show();
        }

        private void additionalUrlHelp_Click(object sender, EventArgs e)
        {
            List<string> messageParagraphs = new List<string>();
            messageParagraphs.Add("The Additional URL is the web address minus the Base URL i.e. for an API call to [https://api.spotify.com/v1/me/following[ " +
                "the Additional URL would be [v1/me/following[. Query strings, part of the URL that begins with ?, should also be included in the Additional URL."); 
            messageParagraphs.Add("[NOTE[ the Additional URL CANNOT begin with a forward slash.");
            Form2 helpForm = new Form2("Help", messageParagraphs);
            helpForm.Show();
        }

        private void tokenHelp_Click(object sender, EventArgs e)
        {
            List<string> messageParagraphs = new List<string>();
            messageParagraphs.Add("An Authentication Token is a security token required by some API calls.  The token is programatically generated so to find a valid" +
                " token you will need to contact the API's developer.");
            Form2 helpForm = new Form2("Help", messageParagraphs);
            helpForm.Show();
        }

        private void bodyHelp_Click(object sender, EventArgs e)
        {
            List<string> messageParagraphs = new List<string>();
            messageParagraphs.Add("Request bodys are sometimes required by PUTs and POSTs to identify what needs to be added/changed.  Although not advised for DELETEs" + 
                " this application will handle request bodys for DELETEs.");
            Form2 helpForm = new Form2("Help", messageParagraphs);
            helpForm.Show();
        }
    }
}
