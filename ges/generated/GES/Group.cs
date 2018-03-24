// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Group : GES.Container {

		public Group (IntPtr raw) : base(raw) {}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_group_new();

		public Group () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Group)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = ges_group_new();
		}

		[GLib.Property ("duration")]
		public new ulong Duration {
			get {
				GLib.Value val = GetProperty ("duration");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("duration", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("in-point")]
		public new ulong InPoint {
			get {
				GLib.Value val = GetProperty ("in-point");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("in-point", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("max-duration")]
		public new ulong MaxDuration {
			get {
				GLib.Value val = GetProperty ("max-duration");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("max-duration", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("priority")]
		public new uint Priority {
			get {
				GLib.Value val = GetProperty ("priority");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("priority", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("start")]
		public new ulong Start {
			get {
				GLib.Value val = GetProperty ("start");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("start", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_ges_reserved"
							, GES.Container.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
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

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_group_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_group_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static Group ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GES.Container.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "priv"
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