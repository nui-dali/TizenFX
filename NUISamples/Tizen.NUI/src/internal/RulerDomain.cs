//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI {

    public class RulerDomain : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RulerDomain(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RulerDomain obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RulerDomain() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_RulerDomain(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RulerDomain(float min, float max, bool enabled) : this(NDalicPINVOKE.new_RulerDomain__SWIG_0(min, max, enabled), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public RulerDomain(float min, float max) : this(NDalicPINVOKE.new_RulerDomain__SWIG_1(min, max), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public float min {
    set {
      NDalicPINVOKE.RulerDomain_min_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.RulerDomain_min_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float max {
    set {
      NDalicPINVOKE.RulerDomain_max_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.RulerDomain_max_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool enabled {
    set {
      NDalicPINVOKE.RulerDomain_enabled_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = NDalicPINVOKE.RulerDomain_enabled_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float Clamp(float x, float length, float scale) {
    float ret = NDalicPINVOKE.RulerDomain_Clamp__SWIG_0(swigCPtr, x, length, scale);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Clamp(float x, float length) {
    float ret = NDalicPINVOKE.RulerDomain_Clamp__SWIG_1(swigCPtr, x, length);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Clamp(float x) {
    float ret = NDalicPINVOKE.RulerDomain_Clamp__SWIG_2(swigCPtr, x);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal float Clamp(float x, float length, float scale, SWIGTYPE_p_Dali__Toolkit__ClampState clamped) {
    float ret = NDalicPINVOKE.RulerDomain_Clamp__SWIG_3(swigCPtr, x, length, scale, SWIGTYPE_p_Dali__Toolkit__ClampState.getCPtr(clamped));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetSize() {
    float ret = NDalicPINVOKE.RulerDomain_GetSize(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
