using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.IO;

[global::Cpp2ILInjected.Token(Token = "0x20002DB")]
public static class FileHelpers
{
	[global::Cpp2ILInjected.Token(Token = "0x60010CE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4F160", Offset = "0xA4F160", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FishingInfo_OldMobile), Member = "Load", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "LoadOld", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(int),
		typeof(ref Player)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "Load", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(ref Player)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignInfo_OldMobile), Member = "UserString", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldHeaderMeta", MemberParameters = new object[]
	{
		typeof(WorldFileData),
		typeof(BinaryReader)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static string ReadOldNetString(this BinaryReader reader)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010CF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4F21C", Offset = "0xA4F21C", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCInfo_OldMobile), Member = "ReadNPCNames", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "LoadOld", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(int),
		typeof(ref Player)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "Load", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(ref Player)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignInfo_OldMobile), Member = "Load", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignInfo_OldMobile), Member = "UserString", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldHeaderMeta", MemberParameters = new object[]
	{
		typeof(WorldFileData),
		typeof(BinaryReader)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static string ReadNetString(this BinaryReader reader)
	{
		throw null;
	}
}
