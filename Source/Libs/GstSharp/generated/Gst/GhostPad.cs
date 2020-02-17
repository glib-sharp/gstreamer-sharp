// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GhostPad : Gst.ProxyPad {

		public GhostPad (IntPtr raw) : base(raw) {}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_ghost_pad_new(IntPtr name, IntPtr target);

		public GhostPad (string name, Gst.Pad target) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GhostPad)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gst_ghost_pad_new(native_name, target == null ? IntPtr.Zero : target.Handle);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_ghost_pad_new_from_template(IntPtr name, IntPtr target, IntPtr templ);

		public GhostPad (string name, Gst.Pad target, Gst.PadTemplate templ) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GhostPad)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gst_ghost_pad_new_from_template(native_name, target == null ? IntPtr.Zero : target.Handle, templ == null ? IntPtr.Zero : templ.Handle);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_ghost_pad_new_no_target(IntPtr name, int dir);

		public GhostPad (string name, Gst.PadDirection dir) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GhostPad)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gst_ghost_pad_new_no_target(native_name, (int) dir);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_ghost_pad_new_no_target_from_template(IntPtr name, IntPtr templ);

		public GhostPad (string name, Gst.PadTemplate templ) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GhostPad)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gst_ghost_pad_new_no_target_from_template(native_name, templ == null ? IntPtr.Zero : templ.Handle);
			GLib.Marshaller.Free (native_name);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gst_reserved"
							, Gst.ProxyPad.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_ghost_pad_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_ghost_pad_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_ghost_pad_activate_mode_default(IntPtr pad, IntPtr parent, int mode, bool active);

		public static bool ActivateModeDefault(Gst.Pad pad, Gst.Object parent, Gst.PadMode mode, bool active) {
			bool raw_ret = gst_ghost_pad_activate_mode_default(pad == null ? IntPtr.Zero : pad.Handle, parent == null ? IntPtr.Zero : parent.Handle, (int) mode, active);
			bool ret = raw_ret;
			return ret;
		}

		public static bool ActivateModeDefault(Gst.Pad pad, Gst.PadMode mode, bool active) {
			return ActivateModeDefault (pad, null, mode, active);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_ghost_pad_internal_activate_mode_default(IntPtr pad, IntPtr parent, int mode, bool active);

		public static bool InternalActivateModeDefault(Gst.Pad pad, Gst.Object parent, Gst.PadMode mode, bool active) {
			bool raw_ret = gst_ghost_pad_internal_activate_mode_default(pad == null ? IntPtr.Zero : pad.Handle, parent == null ? IntPtr.Zero : parent.Handle, (int) mode, active);
			bool ret = raw_ret;
			return ret;
		}

		public static bool InternalActivateModeDefault(Gst.Pad pad, Gst.PadMode mode, bool active) {
			return InternalActivateModeDefault (pad, null, mode, active);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_ghost_pad_construct(IntPtr raw);

		public bool Construct() {
			bool raw_ret = gst_ghost_pad_construct(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_ghost_pad_get_target(IntPtr raw);

		public Gst.Pad Target { 
			get {
				IntPtr raw_ret = gst_ghost_pad_get_target(Handle);
				Gst.Pad ret = GLib.Object.GetObject(raw_ret, true) as Gst.Pad;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_ghost_pad_set_target(IntPtr raw, IntPtr newtarget);

		public bool SetTarget(Gst.Pad newtarget) {
			bool raw_ret = gst_ghost_pad_set_target(Handle, newtarget == null ? IntPtr.Zero : newtarget.Handle);
			bool ret = raw_ret;
			return ret;
		}

		public bool SetTarget() {
			return SetTarget (null);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.ProxyPad.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
