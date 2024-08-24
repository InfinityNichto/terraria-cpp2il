using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x0200044C RID: 1100
	[global::Cpp2ILInjected.Token(Token = "0x2000648")]
	public struct PlayerMovementAccsCache
	{
		// Token: 0x060031BD RID: 12733 RVA: 0x0002AE69 File Offset: 0x00029069
		[global::Cpp2ILInjected.Token(Token = "0x60036DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x141CFD4", Offset = "0x141CFD4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_BlockExtraJumps", ReturnType = typeof(bool))]
		public void CopyFrom(Player player)
		{
			throw null;
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x0002AE6C File Offset: 0x0002906C
		[global::Cpp2ILInjected.Token(Token = "0x60036DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D060", Offset = "0x141D060", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void PasteInto(Player player)
		{
			throw null;
		}

		// Token: 0x040063F1 RID: 25585
		[global::Cpp2ILInjected.Token(Token = "0x40077E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _readyToPaste;

		// Token: 0x040063F2 RID: 25586
		[global::Cpp2ILInjected.Token(Token = "0x40077E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		private bool _mountPreventedFlight;

		// Token: 0x040063F3 RID: 25587
		[global::Cpp2ILInjected.Token(Token = "0x40077E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		private bool _mountPreventedExtraJumps;

		// Token: 0x040063F4 RID: 25588
		[global::Cpp2ILInjected.Token(Token = "0x40077E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int rocketTime;

		// Token: 0x040063F5 RID: 25589
		[global::Cpp2ILInjected.Token(Token = "0x40077E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private float wingTime;

		// Token: 0x040063F6 RID: 25590
		[global::Cpp2ILInjected.Token(Token = "0x40077E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private int rocketDelay;

		// Token: 0x040063F7 RID: 25591
		[global::Cpp2ILInjected.Token(Token = "0x40077E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int rocketDelay2;

		// Token: 0x040063F8 RID: 25592
		[global::Cpp2ILInjected.Token(Token = "0x40077E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool jumpAgainCloud;

		// Token: 0x040063F9 RID: 25593
		[global::Cpp2ILInjected.Token(Token = "0x40077E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
		private bool jumpAgainSandstorm;

		// Token: 0x040063FA RID: 25594
		[global::Cpp2ILInjected.Token(Token = "0x40077EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
		private bool jumpAgainBlizzard;

		// Token: 0x040063FB RID: 25595
		[global::Cpp2ILInjected.Token(Token = "0x40077EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x17")]
		private bool jumpAgainFart;

		// Token: 0x040063FC RID: 25596
		[global::Cpp2ILInjected.Token(Token = "0x40077EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool jumpAgainSail;

		// Token: 0x040063FD RID: 25597
		[global::Cpp2ILInjected.Token(Token = "0x40077ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool jumpAgainUnicorn;
	}
}
