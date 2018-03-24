// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.SeekFlagsGType))]
	public enum SeekFlags {

		None = 0,
		Flush = 1,
		Accurate = 2,
		KeyUnit = 4,
		Segment = 8,
		Trickmode = 16,
		Skip = 16,
		SnapBefore = 32,
		SnapAfter = 64,
		SnapNearest = 96,
		TrickmodeKeyUnits = 128,
		TrickmodeNoAudio = 256,
	}

	internal class SeekFlagsGType {
		[DllImport ("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_seek_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_seek_flags_get_type ());
			}
		}
	}
#endregion
}