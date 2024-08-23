using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001F1 RID: 497
	[global::Cpp2ILInjected.Token(Token = "0x2000276")]
	[global::System.Serializable]
	internal class Latin1Encoding : EncodingNLS, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x0600137F RID: 4991 RVA: 0x00017BAC File Offset: 0x00015DAC
		[global::Cpp2ILInjected.Token(Token = "0x6001539")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD351C", Offset = "0x1AD351C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_Latin1", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public Latin1Encoding()
		{
			throw null;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00017BAF File Offset: 0x00015DAF
		[global::Cpp2ILInjected.Token(Token = "0x600153A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3528", Offset = "0x1AD3528", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "DeserializeEncoding", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal Latin1Encoding(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00017BB2 File Offset: 0x00015DB2
		[global::Cpp2ILInjected.Token(Token = "0x600153B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3574", Offset = "0x1AD3574", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "SerializeEncoding", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00017BB5 File Offset: 0x00015DB5
		[global::Cpp2ILInjected.Token(Token = "0x600153C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3664", Offset = "0x1AD3664", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00017BB8 File Offset: 0x00015DB8
		[global::Cpp2ILInjected.Token(Token = "0x600153D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3848", Offset = "0x1AD3848", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00017BBB File Offset: 0x00015DBB
		[global::Cpp2ILInjected.Token(Token = "0x600153E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3B80", Offset = "0x1AD3B80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			throw null;
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00017BBE File Offset: 0x00015DBE
		[global::Cpp2ILInjected.Token(Token = "0x600153F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3B88", Offset = "0x1AD3B88", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			throw null;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00017BC1 File Offset: 0x00015DC1
		[global::Cpp2ILInjected.Token(Token = "0x6001540")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3BFC", Offset = "0x1AD3BFC", Length = "0xF4")]
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

		// Token: 0x06001387 RID: 4999 RVA: 0x00017BC4 File Offset: 0x00015DC4
		[global::Cpp2ILInjected.Token(Token = "0x6001541")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3CF0", Offset = "0x1AD3CF0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override int GetMaxCharCount(int byteCount)
		{
			throw null;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00017BC7 File Offset: 0x00015DC7
		[global::Cpp2ILInjected.Token(Token = "0x6001542")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3DE0", Offset = "0x1AD3DE0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override char[] GetBestFitUnicodeToBytesData()
		{
			throw null;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00017BCA File Offset: 0x00015DCA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001543")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD3E38", Offset = "0x1AD3E38", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Latin1Encoding()
		{
			throw null;
		}

		// Token: 0x040008B1 RID: 2225
		[global::Cpp2ILInjected.Token(Token = "0x4000B1D")]
		internal static readonly Latin1Encoding s_default;

		// Token: 0x040008B2 RID: 2226
		[global::Cpp2ILInjected.Token(Token = "0x4000B1E")]
		private static readonly char[] arrayCharBestFit;
	}
}
