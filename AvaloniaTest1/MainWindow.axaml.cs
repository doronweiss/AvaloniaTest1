using System;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace AvaloniaTest1 {
  public partial class MainWindow : Window {
    private DispatcherTimer timer = null;
    public MainWindow() {
      InitializeComponent();
      timer = new DispatcherTimer();
      timer.Tick += new EventHandler(this.OnTimer);
      timer.Interval = TimeSpan.FromMilliseconds(250);
    }

    public void OnBtnClick(object? sender, RoutedEventArgs routedEventArgs) {
      //myLBL.Content = DateTime.Now.ToString();
      if (!timer.IsEnabled) {
        timer.IsEnabled = true;
      } else {
        timer.IsEnabled = false;
        myLBL.Text = $"Stopped: {DateTime.Now.ToString()}";
      }
    }

    private void OnTimer(object? sender, EventArgs e) {
      myLBL.Text = DateTime.Now.ToString();
    }

    private void OnWindowClosing(object? sender, CancelEventArgs e) {
      timer?.Stop();
    }
  }
}
