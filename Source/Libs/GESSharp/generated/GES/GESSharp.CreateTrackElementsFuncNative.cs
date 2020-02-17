// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GESSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr CreateTrackElementsFuncNative(IntPtr clip, int type);

	internal class CreateTrackElementsFuncInvoker {

		CreateTrackElementsFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~CreateTrackElementsFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal CreateTrackElementsFuncInvoker (CreateTrackElementsFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal CreateTrackElementsFuncInvoker (CreateTrackElementsFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal CreateTrackElementsFuncInvoker (CreateTrackElementsFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GES.CreateTrackElementsFunc Handler {
			get {
				return new GES.CreateTrackElementsFunc(InvokeNative);
			}
		}

		IntPtr[] InvokeNative (GES.Clip clip, GES.TrackType type)
		{
			IntPtr[] __result = (IntPtr[]) GLib.Marshaller.ListPtrToArray (native_cb (clip == null ? IntPtr.Zero : clip.Handle, (int) type), typeof(GLib.List), false, false, typeof(IntPtr));
			return __result;
		}
	}

	internal class CreateTrackElementsFuncWrapper {

		public IntPtr NativeCallback (IntPtr clip, int type)
		{
			try {
				IntPtr[] __ret = managed (GLib.Object.GetObject(clip) as GES.Clip, (GES.TrackType) type);
				if (release_on_call)
					gch.Free ();
				return new GLib.List(__ret, typeof (IntPtr), false, false) == null ? IntPtr.Zero : new GLib.List(__ret, typeof (IntPtr), false, false).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal CreateTrackElementsFuncNative NativeDelegate;
		GES.CreateTrackElementsFunc managed;

		public CreateTrackElementsFuncWrapper (GES.CreateTrackElementsFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new CreateTrackElementsFuncNative (NativeCallback);
		}

		public static GES.CreateTrackElementsFunc GetManagedDelegate (CreateTrackElementsFuncNative native)
		{
			if (native == null)
				return null;
			CreateTrackElementsFuncWrapper wrapper = (CreateTrackElementsFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
