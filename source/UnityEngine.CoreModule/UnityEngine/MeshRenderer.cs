using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000047")]
	public class MeshRenderer : Renderer
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D4C0", Offset = "0x1F6D4C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DontStripMeshRenderer()
		{
			throw null;
		}
	}
}
