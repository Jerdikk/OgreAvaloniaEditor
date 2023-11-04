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

public class OverlayElementPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OverlayElementPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OverlayElementPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OverlayElementPtr() {
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
          OgreOverlayPINVOKE.delete_OverlayElementPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public OverlayElementPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgreOverlayPINVOKE.new_OverlayElementPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public OverlayElementPtr() : this(OgreOverlayPINVOKE.new_OverlayElementPtr__SWIG_1(), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public OverlayElementPtr(OverlayElementPtr r) : this(OgreOverlayPINVOKE.new_OverlayElementPtr__SWIG_2(OverlayElementPtr.getCPtr(r)), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public OverlayElement __deref__() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr___deref__(swigCPtr);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string DEFAULT_RESOURCE_GROUP {
    get {
      string ret = OgreOverlayPINVOKE.OverlayElementPtr_DEFAULT_RESOURCE_GROUP_get(swigCPtr);
      if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void initialise() {
    OgreOverlayPINVOKE.OverlayElementPtr_initialise(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _releaseManualHardwareResources() {
    OgreOverlayPINVOKE.OverlayElementPtr__releaseManualHardwareResources(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _restoreManualHardwareResources() {
    OgreOverlayPINVOKE.OverlayElementPtr__restoreManualHardwareResources(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = OgreOverlayPINVOKE.OverlayElementPtr_getName(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void show() {
    OgreOverlayPINVOKE.OverlayElementPtr_show(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void hide() {
    OgreOverlayPINVOKE.OverlayElementPtr_hide(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setVisible(bool visible) {
    OgreOverlayPINVOKE.OverlayElementPtr_setVisible(swigCPtr, visible);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isVisible() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_isVisible(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEnabled() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_isEnabled(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setEnabled(bool b) {
    OgreOverlayPINVOKE.OverlayElementPtr_setEnabled(swigCPtr, b);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDimensions(float width, float height) {
    OgreOverlayPINVOKE.OverlayElementPtr_setDimensions(swigCPtr, width, height);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPosition(float left, float top) {
    OgreOverlayPINVOKE.OverlayElementPtr_setPosition(swigCPtr, left, top);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setWidth(float width) {
    OgreOverlayPINVOKE.OverlayElementPtr_setWidth(swigCPtr, width);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getWidth() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr_getWidth(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setHeight(float height) {
    OgreOverlayPINVOKE.OverlayElementPtr_setHeight(swigCPtr, height);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getHeight() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr_getHeight(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setLeft(float left) {
    OgreOverlayPINVOKE.OverlayElementPtr_setLeft(swigCPtr, left);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getLeft() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr_getLeft(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTop(float Top) {
    OgreOverlayPINVOKE.OverlayElementPtr_setTop(swigCPtr, Top);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getTop() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr_getTop(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _getLeft() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr__getLeft(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _getTop() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr__getTop(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _getWidth() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr__getWidth(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _getHeight() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr__getHeight(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _setLeft(float left) {
    OgreOverlayPINVOKE.OverlayElementPtr__setLeft(swigCPtr, left);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _setTop(float top) {
    OgreOverlayPINVOKE.OverlayElementPtr__setTop(swigCPtr, top);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _setWidth(float width) {
    OgreOverlayPINVOKE.OverlayElementPtr__setWidth(swigCPtr, width);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _setHeight(float height) {
    OgreOverlayPINVOKE.OverlayElementPtr__setHeight(swigCPtr, height);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _setPosition(float left, float top) {
    OgreOverlayPINVOKE.OverlayElementPtr__setPosition(swigCPtr, left, top);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _setDimensions(float width, float height) {
    OgreOverlayPINVOKE.OverlayElementPtr__setDimensions(swigCPtr, width, height);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getMaterialName() {
    string ret = OgreOverlayPINVOKE.OverlayElementPtr_getMaterialName(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMaterial(MaterialPtr mat) {
    OgreOverlayPINVOKE.OverlayElementPtr_setMaterial(swigCPtr, MaterialPtr.getCPtr(mat));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterialName(string matName, string group) {
    OgreOverlayPINVOKE.OverlayElementPtr_setMaterialName__SWIG_0(swigCPtr, matName, group);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaterialName(string matName) {
    OgreOverlayPINVOKE.OverlayElementPtr_setMaterialName__SWIG_1(swigCPtr, matName);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public MaterialPtr getMaterial() {
    MaterialPtr ret = new MaterialPtr(OgreOverlayPINVOKE.OverlayElementPtr_getMaterial(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getWorldTransforms(Matrix4 xform) {
    OgreOverlayPINVOKE.OverlayElementPtr_getWorldTransforms(swigCPtr, Matrix4.getCPtr(xform));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _positionsOutOfDate() {
    OgreOverlayPINVOKE.OverlayElementPtr__positionsOutOfDate(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _update() {
    OgreOverlayPINVOKE.OverlayElementPtr__update(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _updateFromParent() {
    OgreOverlayPINVOKE.OverlayElementPtr__updateFromParent(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyParent(OverlayContainer parent, Overlay overlay) {
    OgreOverlayPINVOKE.OverlayElementPtr__notifyParent(swigCPtr, OverlayContainer.getCPtr(parent), Overlay.getCPtr(overlay));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float _getDerivedLeft() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr__getDerivedLeft(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _getDerivedTop() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr__getDerivedTop(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _getRelativeWidth() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr__getRelativeWidth(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float _getRelativeHeight() {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr__getRelativeHeight(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _getClippingRegion(FloatRect clippingRegion) {
    OgreOverlayPINVOKE.OverlayElementPtr__getClippingRegion(swigCPtr, FloatRect.getCPtr(clippingRegion));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort _notifyZOrder(ushort newZOrder) {
    ushort ret = OgreOverlayPINVOKE.OverlayElementPtr__notifyZOrder(swigCPtr, newZOrder);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyWorldTransforms(Matrix4 xform) {
    OgreOverlayPINVOKE.OverlayElementPtr__notifyWorldTransforms(swigCPtr, Matrix4.getCPtr(xform));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyViewport() {
    OgreOverlayPINVOKE.OverlayElementPtr__notifyViewport(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _updateRenderQueue(RenderQueue queue) {
    OgreOverlayPINVOKE.OverlayElementPtr__updateRenderQueue(swigCPtr, RenderQueue.getCPtr(queue));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void visitRenderables(Renderable.Visitor visitor, bool debugRenderables) {
    OgreOverlayPINVOKE.OverlayElementPtr_visitRenderables__SWIG_0(swigCPtr, Renderable.Visitor.getCPtr(visitor), debugRenderables);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void visitRenderables(Renderable.Visitor visitor) {
    OgreOverlayPINVOKE.OverlayElementPtr_visitRenderables__SWIG_1(swigCPtr, Renderable.Visitor.getCPtr(visitor));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getTypeName() {
    string ret = OgreOverlayPINVOKE.OverlayElementPtr_getTypeName(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCaption(string text) {
    OgreOverlayPINVOKE.OverlayElementPtr_setCaption(swigCPtr, text);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getCaption() {
    string ret = OgreOverlayPINVOKE.OverlayElementPtr_getCaption(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setColour(ColourValue col) {
    OgreOverlayPINVOKE.OverlayElementPtr_setColour(swigCPtr, ColourValue.getCPtr(col));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourValue getColour() {
    ColourValue ret = new ColourValue(OgreOverlayPINVOKE.OverlayElementPtr_getColour(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMetricsMode(GuiMetricsMode gmm) {
    OgreOverlayPINVOKE.OverlayElementPtr_setMetricsMode(swigCPtr, (int)gmm);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public GuiMetricsMode getMetricsMode() {
    GuiMetricsMode ret = (GuiMetricsMode)OgreOverlayPINVOKE.OverlayElementPtr_getMetricsMode(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setHorizontalAlignment(GuiHorizontalAlignment gha) {
    OgreOverlayPINVOKE.OverlayElementPtr_setHorizontalAlignment(swigCPtr, (int)gha);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public GuiHorizontalAlignment getHorizontalAlignment() {
    GuiHorizontalAlignment ret = (GuiHorizontalAlignment)OgreOverlayPINVOKE.OverlayElementPtr_getHorizontalAlignment(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setVerticalAlignment(GuiVerticalAlignment gva) {
    OgreOverlayPINVOKE.OverlayElementPtr_setVerticalAlignment(swigCPtr, (int)gva);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public GuiVerticalAlignment getVerticalAlignment() {
    GuiVerticalAlignment ret = (GuiVerticalAlignment)OgreOverlayPINVOKE.OverlayElementPtr_getVerticalAlignment(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool contains(float x, float y) {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_contains(swigCPtr, x, y);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement findElementAt(float x, float y) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr_findElementAt(swigCPtr, x, y);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isContainer() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_isContainer(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isKeyEnabled() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_isKeyEnabled(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isCloneable() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_isCloneable(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCloneable(bool c) {
    OgreOverlayPINVOKE.OverlayElementPtr_setCloneable(swigCPtr, c);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public OverlayContainer getParent() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr_getParent(swigCPtr);
    OverlayContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayContainer(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _setParent(OverlayContainer parent) {
    OgreOverlayPINVOKE.OverlayElementPtr__setParent(swigCPtr, OverlayContainer.getCPtr(parent));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getZOrder() {
    ushort ret = OgreOverlayPINVOKE.OverlayElementPtr_getZOrder(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getSquaredViewDepth(Camera cam) {
    float ret = OgreOverlayPINVOKE.OverlayElementPtr_getSquaredViewDepth(swigCPtr, Camera.getCPtr(cam));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_Ogre__Light_p_t getLights() {
    SWIGTYPE_p_std__vectorT_Ogre__Light_p_t ret = new SWIGTYPE_p_std__vectorT_Ogre__Light_p_t(OgreOverlayPINVOKE.OverlayElementPtr_getLights(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyFromTemplate(OverlayElement templateOverlay) {
    OgreOverlayPINVOKE.OverlayElementPtr_copyFromTemplate(swigCPtr, OverlayElement.getCPtr(templateOverlay));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public OverlayElement clone(string instanceName) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr_clone(swigCPtr, instanceName);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayContainer castOverlayContainer() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr_castOverlayContainer(swigCPtr);
    OverlayContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayContainer(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PanelOverlayElement castPanelOverlayElement() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr_castPanelOverlayElement(swigCPtr);
    PanelOverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new PanelOverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TextAreaOverlayElement castTextAreaOverlayElement() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr_castTextAreaOverlayElement(swigCPtr);
    TextAreaOverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new TextAreaOverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParamDictionary getParamDictionary() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr_getParamDictionary__SWIG_0(swigCPtr);
    ParamDictionary ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParamDictionary(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringList getParameters() {
    StringList ret = new StringList(OgreOverlayPINVOKE.OverlayElementPtr_getParameters(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParameter(string name, string value) {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_setParameter(swigCPtr, name, value);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParameterList(NameValueMap paramList) {
    OgreOverlayPINVOKE.OverlayElementPtr_setParameterList(swigCPtr, NameValueMap.getCPtr(paramList));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getParameter(string name) {
    string ret = OgreOverlayPINVOKE.OverlayElementPtr_getParameter(swigCPtr, name);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyParametersTo(StringInterface dest) {
    OgreOverlayPINVOKE.OverlayElementPtr_copyParametersTo(swigCPtr, StringInterface.getCPtr(dest));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void cleanupDictionary() {
    OgreOverlayPINVOKE.OverlayElementPtr_cleanupDictionary(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public Technique getTechnique() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayElementPtr_getTechnique(swigCPtr);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getRenderOperation(RenderOperation op) {
    OgreOverlayPINVOKE.OverlayElementPtr_getRenderOperation(swigCPtr, RenderOperation.getCPtr(op));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort _getMaterialLodIndex() {
    ushort ret = OgreOverlayPINVOKE.OverlayElementPtr__getMaterialLodIndex(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool preRender(SceneManager sm, RenderSystem rsys) {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_preRender(swigCPtr, SceneManager.getCPtr(sm), RenderSystem.getCPtr(rsys));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void postRender(SceneManager sm, RenderSystem rsys) {
    OgreOverlayPINVOKE.OverlayElementPtr_postRender(swigCPtr, SceneManager.getCPtr(sm), RenderSystem.getCPtr(rsys));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getNumWorldTransforms() {
    ushort ret = OgreOverlayPINVOKE.OverlayElementPtr_getNumWorldTransforms(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setUseIdentityProjection(bool useIdentityProjection) {
    OgreOverlayPINVOKE.OverlayElementPtr_setUseIdentityProjection(swigCPtr, useIdentityProjection);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getUseIdentityProjection() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_getUseIdentityProjection(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setUseIdentityView(bool useIdentityView) {
    OgreOverlayPINVOKE.OverlayElementPtr_setUseIdentityView(swigCPtr, useIdentityView);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getUseIdentityView() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_getUseIdentityView(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getCastsShadows() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_getCastsShadows(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCustomParameter(uint index, Vector4 value) {
    OgreOverlayPINVOKE.OverlayElementPtr_setCustomParameter(swigCPtr, index, Vector4.getCPtr(value));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeCustomParameter(uint index) {
    OgreOverlayPINVOKE.OverlayElementPtr_removeCustomParameter(swigCPtr, index);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool hasCustomParameter(uint index) {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_hasCustomParameter(swigCPtr, index);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 getCustomParameter(uint index) {
    Vector4 ret = new Vector4(OgreOverlayPINVOKE.OverlayElementPtr_getCustomParameter(swigCPtr, index), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _updateCustomGpuParameter(GpuProgramParameters.AutoConstantEntry constantEntry, GpuProgramParameters params_) {
    OgreOverlayPINVOKE.OverlayElementPtr__updateCustomGpuParameter(swigCPtr, GpuProgramParameters.AutoConstantEntry.getCPtr(constantEntry), GpuProgramParameters.getCPtr(params_));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPolygonModeOverrideable(bool override_) {
    OgreOverlayPINVOKE.OverlayElementPtr_setPolygonModeOverrideable(swigCPtr, override_);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getPolygonModeOverrideable() {
    bool ret = OgreOverlayPINVOKE.OverlayElementPtr_getPolygonModeOverrideable(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UserObjectBindings getUserObjectBindings() {
    UserObjectBindings ret = new UserObjectBindings(OgreOverlayPINVOKE.OverlayElementPtr_getUserObjectBindings__SWIG_0(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}