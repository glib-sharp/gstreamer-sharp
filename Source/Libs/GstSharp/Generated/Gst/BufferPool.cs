// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class BufferPool : Gst.Object {

		public BufferPool (IntPtr raw) : base(raw) {}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_pool_new();

		public BufferPool () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (BufferPool)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gst_buffer_pool_new();
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_pool_set_flushing(IntPtr raw, bool flushing);

		public bool Flushing {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("flushing"));
					return (*raw_ptr);
				}
			}
			set  {
				gst_buffer_pool_set_flushing(Handle, value);
			}
		}

		static GetOptionsNativeDelegate GetOptions_cb_delegate;
		static GetOptionsNativeDelegate GetOptionsVMCallback {
			get {
				if (GetOptions_cb_delegate == null)
					GetOptions_cb_delegate = new GetOptionsNativeDelegate (GetOptions_cb);
				return GetOptions_cb_delegate;
			}
		}

		static void OverrideGetOptions (GLib.GType gtype)
		{
			OverrideGetOptions (gtype, GetOptionsVMCallback);
		}

		static void OverrideGetOptions (GLib.GType gtype, GetOptionsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_options"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetOptionsNativeDelegate (IntPtr inst);

		static IntPtr GetOptions_cb (IntPtr inst)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				string[] __result;
				__result = __obj.OnGetOptions ();
				return GLib.Marshaller.StringArrayToNullTermStrvPointer (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideGetOptions")]
		protected virtual string[] OnGetOptions ()
		{
			return InternalGetOptions ();
		}

		private string[] InternalGetOptions ()
		{
			GetOptionsNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_options"));
				unmanaged = (GetOptionsNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetOptionsNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Marshaller.NullTermPtrToStringArray (__result, false);
		}

		static SetConfigNativeDelegate SetConfig_cb_delegate;
		static SetConfigNativeDelegate SetConfigVMCallback {
			get {
				if (SetConfig_cb_delegate == null)
					SetConfig_cb_delegate = new SetConfigNativeDelegate (SetConfig_cb);
				return SetConfig_cb_delegate;
			}
		}

		static void OverrideSetConfig (GLib.GType gtype)
		{
			OverrideSetConfig (gtype, SetConfigVMCallback);
		}

		static void OverrideSetConfig (GLib.GType gtype, SetConfigNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("set_config"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetConfigNativeDelegate (IntPtr inst, IntPtr config);

		static bool SetConfig_cb (IntPtr inst, IntPtr config)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				bool __result;
				__result = __obj.OnSetConfig (config == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (config, typeof (Gst.Structure), true));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideSetConfig")]
		protected virtual bool OnSetConfig (Gst.Structure config)
		{
			return InternalSetConfig (config);
		}

		private bool InternalSetConfig (Gst.Structure config)
		{
			SetConfigNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("set_config"));
				unmanaged = (SetConfigNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SetConfigNativeDelegate));
			}
			if (unmanaged == null) return false;

			config.Owned = false;
			bool __result = unmanaged (this.Handle, config == null ? IntPtr.Zero : config.Handle);
			return __result;
		}

		static StartNativeDelegate Start_cb_delegate;
		static StartNativeDelegate StartVMCallback {
			get {
				if (Start_cb_delegate == null)
					Start_cb_delegate = new StartNativeDelegate (Start_cb);
				return Start_cb_delegate;
			}
		}

		static void OverrideStart (GLib.GType gtype)
		{
			OverrideStart (gtype, StartVMCallback);
		}

		static void OverrideStart (GLib.GType gtype, StartNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("start"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool StartNativeDelegate (IntPtr inst);

		static bool Start_cb (IntPtr inst)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				bool __result;
				__result = __obj.OnStart ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideStart")]
		protected virtual bool OnStart ()
		{
			return InternalStart ();
		}

		private bool InternalStart ()
		{
			StartNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("start"));
				unmanaged = (StartNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(StartNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static StopNativeDelegate Stop_cb_delegate;
		static StopNativeDelegate StopVMCallback {
			get {
				if (Stop_cb_delegate == null)
					Stop_cb_delegate = new StopNativeDelegate (Stop_cb);
				return Stop_cb_delegate;
			}
		}

		static void OverrideStop (GLib.GType gtype)
		{
			OverrideStop (gtype, StopVMCallback);
		}

		static void OverrideStop (GLib.GType gtype, StopNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("stop"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool StopNativeDelegate (IntPtr inst);

		static bool Stop_cb (IntPtr inst)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				bool __result;
				__result = __obj.OnStop ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideStop")]
		protected virtual bool OnStop ()
		{
			return InternalStop ();
		}

		private bool InternalStop ()
		{
			StopNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("stop"));
				unmanaged = (StopNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(StopNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static AcquireBufferNativeDelegate AcquireBuffer_cb_delegate;
		static AcquireBufferNativeDelegate AcquireBufferVMCallback {
			get {
				if (AcquireBuffer_cb_delegate == null)
					AcquireBuffer_cb_delegate = new AcquireBufferNativeDelegate (AcquireBuffer_cb);
				return AcquireBuffer_cb_delegate;
			}
		}

		static void OverrideAcquireBuffer (GLib.GType gtype)
		{
			OverrideAcquireBuffer (gtype, AcquireBufferVMCallback);
		}

		static void OverrideAcquireBuffer (GLib.GType gtype, AcquireBufferNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("acquire_buffer"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int AcquireBufferNativeDelegate (IntPtr inst, out IntPtr buffer, IntPtr parms);

		static int AcquireBuffer_cb (IntPtr inst, out IntPtr buffer, IntPtr parms)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				Gst.FlowReturn __result;
				Gst.Buffer mybuffer;
				__result = __obj.OnAcquireBuffer (out mybuffer, Gst.BufferPoolAcquireParams.New (parms));
				buffer = mybuffer == null ? IntPtr.Zero : mybuffer.Handle;
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideAcquireBuffer")]
		protected virtual Gst.FlowReturn OnAcquireBuffer (out Gst.Buffer buffer, Gst.BufferPoolAcquireParams parms)
		{
			return InternalAcquireBuffer (out buffer, parms);
		}

		private Gst.FlowReturn InternalAcquireBuffer (out Gst.Buffer buffer, Gst.BufferPoolAcquireParams parms)
		{
			AcquireBufferNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("acquire_buffer"));
				unmanaged = (AcquireBufferNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(AcquireBufferNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr native_buffer;
			IntPtr native_parms = GLib.Marshaller.StructureToPtrAlloc (parms);
			int __result = unmanaged (this.Handle, out native_buffer, native_parms);
			buffer = native_buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (native_buffer, typeof (Gst.Buffer), true);
			Marshal.FreeHGlobal (native_parms);
			return (Gst.FlowReturn) __result;
		}

		static AllocBufferNativeDelegate AllocBuffer_cb_delegate;
		static AllocBufferNativeDelegate AllocBufferVMCallback {
			get {
				if (AllocBuffer_cb_delegate == null)
					AllocBuffer_cb_delegate = new AllocBufferNativeDelegate (AllocBuffer_cb);
				return AllocBuffer_cb_delegate;
			}
		}

		static void OverrideAllocBuffer (GLib.GType gtype)
		{
			OverrideAllocBuffer (gtype, AllocBufferVMCallback);
		}

		static void OverrideAllocBuffer (GLib.GType gtype, AllocBufferNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("alloc_buffer"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int AllocBufferNativeDelegate (IntPtr inst, IntPtr buffer, IntPtr parms);

		static int AllocBuffer_cb (IntPtr inst, IntPtr buffer, IntPtr parms)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				Gst.FlowReturn __result;
				__result = __obj.OnAllocBuffer (buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (buffer, typeof (Gst.Buffer), false), Gst.BufferPoolAcquireParams.New (parms));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideAllocBuffer")]
		protected virtual Gst.FlowReturn OnAllocBuffer (Gst.Buffer buffer, Gst.BufferPoolAcquireParams parms)
		{
			return InternalAllocBuffer (buffer, parms);
		}

		private Gst.FlowReturn InternalAllocBuffer (Gst.Buffer buffer, Gst.BufferPoolAcquireParams parms)
		{
			AllocBufferNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("alloc_buffer"));
				unmanaged = (AllocBufferNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(AllocBufferNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			IntPtr native_parms = GLib.Marshaller.StructureToPtrAlloc (parms);
			int __result = unmanaged (this.Handle, buffer == null ? IntPtr.Zero : buffer.Handle, native_parms);
			Marshal.FreeHGlobal (native_parms);
			return (Gst.FlowReturn) __result;
		}

		static ResetBufferNativeDelegate ResetBuffer_cb_delegate;
		static ResetBufferNativeDelegate ResetBufferVMCallback {
			get {
				if (ResetBuffer_cb_delegate == null)
					ResetBuffer_cb_delegate = new ResetBufferNativeDelegate (ResetBuffer_cb);
				return ResetBuffer_cb_delegate;
			}
		}

		static void OverrideResetBuffer (GLib.GType gtype)
		{
			OverrideResetBuffer (gtype, ResetBufferVMCallback);
		}

		static void OverrideResetBuffer (GLib.GType gtype, ResetBufferNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("reset_buffer"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ResetBufferNativeDelegate (IntPtr inst, IntPtr buffer);

		static void ResetBuffer_cb (IntPtr inst, IntPtr buffer)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				__obj.OnResetBuffer (buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (buffer, typeof (Gst.Buffer), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideResetBuffer")]
		protected virtual void OnResetBuffer (Gst.Buffer buffer)
		{
			InternalResetBuffer (buffer);
		}

		private void InternalResetBuffer (Gst.Buffer buffer)
		{
			ResetBufferNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("reset_buffer"));
				unmanaged = (ResetBufferNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ResetBufferNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, buffer == null ? IntPtr.Zero : buffer.Handle);
		}

		static ReleaseBufferNativeDelegate ReleaseBuffer_cb_delegate;
		static ReleaseBufferNativeDelegate ReleaseBufferVMCallback {
			get {
				if (ReleaseBuffer_cb_delegate == null)
					ReleaseBuffer_cb_delegate = new ReleaseBufferNativeDelegate (ReleaseBuffer_cb);
				return ReleaseBuffer_cb_delegate;
			}
		}

		static void OverrideReleaseBuffer (GLib.GType gtype)
		{
			OverrideReleaseBuffer (gtype, ReleaseBufferVMCallback);
		}

		static void OverrideReleaseBuffer (GLib.GType gtype, ReleaseBufferNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("release_buffer"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReleaseBufferNativeDelegate (IntPtr inst, IntPtr buffer);

		static void ReleaseBuffer_cb (IntPtr inst, IntPtr buffer)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				__obj.OnReleaseBuffer (buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (buffer, typeof (Gst.Buffer), true));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideReleaseBuffer")]
		protected virtual void OnReleaseBuffer (Gst.Buffer buffer)
		{
			InternalReleaseBuffer (buffer);
		}

		private void InternalReleaseBuffer (Gst.Buffer buffer)
		{
			ReleaseBufferNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("release_buffer"));
				unmanaged = (ReleaseBufferNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ReleaseBufferNativeDelegate));
			}
			if (unmanaged == null) return;

			buffer.Owned = false;
			unmanaged (this.Handle, buffer == null ? IntPtr.Zero : buffer.Handle);
		}

		static FreeBufferNativeDelegate FreeBuffer_cb_delegate;
		static FreeBufferNativeDelegate FreeBufferVMCallback {
			get {
				if (FreeBuffer_cb_delegate == null)
					FreeBuffer_cb_delegate = new FreeBufferNativeDelegate (FreeBuffer_cb);
				return FreeBuffer_cb_delegate;
			}
		}

		static void OverrideFreeBuffer (GLib.GType gtype)
		{
			OverrideFreeBuffer (gtype, FreeBufferVMCallback);
		}

		static void OverrideFreeBuffer (GLib.GType gtype, FreeBufferNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("free_buffer"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FreeBufferNativeDelegate (IntPtr inst, IntPtr buffer);

		static void FreeBuffer_cb (IntPtr inst, IntPtr buffer)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				__obj.OnFreeBuffer (buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (buffer, typeof (Gst.Buffer), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideFreeBuffer")]
		protected virtual void OnFreeBuffer (Gst.Buffer buffer)
		{
			InternalFreeBuffer (buffer);
		}

		private void InternalFreeBuffer (Gst.Buffer buffer)
		{
			FreeBufferNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("free_buffer"));
				unmanaged = (FreeBufferNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FreeBufferNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, buffer == null ? IntPtr.Zero : buffer.Handle);
		}

		static FlushStartNativeDelegate FlushStart_cb_delegate;
		static FlushStartNativeDelegate FlushStartVMCallback {
			get {
				if (FlushStart_cb_delegate == null)
					FlushStart_cb_delegate = new FlushStartNativeDelegate (FlushStart_cb);
				return FlushStart_cb_delegate;
			}
		}

		static void OverrideFlushStart (GLib.GType gtype)
		{
			OverrideFlushStart (gtype, FlushStartVMCallback);
		}

		static void OverrideFlushStart (GLib.GType gtype, FlushStartNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("flush_start"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FlushStartNativeDelegate (IntPtr inst);

		static void FlushStart_cb (IntPtr inst)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				__obj.OnFlushStart ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideFlushStart")]
		protected virtual void OnFlushStart ()
		{
			InternalFlushStart ();
		}

		private void InternalFlushStart ()
		{
			FlushStartNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("flush_start"));
				unmanaged = (FlushStartNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FlushStartNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static FlushStopNativeDelegate FlushStop_cb_delegate;
		static FlushStopNativeDelegate FlushStopVMCallback {
			get {
				if (FlushStop_cb_delegate == null)
					FlushStop_cb_delegate = new FlushStopNativeDelegate (FlushStop_cb);
				return FlushStop_cb_delegate;
			}
		}

		static void OverrideFlushStop (GLib.GType gtype)
		{
			OverrideFlushStop (gtype, FlushStopVMCallback);
		}

		static void OverrideFlushStop (GLib.GType gtype, FlushStopNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("flush_stop"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FlushStopNativeDelegate (IntPtr inst);

		static void FlushStop_cb (IntPtr inst)
		{
			try {
				BufferPool __obj = GLib.Object.GetObject (inst, false) as BufferPool;
				__obj.OnFlushStop ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.BufferPool), ConnectionMethod="OverrideFlushStop")]
		protected virtual void OnFlushStop ()
		{
			InternalFlushStop ();
		}

		private void InternalFlushStop ()
		{
			FlushStopNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("flush_stop"));
				unmanaged = (FlushStopNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FlushStopNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("get_options"
							, Gst.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_options
							, null
							, "set_config"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("set_config"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // set_config
							, "get_options"
							, "start"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("start"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // start
							, "set_config"
							, "stop"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("stop"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // stop
							, "start"
							, "acquire_buffer"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("acquire_buffer"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // acquire_buffer
							, "stop"
							, "alloc_buffer"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("alloc_buffer"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // alloc_buffer
							, "acquire_buffer"
							, "reset_buffer"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("reset_buffer"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // reset_buffer
							, "alloc_buffer"
							, "release_buffer"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("release_buffer"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // release_buffer
							, "reset_buffer"
							, "free_buffer"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("free_buffer"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // free_buffer
							, "release_buffer"
							, "flush_start"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("flush_start"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // flush_start
							, "free_buffer"
							, "flush_stop"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("flush_stop"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // flush_stop
							, "flush_start"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 2 // _gst_reserved
							, "flush_stop"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_pool_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_buffer_pool_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_pool_config_add_option(IntPtr config, IntPtr option);

		public static void ConfigAddOption(Gst.Structure config, string option) {
			IntPtr native_option = GLib.Marshaller.StringToPtrGStrdup (option);
			gst_buffer_pool_config_add_option(config == null ? IntPtr.Zero : config.Handle, native_option);
			GLib.Marshaller.Free (native_option);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_pool_config_get_allocator(IntPtr config, out IntPtr allocator, IntPtr parms);

		public static bool ConfigGetAllocator(Gst.Structure config, out Gst.Allocator allocator, out Gst.AllocationParams parms) {
			IntPtr native_allocator;
			IntPtr native_parms = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.AllocationParams)));
			bool raw_ret = gst_buffer_pool_config_get_allocator(config == null ? IntPtr.Zero : config.Handle, out native_allocator, native_parms);
			bool ret = raw_ret;
			allocator = GLib.Object.GetObject(native_allocator) as Gst.Allocator;
			parms = Gst.AllocationParams.New (native_parms);
			Marshal.FreeHGlobal (native_parms);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_pool_config_get_option(IntPtr config, uint index);

		public static string ConfigGetOption(Gst.Structure config, uint index) {
			IntPtr raw_ret = gst_buffer_pool_config_get_option(config == null ? IntPtr.Zero : config.Handle, index);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_pool_config_get_params(IntPtr config, out IntPtr caps, out uint size, out uint min_buffers, out uint max_buffers);

		public static bool ConfigGetParams(Gst.Structure config, out Gst.Caps caps, out uint size, out uint min_buffers, out uint max_buffers) {
			IntPtr native_caps;
			bool raw_ret = gst_buffer_pool_config_get_params(config == null ? IntPtr.Zero : config.Handle, out native_caps, out size, out min_buffers, out max_buffers);
			bool ret = raw_ret;
			caps = native_caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (native_caps, typeof (Gst.Caps), false);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_pool_config_has_option(IntPtr config, IntPtr option);

		public static bool ConfigHasOption(Gst.Structure config, string option) {
			IntPtr native_option = GLib.Marshaller.StringToPtrGStrdup (option);
			bool raw_ret = gst_buffer_pool_config_has_option(config == null ? IntPtr.Zero : config.Handle, native_option);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_option);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_buffer_pool_config_n_options(IntPtr config);

		public static uint ConfigNOptions(Gst.Structure config) {
			uint raw_ret = gst_buffer_pool_config_n_options(config == null ? IntPtr.Zero : config.Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_pool_config_set_allocator(IntPtr config, IntPtr allocator, IntPtr parms);

		public static void ConfigSetAllocator(Gst.Structure config, Gst.Allocator allocator, Gst.AllocationParams parms) {
			IntPtr native_parms = GLib.Marshaller.StructureToPtrAlloc (parms);
			gst_buffer_pool_config_set_allocator(config == null ? IntPtr.Zero : config.Handle, allocator == null ? IntPtr.Zero : allocator.Handle, native_parms);
			Marshal.FreeHGlobal (native_parms);
		}

		public static void ConfigSetAllocator(Gst.Structure config) {
			ConfigSetAllocator (config, null, Gst.AllocationParams.Zero);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_pool_config_set_params(IntPtr config, IntPtr caps, uint size, uint min_buffers, uint max_buffers);

		public static void ConfigSetParams(Gst.Structure config, Gst.Caps caps, uint size, uint min_buffers, uint max_buffers) {
			gst_buffer_pool_config_set_params(config == null ? IntPtr.Zero : config.Handle, caps == null ? IntPtr.Zero : caps.Handle, size, min_buffers, max_buffers);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_pool_config_validate_params(IntPtr config, IntPtr caps, uint size, uint min_buffers, uint max_buffers);

		public static bool ConfigValidateParams(Gst.Structure config, Gst.Caps caps, uint size, uint min_buffers, uint max_buffers) {
			bool raw_ret = gst_buffer_pool_config_validate_params(config == null ? IntPtr.Zero : config.Handle, caps == null ? IntPtr.Zero : caps.Handle, size, min_buffers, max_buffers);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_buffer_pool_acquire_buffer(IntPtr raw, out IntPtr buffer, IntPtr parms);

		public Gst.FlowReturn AcquireBuffer(out Gst.Buffer buffer, Gst.BufferPoolAcquireParams parms) {
			IntPtr native_buffer;
			IntPtr native_parms = GLib.Marshaller.StructureToPtrAlloc (parms);
			int raw_ret = gst_buffer_pool_acquire_buffer(Handle, out native_buffer, native_parms);
			Gst.FlowReturn ret = (Gst.FlowReturn) raw_ret;
			buffer = native_buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (native_buffer, typeof (Gst.Buffer), true);
			Marshal.FreeHGlobal (native_parms);
			return ret;
		}

		public Gst.FlowReturn AcquireBuffer(out Gst.Buffer buffer) {
			return AcquireBuffer (out buffer, Gst.BufferPoolAcquireParams.Zero);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_pool_get_config(IntPtr raw);

		public Gst.Structure Config { 
			get {
				IntPtr raw_ret = gst_buffer_pool_get_config(Handle);
				Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), true);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_pool_get_options(IntPtr raw);

		public string[] Options { 
			get {
				IntPtr raw_ret = gst_buffer_pool_get_options(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_pool_has_option(IntPtr raw, IntPtr option);

		public bool HasOption(string option) {
			IntPtr native_option = GLib.Marshaller.StringToPtrGStrdup (option);
			bool raw_ret = gst_buffer_pool_has_option(Handle, native_option);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_option);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_pool_is_active(IntPtr raw);

		public bool IsActive { 
			get {
				bool raw_ret = gst_buffer_pool_is_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_pool_release_buffer(IntPtr raw, IntPtr buffer);

		public void ReleaseBuffer(Gst.Buffer buffer) {
			buffer.Owned = false;
			gst_buffer_pool_release_buffer(Handle, buffer == null ? IntPtr.Zero : buffer.Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_pool_set_active(IntPtr raw, bool active);

		public bool SetActive(bool active) {
			bool raw_ret = gst_buffer_pool_set_active(Handle, active);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_pool_set_config(IntPtr raw, IntPtr config);

		public bool SetConfig(Gst.Structure config) {
			config.Owned = false;
			bool raw_ret = gst_buffer_pool_set_config(Handle, config == null ? IntPtr.Zero : config.Handle);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("flushing"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(bool)) // flushing
							, null
							, "priv"
							, (long) Marshal.OffsetOf(typeof(GstBufferPool_flushingAlign), "flushing")
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "flushing"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstBufferPool_flushingAlign
		{
			sbyte f1;
			private bool flushing;
		}


		// End of the ABI representation.

#endregion
	}
}