using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000042 RID: 66
[global::Cpp2ILInjected.Token(Token = "0x2000067")]
public static class UID
{
	// Token: 0x06000196 RID: 406 RVA: 0x0002203A File Offset: 0x0002023A
	[global::Cpp2ILInjected.Token(Token = "0x6000229")]
	[global::Cpp2ILInjected.Address(RVA = "0x70CD38", Offset = "0x70CD38", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "SaveFields", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "LoadFields", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(Type),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadTexture", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref TextureAtlasDB),
		typeof(ref TextureAtlasEntry)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UID), Member = "Initialise", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static int Generate(string data)
	{
		throw null;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0002203D File Offset: 0x0002023D
	[global::Cpp2ILInjected.Token(Token = "0x600022A")]
	[global::Cpp2ILInjected.Address(RVA = "0x70CF38", Offset = "0x70CF38", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UID), Member = "Initialise", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static int Generate(byte[] data, int dataLength = -1)
	{
		throw null;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00022040 File Offset: 0x00020240
	[global::Cpp2ILInjected.Token(Token = "0x600022B")]
	[global::Cpp2ILInjected.Address(RVA = "0x70CFF0", Offset = "0x70CFF0", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UID), Member = "Initialise", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void InitialiseUIDGeneration(ref uint resultUID)
	{
		throw null;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00022043 File Offset: 0x00020243
	[global::Cpp2ILInjected.Token(Token = "0x600022C")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D04C", Offset = "0x70D04C", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void UIDGenerationAddInt(int value, ref uint resultUID)
	{
		throw null;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00022046 File Offset: 0x00020246
	[global::Cpp2ILInjected.Token(Token = "0x600022D")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D0FC", Offset = "0x70D0FC", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void UIDGenerationAddFloat(float value, ref uint resultUID)
	{
		throw null;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00022049 File Offset: 0x00020249
	[global::Cpp2ILInjected.Token(Token = "0x600022E")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D1EC", Offset = "0x70D1EC", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void UIDGenerationAddString(string value, ref uint resultUID)
	{
		throw null;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0002204C File Offset: 0x0002024C
	[global::Cpp2ILInjected.Token(Token = "0x600022F")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D2D0", Offset = "0x70D2D0", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void FinaliseUIDGeneration(ref uint resultUID)
	{
		throw null;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0002204F File Offset: 0x0002024F
	[global::Cpp2ILInjected.Token(Token = "0x6000230")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D2E0", Offset = "0x70D2E0", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static uint Reflect(uint ulReflect, char cChar)
	{
		throw null;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00022052 File Offset: 0x00020252
	[global::Cpp2ILInjected.Token(Token = "0x6000231")]
	[global::Cpp2ILInjected.Address(RVA = "0x70CE38", Offset = "0x70CE38", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UID), Member = "Generate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UID), Member = "Generate", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UID), Member = "InitialiseUIDGeneration", MemberParameters = new object[] { typeof(ref uint) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private static void Initialise()
	{
		throw null;
	}

	// Token: 0x04000111 RID: 273
	[global::Cpp2ILInjected.Token(Token = "0x4000204")]
	private static uint[] s_lookupTable;
}
