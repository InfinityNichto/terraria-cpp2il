using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	// Token: 0x020003C3 RID: 963
	[global::Cpp2ILInjected.Token(Token = "0x2000569")]
	public class FishingInfo_OldMobile
	{
		// Token: 0x06002F5D RID: 12125 RVA: 0x0002A761 File Offset: 0x00028961
		[global::Cpp2ILInjected.Token(Token = "0x60033C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x134106C", Offset = "0x134106C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadOldNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Load(BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x0002A764 File Offset: 0x00028964
		[global::Cpp2ILInjected.Token(Token = "0x60033C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x13411C8", Offset = "0x13411C8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public FishingInfo_OldMobile()
		{
			throw null;
		}

		// Token: 0x040032B2 RID: 12978
		[global::Cpp2ILInjected.Token(Token = "0x4003C68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private short currentQuest;

		// Token: 0x040032B3 RID: 12979
		[global::Cpp2ILInjected.Token(Token = "0x4003C69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private bool questCompletedToday;

		// Token: 0x040032B4 RID: 12980
		[global::Cpp2ILInjected.Token(Token = "0x4003C6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<string> playersCompleted;
	}
}
