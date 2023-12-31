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

public class CollisionWorld : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CollisionWorld(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CollisionWorld obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CollisionWorld() {
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
          OgreBulletPINVOKE.delete_CollisionWorld(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CollisionWorld(btCollisionWorld btWorld) : this(OgreBulletPINVOKE.new_CollisionWorld(btCollisionWorld.getCPtr(btWorld)), true) {
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public btCollisionObject addCollisionObject(Entity ent, ColliderType ct, int group, int mask) {
    global::System.IntPtr cPtr = OgreBulletPINVOKE.CollisionWorld_addCollisionObject__SWIG_0(swigCPtr, Entity.getCPtr(ent), (int)ct, group, mask);
    btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public btCollisionObject addCollisionObject(Entity ent, ColliderType ct, int group) {
    global::System.IntPtr cPtr = OgreBulletPINVOKE.CollisionWorld_addCollisionObject__SWIG_1(swigCPtr, Entity.getCPtr(ent), (int)ct, group);
    btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public btCollisionObject addCollisionObject(Entity ent, ColliderType ct) {
    global::System.IntPtr cPtr = OgreBulletPINVOKE.CollisionWorld_addCollisionObject__SWIG_2(swigCPtr, Entity.getCPtr(ent), (int)ct);
    btCollisionObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new btCollisionObject(cPtr, false);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void rayTest(Ray ray, RayResultCallback callback, float maxDist) {
    OgreBulletPINVOKE.CollisionWorld_rayTest__SWIG_0(swigCPtr, Ray.getCPtr(ray), RayResultCallback.getCPtr(callback), maxDist);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void rayTest(Ray ray, RayResultCallback callback) {
    OgreBulletPINVOKE.CollisionWorld_rayTest__SWIG_1(swigCPtr, Ray.getCPtr(ray), RayResultCallback.getCPtr(callback));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
