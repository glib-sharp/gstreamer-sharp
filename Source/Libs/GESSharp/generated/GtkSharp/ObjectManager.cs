// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp.GstEditingServices {

	public class ObjectManager {

		static bool initialized = false;
		// Call this method from the appropriate module init function.
		public static void Initialize ()
		{
			if (initialized)
				return;

			initialized = true;
			GLib.GType.Register (GES.Asset.GType, typeof (GES.Asset));
			GLib.GType.Register (GES.AudioSource.GType, typeof (GES.AudioSource));
			GLib.GType.Register (GES.AudioTestSource.GType, typeof (GES.AudioTestSource));
			GLib.GType.Register (GES.AudioTrack.GType, typeof (GES.AudioTrack));
			GLib.GType.Register (GES.AudioTransition.GType, typeof (GES.AudioTransition));
			GLib.GType.Register (GES.AudioUriSource.GType, typeof (GES.AudioUriSource));
			GLib.GType.Register (GES.BaseEffect.GType, typeof (GES.BaseEffect));
			GLib.GType.Register (GES.BaseEffectClip.GType, typeof (GES.BaseEffectClip));
			GLib.GType.Register (GES.BaseTransitionClip.GType, typeof (GES.BaseTransitionClip));
			GLib.GType.Register (GES.BaseXmlFormatter.GType, typeof (GES.BaseXmlFormatter));
			GLib.GType.Register (GES.Clip.GType, typeof (GES.Clip));
			GLib.GType.Register (GES.ClipAsset.GType, typeof (GES.ClipAsset));
			GLib.GType.Register (GES.CommandLineFormatter.GType, typeof (GES.CommandLineFormatter));
			GLib.GType.Register (GES.Container.GType, typeof (GES.Container));
			GLib.GType.Register (GES.Effect.GType, typeof (GES.Effect));
			GLib.GType.Register (GES.EffectAsset.GType, typeof (GES.EffectAsset));
			GLib.GType.Register (GES.EffectClip.GType, typeof (GES.EffectClip));
			GLib.GType.Register (GES.Formatter.GType, typeof (GES.Formatter));
			GLib.GType.Register (GES.Group.GType, typeof (GES.Group));
			GLib.GType.Register (GES.ImageSource.GType, typeof (GES.ImageSource));
			GLib.GType.Register (GES.Layer.GType, typeof (GES.Layer));
			GLib.GType.Register (GES.MultiFileSource.GType, typeof (GES.MultiFileSource));
			GLib.GType.Register (GES.Operation.GType, typeof (GES.Operation));
			GLib.GType.Register (GES.OperationClip.GType, typeof (GES.OperationClip));
			GLib.GType.Register (GES.OverlayClip.GType, typeof (GES.OverlayClip));
			GLib.GType.Register (GES.Pipeline.GType, typeof (GES.Pipeline));
			GLib.GType.Register (GES.Project.GType, typeof (GES.Project));
			GLib.GType.Register (GES.Source.GType, typeof (GES.Source));
			GLib.GType.Register (GES.SourceClip.GType, typeof (GES.SourceClip));
			GLib.GType.Register (GES.TestClip.GType, typeof (GES.TestClip));
			GLib.GType.Register (GES.TextOverlay.GType, typeof (GES.TextOverlay));
			GLib.GType.Register (GES.TextOverlayClip.GType, typeof (GES.TextOverlayClip));
			GLib.GType.Register (GES.Timeline.GType, typeof (GES.Timeline));
			GLib.GType.Register (GES.TimelineElement.GType, typeof (GES.TimelineElement));
			GLib.GType.Register (GES.TitleClip.GType, typeof (GES.TitleClip));
			GLib.GType.Register (GES.TitleSource.GType, typeof (GES.TitleSource));
			GLib.GType.Register (GES.Track.GType, typeof (GES.Track));
			GLib.GType.Register (GES.TrackElement.GType, typeof (GES.TrackElement));
			GLib.GType.Register (GES.TrackElementAsset.GType, typeof (GES.TrackElementAsset));
			GLib.GType.Register (GES.Transition.GType, typeof (GES.Transition));
			GLib.GType.Register (GES.TransitionClip.GType, typeof (GES.TransitionClip));
			GLib.GType.Register (GES.UriClip.GType, typeof (GES.UriClip));
			GLib.GType.Register (GES.UriClipAsset.GType, typeof (GES.UriClipAsset));
			GLib.GType.Register (GES.UriSourceAsset.GType, typeof (GES.UriSourceAsset));
			GLib.GType.Register (GES.VideoSource.GType, typeof (GES.VideoSource));
			GLib.GType.Register (GES.VideoTestSource.GType, typeof (GES.VideoTestSource));
			GLib.GType.Register (GES.VideoTrack.GType, typeof (GES.VideoTrack));
			GLib.GType.Register (GES.VideoTransition.GType, typeof (GES.VideoTransition));
			GLib.GType.Register (GES.VideoUriSource.GType, typeof (GES.VideoUriSource));
			GLib.GType.Register (GES.XmlFormatter.GType, typeof (GES.XmlFormatter));
		}
	}
}
