using Avalonia;
using Avalonia.Automation.Peers;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.LogicalTree;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Threading;
using Avalonia.VisualTree;
using Avalonia.Win32;
using OgreAvaloniaEditor.ViewModels;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace OgreAvaloniaEditor.Views
{
    public partial class MainWindow : Window
    {
        public OgreControl ogreControl;
        public MainWindow()
        {
            InitializeComponent();
            ogreControl = new OgreControl();    
            OgreHost.Children.Clear();
            OgreHost.Children.Add(ogreControl);           
            
        }

        protected override bool IsEnabledCore => base.IsEnabledCore;

        protected override bool BypassFlowDirectionPolicies => base.BypassFlowDirectionPolicies;

        public override void BeginInit()
        {
            base.BeginInit();
        }

        public override void EndInit()
        {
            base.EndInit();
        }

        public override void Hide()
        {
            base.Hide();
        }

        public override void InvalidateMirrorTransform()
        {
            base.InvalidateMirrorTransform();
        }

        public override void Render(DrawingContext context)
        {
            base.Render(context);
        }

        public override void Show()
        {
            base.Show();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        protected override void ArrangeCore(Rect finalRect)
        {
            base.ArrangeCore(finalRect);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            return base.ArrangeOverride(finalSize);
        }

        protected override ILayoutManager CreateLayoutManager()
        {
            return base.CreateLayoutManager();
        }

        protected override IRenderTarget CreateRenderTarget()
        {
            return base.CreateRenderTarget();
        }

        protected override void ExtendClientAreaToDecorationsChanged(bool isExtended)
        {
            base.ExtendClientAreaToDecorationsChanged(isExtended);
        }

        protected override IControl GetTemplateFocusTarget()
        {
            return base.GetTemplateFocusTarget();
        }

        protected override bool HandleClosing()
        {
            return base.HandleClosing();
        }

        protected override void HandlePaint(Rect rect)
        {
            base.HandlePaint(rect);
        }

        protected override void HandleScalingChanged(double scaling)
        {
            base.HandleScalingChanged(scaling);
        }

        protected override void HandleTransparencyLevelChanged(WindowTransparencyLevel transparencyLevel)
        {
            base.HandleTransparencyLevelChanged(transparencyLevel);
        }

        protected override void HandleWindowStateChanged(WindowState state)
        {
            base.HandleWindowStateChanged(state);
        }

        protected override void LogicalChildrenCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            base.LogicalChildrenCollectionChanged(sender, e);
        }

        protected override Size MeasureCore(Size availableSize)
        {
            return base.MeasureCore(availableSize);
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return base.MeasureOverride(availableSize);
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
        }

        protected override void OnAttachedToLogicalTree(LogicalTreeAttachmentEventArgs e)
        {
            base.OnAttachedToLogicalTree(e);
        }

        protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnAttachedToVisualTree(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return base.OnCreateAutomationPeer();
        }

        protected override void OnDataContextBeginUpdate()
        {
            base.OnDataContextBeginUpdate();
        }

        protected override void OnDataContextChanged(EventArgs e)
        {
            base.OnDataContextChanged(e);
            MainWindowViewModel? viewModel = (MainWindowViewModel?)this.DataContext;
            if (viewModel != null)
            {
                viewModel.mainWindow = this;
            }
            
        }

        protected override void OnDataContextEndUpdate()
        {
            base.OnDataContextEndUpdate();
        }

        protected override void OnDetachedFromLogicalTree(LogicalTreeAttachmentEventArgs e)
        {
            base.OnDetachedFromLogicalTree(e);
        }

        protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnDetachedFromVisualTree(e);
        }

        protected override void OnGotFocus(GotFocusEventArgs e)
        {
            base.OnGotFocus(e);
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
        }

        protected override void OnLostFocus(RoutedEventArgs e)
        {
            base.OnLostFocus(e);
        }

        protected override void OnMeasureInvalidated()
        {
            base.OnMeasureInvalidated();
        }

        protected override void OnOpened(EventArgs e)
        {
            base.OnOpened(e);
        }

        protected override void OnPointerCaptureLost(PointerCaptureLostEventArgs e)
        {
            base.OnPointerCaptureLost(e);
        }

        protected override void OnPointerEntered(PointerEventArgs e)
        {
            base.OnPointerEntered(e);
        }

        protected override void OnPointerExited(PointerEventArgs e)
        {
            base.OnPointerExited(e);
        }

        protected override void OnPointerMoved(PointerEventArgs e)
        {
            base.OnPointerMoved(e);
        }

        protected override void OnPointerPressed(PointerPressedEventArgs e)
        {
            base.OnPointerPressed(e);
        }

        protected override void OnPointerReleased(PointerReleasedEventArgs e)
        {
            base.OnPointerReleased(e);
        }

        protected override void OnPointerWheelChanged(PointerWheelEventArgs e)
        {
            base.OnPointerWheelChanged(e);
        }

        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);
        }

        protected override void OnTemplateChanged(AvaloniaPropertyChangedEventArgs e)
        {
            base.OnTemplateChanged(e);
        }

        protected override void OnTextInput(TextInputEventArgs e)
        {
            base.OnTextInput(e);
        }

        protected override void OnUnloaded()
        {
            base.OnUnloaded();
        }

        protected override bool RegisterContentPresenter(IContentPresenter presenter)
        {
            return base.RegisterContentPresenter(presenter);
        }

        protected override void UpdateDataValidation(AvaloniaProperty property, BindingValueType state, Exception? error)
        {
            base.UpdateDataValidation(property, state, error);
        }
    }
}