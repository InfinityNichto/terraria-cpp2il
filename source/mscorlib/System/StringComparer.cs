using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000FD")]
	[global::System.Serializable]
	public abstract class StringComparer : global::System.Collections.IComparer, global::System.Collections.IEqualityComparer, global::System.Collections.Generic.IComparer<string>, global::System.Collections.Generic.IEqualityComparer<string>
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
		public static global::System.StringComparer InvariantCultureIgnoreCase
		{
			[global::Cpp2ILInjected.Token(Token = "0x600097D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4A478", Offset = "0x1C4A478", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
		public static global::System.StringComparer Ordinal
		{
			[global::Cpp2ILInjected.Token(Token = "0x600097E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4A4D0", Offset = "0x1C4A4D0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
		public static global::System.StringComparer OrdinalIgnoreCase
		{
			[global::Cpp2ILInjected.Token(Token = "0x600097F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4A528", Offset = "0x1C4A528", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000980")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A580", Offset = "0x1C4A580", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public int Compare(object x, object y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000981")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A70C", Offset = "0x1C4A70C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(object x, object y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000982")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A7D4", Offset = "0x1C4A7D4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int GetHashCode(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000983")]
		public abstract int Compare(string x, string y);

		[global::Cpp2ILInjected.Token(Token = "0x6000984")]
		public abstract bool Equals(string x, string y);

		[global::Cpp2ILInjected.Token(Token = "0x6000985")]
		public abstract int GetHashCode(string obj);

		[global::Cpp2ILInjected.Token(Token = "0x6000986")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A898", Offset = "0x1C4A898", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected StringComparer()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000987")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A8A0", Offset = "0x1C4A8A0", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CultureAwareComparer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CompareInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OrdinalComparer), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static StringComparer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
		private static readonly global::System.CultureAwareComparer s_invariantCulture;

		[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
		private static readonly global::System.CultureAwareComparer s_invariantCultureIgnoreCase;

		[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
		private static readonly global::System.OrdinalCaseSensitiveComparer s_ordinal;

		[global::Cpp2ILInjected.Token(Token = "0x40003A5")]
		private static readonly global::System.OrdinalIgnoreCaseComparer s_ordinalIgnoreCase;
	}
}
