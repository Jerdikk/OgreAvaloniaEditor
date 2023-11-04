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

public class KeyboardEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal KeyboardEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KeyboardEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KeyboardEvent() {
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
          BitesPINVOKE.delete_KeyboardEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int type {
    set {
      BitesPINVOKE.KeyboardEvent_type_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = BitesPINVOKE.KeyboardEvent_type_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Keysym keysym {
    set {
      BitesPINVOKE.KeyboardEvent_keysym_set(swigCPtr, Keysym.getCPtr(value));
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = BitesPINVOKE.KeyboardEvent_keysym_get(swigCPtr);
      Keysym ret = (cPtr == global::System.IntPtr.Zero) ? null : new Keysym(cPtr, false);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte repeat {
    set {
      BitesPINVOKE.KeyboardEvent_repeat_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = BitesPINVOKE.KeyboardEvent_repeat_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public KeyboardEvent() : this(BitesPINVOKE.new_KeyboardEvent(), true) {
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
