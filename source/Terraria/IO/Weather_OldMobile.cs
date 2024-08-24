using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	// Token: 0x020003CC RID: 972
	[global::Cpp2ILInjected.Token(Token = "0x2000576")]
	public class Weather_OldMobile
	{
		// Token: 0x06002F85 RID: 12165 RVA: 0x0002A7D9 File Offset: 0x000289D9
		[global::Cpp2ILInjected.Token(Token = "0x60033F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1347550", Offset = "0x1347550", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Load(BinaryReader reader, int release)
		{
			throw null;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0002A7DC File Offset: 0x000289DC
		[global::Cpp2ILInjected.Token(Token = "0x60033F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1347638", Offset = "0x1347638", Length = "0x78")]
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

		// Token: 0x06002F87 RID: 12167 RVA: 0x0002A7DF File Offset: 0x000289DF
		[global::Cpp2ILInjected.Token(Token = "0x60033F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13476B0", Offset = "0x13476B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Weather_OldMobile()
		{
			throw null;
		}

		// Token: 0x040032D9 RID: 13017
		[global::Cpp2ILInjected.Token(Token = "0x4003E39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float cloudBGActive;
	}
}
