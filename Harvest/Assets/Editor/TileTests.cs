using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TileTests {

    [Test]
    public void TileTestsSimplePasses()
    {
        Vector3 temp = new Vector3();
        for (int i = 0; i < 256*256; i++)
        {
            temp.x = i%256;
            temp.z = i/256;
            Assert.AreEqual(i,Tile.GetIdByPosition(temp));
        }
    }

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator TileTestsWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
