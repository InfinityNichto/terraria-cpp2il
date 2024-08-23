using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x0200012A RID: 298
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000151")]
	public struct PlayableGraph
	{
		// Token: 0x040005D9 RID: 1497
		[global::Cpp2ILInjected.Token(Token = "0x400062F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IntPtr m_Handle;

		// Token: 0x040005DA RID: 1498
		[global::Cpp2ILInjected.Token(Token = "0x4000630")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal uint m_Version;
	}
}
