using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000327 RID: 807
	[global::Cpp2ILInjected.Token(Token = "0x20003CD")]
	public class FormatterConverter : IFormatterConverter
	{
		// Token: 0x06001CA1 RID: 7329 RVA: 0x000194FC File Offset: 0x000176FC
		[global::Cpp2ILInjected.Token(Token = "0x6001EDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50FB0", Offset = "0x1B50FB0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public object Convert(object value, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000194FF File Offset: 0x000176FF
		[global::Cpp2ILInjected.Token(Token = "0x6001EDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5109C", Offset = "0x1B5109C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool ToBoolean(object value)
		{
			throw null;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00019502 File Offset: 0x00017702
		[global::Cpp2ILInjected.Token(Token = "0x6001EDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51134", Offset = "0x1B51134", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int ToInt32(object value)
		{
			throw null;
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00019505 File Offset: 0x00017705
		[global::Cpp2ILInjected.Token(Token = "0x6001EDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B511CC", Offset = "0x1B511CC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public long ToInt64(object value)
		{
			throw null;
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00019508 File Offset: 0x00017708
		[global::Cpp2ILInjected.Token(Token = "0x6001EDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51264", Offset = "0x1B51264", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public float ToSingle(object value)
		{
			throw null;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0001950B File Offset: 0x0001770B
		[global::Cpp2ILInjected.Token(Token = "0x6001EDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B512FC", Offset = "0x1B512FC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = "ThrowValueNullException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public string ToString(object value)
		{
			throw null;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0001950E File Offset: 0x0001770E
		[global::Cpp2ILInjected.Token(Token = "0x6001EE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51050", Offset = "0x1B51050", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterConverter), Member = "Convert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterConverter), Member = "ToBoolean", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterConverter), Member = "ToInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterConverter), Member = "ToInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterConverter), Member = "ToSingle", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterConverter), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowValueNullException()
		{
			throw null;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00019511 File Offset: 0x00017711
		[global::Cpp2ILInjected.Token(Token = "0x6001EE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51394", Offset = "0x1B51394", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "InitFullDeserialization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeISerializable", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(ISerializable),
			"Newtonsoft.Json.Serialization.JsonISerializableContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			"Newtonsoft.Json.Serialization.JsonContainerContract",
			"Newtonsoft.Json.Serialization.JsonProperty"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FormatterConverter()
		{
			throw null;
		}
	}
}
