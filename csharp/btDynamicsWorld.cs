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

public class btDynamicsWorld : btCollisionWorld {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal btDynamicsWorld(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgreBulletPINVOKE.btDynamicsWorld_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(btDynamicsWorld obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgreBulletPINVOKE.delete_btDynamicsWorld(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual int stepSimulation(float timeStep, int maxSubSteps, float fixedTimeStep) {
    int ret = OgreBulletPINVOKE.btDynamicsWorld_stepSimulation__SWIG_0(swigCPtr, timeStep, maxSubSteps, fixedTimeStep);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int stepSimulation(float timeStep, int maxSubSteps) {
    int ret = OgreBulletPINVOKE.btDynamicsWorld_stepSimulation__SWIG_1(swigCPtr, timeStep, maxSubSteps);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int stepSimulation(float timeStep) {
    int ret = OgreBulletPINVOKE.btDynamicsWorld_stepSimulation__SWIG_2(swigCPtr, timeStep);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void debugDrawWorld() {
    OgreBulletPINVOKE.btDynamicsWorld_debugDrawWorld(swigCPtr);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addConstraint(SWIGTYPE_p_btTypedConstraint constraint, bool disableCollisionsBetweenLinkedBodies) {
    OgreBulletPINVOKE.btDynamicsWorld_addConstraint__SWIG_0(swigCPtr, SWIGTYPE_p_btTypedConstraint.getCPtr(constraint), disableCollisionsBetweenLinkedBodies);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addConstraint(SWIGTYPE_p_btTypedConstraint constraint) {
    OgreBulletPINVOKE.btDynamicsWorld_addConstraint__SWIG_1(swigCPtr, SWIGTYPE_p_btTypedConstraint.getCPtr(constraint));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeConstraint(SWIGTYPE_p_btTypedConstraint constraint) {
    OgreBulletPINVOKE.btDynamicsWorld_removeConstraint(swigCPtr, SWIGTYPE_p_btTypedConstraint.getCPtr(constraint));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addAction(SWIGTYPE_p_btActionInterface action) {
    OgreBulletPINVOKE.btDynamicsWorld_addAction(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(action));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeAction(SWIGTYPE_p_btActionInterface action) {
    OgreBulletPINVOKE.btDynamicsWorld_removeAction(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(action));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setGravity(btVector3 gravity) {
    OgreBulletPINVOKE.btDynamicsWorld_setGravity(swigCPtr, btVector3.getCPtr(gravity));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual btVector3 getGravity() {
    btVector3 ret = new btVector3(OgreBulletPINVOKE.btDynamicsWorld_getGravity(swigCPtr), true);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void synchronizeMotionStates() {
    OgreBulletPINVOKE.btDynamicsWorld_synchronizeMotionStates(swigCPtr);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addRigidBody(btRigidBody body) {
    OgreBulletPINVOKE.btDynamicsWorld_addRigidBody__SWIG_0(swigCPtr, btRigidBody.getCPtr(body));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addRigidBody(btRigidBody body, int group, int mask) {
    OgreBulletPINVOKE.btDynamicsWorld_addRigidBody__SWIG_1(swigCPtr, btRigidBody.getCPtr(body), group, mask);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeRigidBody(btRigidBody body) {
    OgreBulletPINVOKE.btDynamicsWorld_removeRigidBody(swigCPtr, btRigidBody.getCPtr(body));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setConstraintSolver(SWIGTYPE_p_btConstraintSolver solver) {
    OgreBulletPINVOKE.btDynamicsWorld_setConstraintSolver(swigCPtr, SWIGTYPE_p_btConstraintSolver.getCPtr(solver));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_btConstraintSolver getConstraintSolver() {
    global::System.IntPtr cPtr = OgreBulletPINVOKE.btDynamicsWorld_getConstraintSolver(swigCPtr);
    SWIGTYPE_p_btConstraintSolver ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_btConstraintSolver(cPtr, false);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int getNumConstraints() {
    int ret = OgreBulletPINVOKE.btDynamicsWorld_getNumConstraints(swigCPtr);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_btTypedConstraint getConstraint(int index) {
    global::System.IntPtr cPtr = OgreBulletPINVOKE.btDynamicsWorld_getConstraint__SWIG_0(swigCPtr, index);
    SWIGTYPE_p_btTypedConstraint ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_btTypedConstraint(cPtr, false);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual btDynamicsWorldType getWorldType() {
    btDynamicsWorldType ret = (btDynamicsWorldType)OgreBulletPINVOKE.btDynamicsWorld_getWorldType(swigCPtr);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void clearForces() {
    OgreBulletPINVOKE.btDynamicsWorld_clearForces(swigCPtr);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setInternalTickCallback(SWIGTYPE_p_f_p_btDynamicsWorld_float__void cb, global::System.IntPtr worldUserInfo, bool isPreTick) {
    OgreBulletPINVOKE.btDynamicsWorld_setInternalTickCallback__SWIG_0(swigCPtr, SWIGTYPE_p_f_p_btDynamicsWorld_float__void.getCPtr(cb), worldUserInfo, isPreTick);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setInternalTickCallback(SWIGTYPE_p_f_p_btDynamicsWorld_float__void cb, global::System.IntPtr worldUserInfo) {
    OgreBulletPINVOKE.btDynamicsWorld_setInternalTickCallback__SWIG_1(swigCPtr, SWIGTYPE_p_f_p_btDynamicsWorld_float__void.getCPtr(cb), worldUserInfo);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setInternalTickCallback(SWIGTYPE_p_f_p_btDynamicsWorld_float__void cb) {
    OgreBulletPINVOKE.btDynamicsWorld_setInternalTickCallback__SWIG_2(swigCPtr, SWIGTYPE_p_f_p_btDynamicsWorld_float__void.getCPtr(cb));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setWorldUserInfo(global::System.IntPtr worldUserInfo) {
    OgreBulletPINVOKE.btDynamicsWorld_setWorldUserInfo(swigCPtr, worldUserInfo);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public global::System.IntPtr getWorldUserInfo() {
    global::System.IntPtr ret = OgreBulletPINVOKE.btDynamicsWorld_getWorldUserInfo(swigCPtr);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_btContactSolverInfo getSolverInfo() {
    SWIGTYPE_p_btContactSolverInfo ret = new SWIGTYPE_p_btContactSolverInfo(OgreBulletPINVOKE.btDynamicsWorld_getSolverInfo__SWIG_0(swigCPtr), false);
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void addVehicle(SWIGTYPE_p_btActionInterface vehicle) {
    OgreBulletPINVOKE.btDynamicsWorld_addVehicle(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(vehicle));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeVehicle(SWIGTYPE_p_btActionInterface vehicle) {
    OgreBulletPINVOKE.btDynamicsWorld_removeVehicle(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(vehicle));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addCharacter(SWIGTYPE_p_btActionInterface character) {
    OgreBulletPINVOKE.btDynamicsWorld_addCharacter(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(character));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeCharacter(SWIGTYPE_p_btActionInterface character) {
    OgreBulletPINVOKE.btDynamicsWorld_removeCharacter(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(character));
    if (OgreBulletPINVOKE.SWIGPendingException.Pending) throw OgreBulletPINVOKE.SWIGPendingException.Retrieve();
  }

}

}