using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoNetConf.Core.Mvvm
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Set<T>(ref T field, T newValue = default, [CallerMemberName] string propertyName = null)
        {
            field = newValue;
            RaisePropertyChanged(propertyName);
        }

        public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected virtual void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(((propertyExpression.Body as MemberExpression)?.Member as PropertyInfo)?.Name));

    }
}
