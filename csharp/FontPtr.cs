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

public class FontPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FontPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FontPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FontPtr() {
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
          OgreOverlayPINVOKE.delete_FontPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public FontPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgreOverlayPINVOKE.new_FontPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public FontPtr() : this(OgreOverlayPINVOKE.new_FontPtr__SWIG_1(), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public FontPtr(FontPtr r) : this(OgreOverlayPINVOKE.new_FontPtr__SWIG_2(FontPtr.getCPtr(r)), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public Font __deref__() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.FontPtr___deref__(swigCPtr);
    Font ret = (cPtr == global::System.IntPtr.Zero) ? null : new Font(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setType(FontType ftype) {
    OgreOverlayPINVOKE.FontPtr_setType(swigCPtr, (int)ftype);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public FontType getType() {
    FontType ret = (FontType)OgreOverlayPINVOKE.FontPtr_getType(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSource(string source) {
    OgreOverlayPINVOKE.FontPtr_setSource(swigCPtr, source);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getSource() {
    string ret = OgreOverlayPINVOKE.FontPtr_getSource(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTrueTypeSize(float ttfSize) {
    OgreOverlayPINVOKE.FontPtr_setTrueTypeSize(swigCPtr, ttfSize);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTrueTypeResolution(uint ttfResolution) {
    OgreOverlayPINVOKE.FontPtr_setTrueTypeResolution(swigCPtr, ttfResolution);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getTrueTypeSize() {
    float ret = OgreOverlayPINVOKE.FontPtr_getTrueTypeSize(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getTrueTypeResolution() {
    uint ret = OgreOverlayPINVOKE.FontPtr_getTrueTypeResolution(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getTrueTypeMaxBearingY() {
    int ret = OgreOverlayPINVOKE.FontPtr_getTrueTypeMaxBearingY(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FloatRect getGlyphTexCoords(uint id) {
    FloatRect ret = new FloatRect(OgreOverlayPINVOKE.FontPtr_getGlyphTexCoords(swigCPtr, id), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGlyphInfoFromTexCoords(uint id, FloatRect rect, float textureAspect) {
    OgreOverlayPINVOKE.FontPtr_setGlyphInfoFromTexCoords__SWIG_0(swigCPtr, id, FloatRect.getCPtr(rect), textureAspect);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setGlyphInfoFromTexCoords(uint id, FloatRect rect) {
    OgreOverlayPINVOKE.FontPtr_setGlyphInfoFromTexCoords__SWIG_1(swigCPtr, id, FloatRect.getCPtr(rect));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setGlyphInfo(GlyphInfo info) {
    OgreOverlayPINVOKE.FontPtr_setGlyphInfo(swigCPtr, GlyphInfo.getCPtr(info));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getGlyphAspectRatio(uint id) {
    float ret = OgreOverlayPINVOKE.FontPtr_getGlyphAspectRatio(swigCPtr, id);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGlyphAspectRatio(uint id, float ratio) {
    OgreOverlayPINVOKE.FontPtr_setGlyphAspectRatio(swigCPtr, id, ratio);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public GlyphInfo getGlyphInfo(uint id) {
    GlyphInfo ret = new GlyphInfo(OgreOverlayPINVOKE.FontPtr_getGlyphInfo(swigCPtr, id), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addCodePointRange(SWIGTYPE_p_std__pairT_unsigned_int_unsigned_int_t range) {
    OgreOverlayPINVOKE.FontPtr_addCodePointRange(swigCPtr, SWIGTYPE_p_std__pairT_unsigned_int_unsigned_int_t.getCPtr(range));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearCodePointRanges() {
    OgreOverlayPINVOKE.FontPtr_clearCodePointRanges(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_std__pairT_unsigned_int_unsigned_int_t_t getCodePointRangeList() {
    SWIGTYPE_p_std__vectorT_std__pairT_unsigned_int_unsigned_int_t_t ret = new SWIGTYPE_p_std__vectorT_std__pairT_unsigned_int_unsigned_int_t_t(OgreOverlayPINVOKE.FontPtr_getCodePointRangeList(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr getMaterial() {
    MaterialPtr ret = new MaterialPtr(OgreOverlayPINVOKE.FontPtr_getMaterial(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void putText(BillboardSet bbs, string text, float height, ColourValue colour) {
    OgreOverlayPINVOKE.FontPtr_putText__SWIG_0(swigCPtr, BillboardSet.getCPtr(bbs), text, height, ColourValue.getCPtr(colour));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void putText(BillboardSet bbs, string text, float height) {
    OgreOverlayPINVOKE.FontPtr_putText__SWIG_1(swigCPtr, BillboardSet.getCPtr(bbs), text, height);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAntialiasColour(bool enabled) {
    OgreOverlayPINVOKE.FontPtr_setAntialiasColour(swigCPtr, enabled);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getAntialiasColour() {
    bool ret = OgreOverlayPINVOKE.FontPtr_getAntialiasColour(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void loadResource(Resource resource) {
    OgreOverlayPINVOKE.FontPtr_loadResource(swigCPtr, Resource.getCPtr(resource));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _setMaterial(MaterialPtr mat) {
    OgreOverlayPINVOKE.FontPtr__setMaterial(swigCPtr, MaterialPtr.getCPtr(mat));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepare(bool backgroundThread) {
    OgreOverlayPINVOKE.FontPtr_prepare__SWIG_0(swigCPtr, backgroundThread);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepare() {
    OgreOverlayPINVOKE.FontPtr_prepare__SWIG_1(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void load(bool backgroundThread) {
    OgreOverlayPINVOKE.FontPtr_load__SWIG_0(swigCPtr, backgroundThread);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void load() {
    OgreOverlayPINVOKE.FontPtr_load__SWIG_1(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload(Resource.LoadingFlags flags) {
    OgreOverlayPINVOKE.FontPtr_reload__SWIG_0(swigCPtr, (int)flags);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload() {
    OgreOverlayPINVOKE.FontPtr_reload__SWIG_1(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isReloadable() {
    bool ret = OgreOverlayPINVOKE.FontPtr_isReloadable(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isManuallyLoaded() {
    bool ret = OgreOverlayPINVOKE.FontPtr_isManuallyLoaded(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unload() {
    OgreOverlayPINVOKE.FontPtr_unload(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSize() {
    uint ret = OgreOverlayPINVOKE.FontPtr_getSize(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void touch() {
    OgreOverlayPINVOKE.FontPtr_touch(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = OgreOverlayPINVOKE.FontPtr_getName(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getHandle() {
    uint ret = OgreOverlayPINVOKE.FontPtr_getHandle(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isPrepared() {
    bool ret = OgreOverlayPINVOKE.FontPtr_isPrepared(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoaded() {
    bool ret = OgreOverlayPINVOKE.FontPtr_isLoaded(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoading() {
    bool ret = OgreOverlayPINVOKE.FontPtr_isLoading(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Resource.LoadingState getLoadingState() {
    Resource.LoadingState ret = (Resource.LoadingState)OgreOverlayPINVOKE.FontPtr_getLoadingState(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isBackgroundLoaded() {
    bool ret = OgreOverlayPINVOKE.FontPtr_isBackgroundLoaded(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBackgroundLoaded(bool bl) {
    OgreOverlayPINVOKE.FontPtr_setBackgroundLoaded(swigCPtr, bl);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void escalateLoading() {
    OgreOverlayPINVOKE.FontPtr_escalateLoading(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addListener(Resource.Listener lis) {
    OgreOverlayPINVOKE.FontPtr_addListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeListener(Resource.Listener lis) {
    OgreOverlayPINVOKE.FontPtr_removeListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getGroup() {
    string ret = OgreOverlayPINVOKE.FontPtr_getGroup(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void changeGroupOwnership(string newGroup) {
    OgreOverlayPINVOKE.FontPtr_changeGroupOwnership(swigCPtr, newGroup);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResourceManager getCreator() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.FontPtr_getCreator(swigCPtr);
    ResourceManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResourceManager(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getOrigin() {
    string ret = OgreOverlayPINVOKE.FontPtr_getOrigin(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyOrigin(string origin) {
    OgreOverlayPINVOKE.FontPtr__notifyOrigin(swigCPtr, origin);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getStateCount() {
    uint ret = OgreOverlayPINVOKE.FontPtr_getStateCount(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _dirtyState() {
    OgreOverlayPINVOKE.FontPtr__dirtyState(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireLoadingComplete(bool unused) {
    OgreOverlayPINVOKE.FontPtr__fireLoadingComplete__SWIG_0(swigCPtr, unused);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireLoadingComplete() {
    OgreOverlayPINVOKE.FontPtr__fireLoadingComplete__SWIG_1(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _firePreparingComplete(bool unused) {
    OgreOverlayPINVOKE.FontPtr__firePreparingComplete__SWIG_0(swigCPtr, unused);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _firePreparingComplete() {
    OgreOverlayPINVOKE.FontPtr__firePreparingComplete__SWIG_1(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireUnloadingComplete() {
    OgreOverlayPINVOKE.FontPtr__fireUnloadingComplete(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ParamDictionary getParamDictionary() {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.FontPtr_getParamDictionary__SWIG_0(swigCPtr);
    ParamDictionary ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParamDictionary(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringList getParameters() {
    StringList ret = new StringList(OgreOverlayPINVOKE.FontPtr_getParameters(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParameter(string name, string value) {
    bool ret = OgreOverlayPINVOKE.FontPtr_setParameter(swigCPtr, name, value);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParameterList(NameValueMap paramList) {
    OgreOverlayPINVOKE.FontPtr_setParameterList(swigCPtr, NameValueMap.getCPtr(paramList));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getParameter(string name) {
    string ret = OgreOverlayPINVOKE.FontPtr_getParameter(swigCPtr, name);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyParametersTo(StringInterface dest) {
    OgreOverlayPINVOKE.FontPtr_copyParametersTo(swigCPtr, StringInterface.getCPtr(dest));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void cleanupDictionary() {
    OgreOverlayPINVOKE.FontPtr_cleanupDictionary(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepareResource(Resource resource) {
    OgreOverlayPINVOKE.FontPtr_prepareResource(swigCPtr, Resource.getCPtr(resource));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
