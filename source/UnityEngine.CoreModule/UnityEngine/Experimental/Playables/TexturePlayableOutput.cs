using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000120 RID: 288
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
	[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000145")]
	public struct TexturePlayableOutput
	{
		// Token: 0x040005C2 RID: 1474
		[global::Cpp2ILInjected.Token(Token = "0x4000611")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;
	}
}
