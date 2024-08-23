using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003F4 RID: 1012
	[global::Cpp2ILInjected.Token(Token = "0x20004AF")]
	internal sealed class FastResourceComparer : global::System.Collections.IComparer, global::System.Collections.IEqualityComparer, global::System.Collections.Generic.IComparer<string>, global::System.Collections.Generic.IEqualityComparer<string>
	{
		// Token: 0x06002064 RID: 8292 RVA: 0x00019FBB File Offset: 0x000181BB
		[global::Cpp2ILInjected.Token(Token = "0x60022E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77964", Offset = "0x1B77964", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int GetHashCode(object key)
		{
			throw null;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00019FBE File Offset: 0x000181BE
		[global::Cpp2ILInjected.Token(Token = "0x60022E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77A54", Offset = "0x1B77A54", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastResourceComparer), Member = "HashFunction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int GetHashCode(string key)
		{
			throw null;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00019FC1 File Offset: 0x000181C1
		[global::Cpp2ILInjected.Token(Token = "0x60022E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B779F0", Offset = "0x1B779F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FastResourceComparer), Member = "GetHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "FindPosForResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal static int HashFunction(string key)
		{
			throw null;
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00019FC4 File Offset: 0x000181C4
		[global::Cpp2ILInjected.Token(Token = "0x60022E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77AA8", Offset = "0x1B77AA8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int Compare(object a, object b)
		{
			throw null;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00019FC7 File Offset: 0x000181C7
		[global::Cpp2ILInjected.Token(Token = "0x60022E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77B44", Offset = "0x1B77B44", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		public int Compare(string a, string b)
		{
			throw null;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00019FCA File Offset: 0x000181CA
		[global::Cpp2ILInjected.Token(Token = "0x60022E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77B54", Offset = "0x1B77B54", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public bool Equals(string a, string b)
		{
			throw null;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00019FCD File Offset: 0x000181CD
		[global::Cpp2ILInjected.Token(Token = "0x60022E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77B64", Offset = "0x1B77B64", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(object a, object b)
		{
			throw null;
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00019FD0 File Offset: 0x000181D0
		[global::Cpp2ILInjected.Token(Token = "0x60022EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77C00", Offset = "0x1B77C00", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FastResourceComparer), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public static int CompareOrdinal(string a, byte[] bytes, int bCharLength)
		{
			throw null;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00019FD3 File Offset: 0x000181D3
		[global::Cpp2ILInjected.Token(Token = "0x60022EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77CB4", Offset = "0x1B77CB4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastResourceComparer), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int CompareOrdinal(byte[] bytes, int aCharLength, string b)
		{
			throw null;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00019FD6 File Offset: 0x000181D6
		[global::Cpp2ILInjected.Token(Token = "0x60022EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77D28", Offset = "0x1B77D28", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal unsafe static int CompareOrdinal(byte* a, int byteLen, string b)
		{
			throw null;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x00019FD9 File Offset: 0x000181D9
		[global::Cpp2ILInjected.Token(Token = "0x60022ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77DB4", Offset = "0x1B77DB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FastResourceComparer()
		{
			throw null;
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00019FDC File Offset: 0x000181DC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60022EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77DBC", Offset = "0x1B77DBC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static FastResourceComparer()
		{
			throw null;
		}

		// Token: 0x0400100B RID: 4107
		[global::Cpp2ILInjected.Token(Token = "0x4001320")]
		internal static readonly FastResourceComparer Default;
	}
}
