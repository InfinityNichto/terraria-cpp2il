using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Audio;
using UnityEngine;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020002F2 RID: 754
	[global::Cpp2ILInjected.Token(Token = "0x20003CB")]
	public class AudioEngine
	{
		// Token: 0x060018D7 RID: 6359 RVA: 0x000264E3 File Offset: 0x000246E3
		[global::Cpp2ILInjected.Token(Token = "0x6001A66")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49964", Offset = "0xB49964", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Singleton<>), Member = "Create", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public AudioEngine(string contentPath)
		{
			throw null;
		}
	}
}
