// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Parse {

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_parse_bin_from_description(IntPtr bin_description, bool ghost_unlinked_pads, out IntPtr error);

		public static unsafe Gst.Bin BinFromDescription(string bin_description, bool ghost_unlinked_pads) {
			IntPtr native_bin_description = GLib.Marshaller.StringToPtrGStrdup (bin_description);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_parse_bin_from_description(native_bin_description, ghost_unlinked_pads, out error);
			Gst.Bin ret = GLib.Object.GetObject(raw_ret) as Gst.Bin;
			GLib.Marshaller.Free (native_bin_description);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_parse_bin_from_description_full(IntPtr bin_description, bool ghost_unlinked_pads, IntPtr context, int flags, out IntPtr error);

		public static unsafe Gst.Element BinFromDescriptionFull(string bin_description, bool ghost_unlinked_pads, Gst.ParseContext context, Gst.ParseFlags flags) {
			IntPtr native_bin_description = GLib.Marshaller.StringToPtrGStrdup (bin_description);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_parse_bin_from_description_full(native_bin_description, ghost_unlinked_pads, context == null ? IntPtr.Zero : context.Handle, (int) flags, out error);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			GLib.Marshaller.Free (native_bin_description);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public static Gst.Element BinFromDescriptionFull(string bin_description, bool ghost_unlinked_pads, Gst.ParseFlags flags) {
			return BinFromDescriptionFull (bin_description, ghost_unlinked_pads, null, flags);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_parse_error_quark();

		public static uint ErrorQuark() {
			uint raw_ret = gst_parse_error_quark();
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_parse_launch(IntPtr pipeline_description, out IntPtr error);

		public static unsafe Gst.Element Launch(string pipeline_description) {
			IntPtr native_pipeline_description = GLib.Marshaller.StringToPtrGStrdup (pipeline_description);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_parse_launch(native_pipeline_description, out error);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			GLib.Marshaller.Free (native_pipeline_description);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_parse_launch_full(IntPtr pipeline_description, IntPtr context, int flags, out IntPtr error);

		public static unsafe Gst.Element LaunchFull(string pipeline_description, Gst.ParseContext context, Gst.ParseFlags flags) {
			IntPtr native_pipeline_description = GLib.Marshaller.StringToPtrGStrdup (pipeline_description);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_parse_launch_full(native_pipeline_description, context == null ? IntPtr.Zero : context.Handle, (int) flags, out error);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			GLib.Marshaller.Free (native_pipeline_description);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public static Gst.Element LaunchFull(string pipeline_description, Gst.ParseFlags flags) {
			return LaunchFull (pipeline_description, null, flags);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_parse_launchv(IntPtr[] argv, out IntPtr error);

		public static unsafe Gst.Element Launchv(string[] argv) {
			int cnt_argv = argv == null ? 0 : argv.Length;
			IntPtr[] native_argv = new IntPtr [cnt_argv + 1];
			for (int i = 0; i < cnt_argv; i++)
				native_argv [i] = GLib.Marshaller.StringToPtrGStrdup(argv[i]);
			native_argv [cnt_argv] = IntPtr.Zero;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_parse_launchv(native_argv, out error);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_parse_launchv_full(IntPtr[] argv, IntPtr context, int flags, out IntPtr error);

		public static unsafe Gst.Element LaunchvFull(string[] argv, Gst.ParseContext context, Gst.ParseFlags flags) {
			int cnt_argv = argv == null ? 0 : argv.Length;
			IntPtr[] native_argv = new IntPtr [cnt_argv + 1];
			for (int i = 0; i < cnt_argv; i++)
				native_argv [i] = GLib.Marshaller.StringToPtrGStrdup(argv[i]);
			native_argv [cnt_argv] = IntPtr.Zero;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_parse_launchv_full(native_argv, context == null ? IntPtr.Zero : context.Handle, (int) flags, out error);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public static Gst.Element LaunchvFull(string[] argv, Gst.ParseFlags flags) {
			return LaunchvFull (argv, null, flags);
		}

#endregion
	}
}
