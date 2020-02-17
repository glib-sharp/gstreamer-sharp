// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AudioResampler : GLib.Opaque {

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_audio_resampler_get_in_frames(IntPtr raw, UIntPtr out_frames);

		public ulong GetInFrames(ulong out_frames) {
			UIntPtr raw_ret = gst_audio_resampler_get_in_frames(Handle, new UIntPtr (out_frames));
			ulong ret = (ulong) raw_ret;
			return ret;
		}

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_audio_resampler_get_max_latency(IntPtr raw);

		public ulong MaxLatency { 
			get {
				UIntPtr raw_ret = gst_audio_resampler_get_max_latency(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_audio_resampler_get_out_frames(IntPtr raw, UIntPtr in_frames);

		public ulong GetOutFrames(ulong in_frames) {
			UIntPtr raw_ret = gst_audio_resampler_get_out_frames(Handle, new UIntPtr (in_frames));
			ulong ret = (ulong) raw_ret;
			return ret;
		}

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_audio_resampler_resample(IntPtr raw, IntPtr in_param, UIntPtr in_frames, IntPtr out_param, UIntPtr out_frames);

		public void Resample(IntPtr in_param, ulong in_frames, IntPtr out_param, ulong out_frames) {
			gst_audio_resampler_resample(Handle, in_param, new UIntPtr (in_frames), out_param, new UIntPtr (out_frames));
		}

		public void Resample(ulong in_frames, ulong out_frames) {
			Resample (IntPtr.Zero, in_frames, IntPtr.Zero, out_frames);
		}

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_audio_resampler_reset(IntPtr raw);

		public void Reset() {
			gst_audio_resampler_reset(Handle);
		}

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_audio_resampler_update(IntPtr raw, int in_rate, int out_rate, IntPtr options);

		public bool Update(int in_rate, int out_rate, Gst.Structure options) {
			bool raw_ret = gst_audio_resampler_update(Handle, in_rate, out_rate, options == null ? IntPtr.Zero : options.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_resampler_new(int method, int flags, int format, int channels, int in_rate, int out_rate, IntPtr options);

		public static Gst.Audio.AudioResampler New(Gst.Audio.AudioResamplerMethod method, Gst.Audio.AudioResamplerFlags flags, Gst.Audio.AudioFormat format, int channels, int in_rate, int out_rate, Gst.Structure options) {
			IntPtr raw_ret = gst_audio_resampler_new((int) method, (int) flags, (int) format, channels, in_rate, out_rate, options == null ? IntPtr.Zero : options.Handle);
			Gst.Audio.AudioResampler ret = raw_ret == IntPtr.Zero ? null : (Gst.Audio.AudioResampler) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Audio.AudioResampler), true);
			return ret;
		}

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_audio_resampler_options_set_quality(int method, uint quality, int in_rate, int out_rate, IntPtr options);

		public static void OptionsSetQuality(Gst.Audio.AudioResamplerMethod method, uint quality, int in_rate, int out_rate, Gst.Structure options) {
			gst_audio_resampler_options_set_quality((int) method, quality, in_rate, out_rate, options == null ? IntPtr.Zero : options.Handle);
		}

		public AudioResampler(IntPtr raw) : base(raw) {}

		[DllImport("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_audio_resampler_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_audio_resampler_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gst_audio_resampler_free (handle);
				return false;
			}
		}

		~AudioResampler ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}