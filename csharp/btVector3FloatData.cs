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

public class btVector3FloatData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btVector3FloatData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btVector3FloatData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~btVector3FloatData() {
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
          OgreBulletPINVOKE.delete_btVector3FloatData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_float m_floats {
    set {
      OgreBulletPINVOKE.btVector3FloatData_m_floats_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
      if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgreBulletPINVOKE.btVector3FloatData_m_floats_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public btVector3FloatData() : this(OgreBulletPINVOKE.new_btVector3FloatData(), true) {
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
