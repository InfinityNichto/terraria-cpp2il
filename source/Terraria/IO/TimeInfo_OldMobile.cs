using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x2000575")]
	public class TimeInfo_OldMobile
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60033F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1347548", Offset = "0x1347548", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TimeInfo_OldMobile()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003E36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private short totalDays;

		[global::Cpp2ILInjected.Token(Token = "0x4003E37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private byte moonType;

		[global::Cpp2ILInjected.Token(Token = "0x4003E38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public short daysSinceHardmode;
	}
}
