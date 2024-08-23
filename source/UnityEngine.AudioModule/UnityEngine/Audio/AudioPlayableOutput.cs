using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x02000007 RID: 7
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public struct AudioPlayableOutput
	{
		// Token: 0x04000006 RID: 6
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;
	}
}
