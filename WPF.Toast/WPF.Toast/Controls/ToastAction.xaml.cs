﻿using System;
using System.Windows.Media;
using WPF.Toast.Interfaces;

namespace WPF.Toast.Controls {
    /// <summary>
    /// Interaction logic for ToastAction.xaml
    /// </summary>
    public partial class ToastAction : ToastBase
    {
        /// <param name="fadeTimeOut">Timer for fade out in seconds</param>
        public ToastAction(int? fadeTimeOut = null) : base(fadeTimeOut)
        {
            InitializeComponent();
            try
            {
                MediaPlayer mediaPlayer = new MediaPlayer();
                mediaPlayer.Open(new Uri(@"Resources\Windows Proximity Notification.wav", UriKind.Relative));
                mediaPlayer.Play();
            }
            catch { }
        }

        public override bool IsToastAction { get; set; } = true;
    }
}
