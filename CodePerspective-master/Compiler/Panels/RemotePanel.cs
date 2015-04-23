﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XLibrary;
using System.Net;
using XLibrary.Remote;
using System.Security.Cryptography;
using System.IO;


namespace XBuilder.Panels
{
    public partial class RemotePanel : UserControl
    {
        public RemotePanel()
        {
            InitializeComponent();
            AddressTextBox.Text = "127.0.0.1";

            XRay.Remote = new XRemote();
            XRay.Remote.RemoteCachePath = Path.Combine(Application.StartupPath, "Remote");
            Directory.CreateDirectory(XRay.Remote.RemoteCachePath);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                XRay.InitCoreThread();

                // set key
                XRay.Remote.Encryption.Key = Utilities.HextoBytes(KeyTextBox.Text);
                
                // set address
                var ip = AddressTextBox.Text;
                var port = PortTextBox.Text;

                // connect
                XRay.Remote.ConnectToServer(IPAddress.Parse(ip), ushort.Parse(port));

                ConnectionTimer_Tick(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            var server = XRay.Remote.ServerConnection;

            if (server == null)
                StatusLabel.Text = "";
            else
                StatusLabel.Text = server.ToString() + " - " + server.State.ToString() + " - " + XRay.Remote.RemoteStatus;

            ConnectButton.Enabled = (XRay.Remote.Connections.Count == 0);
            OpenButton.Enabled = XRay.InitComplete; // dat loaded
            DisconnectButton.Enabled = (server != null);

            if (server != null)
            {
                BandwidthLabel.Text = string.Format("In: {0} b/s, Out: {1} b/s", server.Bandwidth.InAvg(), server.Bandwidth.OutAvg());
                SyncSpeedLabel.Text = "Syncs per Second: " + server.SyncsPerSecond.ToString();
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            var server = XRay.Remote.ServerConnection;

            if (server == null)
                return;

            XRay.RunInCoreAsync(() => server.CleanClose("Forced Disconnect"));

            ConnectionTimer_Tick(this, null);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            XRay.StartGui();
        }
    }
}
