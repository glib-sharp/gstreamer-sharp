// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.Video.VideoMultiviewFramePackingGType))]
	public enum VideoMultiviewFramePacking {

		None = -1,
		Mono = 0,
		Left = 1,
		Right = 2,
		SideBySide = 3,
		SideBySideQuincunx = 4,
		ColumnInterleaved = 5,
		RowInterleaved = 6,
		TopBottom = 7,
		Checkerboard = 8,
	}

	internal class VideoMultiviewFramePackingGType {
		[DllImport ("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_multiview_frame_packing_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_multiview_frame_packing_get_type ());
			}
		}
	}
#endregion
}
