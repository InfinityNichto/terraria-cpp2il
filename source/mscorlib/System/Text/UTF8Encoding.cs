﻿using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000281")]
	[global::System.Serializable]
	public class UTF8Encoding : Encoding
	{
		[global::Cpp2ILInjected.Token(Token = "0x60015D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC2D0", Offset = "0x1ADC2D0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.TitleContainer", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public UTF8Encoding()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC2F0", Offset = "0x1ADC2F0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(string),
			typeof(int),
			typeof(global::System.Security.Cryptography.CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC320", Offset = "0x1ADC320", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingHelper), Member = "get_UTF8Unmarked", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryParser), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader.<>c", Member = "<ReadT61String>b__45_0", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "CheckEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "SwitchEncodingToUTF8", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextAsset.EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC380", Offset = "0x1ADC380", Length = "0xC8")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC448", Offset = "0x1ADC448", Length = "0x178")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC5C0", Offset = "0x1ADC5C0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int GetByteCount(string chars)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60015DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC64C", Offset = "0x1ADC64C", Length = "0xD0")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC71C", Offset = "0x1ADC71C", Length = "0x248")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADC964", Offset = "0x1ADC964", Length = "0x264")]
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

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60015DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADCBC8", Offset = "0x1ADCBC8", Length = "0xF8")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADCCC0", Offset = "0x1ADCCC0", Length = "0x178")]
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

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60015E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADCE38", Offset = "0x1ADCE38", Length = "0xD0")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADCF08", Offset = "0x1ADCF08", Length = "0x264")]
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

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60015E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADD16C", Offset = "0x1ADD16C", Length = "0xF8")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADD264", Offset = "0x1ADD264", Length = "0x1BC")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADD420", Offset = "0x1ADD420", Length = "0x5DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_InternalHasFallbackBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADDA10", Offset = "0x1ADDA10", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe static int PtrDiff(char* a, char* b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADDA1C", Offset = "0x1ADDA1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe static int PtrDiff(byte* a, byte* b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADD9FC", Offset = "0x1ADD9FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool InRange(int ch, int start, int end)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADDA24", Offset = "0x1ADDA24", Length = "0x720")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_InternalHasFallbackBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADE144", Offset = "0x1ADE144", Length = "0x540")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = "GetBytesUnknown", MemberParameters = new object[]
		{
			typeof(ref byte*),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADE6BC", Offset = "0x1ADE6BC", Length = "0x768")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(char*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = "FallbackInvalidByteSequence", MemberParameters = new object[]
		{
			typeof(ref byte*),
			typeof(int),
			typeof(DecoderFallbackBuffer),
			typeof(ref char*)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADEE24", Offset = "0x1ADEE24", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = "GetBytesUnknown", MemberParameters = new object[]
		{
			typeof(ref byte*),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		private unsafe bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADE684", Offset = "0x1ADE684", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = "GetBytesUnknown", MemberParameters = new object[]
		{
			typeof(ref byte*),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private unsafe int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADEE90", Offset = "0x1ADEE90", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetCharCount", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "FallbackInvalidByteSequence", MemberParameters = new object[]
		{
			typeof(ref byte*),
			typeof(int),
			typeof(DecoderFallbackBuffer),
			typeof(ref char*)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "FallbackInvalidByteSequence", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(DecoderFallbackBuffer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private unsafe byte[] GetBytesUnknown(ref byte* pSrc, int ch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF014", Offset = "0x1ADF014", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Decoder GetDecoder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF078", Offset = "0x1ADF078", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Encoder GetEncoder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF128", Offset = "0x1ADF128", Length = "0xF4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF21C", Offset = "0x1ADF21C", Length = "0xF4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF310", Offset = "0x1ADF310", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override byte[] GetPreamble()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700022D")]
		public override global::System.ReadOnlySpan<byte> Preamble
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADF3E4", Offset = "0x1ADF3E4", Length = "0x160")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60015F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF544", Offset = "0x1ADF544", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF604", Offset = "0x1ADF604", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ADF658", Offset = "0x1ADF658", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding.UTF8EncodingSealed), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static UTF8Encoding()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B48")]
		internal static readonly UTF8Encoding.UTF8EncodingSealed s_default;

		[global::Cpp2ILInjected.Token(Token = "0x4000B49")]
		internal static readonly byte[] s_preamble;

		[global::Cpp2ILInjected.Token(Token = "0x4000B4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal readonly bool _emitUTF8Identifier;

		[global::Cpp2ILInjected.Token(Token = "0x4000B4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		private bool _isThrowException;

		[global::Cpp2ILInjected.Token(Token = "0x2000282")]
		internal sealed class UTF8EncodingSealed : UTF8Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADF720", Offset = "0x1ADF720", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700022E")]
			public override global::System.ReadOnlySpan<byte> Preamble
			{
				[global::Cpp2ILInjected.Token(Token = "0x60015F8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ADF798", Offset = "0x1ADF798", Length = "0xD4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.ReadOnlySpan`1<T>")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000283")]
		[global::System.Serializable]
		private sealed class UTF8Encoder : EncoderNLS
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADF0EC", Offset = "0x1ADF0EC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public UTF8Encoder(UTF8Encoding encoding)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60015FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADF86C", Offset = "0x1ADF86C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700022F")]
			internal override bool HasState
			{
				[global::Cpp2ILInjected.Token(Token = "0x60015FB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ADF88C", Offset = "0x1ADF88C", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B4C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal int surrogateChar;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000284")]
		[global::System.Serializable]
		private sealed class UTF8Decoder : DecoderNLS
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADF070", Offset = "0x1ADF070", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
			public UTF8Decoder(UTF8Encoding encoding)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60015FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ADF89C", Offset = "0x1ADF89C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000230")]
			internal override bool HasState
			{
				[global::Cpp2ILInjected.Token(Token = "0x60015FE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ADF8BC", Offset = "0x1ADF8BC", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B4D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal int bits;
		}
	}
}
