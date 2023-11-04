//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace org.ogre {

public class ApplicationContextBase : FrameListener {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ApplicationContextBase(global::System.IntPtr cPtr, bool cMemoryOwn) : base(BitesPINVOKE.ApplicationContextBase_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ApplicationContextBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BitesPINVOKE.delete_ApplicationContextBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ApplicationContextBase(string appName) : this(BitesPINVOKE.new_ApplicationContextBase__SWIG_0(appName), true) {
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public ApplicationContextBase() : this(BitesPINVOKE.new_ApplicationContextBase__SWIG_1(), true) {
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public RenderWindow getRenderWindow() {
    global::System.IntPtr cPtr = BitesPINVOKE.ApplicationContextBase_getRenderWindow(swigCPtr);
    RenderWindow ret = (cPtr == global::System.IntPtr.Zero) ? null : new RenderWindow(cPtr, false);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Root getRoot() {
    global::System.IntPtr cPtr = BitesPINVOKE.ApplicationContextBase_getRoot(swigCPtr);
    Root ret = (cPtr == global::System.IntPtr.Zero) ? null : new Root(cPtr, false);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__OverlaySystem getOverlaySystem() {
    global::System.IntPtr cPtr = BitesPINVOKE.ApplicationContextBase_getOverlaySystem(swigCPtr);
    SWIGTYPE_p_Ogre__OverlaySystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__OverlaySystem(cPtr, false);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void initApp() {
    BitesPINVOKE.ApplicationContextBase_initApp(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void closeApp() {
    BitesPINVOKE.ApplicationContextBase_closeApp(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool frameStarted(FrameEvent evt) {
    bool ret = (SwigDerivedClassHasMethod("frameStarted", swigMethodTypes0) ? BitesPINVOKE.ApplicationContextBase_frameStartedSwigExplicitApplicationContextBase(swigCPtr, FrameEvent.getCPtr(evt)) : BitesPINVOKE.ApplicationContextBase_frameStarted(swigCPtr, FrameEvent.getCPtr(evt)));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool frameRenderingQueued(FrameEvent evt) {
    bool ret = (SwigDerivedClassHasMethod("frameRenderingQueued", swigMethodTypes1) ? BitesPINVOKE.ApplicationContextBase_frameRenderingQueuedSwigExplicitApplicationContextBase(swigCPtr, FrameEvent.getCPtr(evt)) : BitesPINVOKE.ApplicationContextBase_frameRenderingQueued(swigCPtr, FrameEvent.getCPtr(evt)));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool frameEnded(FrameEvent evt) {
    bool ret = (SwigDerivedClassHasMethod("frameEnded", swigMethodTypes2) ? BitesPINVOKE.ApplicationContextBase_frameEndedSwigExplicitApplicationContextBase(swigCPtr, FrameEvent.getCPtr(evt)) : BitesPINVOKE.ApplicationContextBase_frameEnded(swigCPtr, FrameEvent.getCPtr(evt)));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void windowMoved(RenderWindow rw) {
    if (SwigDerivedClassHasMethod("windowMoved", swigMethodTypes3)) BitesPINVOKE.ApplicationContextBase_windowMovedSwigExplicitApplicationContextBase(swigCPtr, RenderWindow.getCPtr(rw)); else BitesPINVOKE.ApplicationContextBase_windowMoved(swigCPtr, RenderWindow.getCPtr(rw));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void windowResized(RenderWindow rw) {
    if (SwigDerivedClassHasMethod("windowResized", swigMethodTypes4)) BitesPINVOKE.ApplicationContextBase_windowResizedSwigExplicitApplicationContextBase(swigCPtr, RenderWindow.getCPtr(rw)); else BitesPINVOKE.ApplicationContextBase_windowResized(swigCPtr, RenderWindow.getCPtr(rw));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool windowClosing(RenderWindow rw) {
    bool ret = (SwigDerivedClassHasMethod("windowClosing", swigMethodTypes5) ? BitesPINVOKE.ApplicationContextBase_windowClosingSwigExplicitApplicationContextBase(swigCPtr, RenderWindow.getCPtr(rw)) : BitesPINVOKE.ApplicationContextBase_windowClosing(swigCPtr, RenderWindow.getCPtr(rw)));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void windowClosed(RenderWindow rw) {
    if (SwigDerivedClassHasMethod("windowClosed", swigMethodTypes6)) BitesPINVOKE.ApplicationContextBase_windowClosedSwigExplicitApplicationContextBase(swigCPtr, RenderWindow.getCPtr(rw)); else BitesPINVOKE.ApplicationContextBase_windowClosed(swigCPtr, RenderWindow.getCPtr(rw));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void windowFocusChange(RenderWindow rw) {
    if (SwigDerivedClassHasMethod("windowFocusChange", swigMethodTypes7)) BitesPINVOKE.ApplicationContextBase_windowFocusChangeSwigExplicitApplicationContextBase(swigCPtr, RenderWindow.getCPtr(rw)); else BitesPINVOKE.ApplicationContextBase_windowFocusChange(swigCPtr, RenderWindow.getCPtr(rw));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireInputEvent(Event event_, uint windowID) {
    BitesPINVOKE.ApplicationContextBase__fireInputEvent(swigCPtr, Event.getCPtr(event_), windowID);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool initialiseRTShaderSystem() {
    bool ret = BitesPINVOKE.ApplicationContextBase_initialiseRTShaderSystem(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setRTSSWriteShadersToDisk(bool write) {
    BitesPINVOKE.ApplicationContextBase_setRTSSWriteShadersToDisk(swigCPtr, write);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroyRTShaderSystem() {
    BitesPINVOKE.ApplicationContextBase_destroyRTShaderSystem(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setup() {
    if (SwigDerivedClassHasMethod("setup", swigMethodTypes8)) BitesPINVOKE.ApplicationContextBase_setupSwigExplicitApplicationContextBase(swigCPtr); else BitesPINVOKE.ApplicationContextBase_setup(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void createRoot() {
    if (SwigDerivedClassHasMethod("createRoot", swigMethodTypes9)) BitesPINVOKE.ApplicationContextBase_createRootSwigExplicitApplicationContextBase(swigCPtr); else BitesPINVOKE.ApplicationContextBase_createRoot(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool oneTimeConfig() {
    bool ret = (SwigDerivedClassHasMethod("oneTimeConfig", swigMethodTypes10) ? BitesPINVOKE.ApplicationContextBase_oneTimeConfigSwigExplicitApplicationContextBase(swigCPtr) : BitesPINVOKE.ApplicationContextBase_oneTimeConfig(swigCPtr));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setWindowGrab(SWIGTYPE_p_SDL_Window win, bool grab) {
    if (SwigDerivedClassHasMethod("setWindowGrab", swigMethodTypes11)) BitesPINVOKE.ApplicationContextBase_setWindowGrabSwigExplicitApplicationContextBase__SWIG_0(swigCPtr, SWIGTYPE_p_SDL_Window.getCPtr(win), grab); else BitesPINVOKE.ApplicationContextBase_setWindowGrab__SWIG_0(swigCPtr, SWIGTYPE_p_SDL_Window.getCPtr(win), grab);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setWindowGrab(SWIGTYPE_p_SDL_Window win) {
    if (SwigDerivedClassHasMethod("setWindowGrab", swigMethodTypes12)) BitesPINVOKE.ApplicationContextBase_setWindowGrabSwigExplicitApplicationContextBase__SWIG_1(swigCPtr, SWIGTYPE_p_SDL_Window.getCPtr(win)); else BitesPINVOKE.ApplicationContextBase_setWindowGrab__SWIG_1(swigCPtr, SWIGTYPE_p_SDL_Window.getCPtr(win));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float getDisplayDPI() {
    float ret = (SwigDerivedClassHasMethod("getDisplayDPI", swigMethodTypes13) ? BitesPINVOKE.ApplicationContextBase_getDisplayDPISwigExplicitApplicationContextBase(swigCPtr) : BitesPINVOKE.ApplicationContextBase_getDisplayDPI(swigCPtr));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setWindowGrab(bool grab) {
    BitesPINVOKE.ApplicationContextBase_setWindowGrab__SWIG_2(swigCPtr, grab);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setWindowGrab() {
    BitesPINVOKE.ApplicationContextBase_setWindowGrab__SWIG_3(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void locateResources() {
    if (SwigDerivedClassHasMethod("locateResources", swigMethodTypes14)) BitesPINVOKE.ApplicationContextBase_locateResourcesSwigExplicitApplicationContextBase(swigCPtr); else BitesPINVOKE.ApplicationContextBase_locateResources(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void loadResources() {
    if (SwigDerivedClassHasMethod("loadResources", swigMethodTypes15)) BitesPINVOKE.ApplicationContextBase_loadResourcesSwigExplicitApplicationContextBase(swigCPtr); else BitesPINVOKE.ApplicationContextBase_loadResources(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void reconfigure(string renderer, NameValueMap options) {
    if (SwigDerivedClassHasMethod("reconfigure", swigMethodTypes16)) BitesPINVOKE.ApplicationContextBase_reconfigureSwigExplicitApplicationContextBase(swigCPtr, renderer, NameValueMap.getCPtr(options)); else BitesPINVOKE.ApplicationContextBase_reconfigure(swigCPtr, renderer, NameValueMap.getCPtr(options));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void shutdown() {
    if (SwigDerivedClassHasMethod("shutdown", swigMethodTypes17)) BitesPINVOKE.ApplicationContextBase_shutdownSwigExplicitApplicationContextBase(swigCPtr); else BitesPINVOKE.ApplicationContextBase_shutdown(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void pollEvents() {
    if (SwigDerivedClassHasMethod("pollEvents", swigMethodTypes18)) BitesPINVOKE.ApplicationContextBase_pollEventsSwigExplicitApplicationContextBase(swigCPtr); else BitesPINVOKE.ApplicationContextBase_pollEvents(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void createDummyScene() {
    BitesPINVOKE.ApplicationContextBase_createDummyScene(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroyDummyScene() {
    BitesPINVOKE.ApplicationContextBase_destroyDummyScene(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void enableShaderCache() {
    BitesPINVOKE.ApplicationContextBase_enableShaderCache(swigCPtr);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addInputListener(SWIGTYPE_p_SDL_Window win, InputListener lis) {
    if (SwigDerivedClassHasMethod("addInputListener", swigMethodTypes19)) BitesPINVOKE.ApplicationContextBase_addInputListenerSwigExplicitApplicationContextBase__SWIG_0(swigCPtr, SWIGTYPE_p_SDL_Window.getCPtr(win), InputListener.getCPtr(lis)); else BitesPINVOKE.ApplicationContextBase_addInputListener__SWIG_0(swigCPtr, SWIGTYPE_p_SDL_Window.getCPtr(win), InputListener.getCPtr(lis));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addInputListener(InputListener lis) {
    BitesPINVOKE.ApplicationContextBase_addInputListener__SWIG_1(swigCPtr, InputListener.getCPtr(lis));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeInputListener(SWIGTYPE_p_SDL_Window win, InputListener lis) {
    if (SwigDerivedClassHasMethod("removeInputListener", swigMethodTypes20)) BitesPINVOKE.ApplicationContextBase_removeInputListenerSwigExplicitApplicationContextBase__SWIG_0(swigCPtr, SWIGTYPE_p_SDL_Window.getCPtr(win), InputListener.getCPtr(lis)); else BitesPINVOKE.ApplicationContextBase_removeInputListener__SWIG_0(swigCPtr, SWIGTYPE_p_SDL_Window.getCPtr(win), InputListener.getCPtr(lis));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeInputListener(InputListener lis) {
    BitesPINVOKE.ApplicationContextBase_removeInputListener__SWIG_1(swigCPtr, InputListener.getCPtr(lis));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual NativeWindowPair createWindow(string name, uint w, uint h, NameValueMap miscParams) {
    NativeWindowPair ret = new NativeWindowPair((SwigDerivedClassHasMethod("createWindow", swigMethodTypes21) ? BitesPINVOKE.ApplicationContextBase_createWindowSwigExplicitApplicationContextBase__SWIG_0(swigCPtr, name, w, h, NameValueMap.getCPtr(miscParams)) : BitesPINVOKE.ApplicationContextBase_createWindow__SWIG_0(swigCPtr, name, w, h, NameValueMap.getCPtr(miscParams))), true);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual NativeWindowPair createWindow(string name, uint w, uint h) {
    NativeWindowPair ret = new NativeWindowPair((SwigDerivedClassHasMethod("createWindow", swigMethodTypes22) ? BitesPINVOKE.ApplicationContextBase_createWindowSwigExplicitApplicationContextBase__SWIG_1(swigCPtr, name, w, h) : BitesPINVOKE.ApplicationContextBase_createWindow__SWIG_1(swigCPtr, name, w, h)), true);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual NativeWindowPair createWindow(string name, uint w) {
    NativeWindowPair ret = new NativeWindowPair((SwigDerivedClassHasMethod("createWindow", swigMethodTypes23) ? BitesPINVOKE.ApplicationContextBase_createWindowSwigExplicitApplicationContextBase__SWIG_2(swigCPtr, name, w) : BitesPINVOKE.ApplicationContextBase_createWindow__SWIG_2(swigCPtr, name, w)), true);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual NativeWindowPair createWindow(string name) {
    NativeWindowPair ret = new NativeWindowPair((SwigDerivedClassHasMethod("createWindow", swigMethodTypes24) ? BitesPINVOKE.ApplicationContextBase_createWindowSwigExplicitApplicationContextBase__SWIG_3(swigCPtr, name) : BitesPINVOKE.ApplicationContextBase_createWindow__SWIG_3(swigCPtr, name)), true);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void destroyWindow(string name) {
    BitesPINVOKE.ApplicationContextBase_destroyWindow(swigCPtr, name);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  public FileSystemLayer getFSLayer() {
    FileSystemLayer ret = new FileSystemLayer(BitesPINVOKE.ApplicationContextBase_getFSLayer(swigCPtr), false);
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getDefaultMediaDir() {
    string ret = BitesPINVOKE.ApplicationContextBase_getDefaultMediaDir();
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  protected virtual void _destroyWindow(NativeWindowPair win) {
    if (SwigDerivedClassHasMethod("_destroyWindow", swigMethodTypes25)) BitesPINVOKE.ApplicationContextBase__destroyWindowSwigExplicitApplicationContextBase(swigCPtr, NativeWindowPair.getCPtr(win)); else BitesPINVOKE.ApplicationContextBase__destroyWindow(swigCPtr, NativeWindowPair.getCPtr(win));
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("frameStarted", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateApplicationContextBase_0(SwigDirectorMethodframeStarted);
    if (SwigDerivedClassHasMethod("frameRenderingQueued", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateApplicationContextBase_1(SwigDirectorMethodframeRenderingQueued);
    if (SwigDerivedClassHasMethod("frameEnded", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateApplicationContextBase_2(SwigDirectorMethodframeEnded);
    if (SwigDerivedClassHasMethod("windowMoved", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateApplicationContextBase_3(SwigDirectorMethodwindowMoved);
    if (SwigDerivedClassHasMethod("windowResized", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateApplicationContextBase_4(SwigDirectorMethodwindowResized);
    if (SwigDerivedClassHasMethod("windowClosing", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateApplicationContextBase_5(SwigDirectorMethodwindowClosing);
    if (SwigDerivedClassHasMethod("windowClosed", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateApplicationContextBase_6(SwigDirectorMethodwindowClosed);
    if (SwigDerivedClassHasMethod("windowFocusChange", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateApplicationContextBase_7(SwigDirectorMethodwindowFocusChange);
    if (SwigDerivedClassHasMethod("setup", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateApplicationContextBase_8(SwigDirectorMethodsetup);
    if (SwigDerivedClassHasMethod("createRoot", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateApplicationContextBase_9(SwigDirectorMethodcreateRoot);
    if (SwigDerivedClassHasMethod("oneTimeConfig", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateApplicationContextBase_10(SwigDirectorMethodoneTimeConfig);
    if (SwigDerivedClassHasMethod("setWindowGrab", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateApplicationContextBase_11(SwigDirectorMethodsetWindowGrab__SWIG_0);
    if (SwigDerivedClassHasMethod("setWindowGrab", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateApplicationContextBase_12(SwigDirectorMethodsetWindowGrab__SWIG_1);
    if (SwigDerivedClassHasMethod("getDisplayDPI", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateApplicationContextBase_13(SwigDirectorMethodgetDisplayDPI);
    if (SwigDerivedClassHasMethod("locateResources", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateApplicationContextBase_14(SwigDirectorMethodlocateResources);
    if (SwigDerivedClassHasMethod("loadResources", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateApplicationContextBase_15(SwigDirectorMethodloadResources);
    if (SwigDerivedClassHasMethod("reconfigure", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateApplicationContextBase_16(SwigDirectorMethodreconfigure);
    if (SwigDerivedClassHasMethod("shutdown", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateApplicationContextBase_17(SwigDirectorMethodshutdown);
    if (SwigDerivedClassHasMethod("pollEvents", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateApplicationContextBase_18(SwigDirectorMethodpollEvents);
    if (SwigDerivedClassHasMethod("addInputListener", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateApplicationContextBase_19(SwigDirectorMethodaddInputListener__SWIG_0);
    if (SwigDerivedClassHasMethod("removeInputListener", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateApplicationContextBase_20(SwigDirectorMethodremoveInputListener__SWIG_0);
    if (SwigDerivedClassHasMethod("createWindow", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateApplicationContextBase_21(SwigDirectorMethodcreateWindow__SWIG_0);
    if (SwigDerivedClassHasMethod("createWindow", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateApplicationContextBase_22(SwigDirectorMethodcreateWindow__SWIG_1);
    if (SwigDerivedClassHasMethod("createWindow", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateApplicationContextBase_23(SwigDirectorMethodcreateWindow__SWIG_2);
    if (SwigDerivedClassHasMethod("createWindow", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateApplicationContextBase_24(SwigDirectorMethodcreateWindow__SWIG_3);
    if (SwigDerivedClassHasMethod("_destroyWindow", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateApplicationContextBase_25(SwigDirectorMethod_destroyWindow);
    BitesPINVOKE.ApplicationContextBase_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ApplicationContextBase));
    return hasDerivedMethod;
  }

  private bool SwigDirectorMethodframeStarted(global::System.IntPtr evt) {
    return frameStarted(new FrameEvent(evt, false));
  }

  private bool SwigDirectorMethodframeRenderingQueued(global::System.IntPtr evt) {
    return frameRenderingQueued(new FrameEvent(evt, false));
  }

  private bool SwigDirectorMethodframeEnded(global::System.IntPtr evt) {
    return frameEnded(new FrameEvent(evt, false));
  }

  private void SwigDirectorMethodwindowMoved(global::System.IntPtr rw) {
    windowMoved((rw == global::System.IntPtr.Zero) ? null : new RenderWindow(rw, false));
  }

  private void SwigDirectorMethodwindowResized(global::System.IntPtr rw) {
    windowResized((rw == global::System.IntPtr.Zero) ? null : new RenderWindow(rw, false));
  }

  private bool SwigDirectorMethodwindowClosing(global::System.IntPtr rw) {
    return windowClosing((rw == global::System.IntPtr.Zero) ? null : new RenderWindow(rw, false));
  }

  private void SwigDirectorMethodwindowClosed(global::System.IntPtr rw) {
    windowClosed((rw == global::System.IntPtr.Zero) ? null : new RenderWindow(rw, false));
  }

  private void SwigDirectorMethodwindowFocusChange(global::System.IntPtr rw) {
    windowFocusChange((rw == global::System.IntPtr.Zero) ? null : new RenderWindow(rw, false));
  }

  private void SwigDirectorMethodsetup() {
    setup();
  }

  private void SwigDirectorMethodcreateRoot() {
    createRoot();
  }

  private bool SwigDirectorMethodoneTimeConfig() {
    return oneTimeConfig();
  }

  private void SwigDirectorMethodsetWindowGrab__SWIG_0(global::System.IntPtr win, bool grab) {
    setWindowGrab((win == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_SDL_Window(win, false), grab);
  }

  private void SwigDirectorMethodsetWindowGrab__SWIG_1(global::System.IntPtr win) {
    setWindowGrab((win == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_SDL_Window(win, false));
  }

  private float SwigDirectorMethodgetDisplayDPI() {
    return getDisplayDPI();
  }

  private void SwigDirectorMethodlocateResources() {
    locateResources();
  }

  private void SwigDirectorMethodloadResources() {
    loadResources();
  }

  private void SwigDirectorMethodreconfigure(string renderer, global::System.IntPtr options) {
    reconfigure(renderer, new NameValueMap(options, false));
  }

  private void SwigDirectorMethodshutdown() {
    shutdown();
  }

  private void SwigDirectorMethodpollEvents() {
    pollEvents();
  }

  private void SwigDirectorMethodaddInputListener__SWIG_0(global::System.IntPtr win, global::System.IntPtr lis) {
    addInputListener((win == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_SDL_Window(win, false), (lis == global::System.IntPtr.Zero) ? null : new InputListener(lis, false));
  }

  private void SwigDirectorMethodremoveInputListener__SWIG_0(global::System.IntPtr win, global::System.IntPtr lis) {
    removeInputListener((win == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_SDL_Window(win, false), (lis == global::System.IntPtr.Zero) ? null : new InputListener(lis, false));
  }

  private global::System.IntPtr SwigDirectorMethodcreateWindow__SWIG_0(string name, uint w, uint h, global::System.IntPtr miscParams) {
    return NativeWindowPair.getCPtr(createWindow(name, w, h, new NameValueMap(miscParams, true))).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodcreateWindow__SWIG_1(string name, uint w, uint h) {
    return NativeWindowPair.getCPtr(createWindow(name, w, h)).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodcreateWindow__SWIG_2(string name, uint w) {
    return NativeWindowPair.getCPtr(createWindow(name, w)).Handle;
  }

  private global::System.IntPtr SwigDirectorMethodcreateWindow__SWIG_3(string name) {
    return NativeWindowPair.getCPtr(createWindow(name)).Handle;
  }

  private void SwigDirectorMethod_destroyWindow(global::System.IntPtr win) {
    _destroyWindow(new NativeWindowPair(win, false));
  }

  public delegate bool SwigDelegateApplicationContextBase_0(global::System.IntPtr evt);
  public delegate bool SwigDelegateApplicationContextBase_1(global::System.IntPtr evt);
  public delegate bool SwigDelegateApplicationContextBase_2(global::System.IntPtr evt);
  public delegate void SwigDelegateApplicationContextBase_3(global::System.IntPtr rw);
  public delegate void SwigDelegateApplicationContextBase_4(global::System.IntPtr rw);
  public delegate bool SwigDelegateApplicationContextBase_5(global::System.IntPtr rw);
  public delegate void SwigDelegateApplicationContextBase_6(global::System.IntPtr rw);
  public delegate void SwigDelegateApplicationContextBase_7(global::System.IntPtr rw);
  public delegate void SwigDelegateApplicationContextBase_8();
  public delegate void SwigDelegateApplicationContextBase_9();
  public delegate bool SwigDelegateApplicationContextBase_10();
  public delegate void SwigDelegateApplicationContextBase_11(global::System.IntPtr win, bool grab);
  public delegate void SwigDelegateApplicationContextBase_12(global::System.IntPtr win);
  public delegate float SwigDelegateApplicationContextBase_13();
  public delegate void SwigDelegateApplicationContextBase_14();
  public delegate void SwigDelegateApplicationContextBase_15();
  public delegate void SwigDelegateApplicationContextBase_16(string renderer, global::System.IntPtr options);
  public delegate void SwigDelegateApplicationContextBase_17();
  public delegate void SwigDelegateApplicationContextBase_18();
  public delegate void SwigDelegateApplicationContextBase_19(global::System.IntPtr win, global::System.IntPtr lis);
  public delegate void SwigDelegateApplicationContextBase_20(global::System.IntPtr win, global::System.IntPtr lis);
  public delegate global::System.IntPtr SwigDelegateApplicationContextBase_21(string name, uint w, uint h, global::System.IntPtr miscParams);
  public delegate global::System.IntPtr SwigDelegateApplicationContextBase_22(string name, uint w, uint h);
  public delegate global::System.IntPtr SwigDelegateApplicationContextBase_23(string name, uint w);
  public delegate global::System.IntPtr SwigDelegateApplicationContextBase_24(string name);
  public delegate void SwigDelegateApplicationContextBase_25(global::System.IntPtr win);

  private SwigDelegateApplicationContextBase_0 swigDelegate0;
  private SwigDelegateApplicationContextBase_1 swigDelegate1;
  private SwigDelegateApplicationContextBase_2 swigDelegate2;
  private SwigDelegateApplicationContextBase_3 swigDelegate3;
  private SwigDelegateApplicationContextBase_4 swigDelegate4;
  private SwigDelegateApplicationContextBase_5 swigDelegate5;
  private SwigDelegateApplicationContextBase_6 swigDelegate6;
  private SwigDelegateApplicationContextBase_7 swigDelegate7;
  private SwigDelegateApplicationContextBase_8 swigDelegate8;
  private SwigDelegateApplicationContextBase_9 swigDelegate9;
  private SwigDelegateApplicationContextBase_10 swigDelegate10;
  private SwigDelegateApplicationContextBase_11 swigDelegate11;
  private SwigDelegateApplicationContextBase_12 swigDelegate12;
  private SwigDelegateApplicationContextBase_13 swigDelegate13;
  private SwigDelegateApplicationContextBase_14 swigDelegate14;
  private SwigDelegateApplicationContextBase_15 swigDelegate15;
  private SwigDelegateApplicationContextBase_16 swigDelegate16;
  private SwigDelegateApplicationContextBase_17 swigDelegate17;
  private SwigDelegateApplicationContextBase_18 swigDelegate18;
  private SwigDelegateApplicationContextBase_19 swigDelegate19;
  private SwigDelegateApplicationContextBase_20 swigDelegate20;
  private SwigDelegateApplicationContextBase_21 swigDelegate21;
  private SwigDelegateApplicationContextBase_22 swigDelegate22;
  private SwigDelegateApplicationContextBase_23 swigDelegate23;
  private SwigDelegateApplicationContextBase_24 swigDelegate24;
  private SwigDelegateApplicationContextBase_25 swigDelegate25;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(FrameEvent) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(FrameEvent) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(FrameEvent) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(RenderWindow) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(RenderWindow) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(RenderWindow) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(RenderWindow) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(RenderWindow) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(SWIGTYPE_p_SDL_Window), typeof(bool) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(SWIGTYPE_p_SDL_Window) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(string), typeof(NameValueMap) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(SWIGTYPE_p_SDL_Window), typeof(InputListener) };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(SWIGTYPE_p_SDL_Window), typeof(InputListener) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(string), typeof(uint), typeof(uint), typeof(NameValueMap) };
  private static global::System.Type[] swigMethodTypes22 = new global::System.Type[] { typeof(string), typeof(uint), typeof(uint) };
  private static global::System.Type[] swigMethodTypes23 = new global::System.Type[] { typeof(string), typeof(uint) };
  private static global::System.Type[] swigMethodTypes24 = new global::System.Type[] { typeof(string) };
  private static global::System.Type[] swigMethodTypes25 = new global::System.Type[] { typeof(NativeWindowPair) };
}

}