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

public class RenderTargetListener : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RenderTargetListener(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderTargetListener obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RenderTargetListener() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_RenderTargetListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual void preRenderTargetUpdate(RenderTargetEvent evt) {
    if (SwigDerivedClassHasMethod("preRenderTargetUpdate", swigMethodTypes0)) OgrePINVOKE.RenderTargetListener_preRenderTargetUpdateSwigExplicitRenderTargetListener(swigCPtr, RenderTargetEvent.getCPtr(evt)); else OgrePINVOKE.RenderTargetListener_preRenderTargetUpdate(swigCPtr, RenderTargetEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void postRenderTargetUpdate(RenderTargetEvent evt) {
    if (SwigDerivedClassHasMethod("postRenderTargetUpdate", swigMethodTypes1)) OgrePINVOKE.RenderTargetListener_postRenderTargetUpdateSwigExplicitRenderTargetListener(swigCPtr, RenderTargetEvent.getCPtr(evt)); else OgrePINVOKE.RenderTargetListener_postRenderTargetUpdate(swigCPtr, RenderTargetEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void preViewportUpdate(RenderTargetViewportEvent evt) {
    if (SwigDerivedClassHasMethod("preViewportUpdate", swigMethodTypes2)) OgrePINVOKE.RenderTargetListener_preViewportUpdateSwigExplicitRenderTargetListener(swigCPtr, RenderTargetViewportEvent.getCPtr(evt)); else OgrePINVOKE.RenderTargetListener_preViewportUpdate(swigCPtr, RenderTargetViewportEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void postViewportUpdate(RenderTargetViewportEvent evt) {
    if (SwigDerivedClassHasMethod("postViewportUpdate", swigMethodTypes3)) OgrePINVOKE.RenderTargetListener_postViewportUpdateSwigExplicitRenderTargetListener(swigCPtr, RenderTargetViewportEvent.getCPtr(evt)); else OgrePINVOKE.RenderTargetListener_postViewportUpdate(swigCPtr, RenderTargetViewportEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void viewportAdded(RenderTargetViewportEvent evt) {
    if (SwigDerivedClassHasMethod("viewportAdded", swigMethodTypes4)) OgrePINVOKE.RenderTargetListener_viewportAddedSwigExplicitRenderTargetListener(swigCPtr, RenderTargetViewportEvent.getCPtr(evt)); else OgrePINVOKE.RenderTargetListener_viewportAdded(swigCPtr, RenderTargetViewportEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void viewportRemoved(RenderTargetViewportEvent evt) {
    if (SwigDerivedClassHasMethod("viewportRemoved", swigMethodTypes5)) OgrePINVOKE.RenderTargetListener_viewportRemovedSwigExplicitRenderTargetListener(swigCPtr, RenderTargetViewportEvent.getCPtr(evt)); else OgrePINVOKE.RenderTargetListener_viewportRemoved(swigCPtr, RenderTargetViewportEvent.getCPtr(evt));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public RenderTargetListener() : this(OgrePINVOKE.new_RenderTargetListener(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("preRenderTargetUpdate", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateRenderTargetListener_0(SwigDirectorMethodpreRenderTargetUpdate);
    if (SwigDerivedClassHasMethod("postRenderTargetUpdate", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateRenderTargetListener_1(SwigDirectorMethodpostRenderTargetUpdate);
    if (SwigDerivedClassHasMethod("preViewportUpdate", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateRenderTargetListener_2(SwigDirectorMethodpreViewportUpdate);
    if (SwigDerivedClassHasMethod("postViewportUpdate", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateRenderTargetListener_3(SwigDirectorMethodpostViewportUpdate);
    if (SwigDerivedClassHasMethod("viewportAdded", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateRenderTargetListener_4(SwigDirectorMethodviewportAdded);
    if (SwigDerivedClassHasMethod("viewportRemoved", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateRenderTargetListener_5(SwigDirectorMethodviewportRemoved);
    OgrePINVOKE.RenderTargetListener_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(RenderTargetListener));
    return hasDerivedMethod;
  }

  private void SwigDirectorMethodpreRenderTargetUpdate(global::System.IntPtr evt) {
    preRenderTargetUpdate(new RenderTargetEvent(evt, false));
  }

  private void SwigDirectorMethodpostRenderTargetUpdate(global::System.IntPtr evt) {
    postRenderTargetUpdate(new RenderTargetEvent(evt, false));
  }

  private void SwigDirectorMethodpreViewportUpdate(global::System.IntPtr evt) {
    preViewportUpdate(new RenderTargetViewportEvent(evt, false));
  }

  private void SwigDirectorMethodpostViewportUpdate(global::System.IntPtr evt) {
    postViewportUpdate(new RenderTargetViewportEvent(evt, false));
  }

  private void SwigDirectorMethodviewportAdded(global::System.IntPtr evt) {
    viewportAdded(new RenderTargetViewportEvent(evt, false));
  }

  private void SwigDirectorMethodviewportRemoved(global::System.IntPtr evt) {
    viewportRemoved(new RenderTargetViewportEvent(evt, false));
  }

  public delegate void SwigDelegateRenderTargetListener_0(global::System.IntPtr evt);
  public delegate void SwigDelegateRenderTargetListener_1(global::System.IntPtr evt);
  public delegate void SwigDelegateRenderTargetListener_2(global::System.IntPtr evt);
  public delegate void SwigDelegateRenderTargetListener_3(global::System.IntPtr evt);
  public delegate void SwigDelegateRenderTargetListener_4(global::System.IntPtr evt);
  public delegate void SwigDelegateRenderTargetListener_5(global::System.IntPtr evt);

  private SwigDelegateRenderTargetListener_0 swigDelegate0;
  private SwigDelegateRenderTargetListener_1 swigDelegate1;
  private SwigDelegateRenderTargetListener_2 swigDelegate2;
  private SwigDelegateRenderTargetListener_3 swigDelegate3;
  private SwigDelegateRenderTargetListener_4 swigDelegate4;
  private SwigDelegateRenderTargetListener_5 swigDelegate5;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(RenderTargetEvent) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(RenderTargetEvent) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(RenderTargetViewportEvent) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(RenderTargetViewportEvent) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(RenderTargetViewportEvent) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(RenderTargetViewportEvent) };
}

}
