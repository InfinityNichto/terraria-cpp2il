using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Globalization.Unicode;

namespace System.Globalization
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005B6")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class SortKey
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002C8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5DD4", Offset = "0x1BF5DD4", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortKey), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5F1C", Offset = "0x1BF5F1C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CreateSortKeyCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal SortKey(int lcid, string source, CompareOptions opt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF5FD4", Offset = "0x1BF5FD4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Globalization.Unicode.SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6014", Offset = "0x1BF6014", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "InvariantCreateSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006AE")]
		public virtual string OriginalString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C91")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF6054", Offset = "0x1BF6054", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006AF")]
		public virtual byte[] KeyData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF605C", Offset = "0x1BF605C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6064", Offset = "0x1BF6064", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKey), Member = "Compare", MemberParameters = new object[]
		{
			typeof(SortKey),
			typeof(SortKey)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6114", Offset = "0x1BF6114", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6164", Offset = "0x1BF6164", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6308", Offset = "0x1BF6308", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal SortKey()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40018B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string source;

		[global::Cpp2ILInjected.Token(Token = "0x40018BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly byte[] key;

		[global::Cpp2ILInjected.Token(Token = "0x40018BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly CompareOptions options;

		[global::Cpp2ILInjected.Token(Token = "0x40018BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private readonly int lcid;
	}
}
