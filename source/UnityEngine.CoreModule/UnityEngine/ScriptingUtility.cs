using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
	internal class ScriptingUtility
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000347")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D924", Offset = "0x1F7D924", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsManagedCodeWorking()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
		private struct TestClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000372")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int value;
		}
	}
}
