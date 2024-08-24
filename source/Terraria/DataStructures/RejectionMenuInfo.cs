using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Terraria.Audio;

namespace Terraria.DataStructures
{
	// Token: 0x02000470 RID: 1136
	[global::Cpp2ILInjected.Token(Token = "0x200066C")]
	public class RejectionMenuInfo
	{
		// Token: 0x060031F0 RID: 12784 RVA: 0x0002AEF6 File Offset: 0x000290F6
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

		// Token: 0x060031F1 RID: 12785 RVA: 0x0002AEF9 File Offset: 0x000290F9
		[global::Cpp2ILInjected.Token(Token = "0x600370E")]
		[global::Cpp2ILInjected.Address(RVA = "0x141DA00", Offset = "0x141DA00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RejectionMenuInfo()
		{
			throw null;
		}

		// Token: 0x04006422 RID: 25634
		[global::Cpp2ILInjected.Token(Token = "0x4007812")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ReturnFromRejectionMenuAction ExitAction;

		// Token: 0x04006423 RID: 25635
		[global::Cpp2ILInjected.Token(Token = "0x4007813")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string TextToShow;
	}
}
