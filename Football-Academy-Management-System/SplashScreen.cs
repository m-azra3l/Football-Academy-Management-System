using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Football_Academy_Management_System
{
    public partial class SplashScreen : Form
    {
        //The delegates required to invoke methods from a different thread
        private delegate void CloseDelegate();
        private delegate void UpdateDelegate(string txt);

        private SplashScreen _splashInstance;

        //The initializer for the SplashScreen Class
        public SplashScreen(int max)
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = max;
        }

        //Private method used to display the splash creen form.
        private void ShowForm(object max)
        {
            _splashInstance = new SplashScreen(Convert.ToInt32(max));
            Application.Run(_splashInstance);
        }

        //Public method that spawns a new thread and calls the ShowForm() method to lauch the splash screen in the new thread.
        public void ShowSplashScreen(int max)
        {
            if (_splashInstance != null)
                return;
            Thread thread = new Thread(ShowForm);
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(max);
        }

        //Public bool to check if the splash screen is ready.
        public bool Ready()
        {
            return (_splashInstance != null) && (_splashInstance.Created);
        }

        //Public method used to update the progress bar progress and text from your main application thread.
        public void UpdateProgress(string txt)
        {
            _splashInstance.Invoke(new UpdateDelegate(UpdateProgressInternal), txt);

        }

        //Public method used to close the splash screen from your main application thread.
        public void CloseForm()
        {
            _splashInstance.Invoke(new CloseDelegate(CloseFormInternal));
        }

        //The private method invoked by the delegate to update the progress bar.
        private void UpdateProgressInternal(string txt)
        {
            _splashInstance.progressBar1.Value++;
            _splashInstance.progressBar1.Text = txt;
        }

        //The private method invoked by the delegate to close the splash screen.
        private void CloseFormInternal()
        {
            _splashInstance.Close();
        }

    }
}