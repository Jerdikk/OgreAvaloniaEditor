using Avalonia.Controls;
using Avalonia.Platform;
using System;

namespace OgreAvaloniaEditor.Views
{
    public class OgreControl:NativeControlHost
    {
        public IntPtr m_Handle;
        protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
        {
            var piHandle = base.CreateNativeControlCore(parent);
            //this is the handle
            m_Handle = piHandle.Handle;

            return piHandle;
        }
    }
}