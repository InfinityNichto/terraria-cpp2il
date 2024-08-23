using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001F5 RID: 501
	[global::Cpp2ILInjected.Token(Token = "0x200027A")]
	[global::System.Serializable]
	public sealed class UTF32Encoding : Encoding
	{
		// Token: 0x060013CE RID: 5070 RVA: 0x00017C99 File Offset: 0x00015E99
		[global::Cpp2ILInjected.Token(Token = "0x6001588")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7EA4", Offset = "0x1AD7EA4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public UTF32Encoding()
		{
			throw null;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00017C9C File Offset: 0x00015E9C
		[global::Cpp2ILInjected.Token(Token = "0x6001589")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7F3C", Offset = "0x1AD7F3C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_UTF32", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public UTF32Encoding(bool bigEndian, bool byteOrderMark)
		{
			throw null;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00017C9F File Offset: 0x00015E9F
		[global::Cpp2ILInjected.Token(Token = "0x600158A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7ECC", Offset = "0x1AD7ECC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextAsset.EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters)
		{
			throw null;
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00017CA2 File Offset: 0x00015EA2
		[global::Cpp2ILInjected.Token(Token = "0x600158B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD7F7C", Offset = "0x1AD7F7C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(EncoderFallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(DecoderFallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override void SetDefaultFallbacks()
		{
			throw null;
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00017CA5 File Offset: 0x00015EA5
		[global::Cpp2ILInjected.Token(Token = "0x600158C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD8044", Offset = "0x1AD8044", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			throw null;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00017CA8 File Offset: 0x00015EA8
		[global::Cpp2ILInjected.Token(Token = "0x600158D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD81BC", Offset = "0x1AD81BC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int GetByteCount(string s)
		{
			throw null;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00017CAB File Offset: 0x00015EAB
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600158E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD8248", Offset = "0x1AD8248", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			throw null;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00017CAE File Offset: 0x00015EAE
		[global::Cpp2ILInjected.Token(Token = "0x600158F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD8318", Offset = "0x1AD8318", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			throw null;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00017CB1 File Offset: 0x00015EB1
		[global::Cpp2ILInjected.Token(Token = "0x6001590")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD8560", Offset = "0x1AD8560", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			throw null;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00017CB4 File Offset: 0x00015EB4
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001591")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD87C4", Offset = "0x1AD87C4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			throw null;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00017CB7 File Offset: 0x00015EB7
		[global::Cpp2ILInjected.Token(Token = "0x6001592")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD88BC", Offset = "0x1AD88BC", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00017CBA File Offset: 0x00015EBA
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001593")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD8A34", Offset = "0x1AD8A34", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			throw null;
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00017CBD File Offset: 0x00015EBD
		[global::Cpp2ILInjected.Token(Token = "0x6001594")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD8B04", Offset = "0x1AD8B04", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00017CC0 File Offset: 0x00015EC0
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001595")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD8D68", Offset = "0x1AD8D68", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			throw null;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00017CC3 File Offset: 0x00015EC3
		[global::Cpp2ILInjected.Token(Token = "0x6001596")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD8E60", Offset = "0x1AD8E60", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public unsafe override string GetString(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00017CC6 File Offset: 0x00015EC6
		[global::Cpp2ILInjected.Token(Token = "0x6001597")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD901C", Offset = "0x1AD901C", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00017CC9 File Offset: 0x00015EC9
		[global::Cpp2ILInjected.Token(Token = "0x6001598")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD92C8", Offset = "0x1AD92C8", Length = "0x3A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00017CCC File Offset: 0x00015ECC
		[global::Cpp2ILInjected.Token(Token = "0x6001599")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9684", Offset = "0x1AD9684", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			throw null;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00017CCF File Offset: 0x00015ECF
		[global::Cpp2ILInjected.Token(Token = "0x600159A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9944", Offset = "0x1AD9944", Length = "0x36C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			throw null;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00017CD2 File Offset: 0x00015ED2
		[global::Cpp2ILInjected.Token(Token = "0x600159B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9668", Offset = "0x1AD9668", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint GetSurrogate(char cHigh, char cLow)
		{
			throw null;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00017CD5 File Offset: 0x00015ED5
		[global::Cpp2ILInjected.Token(Token = "0x600159C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9CB0", Offset = "0x1AD9CB0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private char GetHighSurrogate(uint iChar)
		{
			throw null;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00017CD8 File Offset: 0x00015ED8
		[global::Cpp2ILInjected.Token(Token = "0x600159D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9CC4", Offset = "0x1AD9CC4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private char GetLowSurrogate(uint iChar)
		{
			throw null;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00017CDB File Offset: 0x00015EDB
		[global::Cpp2ILInjected.Token(Token = "0x600159E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9CD0", Offset = "0x1AD9CD0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Decoder GetDecoder()
		{
			throw null;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00017CDE File Offset: 0x00015EDE
		[global::Cpp2ILInjected.Token(Token = "0x600159F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9D34", Offset = "0x1AD9D34", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Encoder GetEncoder()
		{
			throw null;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00017CE1 File Offset: 0x00015EE1
		[global::Cpp2ILInjected.Token(Token = "0x60015A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9DA8", Offset = "0x1AD9DA8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override int GetMaxByteCount(int charCount)
		{
			throw null;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00017CE4 File Offset: 0x00015EE4
		[global::Cpp2ILInjected.Token(Token = "0x60015A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9E9C", Offset = "0x1AD9E9C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int GetMaxCharCount(int byteCount)
		{
			throw null;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00017CE7 File Offset: 0x00015EE7
		[global::Cpp2ILInjected.Token(Token = "0x60015A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD9F5C", Offset = "0x1AD9F5C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override byte[] GetPreamble()
		{
			throw null;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00017CEA File Offset: 0x00015EEA
		[global::Cpp2ILInjected.Token(Token = "0x17000227")]
		public override global::System.ReadOnlySpan<byte> Preamble
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADA024", Offset = "0x1ADA024", Length = "0x170")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.ReadOnlySpan`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00017CED File Offset: 0x00015EED
		[global::Cpp2ILInjected.Token(Token = "0x60015A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA194", Offset = "0x1ADA194", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00017CF0 File Offset: 0x00015EF0
		[global::Cpp2ILInjected.Token(Token = "0x60015A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA248", Offset = "0x1ADA248", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00017CF3 File Offset: 0x00015EF3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADA2B8", Offset = "0x1ADA2B8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static UTF32Encoding()
		{
			throw null;
		}

		// Token: 0x040008C6 RID: 2246
		[global::Cpp2ILInjected.Token(Token = "0x4000B32")]
		internal static readonly UTF32Encoding s_default;

		// Token: 0x040008C7 RID: 2247
		[global::Cpp2ILInjected.Token(Token = "0x4000B33")]
		internal static readonly UTF32Encoding s_bigEndianDefault;

		// Token: 0x040008C8 RID: 2248
		[global::Cpp2ILInjected.Token(Token = "0x4000B34")]
		private static readonly byte[] s_bigEndianPreamble;

		// Token: 0x040008C9 RID: 2249
		[global::Cpp2ILInjected.Token(Token = "0x4000B35")]
		private static readonly byte[] s_littleEndianPreamble;

		// Token: 0x040008CA RID: 2250
		[global::Cpp2ILInjected.Token(Token = "0x4000B36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _emitUTF32ByteOrderMark;

		// Token: 0x040008CB RID: 2251
		[global::Cpp2ILInjected.Token(Token = "0x4000B37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		private bool _isThrowException;

		// Token: 0x040008CC RID: 2252
		[global::Cpp2ILInjected.Token(Token = "0x4000B38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A")]
		private bool _bigEndian;

		// Token: 0x020005D0 RID: 1488
		[global::Cpp2ILInjected.Token(Token = "0x200027B")]
		[global::System.Serializable]
		private sealed class UTF32Decoder : DecoderNLS
		{
			// Token: 0x06004091 RID: 16529 RVA: 0x0001FC64 File Offset: 0x0001DE64
			[global::Cpp2ILInjected.Token(Token = "0x60015A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD9D2C", Offset = "0x1AD9D2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
			public UTF32Decoder(UTF32Encoding encoding)
			{
				throw null;
			}

			// Token: 0x06004092 RID: 16530 RVA: 0x0001FC67 File Offset: 0x0001DE67
			[global::Cpp2ILInjected.Token(Token = "0x60015A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADA3AC", Offset = "0x1ADA3AC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Reset()
			{
				throw null;
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06004093 RID: 16531 RVA: 0x0001FC6A File Offset: 0x0001DE6A
			[global::Cpp2ILInjected.Token(Token = "0x17000228")]
			internal override bool HasState
			{
				[global::Cpp2ILInjected.Token(Token = "0x60015A9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ADA3CC", Offset = "0x1ADA3CC", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040018F4 RID: 6388
			[global::Cpp2ILInjected.Token(Token = "0x4000B39")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal int iChar;

			// Token: 0x040018F5 RID: 6389
			[global::Cpp2ILInjected.Token(Token = "0x4000B3A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			internal int readByteCount;
		}
	}
}
