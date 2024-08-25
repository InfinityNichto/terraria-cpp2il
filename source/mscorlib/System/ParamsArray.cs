using System;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000ED")]
	internal readonly struct ParamsArray
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C442F0", Offset = "0x1C442F0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = "ThrowBadPaddingException", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.PaddingMode),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ParamsArray(object arg0)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44364", Offset = "0x1C44364", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ParamsArray(object arg0, object arg1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C443DC", Offset = "0x1C443DC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ParamsArray(object arg0, object arg1, object arg2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44460", Offset = "0x1C44460", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public ParamsArray(object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C444B0", Offset = "0x1C444B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(global::System.ParamsArray)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(global::System.ParamsArray)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
		public object this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C444BC", Offset = "0x1C444BC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(global::System.ParamsArray)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60008D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C444F4", Offset = "0x1C444F4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private object GetAtSlow(int index)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44528", Offset = "0x1C44528", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static ParamsArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000382")]
		private static readonly object[] s_oneArgArray;

		[global::Cpp2ILInjected.Token(Token = "0x4000383")]
		private static readonly object[] s_twoArgArray;

		[global::Cpp2ILInjected.Token(Token = "0x4000384")]
		private static readonly object[] s_threeArgArray;

		[global::Cpp2ILInjected.Token(Token = "0x4000385")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly object _arg0;

		[global::Cpp2ILInjected.Token(Token = "0x4000386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly object _arg1;

		[global::Cpp2ILInjected.Token(Token = "0x4000387")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly object _arg2;

		[global::Cpp2ILInjected.Token(Token = "0x4000388")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object[] _args;
	}
}
