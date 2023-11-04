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

public class Entity : MovableObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Entity(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.Entity_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Entity obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Entity(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public MeshPtr getMesh() {
    MeshPtr ret = new MeshPtr(OgrePINVOKE.Entity_getMesh(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SubEntity getSubEntity(uint index) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getSubEntity__SWIG_0(swigCPtr, index);
    SubEntity ret = (cPtr == global::System.IntPtr.Zero) ? null : new SubEntity(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SubEntity getSubEntity(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getSubEntity__SWIG_1(swigCPtr, name);
    SubEntity ret = (cPtr == global::System.IntPtr.Zero) ? null : new SubEntity(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNumSubEntities() {
    uint ret = OgrePINVOKE.Entity_getNumSubEntities(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SubEntityList getSubEntities() {
    SubEntityList ret = new SubEntityList(OgrePINVOKE.Entity_getSubEntities(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Entity clone(string newName) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_clone(swigCPtr, newName);
    Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Entity(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMaterialName(string name, string groupName) {
    OgrePINVOKE.Entity_setMaterialName__SWIG_0(swigCPtr, name, groupName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterialName(string name) {
    OgrePINVOKE.Entity_setMaterialName__SWIG_1(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterial(MaterialPtr material) {
    OgrePINVOKE.Entity_setMaterial(swigCPtr, MaterialPtr.getCPtr(material));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void _releaseManualHardwareResources() {
    OgrePINVOKE.Entity__releaseManualHardwareResources(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void _restoreManualHardwareResources() {
    OgrePINVOKE.Entity__restoreManualHardwareResources(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyCurrentCamera(Camera cam) {
    OgrePINVOKE.Entity__notifyCurrentCamera(swigCPtr, Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRenderQueueGroup(byte queueID) {
    OgrePINVOKE.Entity_setRenderQueueGroup(swigCPtr, queueID);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRenderQueueGroupAndPriority(byte queueID, ushort priority) {
    OgrePINVOKE.Entity_setRenderQueueGroupAndPriority(swigCPtr, queueID, priority);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public AxisAlignedBox getBoundingBox() {
    AxisAlignedBox ret = new AxisAlignedBox(OgrePINVOKE.Entity_getBoundingBox(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AxisAlignedBox getChildObjectsBoundingBox() {
    AxisAlignedBox ret = new AxisAlignedBox(OgrePINVOKE.Entity_getChildObjectsBoundingBox(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _updateRenderQueue(RenderQueue queue) {
    OgrePINVOKE.Entity__updateRenderQueue(swigCPtr, RenderQueue.getCPtr(queue));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getMovableType() {
    string ret = OgrePINVOKE.Entity_getMovableType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AnimationState getAnimationState(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getAnimationState(swigCPtr, name);
    AnimationState ret = (cPtr == global::System.IntPtr.Zero) ? null : new AnimationState(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasAnimationState(string name) {
    bool ret = OgrePINVOKE.Entity_hasAnimationState(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AnimationStateSet getAllAnimationStates() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getAllAnimationStates(swigCPtr);
    AnimationStateSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new AnimationStateSet(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDisplaySkeleton(bool display) {
    OgrePINVOKE.Entity_setDisplaySkeleton(swigCPtr, display);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getDisplaySkeleton() {
    bool ret = OgrePINVOKE.Entity_getDisplaySkeleton(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNumManualLodLevels() {
    uint ret = OgrePINVOKE.Entity_getNumManualLodLevels(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getCurrentLodIndex() {
    ushort ret = OgrePINVOKE.Entity_getCurrentLodIndex(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Entity getManualLodLevel(uint index) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getManualLodLevel(swigCPtr, index);
    Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Entity(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMeshLodBias(float factor, ushort maxDetailIndex, ushort minDetailIndex) {
    OgrePINVOKE.Entity_setMeshLodBias__SWIG_0(swigCPtr, factor, maxDetailIndex, minDetailIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMeshLodBias(float factor, ushort maxDetailIndex) {
    OgrePINVOKE.Entity_setMeshLodBias__SWIG_1(swigCPtr, factor, maxDetailIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMeshLodBias(float factor) {
    OgrePINVOKE.Entity_setMeshLodBias__SWIG_2(swigCPtr, factor);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterialLodBias(float factor, ushort maxDetailIndex, ushort minDetailIndex) {
    OgrePINVOKE.Entity_setMaterialLodBias__SWIG_0(swigCPtr, factor, maxDetailIndex, minDetailIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterialLodBias(float factor, ushort maxDetailIndex) {
    OgrePINVOKE.Entity_setMaterialLodBias__SWIG_1(swigCPtr, factor, maxDetailIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterialLodBias(float factor) {
    OgrePINVOKE.Entity_setMaterialLodBias__SWIG_2(swigCPtr, factor);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPolygonModeOverrideable(bool PolygonModeOverrideable) {
    OgrePINVOKE.Entity_setPolygonModeOverrideable(swigCPtr, PolygonModeOverrideable);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__TagPoint attachObjectToBone(string boneName, MovableObject pMovable, Quaternion offsetOrientation, Vector3 offsetPosition) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_attachObjectToBone__SWIG_0(swigCPtr, boneName, MovableObject.getCPtr(pMovable), Quaternion.getCPtr(offsetOrientation), Vector3.getCPtr(offsetPosition));
    SWIGTYPE_p_Ogre__TagPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__TagPoint(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__TagPoint attachObjectToBone(string boneName, MovableObject pMovable, Quaternion offsetOrientation) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_attachObjectToBone__SWIG_1(swigCPtr, boneName, MovableObject.getCPtr(pMovable), Quaternion.getCPtr(offsetOrientation));
    SWIGTYPE_p_Ogre__TagPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__TagPoint(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__TagPoint attachObjectToBone(string boneName, MovableObject pMovable) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_attachObjectToBone__SWIG_2(swigCPtr, boneName, MovableObject.getCPtr(pMovable));
    SWIGTYPE_p_Ogre__TagPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__TagPoint(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MovableObject detachObjectFromBone(string movableName) {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_detachObjectFromBone__SWIG_0(swigCPtr, movableName);
    MovableObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new MovableObject(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void detachObjectFromBone(MovableObject obj) {
    OgrePINVOKE.Entity_detachObjectFromBone__SWIG_1(swigCPtr, MovableObject.getCPtr(obj));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void detachAllObjectsFromBone() {
    OgrePINVOKE.Entity_detachAllObjectsFromBone(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public MovableObjectList getAttachedObjects() {
    MovableObjectList ret = new MovableObjectList(OgrePINVOKE.Entity_getAttachedObjects(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getBoundingRadius() {
    float ret = OgrePINVOKE.Entity_getBoundingRadius(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override AxisAlignedBox getWorldBoundingBox(bool derive) {
    AxisAlignedBox ret = new AxisAlignedBox(OgrePINVOKE.Entity_getWorldBoundingBox__SWIG_0(swigCPtr, derive), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override AxisAlignedBox getWorldBoundingBox() {
    AxisAlignedBox ret = new AxisAlignedBox(OgrePINVOKE.Entity_getWorldBoundingBox__SWIG_1(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Sphere getWorldBoundingSphere(bool derive) {
    Sphere ret = new Sphere(OgrePINVOKE.Entity_getWorldBoundingSphere__SWIG_0(swigCPtr, derive), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Sphere getWorldBoundingSphere() {
    Sphere ret = new Sphere(OgrePINVOKE.Entity_getWorldBoundingSphere__SWIG_1(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_Ogre__EdgeData getEdgeList() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getEdgeList(swigCPtr);
    SWIGTYPE_p_Ogre__EdgeData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__EdgeData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_std__vectorT_Ogre__ShadowRenderable_p_t getShadowVolumeRenderableList(Light light, HardwareIndexBufferPtr indexBuffer, SWIGTYPE_p_size_t indexBufferUsedSize, float extrusionDistance, int flags) {
    SWIGTYPE_p_std__vectorT_Ogre__ShadowRenderable_p_t ret = new SWIGTYPE_p_std__vectorT_Ogre__ShadowRenderable_p_t(OgrePINVOKE.Entity_getShadowVolumeRenderableList__SWIG_0(swigCPtr, Light.getCPtr(light), HardwareIndexBufferPtr.getCPtr(indexBuffer), SWIGTYPE_p_size_t.getCPtr(indexBufferUsedSize), extrusionDistance, flags), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_std__vectorT_Ogre__ShadowRenderable_p_t getShadowVolumeRenderableList(Light light, HardwareIndexBufferPtr indexBuffer, SWIGTYPE_p_size_t indexBufferUsedSize, float extrusionDistance) {
    SWIGTYPE_p_std__vectorT_Ogre__ShadowRenderable_p_t ret = new SWIGTYPE_p_std__vectorT_Ogre__ShadowRenderable_p_t(OgrePINVOKE.Entity_getShadowVolumeRenderableList__SWIG_1(swigCPtr, Light.getCPtr(light), HardwareIndexBufferPtr.getCPtr(indexBuffer), SWIGTYPE_p_size_t.getCPtr(indexBufferUsedSize), extrusionDistance), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Affine3 _getBoneMatrices() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity__getBoneMatrices(swigCPtr);
    Affine3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Affine3(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort _getNumBoneMatrices() {
    ushort ret = OgrePINVOKE.Entity__getNumBoneMatrices(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasSkeleton() {
    bool ret = OgrePINVOKE.Entity_hasSkeleton(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SkeletonInstance getSkeleton() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getSkeleton(swigCPtr);
    SkeletonInstance ret = (cPtr == global::System.IntPtr.Zero) ? null : new SkeletonInstance(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isHardwareAnimationEnabled() {
    bool ret = OgrePINVOKE.Entity_isHardwareAnimationEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyAttached(Node parent, bool isTagPoint) {
    OgrePINVOKE.Entity__notifyAttached__SWIG_0(swigCPtr, Node.getCPtr(parent), isTagPoint);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyAttached(Node parent) {
    OgrePINVOKE.Entity__notifyAttached__SWIG_1(swigCPtr, Node.getCPtr(parent));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public int getSoftwareAnimationRequests() {
    int ret = OgrePINVOKE.Entity_getSoftwareAnimationRequests(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getSoftwareAnimationNormalsRequests() {
    int ret = OgrePINVOKE.Entity_getSoftwareAnimationNormalsRequests(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addSoftwareAnimationRequest(bool normalsAlso) {
    OgrePINVOKE.Entity_addSoftwareAnimationRequest(swigCPtr, normalsAlso);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeSoftwareAnimationRequest(bool normalsAlso) {
    OgrePINVOKE.Entity_removeSoftwareAnimationRequest(swigCPtr, normalsAlso);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void shareSkeletonInstanceWith(Entity entity) {
    OgrePINVOKE.Entity_shareSkeletonInstanceWith(swigCPtr, Entity.getCPtr(entity));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool hasVertexAnimation() {
    bool ret = OgrePINVOKE.Entity_hasVertexAnimation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void stopSharingSkeletonInstance() {
    OgrePINVOKE.Entity_stopSharingSkeletonInstance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool sharesSkeletonInstance() {
    bool ret = OgrePINVOKE.Entity_sharesSkeletonInstance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__setT_Ogre__Entity_p_t getSkeletonInstanceSharingSet() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getSkeletonInstanceSharingSet(swigCPtr);
    SWIGTYPE_p_std__setT_Ogre__Entity_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__setT_Ogre__Entity_p_t(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void refreshAvailableAnimationState() {
    OgrePINVOKE.Entity_refreshAvailableAnimationState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _updateAnimation() {
    OgrePINVOKE.Entity__updateAnimation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool _isAnimated() {
    bool ret = OgrePINVOKE.Entity__isAnimated(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool _isSkeletonAnimated() {
    bool ret = OgrePINVOKE.Entity__isSkeletonAnimated(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData _getSkelAnimVertexData() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity__getSkelAnimVertexData(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData _getSoftwareVertexAnimVertexData() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity__getSoftwareVertexAnimVertexData(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData _getHardwareVertexAnimVertexData() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity__getHardwareVertexAnimVertexData(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getTypeFlags() {
    uint ret = OgrePINVOKE.Entity_getTypeFlags(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData getVertexDataForBinding() {
    global::System.IntPtr cPtr = OgrePINVOKE.Entity_getVertexDataForBinding(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Entity.VertexDataBindChoice chooseVertexDataForBinding(bool hasVertexAnim) {
    Entity.VertexDataBindChoice ret = (Entity.VertexDataBindChoice)OgrePINVOKE.Entity_chooseVertexDataForBinding(swigCPtr, hasVertexAnim);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool _getBuffersMarkedForAnimation() {
    bool ret = OgrePINVOKE.Entity__getBuffersMarkedForAnimation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _markBuffersUsedForAnimation() {
    OgrePINVOKE.Entity__markBuffersUsedForAnimation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isInitialised() {
    bool ret = OgrePINVOKE.Entity_isInitialised(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _initialise(bool forceReinitialise) {
    OgrePINVOKE.Entity__initialise__SWIG_0(swigCPtr, forceReinitialise);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _initialise() {
    OgrePINVOKE.Entity__initialise__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _deinitialise() {
    OgrePINVOKE.Entity__deinitialise(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadingComplete(Resource res) {
    OgrePINVOKE.Entity_loadingComplete(swigCPtr, Resource.getCPtr(res));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void visitRenderables(Renderable.Visitor visitor, bool debugRenderables) {
    OgrePINVOKE.Entity_visitRenderables__SWIG_0(swigCPtr, Renderable.Visitor.getCPtr(visitor), debugRenderables);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void visitRenderables(Renderable.Visitor visitor) {
    OgrePINVOKE.Entity_visitRenderables__SWIG_1(swigCPtr, Renderable.Visitor.getCPtr(visitor));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float _getMeshLodFactorTransformed() {
    float ret = OgrePINVOKE.Entity__getMeshLodFactorTransformed(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSkipAnimationStateUpdate(bool skip) {
    OgrePINVOKE.Entity_setSkipAnimationStateUpdate(swigCPtr, skip);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getSkipAnimationStateUpdate() {
    bool ret = OgrePINVOKE.Entity_getSkipAnimationStateUpdate(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAlwaysUpdateMainSkeleton(bool update) {
    OgrePINVOKE.Entity_setAlwaysUpdateMainSkeleton(swigCPtr, update);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getAlwaysUpdateMainSkeleton() {
    bool ret = OgrePINVOKE.Entity_getAlwaysUpdateMainSkeleton(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setUpdateBoundingBoxFromSkeleton(bool update) {
    OgrePINVOKE.Entity_setUpdateBoundingBoxFromSkeleton(swigCPtr, update);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getUpdateBoundingBoxFromSkeleton() {
    bool ret = OgrePINVOKE.Entity_getUpdateBoundingBoxFromSkeleton(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum VertexDataBindChoice {
    BIND_ORIGINAL,
    BIND_SOFTWARE_SKELETAL,
    BIND_SOFTWARE_MORPH,
    BIND_HARDWARE_MORPH
  }

}

}