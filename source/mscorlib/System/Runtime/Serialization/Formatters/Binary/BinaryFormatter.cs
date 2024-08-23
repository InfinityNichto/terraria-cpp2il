using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036E RID: 878
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000416")]
	public sealed class BinaryFormatter : IFormatter
	{
		// Token: 0x170003E7 RID: 999
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x00019910 File Offset: 0x00017B10
		[global::Cpp2ILInjected.Token(Token = "0x17000445")]
		public FormatterAssemblyStyle AssemblyFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002041")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B605D0", Offset = "0x1B605D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x00019913 File Offset: 0x00017B13
		[global::Cpp2ILInjected.Token(Token = "0x17000446")]
		public ISurrogateSelector SurrogateSelector
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002042")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B605D8", Offset = "0x1B605D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00019916 File Offset: 0x00017B16
		[global::Cpp2ILInjected.Token(Token = "0x6002043")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B605E0", Offset = "0x1B605E0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "DeserializeClaims", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "DeserializeIdentities", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "SerializeIdentities", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "DeserializeObject", MemberParameters = new object[] { typeof(global::System.IO.MemoryStream) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.DesigntimeLicenseContextSerializer", Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(string),
			"System.ComponentModel.Design.RuntimeLicenseContext"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BinaryFormatter()
		{
			throw null;
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00019919 File Offset: 0x00017B19
		[global::Cpp2ILInjected.Token(Token = "0x6002044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60614", Offset = "0x1B60614", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0001991C File Offset: 0x00017B1C
		[global::Cpp2ILInjected.Token(Token = "0x6002045")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60660", Offset = "0x1B60660", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "DeserializeCallData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "DeserializeObject", MemberParameters = new object[] { typeof(global::System.IO.MemoryStream) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "DeserializeObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(bool)
		}, ReturnType = typeof(object))]
		public object Deserialize(global::System.IO.Stream serializationStream)
		{
			throw null;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0001991F File Offset: 0x00017B1F
		[global::Cpp2ILInjected.Token(Token = "0x6002046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60674", Offset = "0x1B60674", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "DeserializeClaims", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "DeserializeIdentities", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalFE), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(InternalFE),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(ObjectReader)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(__BinaryParser),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal object Deserialize(global::System.IO.Stream serializationStream, global::System.Runtime.Remoting.Messaging.HeaderHandler handler, bool fCheck)
		{
			throw null;
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00019922 File Offset: 0x00017B22
		[global::Cpp2ILInjected.Token(Token = "0x6002047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6066C", Offset = "0x1B6066C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object Deserialize(global::System.IO.Stream serializationStream, global::System.Runtime.Remoting.Messaging.HeaderHandler handler)
		{
			throw null;
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00019925 File Offset: 0x00017B25
		[global::Cpp2ILInjected.Token(Token = "0x6002048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60890", Offset = "0x1B60890", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "SerializeCallData", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "SerializeExceptionData", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void Serialize(global::System.IO.Stream serializationStream, object graph)
		{
			throw null;
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00019928 File Offset: 0x00017B28
		[global::Cpp2ILInjected.Token(Token = "0x6002049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6089C", Offset = "0x1B6089C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Serialize(global::System.IO.Stream serializationStream, object graph, global::System.Runtime.Remoting.Messaging.Header[] headers)
		{
			throw null;
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0001992B File Offset: 0x00017B2B
		[global::Cpp2ILInjected.Token(Token = "0x600204A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B608A4", Offset = "0x1B608A4", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "SerializeIdentities", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalFE), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(InternalFE),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(ObjectWriter),
			typeof(FormatterTypeStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal void Serialize(global::System.IO.Stream serializationStream, object graph, global::System.Runtime.Remoting.Messaging.Header[] headers, bool fCheck)
		{
			throw null;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0001992E File Offset: 0x00017B2E
		[global::Cpp2ILInjected.Token(Token = "0x600204B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60B14", Offset = "0x1B60B14", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSiWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerObjectInfoCache), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetClrAssemblyName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetClrTypeFullName", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeInformation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static TypeInformation GetTypeInformation(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00019931 File Offset: 0x00017B31
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600204C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60D54", Offset = "0x1B60D54", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static BinaryFormatter()
		{
			throw null;
		}

		// Token: 0x04000DF9 RID: 3577
		[global::Cpp2ILInjected.Token(Token = "0x40010EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ISurrogateSelector m_surrogates;

		// Token: 0x04000DFA RID: 3578
		[global::Cpp2ILInjected.Token(Token = "0x40010EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal StreamingContext m_context;

		// Token: 0x04000DFB RID: 3579
		[global::Cpp2ILInjected.Token(Token = "0x40010ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal SerializationBinder m_binder;

		// Token: 0x04000DFC RID: 3580
		[global::Cpp2ILInjected.Token(Token = "0x40010EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal FormatterTypeStyle m_typeFormat;

		// Token: 0x04000DFD RID: 3581
		[global::Cpp2ILInjected.Token(Token = "0x40010EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal FormatterAssemblyStyle m_assemblyFormat;

		// Token: 0x04000DFE RID: 3582
		[global::Cpp2ILInjected.Token(Token = "0x40010F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal TypeFilterLevel m_securityLevel;

		// Token: 0x04000DFF RID: 3583
		[global::Cpp2ILInjected.Token(Token = "0x40010F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal object[] m_crossAppDomainArray;

		// Token: 0x04000E00 RID: 3584
		[global::Cpp2ILInjected.Token(Token = "0x40010F2")]
		private static global::System.Collections.Generic.Dictionary<global::System.Type, TypeInformation> typeNameCache;
	}
}
