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

public class RenderPriorityGroup : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RenderPriorityGroup(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderPriorityGroup obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RenderPriorityGroup() {
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
          OgrePINVOKE.delete_RenderPriorityGroup(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public RenderPriorityGroup(RenderQueueGroup parent, bool splitPassesByLightingType, bool splitNoShadowPasses, bool shadowCastersNotReceivers) : this(OgrePINVOKE.new_RenderPriorityGroup(RenderQueueGroup.getCPtr(parent), splitPassesByLightingType, splitNoShadowPasses, shadowCastersNotReceivers), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public QueuedRenderableCollection getSolidsBasic() {
    QueuedRenderableCollection ret = new QueuedRenderableCollection(OgrePINVOKE.RenderPriorityGroup_getSolidsBasic(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueuedRenderableCollection getSolidsDiffuseSpecular() {
    QueuedRenderableCollection ret = new QueuedRenderableCollection(OgrePINVOKE.RenderPriorityGroup_getSolidsDiffuseSpecular(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueuedRenderableCollection getSolidsDecal() {
    QueuedRenderableCollection ret = new QueuedRenderableCollection(OgrePINVOKE.RenderPriorityGroup_getSolidsDecal(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueuedRenderableCollection getSolidsNoShadowReceive() {
    QueuedRenderableCollection ret = new QueuedRenderableCollection(OgrePINVOKE.RenderPriorityGroup_getSolidsNoShadowReceive(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueuedRenderableCollection getTransparentsUnsorted() {
    QueuedRenderableCollection ret = new QueuedRenderableCollection(OgrePINVOKE.RenderPriorityGroup_getTransparentsUnsorted(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueuedRenderableCollection getTransparents() {
    QueuedRenderableCollection ret = new QueuedRenderableCollection(OgrePINVOKE.RenderPriorityGroup_getTransparents(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resetOrganisationModes() {
    OgrePINVOKE.RenderPriorityGroup_resetOrganisationModes(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addOrganisationMode(QueuedRenderableCollection.OrganisationMode om) {
    OgrePINVOKE.RenderPriorityGroup_addOrganisationMode(swigCPtr, (int)om);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void defaultOrganisationMode() {
    OgrePINVOKE.RenderPriorityGroup_defaultOrganisationMode(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addRenderable(Renderable pRend, Technique pTech) {
    OgrePINVOKE.RenderPriorityGroup_addRenderable(swigCPtr, Renderable.getCPtr(pRend), Technique.getCPtr(pTech));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void sort(Camera cam) {
    OgrePINVOKE.RenderPriorityGroup_sort(swigCPtr, Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    OgrePINVOKE.RenderPriorityGroup_clear(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSplitPassesByLightingType(bool split) {
    OgrePINVOKE.RenderPriorityGroup_setSplitPassesByLightingType(swigCPtr, split);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSplitNoShadowPasses(bool split) {
    OgrePINVOKE.RenderPriorityGroup_setSplitNoShadowPasses(swigCPtr, split);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setShadowCastersCannotBeReceivers(bool ind) {
    OgrePINVOKE.RenderPriorityGroup_setShadowCastersCannotBeReceivers(swigCPtr, ind);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void merge(RenderPriorityGroup rhs) {
    OgrePINVOKE.RenderPriorityGroup_merge(swigCPtr, RenderPriorityGroup.getCPtr(rhs));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}