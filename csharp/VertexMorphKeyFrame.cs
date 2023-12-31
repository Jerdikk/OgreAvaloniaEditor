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

public class VertexMorphKeyFrame : KeyFrame {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VertexMorphKeyFrame(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.VertexMorphKeyFrame_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VertexMorphKeyFrame obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_VertexMorphKeyFrame(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public VertexMorphKeyFrame(AnimationTrack parent, float time) : this(OgrePINVOKE.new_VertexMorphKeyFrame(AnimationTrack.getCPtr(parent), time), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setVertexBuffer(HardwareVertexBufferPtr buf) {
    OgrePINVOKE.VertexMorphKeyFrame_setVertexBuffer(swigCPtr, HardwareVertexBufferPtr.getCPtr(buf));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareVertexBufferPtr getVertexBuffer() {
    HardwareVertexBufferPtr ret = new HardwareVertexBufferPtr(OgrePINVOKE.VertexMorphKeyFrame_getVertexBuffer(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override KeyFrame _clone(AnimationTrack newParent) {
    global::System.IntPtr cPtr = OgrePINVOKE.VertexMorphKeyFrame__clone(swigCPtr, AnimationTrack.getCPtr(newParent));
    KeyFrame ret = (cPtr == global::System.IntPtr.Zero) ? null : new KeyFrame(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
