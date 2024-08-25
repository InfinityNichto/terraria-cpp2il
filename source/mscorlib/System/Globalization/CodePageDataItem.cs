using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x20005BA")]
	[global::System.Serializable]
	internal class CodePageDataItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002CCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF7434", Offset = "0x1BF7434", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingTable), Member = "GetCodePageDataItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CodePageDataItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal CodePageDataItem(int dataIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002CCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF74C0", Offset = "0x1BF74C0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CodePageDataItem), Member = "get_WebName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string CreateString(string pStrings, uint index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006BF")]
		public string WebName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF7558", Offset = "0x1BF7558", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "get_WebName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePageDataItem), Member = "CreateString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(uint)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002CCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF75FC", Offset = "0x1BF75FC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static CodePageDataItem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40018E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_dataIndex;

		[global::Cpp2ILInjected.Token(Token = "0x40018EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int m_uiFamilyCodePage;

		[global::Cpp2ILInjected.Token(Token = "0x40018EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string m_webName;

		[global::Cpp2ILInjected.Token(Token = "0x40018EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal uint m_flags;

		[global::Cpp2ILInjected.Token(Token = "0x40018ED")]
		private static readonly char[] sep;
	}
}
