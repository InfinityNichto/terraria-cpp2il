using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Creative;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x0200066F RID: 1647
	[global::Cpp2ILInjected.Token(Token = "0x20009F6")]
	public class NetCreativeUnlocksModule : NetModule
	{
		// Token: 0x060040ED RID: 16621 RVA: 0x0002D9A4 File Offset: 0x0002BBA4
		[global::Cpp2ILInjected.Token(Token = "0x6004B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8584", Offset = "0x8A8584", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket SerializeItemSacrifice(int itemId, int sacrificeCount)
		{
			throw null;
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x0002D9A7 File Offset: 0x0002BBA7
		[global::Cpp2ILInjected.Token(Token = "0x6004B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A862C", Offset = "0x8A862C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayerCreativeTracker", ReturnType = typeof(CreativeUnlocksTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "SetSacrificeCountDirectly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			throw null;
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x0002D9AA File Offset: 0x0002BBAA
		[global::Cpp2ILInjected.Token(Token = "0x6004B74")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A8758", Offset = "0x8A8758", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetCreativeUnlocksModule()
		{
			throw null;
		}
	}
}
