using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	[global::Cpp2ILInjected.Token(Token = "0x20004AF")]
	internal sealed class FastResourceComparer : global::System.Collections.IComparer, global::System.Collections.IEqualityComparer, global::System.Collections.Generic.IComparer<string>, global::System.Collections.Generic.IEqualityComparer<string>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60022E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77964", Offset = "0x1B77964", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int GetHashCode(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77A54", Offset = "0x1B77A54", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastResourceComparer), Member = "HashFunction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int GetHashCode(string key)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60022ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77DB4", Offset = "0x1B77DB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FastResourceComparer()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4001320")]
		internal static readonly FastResourceComparer Default;
	}
}
