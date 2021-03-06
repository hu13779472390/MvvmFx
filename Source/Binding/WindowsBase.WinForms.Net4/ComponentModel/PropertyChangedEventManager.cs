// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2008 Novell, Inc. (http://www.novell.com)
//
// Authors:
//	Chris Toshok (toshok@ximian.com)
//
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using MvvmFx.Windows;

namespace MvvmFx.ComponentModel
{
    /// <summary>
    /// PropertyChangedEventManager
    /// </summary>
    /// <remarks>This class isn't implemented.</remarks>
    public class PropertyChangedEventManager : WeakEventManager
    {
        internal PropertyChangedEventManager()
        {
        }

        [SuppressMessage("Microsoft.Usage", "CA1801", Justification = "The feature isn't implemented.")]
        public static void AddListener(INotifyPropertyChanged source, IWeakEventListener listener, string propertyName)
        {
            throw new NotImplementedException("PropertyChangedEventManager.AddListener");
        }

        [SuppressMessage("Microsoft.Usage", "CA1801", Justification = "The feature isn't implemented.")]
        public static void RemoveListener(INotifyPropertyChanged source, IWeakEventListener listener, string propertyName)
        {
            throw new NotImplementedException("PropertyChangedEventManager.RemoveListener");
        }

        protected override bool Purge(object source, object data, bool purgeAll)
        {
            throw new NotImplementedException("PropertyChangedEventManager.Purge");
        }

        protected override void StartListening(object source)
        {
            throw new NotImplementedException("PropertyChangedEventManager.StartListening");
        }

        protected override void StopListening(object source)
        {
            throw new NotImplementedException("PropertyChangedEventManager.StopListening");
        }
    }
}
