using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Terraria.Audio;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200066C")]
	public class RejectionMenuInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x600370D")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D97C", Offset = "0x141D97C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DefaultExitAction()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600370E")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DA00", Offset = "0x141DA00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RejectionMenuInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007812")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ReturnFromRejectionMenuAction ExitAction;

		[global::Cpp2ILInjected.Token(Token = "0x4007813")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string TextToShow;
	}
}
