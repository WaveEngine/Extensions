//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class FontFamily : BaseComponent {
  internal new static FontFamily CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new FontFamily(cPtr, cMemoryOwn);
  }

  internal FontFamily(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(FontFamily obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public FontFamily() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_FontFamily__SWIG_0();
  }

  public FontFamily(string source) : this(NoesisGUI_PINVOKE.new_FontFamily__SWIG_1(source != null ? source : string.Empty), true) {
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  public FontFamily(string baseUri, string source) : this(NoesisGUI_PINVOKE.new_FontFamily__SWIG_2(baseUri != null ? baseUri : string.Empty, source != null ? source : string.Empty), true) {
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  public string BaseUri {
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.FontFamily_BaseUri_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public string Source {
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.FontFamily_Source_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public string Name {
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.FontFamily_Name_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.FontFamily_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
