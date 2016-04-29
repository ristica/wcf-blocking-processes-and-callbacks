using Demo.Contracts;
using Demo.Proxies;
using System.ComponentModel;
using System.Windows;
using System;

namespace Demo.Client
{
    public partial class MainWindow : Window, IProcessCallback
    {
        private ProcessDuplexClient _proxy;
        private bool _cancel;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartProcess(object sender, RoutedEventArgs e)
        {
            this._proxy = new ProcessDuplexClient(new System.ServiceModel.InstanceContext(this));
            this._proxy.StartProcess();

            this._cancel = false;
            this.BtnStart.IsEnabled = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this._cancel = true;
            this._proxy.Abort();
        }

        private void CloseProcess(object sender, RoutedEventArgs e)
        {
            this._cancel = true;

            this.BtnStart.IsEnabled = true;
        }

        public bool ReportBack(int nr)
        {
            this.lblOutput.Content = nr;

            return this._cancel;
        }
    }
}
