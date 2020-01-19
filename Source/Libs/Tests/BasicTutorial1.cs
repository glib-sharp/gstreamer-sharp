using Gst;
using Xunit;

namespace Tests
{
    public class BasicTutorial1
    {
        [Fact]
        public void Test()
        {
            // Initialize Gstreamer
            Application.Init();

            // Build the pipeline
            var pipeline =
                Parse.Launch("playbin uri=http://download.blender.org/durian/trailer/sintel_trailer-1080p.mp4");

            // Start playing
            pipeline.SetState(State.Playing);

            // Wait until error or EOS
            var bus = pipeline.Bus;
            var msg = bus.TimedPopFiltered(Constants.CLOCK_TIME_NONE, MessageType.Eos | MessageType.Error);

            // Free resources
            pipeline.SetState(State.Null);
        }
    }
}