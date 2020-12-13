using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Markdig;

namespace LinkViewerControl
{
    public partial class ViewerControl : UserControl
    {
        public ViewerControl()
        {
            InitializeComponent();
        }

        protected override async void OnCreateControl()
        {
            base.OnCreateControl();
            await webBrowser1.EnsureCoreWebView2Async();

            if (!string.IsNullOrEmpty(pendingLink))
            {
                ShowLink(pendingLink);
            }
        }

        string pendingLink = string.Empty;

        public void ShowLink(string url)
        {
            try
            {
                pendingLink = url;
                webBrowser1.CoreWebView2.Navigate(url);
                pendingLink = string.Empty;
            }
            catch { }
        }
    }
}
