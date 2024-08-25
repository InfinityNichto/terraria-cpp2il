using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005B2")]
	[global::System.Serializable]
	public class TextInfo : global::System.ICloneable, global::System.Runtime.Serialization.IDeserializationCallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700069F")]
		internal static TextInfo Invariant
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2F8C", Offset = "0x1BF2F8C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3034", Offset = "0x1BF3034", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateTextInfo", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(TextInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal TextInfo(CultureData cultureData)
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnDeserializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002C3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3068", Offset = "0x1BF3068", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3070", Offset = "0x1BF3070", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void OnDeserialized()
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6002C41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3140", Offset = "0x1BF3140", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnSerializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002C42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3144", Offset = "0x1BF3144", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnSerializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170006A0")]
		public string CultureName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF31BC", Offset = "0x1BF31BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170006A1")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF31C4", Offset = "0x1BF31C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002C45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF31CC", Offset = "0x1BF31CC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Clone()
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002C46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3250", Offset = "0x1BF3250", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static TextInfo ReadOnly(TextInfo textInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3338", Offset = "0x1BF3338", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetReadOnlyState(bool readOnly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3344", Offset = "0x1BF3344", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		public virtual char ToLower(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF38C0", Offset = "0x1BF38C0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual string ToLower(string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF34B8", Offset = "0x1BF34B8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static char ToLowerAsciiInvariant(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF39F0", Offset = "0x1BF39F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		public virtual char ToUpper(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3E84", Offset = "0x1BF3E84", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual string ToUpper(string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3A54", Offset = "0x1BF3A54", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static char ToUpperAsciiInvariant(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF33A8", Offset = "0x1BF33A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsAscii(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006A2")]
		private bool IsAsciiCasingSameAsInvariant
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF33B8", Offset = "0x1BF33B8", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Nullable<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3FB4", Offset = "0x1BF3FB4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4044", Offset = "0x1BF4044", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4054", Offset = "0x1BF4054", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF40A4", Offset = "0x1BF40A4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3ED8", Offset = "0x1BF3ED8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string ToUpperInternal(string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3914", Offset = "0x1BF3914", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string ToLowerInternal(string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF3A70", Offset = "0x1BF3A70", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private char ToUpperInternal(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF34D4", Offset = "0x1BF34D4", Length = "0x3EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private char ToLowerInternal(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF40A8", Offset = "0x1BF40A8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "ToUpperInvariant", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void ToUpperAsciiInvariant(global::System.ReadOnlySpan<char> source, global::System.Span<char> destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4124", Offset = "0x1BF4124", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "ToUpperInvariant", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void ChangeCase(global::System.ReadOnlySpan<char> source, global::System.Span<char> destination, bool toUpper)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002C5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF4264", Offset = "0x1BF4264", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal TextInfo()
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x40018A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_listSeparator;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x40018A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_isReadOnly;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 3)]
		[global::Cpp2ILInjected.Token(Token = "0x40018A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_cultureName;

		[global::Cpp2ILInjected.Token(Token = "0x40018A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[global::System.NonSerialized]
		private CultureData m_cultureData;

		[global::Cpp2ILInjected.Token(Token = "0x40018AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[global::System.NonSerialized]
		private string m_textInfoName;

		[global::Cpp2ILInjected.Token(Token = "0x40018AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		[global::System.NonSerialized]
		private bool? m_IsAsciiCasingSameAsInvariant;

		[global::Cpp2ILInjected.Token(Token = "0x40018AC")]
		internal static TextInfo s_Invariant;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x40018AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string customCultureName;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x40018AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int m_nDataItem;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x40018AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		internal bool m_useUserOverride;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x40018B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal int m_win32LangID;

		[global::Cpp2ILInjected.Token(Token = "0x40018B1")]
		private const int wordSeparatorMask = 536672256;
	}
}
