using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	// Token: 0x020003C9 RID: 969
	[global::Cpp2ILInjected.Token(Token = "0x2000573")]
	public class SignInfo_OldMobile
	{
		// Token: 0x06002F75 RID: 12149 RVA: 0x0002A7A9 File Offset: 0x000289A9
		[global::Cpp2ILInjected.Token(Token = "0x60033E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1345AC4", Offset = "0x1345AC4", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignInfo_OldMobile), Member = "UserString", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sign), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool Load(BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x0002A7AC File Offset: 0x000289AC
		[global::Cpp2ILInjected.Token(Token = "0x60033E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1345CD4", Offset = "0x1345CD4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignInfo_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadOldNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string UserString(BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x0002A7AF File Offset: 0x000289AF
		[global::Cpp2ILInjected.Token(Token = "0x60033E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1345D4C", Offset = "0x1345D4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SignInfo_OldMobile()
		{
			throw null;
		}
	}
}
