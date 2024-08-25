using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Globalization.Unicode;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x200028F")]
	internal class Normalization
	{
		[global::Cpp2ILInjected.Token(Token = "0x600169F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE83BC", Offset = "0x1AE83BC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "TryCompose", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "QuickCheck", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(NormalizationCheck))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Globalization.Unicode.NormalizationTableUtil), Member = "PropIdx", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static uint PropValue(int cp)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE8450", Offset = "0x1AE8450", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "GetCanonical", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Globalization.Unicode.NormalizationTableUtil), Member = "MapIdx", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int CharMapIdx(int cp)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE84E4", Offset = "0x1AE84E4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "ReorderCanonical", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Globalization.Unicode.CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static byte GetCombiningClass(int c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE8584", Offset = "0x1AE8584", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "TryCompose", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Globalization.Unicode.CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int GetPrimaryCompositeFromMapIndex(int src)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE8624", Offset = "0x1AE8624", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Globalization.Unicode.CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int GetPrimaryCompositeHelperIndex(int cp)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE86C4", Offset = "0x1AE86C4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Normalize", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Combine", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string Compose(string source, int checkType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE88CC", Offset = "0x1AE88CC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Compose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "QuickCheck", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(NormalizationCheck))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Combine", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static StringBuilder Combine(string source, int start, int checkType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE89FC", Offset = "0x1AE89FC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Compose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "CombineHangul", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "QuickCheck", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(NormalizationCheck))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void Combine(StringBuilder sb, int i, int checkType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE8C20", Offset = "0x1AE8C20", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Combine", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Fetch", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static int CombineHangul(StringBuilder sb, string s, int current)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9008", Offset = "0x1AE9008", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "CombineHangul", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static int Fetch(StringBuilder sb, string s, int i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE8DDC", Offset = "0x1AE8DDC", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Combine", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Fetch", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "GetCombiningClass", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "GetPrimaryCompositeHelperIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "TryCompose", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE903C", Offset = "0x1AE903C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "GetPrimaryCompositeFromMapIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "PropValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static int TryCompose(int i, int starter, int candidate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9154", Offset = "0x1AE9154", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Normalize", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static string Decompose(string source, int checkType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE87A4", Offset = "0x1AE87A4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Compose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "QuickCheck", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(NormalizationCheck))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "DecomposeChar", MemberParameters = new object[]
		{
			typeof(ref StringBuilder),
			typeof(ref int[]),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "ReorderCanonical", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void Decompose(string source, ref StringBuilder sb, int checkType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE937C", Offset = "0x1AE937C", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "GetCombiningClass", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void ReorderCanonical(string src, ref StringBuilder sb, int start)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE91E0", Offset = "0x1AE91E0", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "GetCanonical", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE8B04", Offset = "0x1AE8B04", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Combine", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "GetCanonical", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "PropValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static NormalizationCheck QuickCheck(char c, int type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9758", Offset = "0x1AE9758", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "GetCanonical", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static int GetCanonicalHangul(int s, int[] buf, int bufIdx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE95C8", Offset = "0x1AE95C8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "DecomposeChar", MemberParameters = new object[]
		{
			typeof(ref StringBuilder),
			typeof(ref int[]),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Normalization), Member = "GetCanonical", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "GetCanonicalHangul", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "CharMapIdx", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "QuickCheck", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(NormalizationCheck))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "GetCanonical", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9808", Offset = "0x1AE9808", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Normalize", MemberParameters = new object[] { typeof(NormalizationForm) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string Normalize(string source, NormalizationForm normalizationForm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE98C4", Offset = "0x1AE98C4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Normalization), Member = "Compose", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string Normalize(string source, int type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE995C", Offset = "0x1AE995C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void load_normalization_resource(out global::System.IntPtr props, out global::System.IntPtr mappedChars, out global::System.IntPtr charMapIndex, out global::System.IntPtr helperIndex, out global::System.IntPtr mapIdxToComposite, out global::System.IntPtr combiningClass);

		[global::Cpp2ILInjected.Token(Token = "0x60016B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9960", Offset = "0x1AE9960", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static unsafe Normalization()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B8A")]
		private unsafe static byte* props;

		[global::Cpp2ILInjected.Token(Token = "0x4000B8B")]
		private unsafe static int* mappedChars;

		[global::Cpp2ILInjected.Token(Token = "0x4000B8C")]
		private unsafe static short* charMapIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4000B8D")]
		private unsafe static short* helperIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4000B8E")]
		private unsafe static ushort* mapIdxToComposite;

		[global::Cpp2ILInjected.Token(Token = "0x4000B8F")]
		private unsafe static byte* combiningClass;

		[global::Cpp2ILInjected.Token(Token = "0x4000B90")]
		private static object forLock;

		[global::Cpp2ILInjected.Token(Token = "0x4000B91")]
		public static readonly bool isReady;
	}
}
