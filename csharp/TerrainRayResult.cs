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

public class TerrainRayResult : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TerrainRayResult(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TerrainRayResult obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TerrainRayResult() {
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
          OgreTerrainPINVOKE.delete_TerrainRayResult(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TerrainRayResult() : this(OgreTerrainPINVOKE.new_TerrainRayResult__SWIG_0(), true) {
    if (OgreTerrainPINVOKE.SWIGPendingException.Pending) throw OgreTerrainPINVOKE.SWIGPendingException.Retrieve();
  }

  public TerrainRayResult(bool first, Vector3 second) : this(OgreTerrainPINVOKE.new_TerrainRayResult__SWIG_1(first, Vector3.getCPtr(second)), true) {
    if (OgreTerrainPINVOKE.SWIGPendingException.Pending) throw OgreTerrainPINVOKE.SWIGPendingException.Retrieve();
  }

  public TerrainRayResult(TerrainRayResult other) : this(OgreTerrainPINVOKE.new_TerrainRayResult__SWIG_2(TerrainRayResult.getCPtr(other)), true) {
    if (OgreTerrainPINVOKE.SWIGPendingException.Pending) throw OgreTerrainPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool first {
    set {
      OgreTerrainPINVOKE.TerrainRayResult_first_set(swigCPtr, value);
      if (OgreTerrainPINVOKE.SWIGPendingException.Pending) throw OgreTerrainPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = OgreTerrainPINVOKE.TerrainRayResult_first_get(swigCPtr);
      if (OgreTerrainPINVOKE.SWIGPendingException.Pending) throw OgreTerrainPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Vector3 second {
    set {
      OgreTerrainPINVOKE.TerrainRayResult_second_set(swigCPtr, Vector3.getCPtr(value));
      if (OgreTerrainPINVOKE.SWIGPendingException.Pending) throw OgreTerrainPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgreTerrainPINVOKE.TerrainRayResult_second_get(swigCPtr);
      Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
      if (OgreTerrainPINVOKE.SWIGPendingException.Pending) throw OgreTerrainPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}