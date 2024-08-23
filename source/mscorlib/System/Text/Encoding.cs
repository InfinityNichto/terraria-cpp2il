using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001FB RID: 507
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000289")]
	[global::System.Serializable]
	public abstract class Encoding : global::System.ICloneable
	{
		// Token: 0x06001456 RID: 5206 RVA: 0x00017E31 File Offset: 0x00016031
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

		// Token: 0x06001457 RID: 5207 RVA: 0x00017E34 File Offset: 0x00016034
		[global::Cpp2ILInjected.Token(Token = "0x6001630")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3D40", Offset = "0x1AE3D40", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected Encoding(int codePage)
		{
			throw null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00017E37 File Offset: 0x00016037
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

		// Token: 0x06001459 RID: 5209 RVA: 0x00017E3A File Offset: 0x0001603A
		[global::Cpp2ILInjected.Token(Token = "0x6001632")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3E5C", Offset = "0x1AE3E5C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void OnDeserializing()
		{
			throw null;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00017E3D File Offset: 0x0001603D
		[global::Cpp2ILInjected.Token(Token = "0x6001633")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3E6C", Offset = "0x1AE3E6C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void OnDeserialized()
		{
			throw null;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00017E40 File Offset: 0x00016040
		[global::System.Runtime.Serialization.OnDeserializing]
		[global::Cpp2ILInjected.Token(Token = "0x6001634")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3EA8", Offset = "0x1AE3EA8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00017E43 File Offset: 0x00016043
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6001635")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3EB8", Offset = "0x1AE3EB8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00017E46 File Offset: 0x00016046
		[global::System.Runtime.Serialization.OnSerializing]
		[global::Cpp2ILInjected.Token(Token = "0x6001636")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3EF4", Offset = "0x1AE3EF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnSerializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00017E49 File Offset: 0x00016049
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

		// Token: 0x0600145F RID: 5215 RVA: 0x00017E4C File Offset: 0x0001604C
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00017E4F File Offset: 0x0001604F
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

		// Token: 0x06001461 RID: 5217 RVA: 0x00017E52 File Offset: 0x00016052
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

		// Token: 0x06001462 RID: 5218 RVA: 0x00017E55 File Offset: 0x00016055
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

		// Token: 0x06001463 RID: 5219 RVA: 0x00017E58 File Offset: 0x00016058
		[global::Cpp2ILInjected.Token(Token = "0x600163C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5B14", Offset = "0x1AE5B14", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingProvider), Member = "GetEncodingFromProvider", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.EncodingTable), Member = "GetCodePageFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Encoding GetEncoding(string name)
		{
			throw null;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00017E5B File Offset: 0x0001605B
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

		// Token: 0x06001465 RID: 5221 RVA: 0x00017E5E File Offset: 0x0001605E
		[global::Cpp2ILInjected.Token(Token = "0x600163E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE5C70", Offset = "0x1AE5C70", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] GetPreamble()
		{
			throw null;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x00017E61 File Offset: 0x00016061
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

		// Token: 0x06001467 RID: 5223 RVA: 0x00017E64 File Offset: 0x00016064
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

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00017E67 File Offset: 0x00016067
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x00017E6A File Offset: 0x0001606A
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00017E6D File Offset: 0x0001606D
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00017E70 File Offset: 0x00016070
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00017E73 File Offset: 0x00016073
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00017E76 File Offset: 0x00016076
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

		// Token: 0x0600146E RID: 5230 RVA: 0x00017E79 File Offset: 0x00016079
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00017E7C File Offset: 0x0001607C
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x00017E7F File Offset: 0x0001607F
		[global::Cpp2ILInjected.Token(Token = "0x1700023C")]
		public static Encoding ASCII
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001649")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE506C", Offset = "0x1AE506C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 44)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASCIIEncoding), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x00017E82 File Offset: 0x00016082
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

		// Token: 0x06001472 RID: 5234 RVA: 0x00017E85 File Offset: 0x00016085
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

		// Token: 0x06001473 RID: 5235
		[global::Cpp2ILInjected.Token(Token = "0x600164C")]
		public abstract int GetByteCount(char[] chars, int index, int count);

		// Token: 0x06001474 RID: 5236 RVA: 0x00017E88 File Offset: 0x00016088
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

		// Token: 0x06001475 RID: 5237 RVA: 0x00017E8B File Offset: 0x0001608B
		[global::Cpp2ILInjected.Token(Token = "0x600164E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE60C4", Offset = "0x1AE60C4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00017E8E File Offset: 0x0001608E
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

		// Token: 0x06001477 RID: 5239 RVA: 0x00017E91 File Offset: 0x00016091
		[global::Cpp2ILInjected.Token(Token = "0x6001650")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6164", Offset = "0x1AE6164", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] GetBytes(char[] chars, int index, int count)
		{
			throw null;
		}

		// Token: 0x06001478 RID: 5240
		[global::Cpp2ILInjected.Token(Token = "0x6001651")]
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

		// Token: 0x06001479 RID: 5241 RVA: 0x00017E94 File Offset: 0x00016094
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

		// Token: 0x0600147A RID: 5242 RVA: 0x00017E97 File Offset: 0x00016097
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

		// Token: 0x0600147B RID: 5243 RVA: 0x00017E9A File Offset: 0x0001609A
		[global::Cpp2ILInjected.Token(Token = "0x6001654")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE63C8", Offset = "0x1AE63C8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			throw null;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00017E9D File Offset: 0x0001609D
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

		// Token: 0x0600147D RID: 5245
		[global::Cpp2ILInjected.Token(Token = "0x6001656")]
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		// Token: 0x0600147E RID: 5246 RVA: 0x00017EA0 File Offset: 0x000160A0
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

		// Token: 0x0600147F RID: 5247 RVA: 0x00017EA3 File Offset: 0x000160A3
		[global::Cpp2ILInjected.Token(Token = "0x6001658")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6714", Offset = "0x1AE6714", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			throw null;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00017EA6 File Offset: 0x000160A6
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

		// Token: 0x06001481 RID: 5249 RVA: 0x00017EA9 File Offset: 0x000160A9
		[global::Cpp2ILInjected.Token(Token = "0x600165A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE67B4", Offset = "0x1AE67B4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual char[] GetChars(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x06001482 RID: 5250
		[global::Cpp2ILInjected.Token(Token = "0x600165B")]
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		// Token: 0x06001483 RID: 5251 RVA: 0x00017EAC File Offset: 0x000160AC
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

		// Token: 0x06001484 RID: 5252 RVA: 0x00017EAF File Offset: 0x000160AF
		[global::Cpp2ILInjected.Token(Token = "0x600165D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6A5C", Offset = "0x1AE6A5C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			throw null;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00017EB2 File Offset: 0x000160B2
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

		// Token: 0x06001486 RID: 5254 RVA: 0x00017EB5 File Offset: 0x000160B5
		[global::Cpp2ILInjected.Token(Token = "0x600165F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6B50", Offset = "0x1AE6B50", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual int GetChars(global::System.ReadOnlySpan<byte> bytes, global::System.Span<char> chars)
		{
			throw null;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00017EB8 File Offset: 0x000160B8
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x00017EBB File Offset: 0x000160BB
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

		// Token: 0x06001489 RID: 5257 RVA: 0x00017EBE File Offset: 0x000160BE
		[global::Cpp2ILInjected.Token(Token = "0x6001662")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6C60", Offset = "0x1AE6C60", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Decoder GetDecoder()
		{
			throw null;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00017EC1 File Offset: 0x000160C1
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

		// Token: 0x0600148B RID: 5259 RVA: 0x00017EC4 File Offset: 0x000160C4
		[global::Cpp2ILInjected.Token(Token = "0x6001664")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6EC8", Offset = "0x1AE6EC8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void setReadOnly(bool value = true)
		{
			throw null;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x00017EC7 File Offset: 0x000160C7
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

		// Token: 0x0600148D RID: 5261 RVA: 0x00017ECA File Offset: 0x000160CA
		[global::Cpp2ILInjected.Token(Token = "0x6001666")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6ED4", Offset = "0x1AE6ED4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Encoder GetEncoder()
		{
			throw null;
		}

		// Token: 0x0600148E RID: 5262
		[global::Cpp2ILInjected.Token(Token = "0x6001667")]
		public abstract int GetMaxByteCount(int charCount);

		// Token: 0x0600148F RID: 5263
		[global::Cpp2ILInjected.Token(Token = "0x6001668")]
		public abstract int GetMaxCharCount(int byteCount);

		// Token: 0x06001490 RID: 5264 RVA: 0x00017ECD File Offset: 0x000160CD
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

		// Token: 0x06001491 RID: 5265 RVA: 0x00017ED0 File Offset: 0x000160D0
		[global::Cpp2ILInjected.Token(Token = "0x600166A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6FF8", Offset = "0x1AE6FF8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		public virtual string GetString(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x00017ED3 File Offset: 0x000160D3
		[global::Cpp2ILInjected.Token(Token = "0x17000240")]
		public static Encoding Unicode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE4DD4", Offset = "0x1AE4DD4", Length = "0xA8")]
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

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x00017ED6 File Offset: 0x000160D6
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00017ED9 File Offset: 0x000160D9
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00017EDC File Offset: 0x000160DC
		[global::Cpp2ILInjected.Token(Token = "0x17000243")]
		public static Encoding UTF8
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE3B80", Offset = "0x1AE3B80", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 81)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x00017EDF File Offset: 0x000160DF
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

		// Token: 0x06001497 RID: 5271 RVA: 0x00017EE2 File Offset: 0x000160E2
		[global::Cpp2ILInjected.Token(Token = "0x6001670")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE7020", Offset = "0x1AE7020", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00017EE5 File Offset: 0x000160E5
		[global::Cpp2ILInjected.Token(Token = "0x6001671")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE70E0", Offset = "0x1AE70E0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00017EE8 File Offset: 0x000160E8
		[global::Cpp2ILInjected.Token(Token = "0x6001672")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE712C", Offset = "0x1AE712C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual char[] GetBestFitUnicodeToBytesData()
		{
			throw null;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00017EEB File Offset: 0x000160EB
		[global::Cpp2ILInjected.Token(Token = "0x6001673")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE7184", Offset = "0x1AE7184", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual char[] GetBestFitBytesToUnicodeData()
		{
			throw null;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00017EEE File Offset: 0x000160EE
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

		// Token: 0x0600149C RID: 5276 RVA: 0x00017EF1 File Offset: 0x000160F1
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

		// Token: 0x0600149D RID: 5277 RVA: 0x00017EF4 File Offset: 0x000160F4
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

		// Token: 0x0600149E RID: 5278 RVA: 0x00017EF7 File Offset: 0x000160F7
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

		// Token: 0x0600149F RID: 5279 RVA: 0x00017EFA File Offset: 0x000160FA
		[global::Cpp2ILInjected.Token(Token = "0x6001678")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE745C", Offset = "0x1AE745C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual int GetBytes(global::System.ReadOnlySpan<char> chars, global::System.Span<byte> bytes)
		{
			throw null;
		}

		// Token: 0x040008E3 RID: 2275
		[global::Cpp2ILInjected.Token(Token = "0x4000B5D")]
		private static Encoding defaultEncoding;

		// Token: 0x040008E4 RID: 2276
		[global::Cpp2ILInjected.Token(Token = "0x4000B5E")]
		private static Encoding unicodeEncoding;

		// Token: 0x040008E5 RID: 2277
		[global::Cpp2ILInjected.Token(Token = "0x4000B5F")]
		private static Encoding bigEndianUnicode;

		// Token: 0x040008E6 RID: 2278
		[global::Cpp2ILInjected.Token(Token = "0x4000B60")]
		private static Encoding utf7Encoding;

		// Token: 0x040008E7 RID: 2279
		[global::Cpp2ILInjected.Token(Token = "0x4000B61")]
		private static Encoding utf8Encoding;

		// Token: 0x040008E8 RID: 2280
		[global::Cpp2ILInjected.Token(Token = "0x4000B62")]
		private static Encoding utf32Encoding;

		// Token: 0x040008E9 RID: 2281
		[global::Cpp2ILInjected.Token(Token = "0x4000B63")]
		private static Encoding asciiEncoding;

		// Token: 0x040008EA RID: 2282
		[global::Cpp2ILInjected.Token(Token = "0x4000B64")]
		private static Encoding latin1Encoding;

		// Token: 0x040008EB RID: 2283
		[global::Cpp2ILInjected.Token(Token = "0x4000B65")]
		private static global::System.Collections.Generic.Dictionary<int, Encoding> encodings;

		// Token: 0x040008EC RID: 2284
		[global::Cpp2ILInjected.Token(Token = "0x4000B66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_codePage;

		// Token: 0x040008ED RID: 2285
		[global::Cpp2ILInjected.Token(Token = "0x4000B67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Globalization.CodePageDataItem dataItem;

		// Token: 0x040008EE RID: 2286
		[global::Cpp2ILInjected.Token(Token = "0x4000B68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		internal bool m_deserializedFromEverett;

		// Token: 0x040008EF RID: 2287
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000B69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool m_isReadOnly;

		// Token: 0x040008F0 RID: 2288
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000B6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal EncoderFallback encoderFallback;

		// Token: 0x040008F1 RID: 2289
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4000B6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal DecoderFallback decoderFallback;

		// Token: 0x040008F2 RID: 2290
		[global::Cpp2ILInjected.Token(Token = "0x4000B6C")]
		private static object s_InternalSyncObject;

		// Token: 0x020005D9 RID: 1497
		[global::Cpp2ILInjected.Token(Token = "0x200028A")]
		[global::System.Serializable]
		internal class DefaultEncoder : Encoder, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IObjectReference
		{
			// Token: 0x060040B0 RID: 16560 RVA: 0x0001FCC1 File Offset: 0x0001DEC1
			[global::Cpp2ILInjected.Token(Token = "0x6001679")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE6F38", Offset = "0x1AE6F38", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
			public DefaultEncoder(Encoding encoding)
			{
				throw null;
			}

			// Token: 0x060040B1 RID: 16561 RVA: 0x0001FCC4 File Offset: 0x0001DEC4
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

			// Token: 0x060040B2 RID: 16562 RVA: 0x0001FCC7 File Offset: 0x0001DEC7
			[global::Cpp2ILInjected.Token(Token = "0x600167B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE784C", Offset = "0x1AE784C", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public object GetRealObject(global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			// Token: 0x060040B3 RID: 16563 RVA: 0x0001FCCA File Offset: 0x0001DECA
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

			// Token: 0x060040B4 RID: 16564 RVA: 0x0001FCCD File Offset: 0x0001DECD
			[global::Cpp2ILInjected.Token(Token = "0x600167D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7998", Offset = "0x1AE7998", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetByteCount(char[] chars, int index, int count, bool flush)
			{
				throw null;
			}

			// Token: 0x060040B5 RID: 16565 RVA: 0x0001FCD0 File Offset: 0x0001DED0
			[global::Cpp2ILInjected.Token(Token = "0x600167E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE79A8", Offset = "0x1AE79A8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				throw null;
			}

			// Token: 0x060040B6 RID: 16566 RVA: 0x0001FCD3 File Offset: 0x0001DED3
			[global::Cpp2ILInjected.Token(Token = "0x600167F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE79BC", Offset = "0x1AE79BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
			{
				throw null;
			}

			// Token: 0x060040B7 RID: 16567 RVA: 0x0001FCD6 File Offset: 0x0001DED6
			[global::Cpp2ILInjected.Token(Token = "0x6001680")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE79D0", Offset = "0x1AE79D0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
			{
				throw null;
			}

			// Token: 0x04001902 RID: 6402
			[global::Cpp2ILInjected.Token(Token = "0x4000B6D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Encoding m_encoding;

			// Token: 0x04001903 RID: 6403
			[global::Cpp2ILInjected.Token(Token = "0x4000B6E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			[global::System.NonSerialized]
			private bool m_hasInitializedEncoding;

			// Token: 0x04001904 RID: 6404
			[global::Cpp2ILInjected.Token(Token = "0x4000B6F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
			[global::System.NonSerialized]
			internal char charLeftOver;
		}

		// Token: 0x020005DA RID: 1498
		[global::Cpp2ILInjected.Token(Token = "0x200028B")]
		[global::System.Serializable]
		internal class DefaultDecoder : Decoder, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IObjectReference
		{
			// Token: 0x060040B8 RID: 16568 RVA: 0x0001FCD9 File Offset: 0x0001DED9
			[global::Cpp2ILInjected.Token(Token = "0x6001681")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE6CC4", Offset = "0x1AE6CC4", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = ".ctor", ReturnType = typeof(void))]
			public DefaultDecoder(Encoding encoding)
			{
				throw null;
			}

			// Token: 0x060040B9 RID: 16569 RVA: 0x0001FCDC File Offset: 0x0001DEDC
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

			// Token: 0x060040BA RID: 16570 RVA: 0x0001FCDF File Offset: 0x0001DEDF
			[global::Cpp2ILInjected.Token(Token = "0x6001683")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7C98", Offset = "0x1AE7C98", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public object GetRealObject(global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			// Token: 0x060040BB RID: 16571 RVA: 0x0001FCE2 File Offset: 0x0001DEE2
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

			// Token: 0x060040BC RID: 16572 RVA: 0x0001FCE5 File Offset: 0x0001DEE5
			[global::Cpp2ILInjected.Token(Token = "0x6001685")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7D78", Offset = "0x1AE7D78", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetCharCount(byte[] bytes, int index, int count)
			{
				throw null;
			}

			// Token: 0x060040BD RID: 16573 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
			[global::Cpp2ILInjected.Token(Token = "0x6001686")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7D88", Offset = "0x1AE7D88", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
			{
				throw null;
			}

			// Token: 0x060040BE RID: 16574 RVA: 0x0001FCEB File Offset: 0x0001DEEB
			[global::Cpp2ILInjected.Token(Token = "0x6001687")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7D9C", Offset = "0x1AE7D9C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				throw null;
			}

			// Token: 0x060040BF RID: 16575 RVA: 0x0001FCEE File Offset: 0x0001DEEE
			[global::Cpp2ILInjected.Token(Token = "0x6001688")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7DB0", Offset = "0x1AE7DB0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
			{
				throw null;
			}

			// Token: 0x060040C0 RID: 16576 RVA: 0x0001FCF1 File Offset: 0x0001DEF1
			[global::Cpp2ILInjected.Token(Token = "0x6001689")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7DC0", Offset = "0x1AE7DC0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
			{
				throw null;
			}

			// Token: 0x060040C1 RID: 16577 RVA: 0x0001FCF4 File Offset: 0x0001DEF4
			[global::Cpp2ILInjected.Token(Token = "0x600168A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE7DD4", Offset = "0x1AE7DD4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
			{
				throw null;
			}

			// Token: 0x04001905 RID: 6405
			[global::Cpp2ILInjected.Token(Token = "0x4000B70")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Encoding m_encoding;

			// Token: 0x04001906 RID: 6406
			[global::Cpp2ILInjected.Token(Token = "0x4000B71")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			[global::System.NonSerialized]
			private bool m_hasInitializedEncoding;
		}

		// Token: 0x020005DB RID: 1499
		[global::Cpp2ILInjected.Token(Token = "0x200028C")]
		internal class EncodingCharBuffer
		{
			// Token: 0x060040C2 RID: 16578 RVA: 0x0001FCF7 File Offset: 0x0001DEF7
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

			// Token: 0x060040C3 RID: 16579 RVA: 0x0001FCFA File Offset: 0x0001DEFA
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

			// Token: 0x060040C4 RID: 16580 RVA: 0x0001FCFD File Offset: 0x0001DEFD
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

			// Token: 0x060040C5 RID: 16581 RVA: 0x0001FD00 File Offset: 0x0001DF00
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

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x060040C6 RID: 16582 RVA: 0x0001FD03 File Offset: 0x0001DF03
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

			// Token: 0x060040C7 RID: 16583 RVA: 0x0001FD06 File Offset: 0x0001DF06
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

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x060040C8 RID: 16584 RVA: 0x0001FD09 File Offset: 0x0001DF09
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

			// Token: 0x060040C9 RID: 16585 RVA: 0x0001FD0C File Offset: 0x0001DF0C
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

			// Token: 0x060040CA RID: 16586 RVA: 0x0001FD0F File Offset: 0x0001DF0F
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

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x060040CB RID: 16587 RVA: 0x0001FD12 File Offset: 0x0001DF12
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

			// Token: 0x04001907 RID: 6407
			[global::Cpp2ILInjected.Token(Token = "0x4000B72")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private unsafe char* chars;

			// Token: 0x04001908 RID: 6408
			[global::Cpp2ILInjected.Token(Token = "0x4000B73")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private unsafe char* charStart;

			// Token: 0x04001909 RID: 6409
			[global::Cpp2ILInjected.Token(Token = "0x4000B74")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private unsafe char* charEnd;

			// Token: 0x0400190A RID: 6410
			[global::Cpp2ILInjected.Token(Token = "0x4000B75")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int charCountResult;

			// Token: 0x0400190B RID: 6411
			[global::Cpp2ILInjected.Token(Token = "0x4000B76")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Encoding enc;

			// Token: 0x0400190C RID: 6412
			[global::Cpp2ILInjected.Token(Token = "0x4000B77")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private DecoderNLS decoder;

			// Token: 0x0400190D RID: 6413
			[global::Cpp2ILInjected.Token(Token = "0x4000B78")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private unsafe byte* byteStart;

			// Token: 0x0400190E RID: 6414
			[global::Cpp2ILInjected.Token(Token = "0x4000B79")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private unsafe byte* byteEnd;

			// Token: 0x0400190F RID: 6415
			[global::Cpp2ILInjected.Token(Token = "0x4000B7A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private unsafe byte* bytes;

			// Token: 0x04001910 RID: 6416
			[global::Cpp2ILInjected.Token(Token = "0x4000B7B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private DecoderFallbackBuffer fallbackBuffer;
		}

		// Token: 0x020005DC RID: 1500
		[global::Cpp2ILInjected.Token(Token = "0x200028D")]
		internal class EncodingByteBuffer
		{
			// Token: 0x060040CC RID: 16588 RVA: 0x0001FD15 File Offset: 0x0001DF15
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

			// Token: 0x060040CD RID: 16589 RVA: 0x0001FD18 File Offset: 0x0001DF18
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

			// Token: 0x060040CE RID: 16590 RVA: 0x0001FD1B File Offset: 0x0001DF1B
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

			// Token: 0x060040CF RID: 16591 RVA: 0x0001FD1E File Offset: 0x0001DF1E
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

			// Token: 0x060040D0 RID: 16592 RVA: 0x0001FD21 File Offset: 0x0001DF21
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

			// Token: 0x060040D1 RID: 16593 RVA: 0x0001FD24 File Offset: 0x0001DF24
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

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x060040D2 RID: 16594 RVA: 0x0001FD27 File Offset: 0x0001DF27
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

			// Token: 0x060040D3 RID: 16595 RVA: 0x0001FD2A File Offset: 0x0001DF2A
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

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x060040D4 RID: 16596 RVA: 0x0001FD2D File Offset: 0x0001DF2D
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

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x060040D5 RID: 16597 RVA: 0x0001FD30 File Offset: 0x0001DF30
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

			// Token: 0x04001911 RID: 6417
			[global::Cpp2ILInjected.Token(Token = "0x4000B7C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private unsafe byte* bytes;

			// Token: 0x04001912 RID: 6418
			[global::Cpp2ILInjected.Token(Token = "0x4000B7D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private unsafe byte* byteStart;

			// Token: 0x04001913 RID: 6419
			[global::Cpp2ILInjected.Token(Token = "0x4000B7E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private unsafe byte* byteEnd;

			// Token: 0x04001914 RID: 6420
			[global::Cpp2ILInjected.Token(Token = "0x4000B7F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private unsafe char* chars;

			// Token: 0x04001915 RID: 6421
			[global::Cpp2ILInjected.Token(Token = "0x4000B80")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private unsafe char* charStart;

			// Token: 0x04001916 RID: 6422
			[global::Cpp2ILInjected.Token(Token = "0x4000B81")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private unsafe char* charEnd;

			// Token: 0x04001917 RID: 6423
			[global::Cpp2ILInjected.Token(Token = "0x4000B82")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private int byteCountResult;

			// Token: 0x04001918 RID: 6424
			[global::Cpp2ILInjected.Token(Token = "0x4000B83")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private Encoding enc;

			// Token: 0x04001919 RID: 6425
			[global::Cpp2ILInjected.Token(Token = "0x4000B84")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private EncoderNLS encoder;

			// Token: 0x0400191A RID: 6426
			[global::Cpp2ILInjected.Token(Token = "0x4000B85")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal EncoderFallbackBuffer fallbackBuffer;
		}
	}
}
