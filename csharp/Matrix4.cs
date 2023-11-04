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

public class Matrix4 : TransformBaseReal {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Matrix4(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.Matrix4_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Matrix4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Matrix4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Matrix4() : this(OgrePINVOKE.new_Matrix4__SWIG_0(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) : this(OgrePINVOKE.new_Matrix4__SWIG_1(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix4(SWIGTYPE_p_float arr) : this(OgrePINVOKE.new_Matrix4__SWIG_3(SWIGTYPE_p_float.getCPtr(arr)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix4(Matrix3 m3x3) : this(OgrePINVOKE.new_Matrix4__SWIG_4(Matrix3.getCPtr(m3x3)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix4(Quaternion rot) : this(OgrePINVOKE.new_Matrix4__SWIG_5(Quaternion.getCPtr(rot)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static Matrix4 ZERO {
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.Matrix4_ZERO_get();
      Matrix4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Matrix4(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Matrix4 IDENTITY {
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.Matrix4_IDENTITY_get();
      Matrix4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Matrix4(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Matrix4 CLIPSPACE2DTOIMAGESPACE {
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.Matrix4_CLIPSPACE2DTOIMAGESPACE_get();
      Matrix4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Matrix4(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Matrix4 __mul__(float scalar) {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Matrix4___mul____SWIG_0(swigCPtr, scalar), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 adjoint() {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Matrix4_adjoint(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 inverse() {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Matrix4_inverse(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = OgrePINVOKE.Matrix4_ToString(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 __mul__(Vector4 v) {
    Vector4 ret = new Vector4(OgrePINVOKE.Matrix4___mul____SWIG_1(swigCPtr, Vector4.getCPtr(v)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 __mul__(Vector3 v) {
    Vector3 ret = new Vector3(OgrePINVOKE.Matrix4___mul____SWIG_2(swigCPtr, Vector3.getCPtr(v)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 __mul__(Matrix4 m) {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Matrix4___mul____SWIG_3(swigCPtr, Matrix4.getCPtr(m)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 __add__(Matrix4 m) {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Matrix4___add__(swigCPtr, Matrix4.getCPtr(m)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 __sub__(Matrix4 m) {
    Matrix4 ret = new Matrix4(OgrePINVOKE.Matrix4___sub__(swigCPtr, Matrix4.getCPtr(m)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float __getitem__(int row, int column) {
    float ret = OgrePINVOKE.Matrix4___getitem__(swigCPtr, row, column);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
