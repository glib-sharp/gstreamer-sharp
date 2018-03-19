// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCStatsTypeGType))]
	public enum WebRTCStatsType {

		Codec = 1,
		InboundRtp = 2,
		OutboundRtp = 3,
		RemoteInboundRtp = 4,
		RemoteOutboundRtp = 5,
		Csrc = 6,
		PeerConnection = 7,
		DataChannel = 8,
		Stream = 9,
		Transport = 10,
		CandidatePair = 11,
		LocalCandidate = 12,
		RemoteCandidate = 13,
		Certificate = 14,
	}

	internal class WebRTCStatsTypeGType {
		[DllImport ("libgstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_stats_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_stats_type_get_type ());
			}
		}
	}
#endregion
}
