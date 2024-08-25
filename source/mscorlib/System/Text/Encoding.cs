using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Security.Util;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;
using Mono.Security.Cryptography;

namespace System.Text
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000289")]
	[global::System.Serializable]
	public abstract class Encoding : global::System.ICloneable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600162F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3D10", Offset = "0x1AE3D10", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Ucs4Encoding", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Ucs4Encoding1234", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Ucs4Encoding4321", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Ucs4Encoding2143", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Ucs4Encoding3412", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected Encoding()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001630")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3D40", Offset = "0x1AE3D40", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding.ASCIIEncodingSealed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingNLS), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding.UTF8EncodingSealed), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected Encoding(int codePage)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001631")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3DC8", Offset = "0x1AE3DC8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalEncoderBestFitFallback), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalDecoderBestFitFallback), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal virtual void SetDefaultFallbacks()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001632")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3E5C", Offset = "0x1AE3E5C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void OnDeserializing()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001633")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3E6C", Offset = "0x1AE3E6C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void OnDeserialized()
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnDeserializing]
		[global::Cpp2ILInjected.Token(Token = "0x6001634")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3EA8", Offset = "0x1AE3EA8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6001635")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3EB8", Offset = "0x1AE3EB8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		[global::System.Runtime.Serialization.OnSerializing]
		[global::Cpp2ILInjected.Token(Token = "0x6001636")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3EF4", Offset = "0x1AE3EF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnSerializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001637")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3EFC", Offset = "0x1AE3EFC", Length = "0x3F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		internal void DeserializeEncoding(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001638")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE42F4", Offset = "0x1AE42F4", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void SerializeEncoding(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000235")]
		private static object InternalSyncObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001639")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE449C", Offset = "0x1AE449C", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE4534", Offset = "0x1AE4534", Length = "0x824")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
		{
			typeof(int),
			typeof(EncoderFallback),
			typeof(DecoderFallback)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingHelper), Member = "GetDefaultEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingProvider), Member = "GetEncodingFromProvider", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.EncodingTable), Member = "GetCodePageDataItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.CodePageDataItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF32", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingHelper), Member = "InvokeI18N", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF7", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Latin1", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 82)]
		public static Encoding GetEncoding(int codepage)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE58A0", Offset = "0x1AE58A0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
		{
			typeof(string),
			typeof(EncoderFallback),
			typeof(DecoderFallback)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextAsset.EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingProvider), Member = "GetEncodingFromProvider", MemberParameters = new object[]
		{
			typeof(int),
			typeof(EncoderFallback),
			typeof(DecoderFallback)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new object[] { typeof(EncoderFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "set_DecoderFallback", MemberParameters = new object[] { typeof(DecoderFallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5B14", Offset = "0x1AE5B14", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingHelper), Member = "GetDefaultEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "DetermineFormat", MemberParameters = new object[] { typeof(global::System.Security.Util.TokenizerStream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader.<>c", Member = "<ReadT61String>b__45_1", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "GetStringUsingEncoding", MemberParameters = new object[] { "System.Net.WebRequest", "System.Byte[]" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "CheckEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "get_UseUnicodeAsNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "set_UseUnicodeAsNecessary", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "get_UseUnicodeAsNecessary", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "set_UseUnicodeAsNecessary", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.TextWriter),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipInputStream", Member = "_Init", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutputStream", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutputStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutputStream", Member = "get_DefaultEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.GZipStream", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingProvider), Member = "GetEncodingFromProvider", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.EncodingTable), Member = "GetCodePageFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Encoding GetEncoding(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5BB0", Offset = "0x1AE5BB0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection.HeaderEncoding", Member = "DecodeUtf8FromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingProvider), Member = "GetEncodingFromProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(EncoderFallback),
			typeof(DecoderFallback)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.EncodingTable), Member = "GetCodePageFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
		{
			typeof(int),
			typeof(EncoderFallback),
			typeof(DecoderFallback)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5C70", Offset = "0x1AE5C70", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] GetPreamble()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000236")]
		public virtual global::System.ReadOnlySpan<byte> Preamble
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE5CC8", Offset = "0x1AE5CC8", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.ReadOnlySpan`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001640")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5D1C", Offset = "0x1AE5D1C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_WebName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.EncodingTable), Member = "GetCodePageDataItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.CodePageDataItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void GetDataItem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000237")]
		public virtual string EncodingName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001641")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE5E28", Offset = "0x1AE5E28", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceStringEncodingName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000238")]
		public virtual string WebName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001642")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE5E34", Offset = "0x1AE5E34", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetDataItem", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CodePageDataItem), Member = "get_WebName", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000239")]
		public EncoderFallback EncoderFallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001643")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE5E5C", Offset = "0x1AE5E5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001644")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE599C", Offset = "0x1AE599C", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingProvider), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(string),
				typeof(EncoderFallback),
				typeof(DecoderFallback)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingProvider), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(int),
				typeof(EncoderFallback),
				typeof(DecoderFallback)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(int),
				typeof(EncoderFallback),
				typeof(DecoderFallback)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
			{
				"System.Char*",
				typeof(int),
				typeof(int),
				"System.UriComponents"
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new object[]
			{
				"System.Char*",
				typeof(int),
				typeof(int),
				"System.Char[]",
				typeof(ref int),
				typeof(char),
				typeof(char),
				typeof(char),
				"System.UnescapeMode",
				"System.UriParser",
				typeof(bool)
			}, ReturnType = "System.Char[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlEncodedRawTextWriter", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.IO.Stream),
				"System.Xml.XmlWriterSettings"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700023A")]
		public DecoderFallback DecoderFallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001645")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE5E64", Offset = "0x1AE5E64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001646")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE5A58", Offset = "0x1AE5A58", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingProvider), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(string),
				typeof(EncoderFallback),
				typeof(DecoderFallback)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingProvider), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(int),
				typeof(EncoderFallback),
				typeof(DecoderFallback)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(int),
				typeof(EncoderFallback),
				typeof(DecoderFallback)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
			{
				"System.Char*",
				typeof(int),
				typeof(int),
				"System.UriComponents"
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new object[]
			{
				"System.Char*",
				typeof(int),
				typeof(int),
				"System.Char[]",
				typeof(ref int),
				typeof(char),
				typeof(char),
				typeof(char),
				"System.UnescapeMode",
				"System.UriParser",
				typeof(bool)
			}, ReturnType = "System.Char[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001647")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5E6C", Offset = "0x1AE5E6C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Clone()
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x1700023B")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001648")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE5EF0", Offset = "0x1AE5EF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700023C")]
		public static Encoding ASCII
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001649")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE506C", Offset = "0x1AE506C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadWorlds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadPlayers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FileUtilities", Member = "WriteAllText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = ".ctor", MemberParameters = new object[] { "LocalUser" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoReader), Member = "GetString", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "ChangeFormat", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.ToBase64Transform), Member = "TransformBlock", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.ToBase64Transform), Member = "TransformFinalBlock", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.FromBase64Transform), Member = "TransformBlock", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.FromBase64Transform), Member = "TransformFinalBlock", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.X509PalImpl", Member = "PEM", MemberParameters = new object[]
			{
				typeof(string),
				"System.Byte[]"
			}, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.X509PalImpl", Member = "GetCertContentType", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(global::System.Security.Cryptography.X509Certificates.X509ContentType))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadPrintableString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadIA5String", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadTime", MemberParameters = new object[]
			{
				"System.Security.Cryptography.DerSequenceReader.DerTag",
				typeof(string)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AsnEncodedData", Member = "SubjectAltName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream", Member = "GetEncodedString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "OpenFileInternal", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(string),
				typeof(ref global::System.IO.FileStream),
				"System.Byte[]&",
				"System.Byte[]&",
				"System.Byte[]&"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "GetValuesToUpload", MemberParameters = new object[] { "System.Collections.Specialized.NameValueCollection" }, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "UrlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestSession", Member = "HashToHexString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ResponseStream", Member = "GetChunkSizeBytes", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<ProcessWrite>d__34", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer_inner>d__39", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.CommonUnixIPGlobalProperties", Member = "get_DomainName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "FromDateTime", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = "Mono.Security.ASN1")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToDateTime", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "PEM", MemberParameters = new object[]
			{
				typeof(string),
				"System.Byte[]"
			}, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X520.AttributeTypeAndValue", Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = "Mono.Security.ASN1")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "PasswordToKey", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "PasswordToKey", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type1Message", Member = "Decode", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type1Message", Member = "GetBytes", ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type2Message", Member = "Decode", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = "DecodeString", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = "EncodeString", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "DeriveKey", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(string)
			}, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 44)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASCIIEncoding), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700023D")]
		private static Encoding Latin1
		{
			[global::Cpp2ILInjected.Token(Token = "0x600164A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE510C", Offset = "0x1AE510C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Latin1Encoding), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600164B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5EF8", Offset = "0x1AE5EF8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual int GetByteCount(string s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600164C")]
		public abstract int GetByteCount(char[] chars, int index, int count);

		[global::System.CLSCompliant(false)]
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600164D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5F78", Offset = "0x1AE5F78", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public unsafe virtual int GetByteCount(char* chars, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600164E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE60C4", Offset = "0x1AE60C4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600164F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE60D4", Offset = "0x1AE60D4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual byte[] GetBytes(char[] chars)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001650")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6164", Offset = "0x1AE6164", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] GetBytes(char[] chars, int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001651")]
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

		[global::Cpp2ILInjected.Token(Token = "0x6001652")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE621C", Offset = "0x1AE621C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual byte[] GetBytes(string s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001653")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE631C", Offset = "0x1AE631C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001654")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE63C8", Offset = "0x1AE63C8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001655")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE63D8", Offset = "0x1AE63D8", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001656")]
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		[global::System.CLSCompliant(false)]
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001657")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE65C4", Offset = "0x1AE65C4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public unsafe virtual int GetCharCount(byte* bytes, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001658")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6714", Offset = "0x1AE6714", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001659")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6724", Offset = "0x1AE6724", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual char[] GetChars(byte[] bytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600165A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE67B4", Offset = "0x1AE67B4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual char[] GetChars(byte[] bytes, int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600165B")]
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		[global::System.CLSCompliant(false)]
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600165C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6870", Offset = "0x1AE6870", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600165D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6A5C", Offset = "0x1AE6A5C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600165E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6A6C", Offset = "0x1AE6A6C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateStringForSByteConstructor", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureData), Member = "idx2string", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public unsafe string GetString(byte* bytes, int byteCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600165F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6B50", Offset = "0x1AE6B50", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual int GetChars(global::System.ReadOnlySpan<byte> bytes, global::System.Span<char> chars)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001660")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6BF4", Offset = "0x1AE6BF4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(sbyte*),
			typeof(int),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe string GetString(global::System.ReadOnlySpan<byte> bytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700023E")]
		public virtual int CodePage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001661")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE6C58", Offset = "0x1AE6C58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001662")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6C60", Offset = "0x1AE6C60", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Decoder GetDecoder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001663")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6CF4", Offset = "0x1AE6CF4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingHelper), Member = "GetDefaultEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Encoding CreateDefaultEncoding()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001664")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6EC8", Offset = "0x1AE6EC8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void setReadOnly(bool value = true)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700023F")]
		public static Encoding Default
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001665")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE4D58", Offset = "0x1AE4D58", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FileUtilities", Member = "ReadAllText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordRpc.RichPresence", Member = "StrToUtf8NullTerm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new object[]
			{
				"System.Net.CommandStream.PipelineEntry",
				"System.Net.ResponseDescription",
				typeof(bool),
				typeof(ref global::System.IO.Stream)
			}, ReturnType = "System.Net.CommandStream.PipelineInstruction")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HostHeaderString", Member = "Convert", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpConnection", Member = "SendError", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerContext", Member = "ParseBasicAuthentication", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Security.Principal.IPrincipal))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "get_ContentEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "get_ContentEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(global::System.IO.MemoryStream)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddEntry", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = "Ionic.Zip.ZipEntry")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "UpdateEntry", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = "Ionic.Zip.ZipEntry")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "CreateDefaultEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001666")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6ED4", Offset = "0x1AE6ED4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Encoder GetEncoder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001667")]
		public abstract int GetMaxByteCount(int charCount);

		[global::Cpp2ILInjected.Token(Token = "0x6001668")]
		public abstract int GetMaxCharCount(int byteCount);

		[global::Cpp2ILInjected.Token(Token = "0x6001669")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6F68", Offset = "0x1AE6F68", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual string GetString(byte[] bytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600166A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6FF8", Offset = "0x1AE6FF8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		public virtual string GetString(byte[] bytes, int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000240")]
		public static Encoding Unicode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE4DD4", Offset = "0x1AE4DD4", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "FileHelpers", Member = "ReadNetString", MemberParameters = new object[] { typeof(global::System.IO.BinaryReader) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "LoadSpriteFont", MemberParameters = new object[] { typeof(string) }, ReturnType = "Microsoft.Xna.Framework.Graphics.SpriteFont")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "ChangeFormat", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.StreamReader.NullStreamReader", Member = "get_CurrentEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.TextWriter.NullTextWriter", Member = "get_Encoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				"System.Xml.XmlNodeType",
				"System.Xml.XmlParserContext"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				"System.Xml.XmlParserContext"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "InitTextReaderInput", MemberParameters = new object[]
			{
				typeof(string),
				"System.Uri",
				typeof(global::System.IO.TextReader)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "DetectEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLM_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new object[]
			{
				"Mono.Security.Protocol.Ntlm.Type2Message",
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type2Message", Member = "Decode", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = "DecodeString", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = "EncodeString", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000241")]
		public static Encoding BigEndianUnicode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE4E7C", Offset = "0x1AE4E7C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadBMPString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "DetectEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X520.AttributeTypeAndValue", Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = "Mono.Security.ASN1")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000242")]
		public static Encoding UTF7
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE4F24", Offset = "0x1AE4F24", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X501", Member = "AppendEntry", MemberParameters = new object[]
			{
				typeof(StringBuilder),
				"Mono.Security.ASN1",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF7Encoding), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000243")]
		public unsafe static Encoding UTF8
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE3B80", Offset = "0x1AE3B80", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CSVReader", Member = "GetRawLine", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "nativefiledialog", Member = "Utf8EncodeNullable", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Byte*")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "nativefiledialog", Member = "UTF8_ToManaged", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "InitializeConsoleOutput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordRpc.RichPresence", Member = "StrToPtr", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordRpc.RichPresence", Member = "StrToUtf8NullTerm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.NetworkText", Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.FavoritesFile", Member = "Save", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.FavoritesFile", Member = "Load", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Chat.ChatCommandId", Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Chat.ChatMessage", Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys.DirectoryEntry), Member = "GetName", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "ReadLink", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.RuntimeMarshal), Member = "PtrToUtf8String", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Security.Cryptography.KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Security.Cryptography.KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateStringForSByteConstructor", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseRaw", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(ref global::System.TimeZoneInfo.TZifHead),
				typeof(ref global::System.DateTime[]),
				typeof(ref byte[]),
				typeof(ref global::System.TimeZoneInfo.TZifType[]),
				typeof(ref string),
				typeof(ref bool[]),
				typeof(ref bool[]),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueUtf8Converter), Member = "ConvertAndTerminateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.Span<byte>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "ChangeFormat", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[]),
				typeof(int),
				typeof(global::System.Security.Cryptography.HashAlgorithmName)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(global::System.Security.Cryptography.HashAlgorithmName)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RNGCryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.IO.Stream),
				typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter),
				typeof(global::System.Runtime.Serialization.Formatters.FormatterTypeStyle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.IO.Stream),
				typeof(global::System.Collections.Generic.Dictionary<string, global::System.Resources.ResourceLocator>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.IO.Stream),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.File), Member = "OpenText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IO.StreamReader))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureData), Member = "idx2string", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = ".ctor", MemberParameters = new object[] { "Mono.Net.Security.MobileAuthenticatedStream", "Mono.Net.Security.MonoSslAuthenticationOptions" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsProvider", Member = "ValidateCertificate", MemberParameters = new object[]
			{
				"Mono.Net.Security.ChainValidationHelper",
				typeof(string),
				typeof(bool),
				"System.Security.Cryptography.X509Certificates.X509CertificateCollection",
				typeof(bool),
				"System.Security.Cryptography.X509Certificates.X509Chain&",
				"System.Net.Security.SslPolicyErrors&",
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeGssNameHandle", Member = "CreateUser", MemberParameters = new object[] { typeof(string) }, ReturnType = "Microsoft.Win32.SafeHandles.SafeGssNameHandle")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeGssNameHandle", Member = "CreatePrincipal", MemberParameters = new object[] { typeof(string) }, ReturnType = "Microsoft.Win32.SafeHandles.SafeGssNameHandle")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeGssCredHandle", Member = "Create", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(bool)
			}, ReturnType = "Microsoft.Win32.SafeHandles.SafeGssCredHandle")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
			{
				"System.Char*",
				typeof(int),
				typeof(int),
				"System.UriComponents"
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "EscapeString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				"System.Char[]",
				typeof(ref int),
				typeof(bool),
				typeof(char),
				typeof(char),
				typeof(char)
			}, ReturnType = "System.Char[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new object[]
			{
				"System.Char*",
				typeof(int),
				typeof(int),
				"System.Char[]",
				typeof(ref int),
				typeof(char),
				typeof(char),
				typeof(char),
				"System.UnescapeMode",
				"System.UriParser",
				typeof(bool)
			}, ReturnType = "System.Char[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "MatchUTF8Sequence", MemberParameters = new object[]
			{
				"System.Char*",
				"System.Char[]",
				typeof(ref int),
				"System.Char[]",
				typeof(int),
				"System.Byte[]",
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadUtf8String", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CommandStream", Member = ".ctor", MemberParameters = new object[] { "System.Net.Sockets.TcpClient" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new object[]
			{
				"System.Net.CommandStream.PipelineEntry",
				"System.Net.ResponseDescription",
				typeof(bool),
				typeof(ref global::System.IO.Stream)
			}, ReturnType = "System.Net.CommandStream.PipelineInstruction")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "OpenFileInternal", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(string),
				typeof(ref global::System.IO.FileStream),
				"System.Byte[]&",
				"System.Byte[]&",
				"System.Byte[]&"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "UrlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HostHeaderString", Member = "Convert", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "UrlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "UrlDecode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerActionSet", Member = "SaveData", ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "SetupEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlWriterSettings", Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "ReadString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "GetString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "EnsureBuffers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "get_Encoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextAsset.EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractStackTrace", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ReadDirEntry", MemberParameters = new object[] { "Ionic.Zip.ZipFile", "System.Collections.Generic.Dictionary`2<String, Object>" }, ReturnType = "Ionic.Zip.ZipEntry")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ReadHeader", MemberParameters = new object[]
			{
				"Ionic.Zip.ZipEntry",
				typeof(Encoding)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "WriteHeader", MemberParameters = new object[]
			{
				typeof(global::System.IO.Stream),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutputStream", Member = "get_UseUnicodeAsNecessary", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutputStream", Member = "set_UseUnicodeAsNecessary", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.SharedUtils", Member = "ToByteArray", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.SharedUtils", Member = "ToCharArray", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Char[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = "CompressString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.IO.Stream)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = "UncompressString", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(global::System.IO.Stream)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X501", Member = "AppendEntry", MemberParameters = new object[]
			{
				typeof(StringBuilder),
				"Mono.Security.ASN1",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X501", Member = "ReadHex", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 81)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000244")]
		public static Encoding UTF32
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE4FC4", Offset = "0x1AE4FC4", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001670")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE7020", Offset = "0x1AE7020", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001671")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE70E0", Offset = "0x1AE70E0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001672")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE712C", Offset = "0x1AE712C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual char[] GetBestFitUnicodeToBytesData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001673")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE7184", Offset = "0x1AE7184", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual char[] GetBestFitBytesToUnicodeData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001674")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE71DC", Offset = "0x1AE71DC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void ThrowBytesOverflow()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001675")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE72AC", Offset = "0x1AE72AC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(EncoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderNLS), Member = "ClearMustFlush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_InternalHasFallbackBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", ReturnType = typeof(void))]
		internal unsafe void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001676")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE731C", Offset = "0x1AE731C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
		{
			typeof(DecoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void ThrowCharsOverflow()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001677")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE73EC", Offset = "0x1AE73EC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Latin1Encoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "GetChars", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(DecoderNLS)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingCharBuffer), Member = "AddChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingCharBuffer), Member = "Fallback", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderNLS), Member = "ClearMustFlush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_InternalHasFallbackBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", ReturnType = typeof(void))]
		internal unsafe void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001678")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE745C", Offset = "0x1AE745C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual int GetBytes(global::System.ReadOnlySpan<char> chars, global::System.Span<byte> bytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B5D")]
		private static Encoding defaultEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000B5E")]
		private static Encoding unicodeEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000B5F")]
		private static Encoding bigEndianUnicode;

		[global::Cpp2ILInjected.Token(Token = "0x4000B60")]
		private static Encoding utf7Encoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000B61")]
		private static Encoding utf8Encoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000B62")]
		private static Encoding utf32Encoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000B63")]
		private static Encoding asciiEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000B64")]
		private static Encoding latin1Encoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000B65")]
		private static global::System.Collections.Generic.Dictionary<int, Encoding> encodings;

		[global::Cpp2ILInjected.Token(Token = "0x4000B66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_codePage;

		[global::Cpp2ILInjected.Token(Token = "0x4000B67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Globalization.CodePageDataItem dataItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000B68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		internal bool m_deserializedFromEverett;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000B69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool m_isReadOnly;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000B6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal EncoderFallback encoderFallback;

		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000B6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal DecoderFallback decoderFallback;

		[global::Cpp2ILInjected.Token(Token = "0x4000B6C")]
		private static object s_InternalSyncObject;

		[global::Cpp2ILInjected.Token(Token = "0x200028A")]
		[global::System.Serializable]
		internal class DefaultEncoder : Encoder, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IObjectReference
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001679")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE6F38", Offset = "0x1AE6F38", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
			public DefaultEncoder(Encoding encoding)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600167A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7500", Offset = "0x1AE7500", Length = "0x34C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
			internal DefaultEncoder(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600167B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE784C", Offset = "0x1AE784C", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public object GetRealObject(global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600167C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE78F8", Offset = "0x1AE78F8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600167D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7998", Offset = "0x1AE7998", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetByteCount(char[] chars, int index, int count, bool flush)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600167E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE79A8", Offset = "0x1AE79A8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600167F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE79BC", Offset = "0x1AE79BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001680")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE79D0", Offset = "0x1AE79D0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B6D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Encoding m_encoding;

			[global::Cpp2ILInjected.Token(Token = "0x4000B6E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			[global::System.NonSerialized]
			private bool m_hasInitializedEncoding;

			[global::Cpp2ILInjected.Token(Token = "0x4000B6F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
			[global::System.NonSerialized]
			internal char charLeftOver;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200028B")]
		[global::System.Serializable]
		internal class DefaultDecoder : Decoder, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IObjectReference
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001681")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE6CC4", Offset = "0x1AE6CC4", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = ".ctor", ReturnType = typeof(void))]
			public DefaultDecoder(Encoding encoding)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001682")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE79E4", Offset = "0x1AE79E4", Length = "0x2B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
			internal DefaultDecoder(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001683")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7C98", Offset = "0x1AE7C98", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public object GetRealObject(global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001684")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7CD8", Offset = "0x1AE7CD8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001685")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7D78", Offset = "0x1AE7D78", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetCharCount(byte[] bytes, int index, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001686")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7D88", Offset = "0x1AE7D88", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001687")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7D9C", Offset = "0x1AE7D9C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001688")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7DB0", Offset = "0x1AE7DB0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001689")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7DC0", Offset = "0x1AE7DC0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600168A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7DD4", Offset = "0x1AE7DD4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B70")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Encoding m_encoding;

			[global::Cpp2ILInjected.Token(Token = "0x4000B71")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			[global::System.NonSerialized]
			private bool m_hasInitializedEncoding;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200028C")]
		internal class EncodingCharBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600168B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7DE8", Offset = "0x1AE7DE8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(char*)
			}, ReturnType = typeof(void))]
			internal unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600168C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7E80", Offset = "0x1AE7E80", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingCharBuffer), Member = "AddChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
			{
				typeof(DecoderNLS),
				typeof(bool)
			}, ReturnType = typeof(void))]
			internal bool AddChar(char ch, int numBytes)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600168D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7EE8", Offset = "0x1AE7EE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingCharBuffer), Member = "AddChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int)
			}, ReturnType = typeof(bool))]
			internal unsafe bool AddChar(char ch)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600168E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7EF0", Offset = "0x1AE7EF0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal unsafe void AdjustBytes(int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000245")]
			internal unsafe bool MoreData
			{
				[global::Cpp2ILInjected.Token(Token = "0x600168F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AE7F00", Offset = "0x1AE7F00", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new object[]
				{
					typeof(byte*),
					typeof(int),
					typeof(char*),
					typeof(int),
					typeof(DecoderNLS)
				}, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001690")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7F10", Offset = "0x1AE7F10", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal unsafe byte GetNextByte()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000246")]
			internal unsafe int BytesUsed
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001691")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AE7F34", Offset = "0x1AE7F34", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new object[]
				{
					typeof(byte*),
					typeof(int),
					typeof(char*),
					typeof(int),
					typeof(DecoderNLS)
				}, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001692")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7F44", Offset = "0x1AE7F44", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int),
				typeof(char*),
				typeof(int),
				typeof(DecoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal unsafe bool Fallback(byte fallbackByte)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001693")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7FA8", Offset = "0x1AE7FA8", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new object[]
			{
				typeof(DecoderNLS),
				typeof(bool)
			}, ReturnType = typeof(void))]
			internal bool Fallback(byte[] byteBuffer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000247")]
			internal int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001694")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AE8060", Offset = "0x1AE8060", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B72")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private unsafe char* chars;

			[global::Cpp2ILInjected.Token(Token = "0x4000B73")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private unsafe char* charStart;

			[global::Cpp2ILInjected.Token(Token = "0x4000B74")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private unsafe char* charEnd;

			[global::Cpp2ILInjected.Token(Token = "0x4000B75")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int charCountResult;

			[global::Cpp2ILInjected.Token(Token = "0x4000B76")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Encoding enc;

			[global::Cpp2ILInjected.Token(Token = "0x4000B77")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private DecoderNLS decoder;

			[global::Cpp2ILInjected.Token(Token = "0x4000B78")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private unsafe byte* byteStart;

			[global::Cpp2ILInjected.Token(Token = "0x4000B79")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private unsafe byte* byteEnd;

			[global::Cpp2ILInjected.Token(Token = "0x4000B7A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private unsafe byte* bytes;

			[global::Cpp2ILInjected.Token(Token = "0x4000B7B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private DecoderFallbackBuffer fallbackBuffer;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200028D")]
		internal class EncodingByteBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001695")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE8068", Offset = "0x1AE8068", Length = "0x194")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = "get_InternalHasFallbackBuffer", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(char*),
				typeof(EncoderNLS),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			internal unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001696")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE81FC", Offset = "0x1AE81FC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingByteBuffer), Member = "AddByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingByteBuffer), Member = "AddByte", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			internal bool AddByte(byte b, int moreBytesExpected)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001697")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE82BC", Offset = "0x1AE82BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = "AddByte", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(int)
			}, ReturnType = typeof(bool))]
			internal unsafe bool AddByte(byte b1)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001698")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE82C4", Offset = "0x1AE82C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal unsafe bool AddByte(byte b1, byte b2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001699")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE82CC", Offset = "0x1AE82CC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding.EncodingByteBuffer), Member = "AddByte", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(int)
			}, ReturnType = typeof(bool))]
			internal bool AddByte(byte b1, byte b2, int moreBytesExpected)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600169A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE824C", Offset = "0x1AE824C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding.EncodingByteBuffer), Member = "AddByte", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
			{
				typeof(EncoderNLS),
				typeof(bool)
			}, ReturnType = typeof(void))]
			internal void MovePrevious(bool bThrow)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000248")]
			internal unsafe bool MoreData
			{
				[global::Cpp2ILInjected.Token(Token = "0x600169B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AE8314", Offset = "0x1AE8314", Length = "0x40")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new object[]
				{
					typeof(char*),
					typeof(int),
					typeof(byte*),
					typeof(int),
					typeof(EncoderNLS)
				}, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x600169C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE8354", Offset = "0x1AE8354", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int),
				typeof(byte*),
				typeof(int),
				typeof(EncoderNLS)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
			internal unsafe char GetNextChar()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000249")]
			internal unsafe int CharsUsed
			{
				[global::Cpp2ILInjected.Token(Token = "0x600169D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AE839C", Offset = "0x1AE839C", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new object[]
				{
					typeof(char*),
					typeof(int),
					typeof(byte*),
					typeof(int),
					typeof(EncoderNLS)
				}, ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700024A")]
			internal int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x600169E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AE83B4", Offset = "0x1AE83B4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B7C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private unsafe byte* bytes;

			[global::Cpp2ILInjected.Token(Token = "0x4000B7D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private unsafe byte* byteStart;

			[global::Cpp2ILInjected.Token(Token = "0x4000B7E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private unsafe byte* byteEnd;

			[global::Cpp2ILInjected.Token(Token = "0x4000B7F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private unsafe char* chars;

			[global::Cpp2ILInjected.Token(Token = "0x4000B80")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private unsafe char* charStart;

			[global::Cpp2ILInjected.Token(Token = "0x4000B81")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private unsafe char* charEnd;

			[global::Cpp2ILInjected.Token(Token = "0x4000B82")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private int byteCountResult;

			[global::Cpp2ILInjected.Token(Token = "0x4000B83")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private Encoding enc;

			[global::Cpp2ILInjected.Token(Token = "0x4000B84")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private EncoderNLS encoder;

			[global::Cpp2ILInjected.Token(Token = "0x4000B85")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal EncoderFallbackBuffer fallbackBuffer;
		}
	}
}
