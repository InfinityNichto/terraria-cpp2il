using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Audio;

namespace Microsoft.Xna.Framework.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D2")]
	public class WaveBank
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A8E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4A58C", Offset = "0xB4A58C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyAudioSystem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WaveBank(AudioEngine engine, string contentPath)
		{
			throw null;
		}
	}
}
