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

public class Light : MovableObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Light(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.Light_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Light obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Light(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public float tempSquareDist {
    set {
      OgrePINVOKE.Light_tempSquareDist_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = OgrePINVOKE.Light_tempSquareDist_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void _calcTempSquareDist(Vector3 worldPos) {
    OgrePINVOKE.Light__calcTempSquareDist(swigCPtr, Vector3.getCPtr(worldPos));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Light() : this(OgrePINVOKE.new_Light__SWIG_0(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Light(string name) : this(OgrePINVOKE.new_Light__SWIG_1(name), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setType(Light.LightTypes type) {
    OgrePINVOKE.Light_setType(swigCPtr, (int)type);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Light.LightTypes getType() {
    Light.LightTypes ret = (Light.LightTypes)OgrePINVOKE.Light_getType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDiffuseColour(float red, float green, float blue) {
    OgrePINVOKE.Light_setDiffuseColour__SWIG_0(swigCPtr, red, green, blue);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDiffuseColour(ColourValue colour) {
    OgrePINVOKE.Light_setDiffuseColour__SWIG_1(swigCPtr, ColourValue.getCPtr(colour));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourValue getDiffuseColour() {
    ColourValue ret = new ColourValue(OgrePINVOKE.Light_getDiffuseColour(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSpecularColour(float red, float green, float blue) {
    OgrePINVOKE.Light_setSpecularColour__SWIG_0(swigCPtr, red, green, blue);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpecularColour(ColourValue colour) {
    OgrePINVOKE.Light_setSpecularColour__SWIG_1(swigCPtr, ColourValue.getCPtr(colour));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourValue getSpecularColour() {
    ColourValue ret = new ColourValue(OgrePINVOKE.Light_getSpecularColour(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAttenuation(float range, float constant, float linear, float quadratic) {
    OgrePINVOKE.Light_setAttenuation(swigCPtr, range, constant, linear, quadratic);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getAttenuationRange() {
    float ret = OgrePINVOKE.Light_getAttenuationRange(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getAttenuationConstant() {
    float ret = OgrePINVOKE.Light_getAttenuationConstant(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getAttenuationLinear() {
    float ret = OgrePINVOKE.Light_getAttenuationLinear(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getAttenuationQuadric() {
    float ret = OgrePINVOKE.Light_getAttenuationQuadric(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 getAttenuation() {
    Vector4 ret = new Vector4(OgrePINVOKE.Light_getAttenuation(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSpotlightRange(Radian innerAngle, Radian outerAngle, float falloff) {
    OgrePINVOKE.Light_setSpotlightRange__SWIG_0(swigCPtr, Radian.getCPtr(innerAngle), Radian.getCPtr(outerAngle), falloff);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpotlightRange(Radian innerAngle, Radian outerAngle) {
    OgrePINVOKE.Light_setSpotlightRange__SWIG_1(swigCPtr, Radian.getCPtr(innerAngle), Radian.getCPtr(outerAngle));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Radian getSpotlightInnerAngle() {
    Radian ret = new Radian(OgrePINVOKE.Light_getSpotlightInnerAngle(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Radian getSpotlightOuterAngle() {
    Radian ret = new Radian(OgrePINVOKE.Light_getSpotlightOuterAngle(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getSpotlightFalloff() {
    float ret = OgrePINVOKE.Light_getSpotlightFalloff(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSpotlightInnerAngle(Radian val) {
    OgrePINVOKE.Light_setSpotlightInnerAngle(swigCPtr, Radian.getCPtr(val));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpotlightOuterAngle(Radian val) {
    OgrePINVOKE.Light_setSpotlightOuterAngle(swigCPtr, Radian.getCPtr(val));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpotlightFalloff(float val) {
    OgrePINVOKE.Light_setSpotlightFalloff(swigCPtr, val);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpotlightNearClipDistance(float nearClip) {
    OgrePINVOKE.Light_setSpotlightNearClipDistance(swigCPtr, nearClip);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getSpotlightNearClipDistance() {
    float ret = OgrePINVOKE.Light_getSpotlightNearClipDistance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSourceSize(float width, float height) {
    OgrePINVOKE.Light_setSourceSize(swigCPtr, width, height);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 getSourceSize() {
    Vector2 ret = new Vector2(OgrePINVOKE.Light_getSourceSize(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 getDerivedSourceHalfWidth() {
    Vector3 ret = new Vector3(OgrePINVOKE.Light_getDerivedSourceHalfWidth(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 getDerivedSourceHalfHeight() {
    Vector3 ret = new Vector3(OgrePINVOKE.Light_getDerivedSourceHalfHeight(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPowerScale(float power) {
    OgrePINVOKE.Light_setPowerScale(swigCPtr, power);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getPowerScale() {
    float ret = OgrePINVOKE.Light_getPowerScale(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getBoundingRadius() {
    float ret = OgrePINVOKE.Light_getBoundingRadius(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AxisAlignedBox getBoundingBox() {
    AxisAlignedBox ret = new AxisAlignedBox(OgrePINVOKE.Light_getBoundingBox(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _updateRenderQueue(RenderQueue queue) {
    OgrePINVOKE.Light__updateRenderQueue(swigCPtr, RenderQueue.getCPtr(queue));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getMovableType() {
    string ret = OgrePINVOKE.Light_getMovableType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 getDerivedPosition(bool cameraRelativeIfSet) {
    Vector3 ret = new Vector3(OgrePINVOKE.Light_getDerivedPosition__SWIG_0(swigCPtr, cameraRelativeIfSet), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 getDerivedPosition() {
    Vector3 ret = new Vector3(OgrePINVOKE.Light_getDerivedPosition__SWIG_1(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 getDerivedDirection() {
    Vector3 ret = new Vector3(OgrePINVOKE.Light_getDerivedDirection(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new void setVisible(bool visible) {
    OgrePINVOKE.Light_setVisible(swigCPtr, visible);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4 getAs4DVector(bool cameraRelativeIfSet) {
    Vector4 ret = new Vector4(OgrePINVOKE.Light_getAs4DVector__SWIG_0(swigCPtr, cameraRelativeIfSet), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 getAs4DVector() {
    Vector4 ret = new Vector4(OgrePINVOKE.Light_getAs4DVector__SWIG_1(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual PlaneBoundedVolume _getNearClipVolume(Camera cam) {
    PlaneBoundedVolume ret = new PlaneBoundedVolume(OgrePINVOKE.Light__getNearClipVolume(swigCPtr, Camera.getCPtr(cam)), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_std__vectorT_Ogre__PlaneBoundedVolume_t _getFrustumClipVolumes(Camera cam) {
    SWIGTYPE_p_std__vectorT_Ogre__PlaneBoundedVolume_t ret = new SWIGTYPE_p_std__vectorT_Ogre__PlaneBoundedVolume_t(OgrePINVOKE.Light__getFrustumClipVolumes(swigCPtr, Camera.getCPtr(cam)), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getTypeFlags() {
    uint ret = OgrePINVOKE.Light_getTypeFlags(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__SharedPtrT_Ogre__AnimableValue_t createAnimableValue(string valueName) {
    SWIGTYPE_p_Ogre__SharedPtrT_Ogre__AnimableValue_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_Ogre__AnimableValue_t(OgrePINVOKE.Light_createAnimableValue(swigCPtr, valueName), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCustomShadowCameraSetup(ShadowCameraSetupPtr customShadowSetup) {
    OgrePINVOKE.Light_setCustomShadowCameraSetup(swigCPtr, ShadowCameraSetupPtr.getCPtr(customShadowSetup));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void resetCustomShadowCameraSetup() {
    OgrePINVOKE.Light_resetCustomShadowCameraSetup(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ShadowCameraSetupPtr getCustomShadowCameraSetup() {
    ShadowCameraSetupPtr ret = new ShadowCameraSetupPtr(OgrePINVOKE.Light_getCustomShadowCameraSetup(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void visitRenderables(Renderable.Visitor visitor, bool debugRenderables) {
    OgrePINVOKE.Light_visitRenderables__SWIG_0(swigCPtr, Renderable.Visitor.getCPtr(visitor), debugRenderables);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void visitRenderables(Renderable.Visitor visitor) {
    OgrePINVOKE.Light_visitRenderables__SWIG_1(swigCPtr, Renderable.Visitor.getCPtr(visitor));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint _getIndexInFrame() {
    uint ret = OgrePINVOKE.Light__getIndexInFrame(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyIndexInFrame(uint i) {
    OgrePINVOKE.Light__notifyIndexInFrame(swigCPtr, i);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setShadowFarDistance(float distance) {
    OgrePINVOKE.Light_setShadowFarDistance(swigCPtr, distance);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void resetShadowFarDistance() {
    OgrePINVOKE.Light_resetShadowFarDistance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getShadowFarDistance() {
    float ret = OgrePINVOKE.Light_getShadowFarDistance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getShadowFarDistanceSquared() {
    float ret = OgrePINVOKE.Light_getShadowFarDistanceSquared(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setShadowNearClipDistance(float nearClip) {
    OgrePINVOKE.Light_setShadowNearClipDistance(swigCPtr, nearClip);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getShadowNearClipDistance() {
    float ret = OgrePINVOKE.Light_getShadowNearClipDistance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _deriveShadowNearClipDistance(Camera maincam) {
    float ret = OgrePINVOKE.Light__deriveShadowNearClipDistance(swigCPtr, Camera.getCPtr(maincam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setShadowFarClipDistance(float farClip) {
    OgrePINVOKE.Light_setShadowFarClipDistance(swigCPtr, farClip);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getShadowFarClipDistance() {
    float ret = OgrePINVOKE.Light_getShadowFarClipDistance(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _deriveShadowFarClipDistance() {
    float ret = OgrePINVOKE.Light__deriveShadowFarClipDistance__SWIG_0(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _deriveShadowFarClipDistance(Camera arg0) {
    float ret = OgrePINVOKE.Light__deriveShadowFarClipDistance__SWIG_1(swigCPtr, Camera.getCPtr(arg0));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _setCameraRelative(Camera cam) {
    OgrePINVOKE.Light__setCameraRelative(swigCPtr, Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCustomParameter(ushort index, Vector4 value) {
    OgrePINVOKE.Light_setCustomParameter(swigCPtr, index, Vector4.getCPtr(value));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4 getCustomParameter(ushort index) {
    Vector4 ret = new Vector4(OgrePINVOKE.Light_getCustomParameter(swigCPtr, index), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void _updateCustomGpuParameter(ushort paramIndex, GpuProgramParameters.AutoConstantEntry constantEntry, GpuProgramParameters params_) {
    OgrePINVOKE.Light__updateCustomGpuParameter(swigCPtr, paramIndex, GpuProgramParameters.AutoConstantEntry.getCPtr(constantEntry), GpuProgramParameters.getCPtr(params_));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isInLightRange(Sphere sphere) {
    bool ret = OgrePINVOKE.Light_isInLightRange__SWIG_0(swigCPtr, Sphere.getCPtr(sphere));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isInLightRange(AxisAlignedBox container) {
    bool ret = OgrePINVOKE.Light_isInLightRange__SWIG_1(swigCPtr, AxisAlignedBox.getCPtr(container));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum LightTypes {
    LT_POINT = 0,
    LT_DIRECTIONAL = 1,
    LT_SPOTLIGHT = 2,
    LT_RECTLIGHT = 3
  }

}

}
