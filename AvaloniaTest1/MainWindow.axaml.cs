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
    }

    public void OnBtnClick(object? sender, RoutedEventArgs routedEventArgs) {
      //myLBL.Content = DateTime.Now.ToString();
      if (timer == null) {
        timer = new DispatcherTimer();
        timer.Tick += new EventHandler(this.OnTimer);
        timer.Interval = TimeSpan.FromMilliseconds(250);
        timer.Start();
      }
    }

    private void OnTimer(object? sender, EventArgs e) {
      myLBL.Content = DateTime.Now.ToString();
    }

    private void OnWindowClosing(object? sender, CancelEventArgs e) {
      timer?.Stop();
    }
  }
}
