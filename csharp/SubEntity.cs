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

public class SubEntity : Renderable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SubEntity(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.SubEntity_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SubEntity obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public string getMaterialName() {
    string ret = OgrePINVOKE.SubEntity_getMaterialName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMaterialName(string name, string groupName) {
    OgrePINVOKE.SubEntity_setMaterialName__SWIG_0(swigCPtr, name, groupName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterialName(string name) {
    OgrePINVOKE.SubEntity_setMaterialName__SWIG_1(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterial(MaterialPtr material) {
    OgrePINVOKE.SubEntity_setMaterial(swigCPtr, MaterialPtr.getCPtr(material));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setVisible(bool visible) {
    OgrePINVOKE.SubEntity_setVisible(swigCPtr, visible);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isVisible() {
    bool ret = OgrePINVOKE.SubEntity_isVisible(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setRenderQueueGroup(byte queueID) {
    OgrePINVOKE.SubEntity_setRenderQueueGroup(swigCPtr, queueID);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRenderQueueGroupAndPriority(byte queueID, ushort priority) {
    OgrePINVOKE.SubEntity_setRenderQueueGroupAndPriority(swigCPtr, queueID, priority);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public byte getRenderQueueGroup() {
    byte ret = OgrePINVOKE.SubEntity_getRenderQueueGroup(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getRenderQueuePriority() {
    ushort ret = OgrePINVOKE.SubEntity_getRenderQueuePriority(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isRenderQueueGroupSet() {
    bool ret = OgrePINVOKE.SubEntity_isRenderQueueGroupSet(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isRenderQueuePrioritySet() {
    bool ret = OgrePINVOKE.SubEntity_isRenderQueuePrioritySet(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SubMesh getSubMesh() {
    global::System.IntPtr cPtr = OgrePINVOKE.SubEntity_getSubMesh(swigCPtr);
    SubMesh ret = (cPtr == global::System.IntPtr.Zero) ? null : new SubMesh(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Entity getParent() {
    global::System.IntPtr cPtr = OgrePINVOKE.SubEntity_getParent(swigCPtr);
    Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Entity(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr getMaterial() {
    MaterialPtr ret = new MaterialPtr(OgrePINVOKE.SubEntity_getMaterial(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getRenderOperation(RenderOperation op) {
    OgrePINVOKE.SubEntity_getRenderOperation(swigCPtr, RenderOperation.getCPtr(op));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setIndexDataStartIndex(uint start_index) {
    OgrePINVOKE.SubEntity_setIndexDataStartIndex(swigCPtr, start_index);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getIndexDataStartIndex() {
    uint ret = OgrePINVOKE.SubEntity_getIndexDataStartIndex(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setIndexDataEndIndex(uint end_index) {
    OgrePINVOKE.SubEntity_setIndexDataEndIndex(swigCPtr, end_index);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getIndexDataEndIndex() {
    uint ret = OgrePINVOKE.SubEntity_getIndexDataEndIndex(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resetIndexDataStartEndIndex() {
    OgrePINVOKE.SubEntity_resetIndexDataStartEndIndex(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getWorldTransforms(Matrix4 xform) {
    OgrePINVOKE.SubEntity_getWorldTransforms(swigCPtr, Matrix4.getCPtr(xform));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ushort getNumWorldTransforms() {
    ushort ret = OgrePINVOKE.SubEntity_getNumWorldTransforms(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getSquaredViewDepth(Camera cam) {
    float ret = OgrePINVOKE.SubEntity_getSquaredViewDepth(swigCPtr, Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_Ogre__Light_p_t getLights() {
    SWIGTYPE_p_std__vectorT_Ogre__Light_p_t ret = new SWIGTYPE_p_std__vectorT_Ogre__Light_p_t(OgrePINVOKE.SubEntity_getLights(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool getCastsShadows() {
    bool ret = OgrePINVOKE.SubEntity_getCastsShadows(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData _getSkelAnimVertexData() {
    global::System.IntPtr cPtr = OgrePINVOKE.SubEntity__getSkelAnimVertexData(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData _getSoftwareVertexAnimVertexData() {
    global::System.IntPtr cPtr = OgrePINVOKE.SubEntity__getSoftwareVertexAnimVertexData(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData _getHardwareVertexAnimVertexData() {
    global::System.IntPtr cPtr = OgrePINVOKE.SubEntity__getHardwareVertexAnimVertexData(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData getVertexDataForBinding() {
    global::System.IntPtr cPtr = OgrePINVOKE.SubEntity_getVertexDataForBinding(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _markBuffersUnusedForAnimation() {
    OgrePINVOKE.SubEntity__markBuffersUnusedForAnimation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _markBuffersUsedForAnimation() {
    OgrePINVOKE.SubEntity__markBuffersUsedForAnimation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool _getBuffersMarkedForAnimation() {
    bool ret = OgrePINVOKE.SubEntity__getBuffersMarkedForAnimation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _restoreBuffersForUnusedAnimation(bool hardwareAnimation) {
    OgrePINVOKE.SubEntity__restoreBuffersForUnusedAnimation(swigCPtr, hardwareAnimation);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void _updateCustomGpuParameter(GpuProgramParameters.AutoConstantEntry constantEntry, GpuProgramParameters params_) {
    OgrePINVOKE.SubEntity__updateCustomGpuParameter(swigCPtr, GpuProgramParameters.AutoConstantEntry.getCPtr(constantEntry), GpuProgramParameters.getCPtr(params_));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _invalidateCameraCache() {
    OgrePINVOKE.SubEntity__invalidateCameraCache(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}