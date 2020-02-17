// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VideoFilter : Gst.Base.BaseTransform {

		protected VideoFilter (IntPtr raw) : base(raw) {}

		protected VideoFilter() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		public bool Negotiated {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("negotiated"));
					return (*raw_ptr);
				}
			}
		}

		public Gst.Video.VideoInfo InInfo {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("in_info"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Video.VideoInfo), false);
				}
			}
		}

		public Gst.Video.VideoInfo OutInfo {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("out_info"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Video.VideoInfo), false);
				}
			}
		}

		static SetInfoNativeDelegate SetInfo_cb_delegate;
		static SetInfoNativeDelegate SetInfoVMCallback {
			get {
				if (SetInfo_cb_delegate == null)
					SetInfo_cb_delegate = new SetInfoNativeDelegate (SetInfo_cb);
				return SetInfo_cb_delegate;
			}
		}

		static void OverrideSetInfo (GLib.GType gtype)
		{
			OverrideSetInfo (gtype, SetInfoVMCallback);
		}

		static void OverrideSetInfo (GLib.GType gtype, SetInfoNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("set_info"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetInfoNativeDelegate (IntPtr inst, IntPtr incaps, IntPtr in_info, IntPtr outcaps, IntPtr out_info);

		static bool SetInfo_cb (IntPtr inst, IntPtr incaps, IntPtr in_info, IntPtr outcaps, IntPtr out_info)
		{
			try {
				VideoFilter __obj = GLib.Object.GetObject (inst, false) as VideoFilter;
				bool __result;
				__result = __obj.OnSetInfo (incaps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (incaps, typeof (Gst.Caps), false), in_info == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque (in_info, typeof (Gst.Video.VideoInfo), false), outcaps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (outcaps, typeof (Gst.Caps), false), out_info == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque (out_info, typeof (Gst.Video.VideoInfo), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Video.VideoFilter), ConnectionMethod="OverrideSetInfo")]
		protected virtual bool OnSetInfo (Gst.Caps incaps, Gst.Video.VideoInfo in_info, Gst.Caps outcaps, Gst.Video.VideoInfo out_info)
		{
			return InternalSetInfo (incaps, in_info, outcaps, out_info);
		}

		private bool InternalSetInfo (Gst.Caps incaps, Gst.Video.VideoInfo in_info, Gst.Caps outcaps, Gst.Video.VideoInfo out_info)
		{
			SetInfoNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("set_info"));
				unmanaged = (SetInfoNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SetInfoNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, incaps == null ? IntPtr.Zero : incaps.Handle, in_info == null ? IntPtr.Zero : in_info.Handle, outcaps == null ? IntPtr.Zero : outcaps.Handle, out_info == null ? IntPtr.Zero : out_info.Handle);
			return __result;
		}

		static TransformFrameNativeDelegate TransformFrame_cb_delegate;
		static TransformFrameNativeDelegate TransformFrameVMCallback {
			get {
				if (TransformFrame_cb_delegate == null)
					TransformFrame_cb_delegate = new TransformFrameNativeDelegate (TransformFrame_cb);
				return TransformFrame_cb_delegate;
			}
		}

		static void OverrideTransformFrame (GLib.GType gtype)
		{
			OverrideTransformFrame (gtype, TransformFrameVMCallback);
		}

		static void OverrideTransformFrame (GLib.GType gtype, TransformFrameNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("transform_frame"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int TransformFrameNativeDelegate (IntPtr inst, IntPtr inframe, IntPtr outframe);

		static int TransformFrame_cb (IntPtr inst, IntPtr inframe, IntPtr outframe)
		{
			try {
				VideoFilter __obj = GLib.Object.GetObject (inst, false) as VideoFilter;
				Gst.FlowReturn __result;
				__result = __obj.OnTransformFrame (Gst.Video.VideoFrame.New (inframe), Gst.Video.VideoFrame.New (outframe));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Video.VideoFilter), ConnectionMethod="OverrideTransformFrame")]
		protected virtual Gst.FlowReturn OnTransformFrame (Gst.Video.VideoFrame inframe, Gst.Video.VideoFrame outframe)
		{
			return InternalTransformFrame (inframe, outframe);
		}

		private Gst.FlowReturn InternalTransformFrame (Gst.Video.VideoFrame inframe, Gst.Video.VideoFrame outframe)
		{
			TransformFrameNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("transform_frame"));
				unmanaged = (TransformFrameNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TransformFrameNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			IntPtr native_inframe = GLib.Marshaller.StructureToPtrAlloc (inframe);
			IntPtr native_outframe = GLib.Marshaller.StructureToPtrAlloc (outframe);
			int __result = unmanaged (this.Handle, native_inframe, native_outframe);
			Marshal.FreeHGlobal (native_inframe);
			Marshal.FreeHGlobal (native_outframe);
			return (Gst.FlowReturn) __result;
		}

		static TransformFrameIpNativeDelegate TransformFrameIp_cb_delegate;
		static TransformFrameIpNativeDelegate TransformFrameIpVMCallback {
			get {
				if (TransformFrameIp_cb_delegate == null)
					TransformFrameIp_cb_delegate = new TransformFrameIpNativeDelegate (TransformFrameIp_cb);
				return TransformFrameIp_cb_delegate;
			}
		}

		static void OverrideTransformFrameIp (GLib.GType gtype)
		{
			OverrideTransformFrameIp (gtype, TransformFrameIpVMCallback);
		}

		static void OverrideTransformFrameIp (GLib.GType gtype, TransformFrameIpNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("transform_frame_ip"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int TransformFrameIpNativeDelegate (IntPtr inst, IntPtr frame);

		static int TransformFrameIp_cb (IntPtr inst, IntPtr frame)
		{
			try {
				VideoFilter __obj = GLib.Object.GetObject (inst, false) as VideoFilter;
				Gst.FlowReturn __result;
				__result = __obj.OnTransformFrameIp (Gst.Video.VideoFrame.New (frame));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Video.VideoFilter), ConnectionMethod="OverrideTransformFrameIp")]
		protected virtual Gst.FlowReturn OnTransformFrameIp (Gst.Video.VideoFrame frame)
		{
			return InternalTransformFrameIp (frame);
		}

		private Gst.FlowReturn InternalTransformFrameIp (Gst.Video.VideoFrame frame)
		{
			TransformFrameIpNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("transform_frame_ip"));
				unmanaged = (TransformFrameIpNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TransformFrameIpNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			IntPtr native_frame = GLib.Marshaller.StructureToPtrAlloc (frame);
			int __result = unmanaged (this.Handle, native_frame);
			Marshal.FreeHGlobal (native_frame);
			return (Gst.FlowReturn) __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("set_info"
							, Gst.Base.BaseTransform.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // set_info
							, null
							, "transform_frame"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("transform_frame"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // transform_frame
							, "set_info"
							, "transform_frame_ip"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("transform_frame_ip"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // transform_frame_ip
							, "transform_frame"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "transform_frame_ip"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_filter_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_filter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static VideoFilter ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("negotiated"
							, Gst.Base.BaseTransform.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(bool)) // negotiated
							, null
							, "in_info"
							, (long) Marshal.OffsetOf(typeof(GstVideoFilter_negotiatedAlign), "negotiated")
							, 0
							),
						new GLib.AbiField("in_info"
							, -1
							, Gst.Video.VideoInfo.abi_info.Size // in_info
							, "negotiated"
							, "out_info"
							, Gst.Video.VideoInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("out_info"
							, -1
							, Gst.Video.VideoInfo.abi_info.Size // out_info
							, "in_info"
							, "_gst_reserved"
							, Gst.Video.VideoInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "out_info"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoFilter_negotiatedAlign
		{
			sbyte f1;
			private bool negotiated;
		}


		// End of the ABI representation.

#endregion
	}
}
