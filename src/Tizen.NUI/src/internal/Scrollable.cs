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

using System;
using System.Runtime.InteropServices;
using Tizen.NUI.BaseComponents;

    public class Scrollable : View {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Scrollable(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Scrollable_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Scrollable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_Scrollable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



public class StartedEventArgs : EventArgs
{
   private Vector2 _vector2;

   public Vector2 Vector2
   {
      get
      {
         return _vector2;
      }
      set
      {
         _vector2 = value;
      }
   }
}

public class UpdatedEventArgs : EventArgs
{
   private Vector2 _vector2;

   public Vector2 Vector2
   {
      get
      {
         return _vector2;
      }
      set
      {
         _vector2 = value;
      }
   }
}

public class CompletedEventArgs : EventArgs
{
   private Vector2 _vector2;

   public Vector2 Vector2
   {
      get
      {
         return _vector2;
      }
      set
      {
         _vector2 = value;
      }
   }
}

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate void StartedCallbackDelegate(IntPtr vector2);
  private DaliEventHandler<object,StartedEventArgs> _scrollableStartedEventHandler;
  private StartedCallbackDelegate _scrollableStartedCallbackDelegate;

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate void UpdatedCallbackDelegate(IntPtr vector2);
  private DaliEventHandler<object,UpdatedEventArgs> _scrollableUpdatedEventHandler;
  private UpdatedCallbackDelegate _scrollableUpdatedCallbackDelegate;

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate void CompletedCallbackDelegate(IntPtr vector2);
  private DaliEventHandler<object,CompletedEventArgs> _scrollableCompletedEventHandler;
  private CompletedCallbackDelegate _scrollableCompletedCallbackDelegate;

  public event DaliEventHandler<object,StartedEventArgs> ScrollStarted
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_scrollableStartedEventHandler == null)
           {
              _scrollableStartedEventHandler += value;

              _scrollableStartedCallbackDelegate = new StartedCallbackDelegate(OnStarted);
              this.ScrollStartedSignal().Connect(_scrollableStartedCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_scrollableStartedEventHandler != null)
           {
              this.ScrollStartedSignal().Disconnect(_scrollableStartedCallbackDelegate);
           }

           _scrollableStartedEventHandler -= value;
        }
     }
  }

 private void OnStarted(IntPtr vector2)
  {
   StartedEventArgs e = new StartedEventArgs();

   // Populate all members of "e" (StartedEventArgs) with real data
   e.Vector2 = Tizen.NUI.Vector2.GetVector2FromPtr(vector2);

   if (_scrollableStartedEventHandler != null)
   {
      //here we send all data to user event handlers
      _scrollableStartedEventHandler(this, e);
   }

  }

  public event DaliEventHandler<object,UpdatedEventArgs> ScrollUpdated
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_scrollableUpdatedEventHandler == null)
           {
              _scrollableUpdatedEventHandler += value;

              _scrollableUpdatedCallbackDelegate = new UpdatedCallbackDelegate(OnUpdated);
              this.ScrollUpdatedSignal().Connect(_scrollableUpdatedCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_scrollableUpdatedEventHandler != null)
           {
              this.ScrollUpdatedSignal().Disconnect(_scrollableUpdatedCallbackDelegate);
           }

           _scrollableUpdatedEventHandler -= value;
        }
     }
  }

 private void OnUpdated(IntPtr vector2)
  {
   UpdatedEventArgs e = new UpdatedEventArgs();

   // Populate all members of "e" (UpdatedEventArgs) with real data
   e.Vector2 = Tizen.NUI.Vector2.GetVector2FromPtr(vector2);

   if (_scrollableUpdatedEventHandler != null)
   {
      //here we send all data to user event handlers
      _scrollableUpdatedEventHandler(this, e);
   }

  }

  public event DaliEventHandler<object,CompletedEventArgs> ScrollCompleted
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_scrollableCompletedEventHandler == null)
           {
              _scrollableCompletedEventHandler += value;

              _scrollableCompletedCallbackDelegate = new CompletedCallbackDelegate(OnCompleted);
              this.ScrollCompletedSignal().Connect(_scrollableCompletedCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_scrollableCompletedEventHandler != null)
           {
              this.ScrollCompletedSignal().Disconnect(_scrollableCompletedCallbackDelegate);
           }

           _scrollableCompletedEventHandler -= value;
        }
     }
  }

 private void OnCompleted(IntPtr vector2)
  {
   CompletedEventArgs e = new CompletedEventArgs();

   // Populate all members of "e" (CompletedEventArgs) with real data
   e.Vector2 = Tizen.NUI.Vector2.GetVector2FromPtr(vector2);

   if (_scrollableCompletedEventHandler != null)
   {
      //here we send all data to user event handlers
      _scrollableCompletedEventHandler(this, e);
   }

  }


  public class Property : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Property(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Property() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_Scrollable_Property(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property() : this(NDalicPINVOKE.new_Scrollable_Property(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int OVERSHOOT_EFFECT_COLOR = NDalicPINVOKE.Scrollable_Property_OVERSHOOT_EFFECT_COLOR_get();
    public static readonly int OVERSHOOT_ANIMATION_SPEED = NDalicPINVOKE.Scrollable_Property_OVERSHOOT_ANIMATION_SPEED_get();
    public static readonly int OVERSHOOT_ENABLED = NDalicPINVOKE.Scrollable_Property_OVERSHOOT_ENABLED_get();
    public static readonly int OVERSHOOT_SIZE = NDalicPINVOKE.Scrollable_Property_OVERSHOOT_SIZE_get();
    public static readonly int SCROLL_TO_ALPHA_FUNCTION = NDalicPINVOKE.Scrollable_Property_SCROLL_TO_ALPHA_FUNCTION_get();
    public static readonly int SCROLL_RELATIVE_POSITION = NDalicPINVOKE.Scrollable_Property_SCROLL_RELATIVE_POSITION_get();
    public static readonly int SCROLL_POSITION_MIN = NDalicPINVOKE.Scrollable_Property_SCROLL_POSITION_MIN_get();
    public static readonly int SCROLL_POSITION_MIN_X = NDalicPINVOKE.Scrollable_Property_SCROLL_POSITION_MIN_X_get();
    public static readonly int SCROLL_POSITION_MIN_Y = NDalicPINVOKE.Scrollable_Property_SCROLL_POSITION_MIN_Y_get();
    public static readonly int SCROLL_POSITION_MAX = NDalicPINVOKE.Scrollable_Property_SCROLL_POSITION_MAX_get();
    public static readonly int SCROLL_POSITION_MAX_X = NDalicPINVOKE.Scrollable_Property_SCROLL_POSITION_MAX_X_get();
    public static readonly int SCROLL_POSITION_MAX_Y = NDalicPINVOKE.Scrollable_Property_SCROLL_POSITION_MAX_Y_get();
    public static readonly int CAN_SCROLL_VERTICAL = NDalicPINVOKE.Scrollable_Property_CAN_SCROLL_VERTICAL_get();
    public static readonly int CAN_SCROLL_HORIZONTAL = NDalicPINVOKE.Scrollable_Property_CAN_SCROLL_HORIZONTAL_get();
  
  }

  public Scrollable() : this(NDalicPINVOKE.new_Scrollable__SWIG_0(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Scrollable(Scrollable handle) : this(NDalicPINVOKE.new_Scrollable__SWIG_1(Scrollable.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Scrollable Assign(Scrollable handle) {
    Scrollable ret = new Scrollable(NDalicPINVOKE.Scrollable_Assign(swigCPtr, Scrollable.getCPtr(handle)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static Scrollable DownCast(BaseHandle handle) {
    Scrollable ret = new Scrollable(NDalicPINVOKE.Scrollable_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsOvershootEnabled() {
    bool ret = NDalicPINVOKE.Scrollable_IsOvershootEnabled(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetOvershootEnabled(bool enable) {
    NDalicPINVOKE.Scrollable_SetOvershootEnabled(swigCPtr, enable);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetOvershootEffectColor(Vector4 color) {
    NDalicPINVOKE.Scrollable_SetOvershootEffectColor(swigCPtr, Vector4.getCPtr(color));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4 GetOvershootEffectColor() {
    Vector4 ret = new Vector4(NDalicPINVOKE.Scrollable_GetOvershootEffectColor(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetOvershootAnimationSpeed(float pixelsPerSecond) {
    NDalicPINVOKE.Scrollable_SetOvershootAnimationSpeed(swigCPtr, pixelsPerSecond);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetOvershootAnimationSpeed() {
    float ret = NDalicPINVOKE.Scrollable_GetOvershootAnimationSpeed(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal ScrollableSignal ScrollStartedSignal() {
    ScrollableSignal ret = new ScrollableSignal(NDalicPINVOKE.Scrollable_ScrollStartedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal ScrollableSignal ScrollUpdatedSignal() {
    ScrollableSignal ret = new ScrollableSignal(NDalicPINVOKE.Scrollable_ScrollUpdatedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal ScrollableSignal ScrollCompletedSignal() {
    ScrollableSignal ret = new ScrollableSignal(NDalicPINVOKE.Scrollable_ScrollCompletedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum PropertyRange {
    PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
    PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX+1000,
    ANIMATABLE_PROPERTY_START_INDEX = PropertyRanges.ANIMATABLE_PROPERTY_REGISTRATION_START_INDEX,
    ANIMATABLE_PROPERTY_END_INDEX = PropertyRanges.ANIMATABLE_PROPERTY_REGISTRATION_START_INDEX+1000
  }

  public Vector4 OvershootEffectColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( Scrollable.Property.OVERSHOOT_EFFECT_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.OVERSHOOT_EFFECT_COLOR, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public float OvershootAnimationSpeed
  {
    get
    {
      float temp = 0.0f;
      GetProperty( Scrollable.Property.OVERSHOOT_ANIMATION_SPEED).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.OVERSHOOT_ANIMATION_SPEED, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public bool OvershootEnabled
  {
    get
    {
      bool temp = false;
      GetProperty( Scrollable.Property.OVERSHOOT_ENABLED).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.OVERSHOOT_ENABLED, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public Vector2 OvershootSize
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( Scrollable.Property.OVERSHOOT_SIZE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.OVERSHOOT_SIZE, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public int ScrollToAlphaFunction
  {
    get
    {
      int temp = 0;
      GetProperty( Scrollable.Property.SCROLL_TO_ALPHA_FUNCTION).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.SCROLL_TO_ALPHA_FUNCTION, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public Vector2 ScrollRelativePosition
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( Scrollable.Property.SCROLL_RELATIVE_POSITION).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.SCROLL_RELATIVE_POSITION, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public Vector2 ScrollPositionMin
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( Scrollable.Property.SCROLL_POSITION_MIN).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.SCROLL_POSITION_MIN, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public Vector2 ScrollPositionMax
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( Scrollable.Property.SCROLL_POSITION_MAX).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.SCROLL_POSITION_MAX, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public bool CanScrollVertical
  {
    get
    {
      bool temp = false;
      GetProperty( Scrollable.Property.CAN_SCROLL_VERTICAL).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.CAN_SCROLL_VERTICAL, new Tizen.NUI.PropertyValue( value ) );
    }
  }
  public bool CanScrollHorizontal
  {
    get
    {
      bool temp = false;
      GetProperty( Scrollable.Property.CAN_SCROLL_HORIZONTAL).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Scrollable.Property.CAN_SCROLL_HORIZONTAL, new Tizen.NUI.PropertyValue( value ) );
    }
  }

}

}