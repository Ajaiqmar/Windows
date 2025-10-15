using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CustomEmojiPicker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private NotifyIcon trayIcon;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            trayIcon = new NotifyIcon
            {
                Icon = System.Drawing.SystemIcons.Information,
                Visible = true,
                Text = "Emoji Picker"
            };

            var menu = new ContextMenuStrip();
            menu.Items.Add("Open Picker", null, (s, a) => ShowPicker());
            menu.Items.Add("Exit", null, (s, a) => Shutdown());
            trayIcon.ContextMenuStrip = menu;
        }

        private void ShowPicker()
        {
            //var picker = new PickerWindow();
            //picker.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            base.OnExit(e);
        }
    }
}
