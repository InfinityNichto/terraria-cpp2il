using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	// Token: 0x020003CB RID: 971
	[global::Cpp2ILInjected.Token(Token = "0x2000575")]
	public class TimeInfo_OldMobile
	{
		// Token: 0x06002F82 RID: 12162 RVA: 0x0002A7D0 File Offset: 0x000289D0
		[global::Cpp2ILInjected.Token(Token = "0x60033EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x13472BC", Offset = "0x13472BC", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Load(BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x0002A7D3 File Offset: 0x000289D3
		[global::Cpp2ILInjected.Token(Token = "0x60033EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x134749C", Offset = "0x134749C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldDataMeta", MemberParameters = new object[]
		{
			typeof(WorldFileData),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x0002A7D6 File Offset: 0x000289D6
		[global::Cpp2ILInjected.Token(Token = "0x60033F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1347548", Offset = "0x1347548", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TimeInfo_OldMobile()
		{
			throw null;
		}

		// Token: 0x040032D6 RID: 13014
		[global::Cpp2ILInjected.Token(Token = "0x4003E36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private short totalDays;

		// Token: 0x040032D7 RID: 13015
		[global::Cpp2ILInjected.Token(Token = "0x4003E37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private byte moonType;

		// Token: 0x040032D8 RID: 13016
		[global::Cpp2ILInjected.Token(Token = "0x4003E38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public short daysSinceHardmode;
	}
}
