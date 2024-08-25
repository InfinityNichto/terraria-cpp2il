using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001D1")]
	internal class HostHeaderString
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F171E4", Offset = "0x1F171E4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal HostHeaderString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17210", Offset = "0x1F17210", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal HostHeaderString(string s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F17204", Offset = "0x1F17204", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Init(string s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1723C", Offset = "0x1F1723C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HostHeaderString), Member = "get_ByteCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HostHeaderString), Member = "get_Bytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HostHeaderString), Member = "Copy", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		private void Convert()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700024A")]
		internal string String
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F172D4", Offset = "0x1F172D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B51")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F172DC", Offset = "0x1F172DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700024B")]
		internal int ByteCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B52")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F172E8", Offset = "0x1F172E8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HostHeaderString), Member = "Convert", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700024C")]
		internal byte[] Bytes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F17304", Offset = "0x1F17304", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HostHeaderString), Member = "Convert", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1731C", Offset = "0x1F1731C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HostHeaderString), Member = "Convert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void Copy(byte[] destBytes, int destByteIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40009E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_Converted;

		[global::Cpp2ILInjected.Token(Token = "0x40009E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_String;

		[global::Cpp2ILInjected.Token(Token = "0x40009EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] m_Bytes;
	}
}
