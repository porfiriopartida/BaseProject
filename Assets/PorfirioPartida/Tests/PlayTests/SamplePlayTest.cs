using System.Collections;
using UnityEngine.TestTools;

namespace PorfirioPartida.Tests.PlayTests
{
    public class SamplePlayTest
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SampleSkipFrameTest()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
