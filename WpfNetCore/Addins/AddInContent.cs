using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace WpfNetCore.Addins
{
    public class AddInContent : ContentControl
    {
        static  DependencyProperty IdProperty = DependencyProperty.Register(nameof(Id), typeof(Type), typeof(AddInContent));

        public Type Id  { get { return (Type)GetValue(IdProperty); }
    set { SetValue(IdProperty, value); }
        }

        override protected void OnInitialized(EventArgs e) {
            base.OnInitialized(e);
            var serviceProvider = this.DataContext as IServiceProvider;
            var instance = serviceProvider.GetRequiredService(this.Id);
            this.AddChild(instance);
        }
    }
}