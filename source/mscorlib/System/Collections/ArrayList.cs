using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;

namespace System.Collections
{
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000603")]
	[global::System.Serializable]
	public class ArrayList : IList, ICollection, IEnumerable, global::System.ICloneable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002EA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08B40", Offset = "0x1C08B40", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "ConvertMonoArgsToDotNet", MemberParameters = new object[] { "System.String[]" }, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.ASN1), Member = "Add", MemberParameters = new object[] { typeof(Mono.Security.ASN1) }, ReturnType = typeof(Mono.Security.ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.ASN1), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.PermissionSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = "AddChild", MemberParameters = new object[] { typeof(global::System.Security.SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ChannelData), Member = "get_ServerProviders", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ChannelData), Member = "get_ClientProviders", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ChannelData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ProviderData), Member = "CopyFrom", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.ProviderData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "CreateClientProxy", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.ActivatedClientTypeEntry),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Services.TrackingServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LeaseManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.SinkProviderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateConstructionCall", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "MarshalProperties", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(ref ArrayList)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "MarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "SaveLogicalCallContext", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMethodMessage),
			typeof(ref ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall), Member = "get_ContextProperties", ReturnType = typeof(IList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MessageDictionary), Member = "get_Keys", ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MessageDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList.IListWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList.IListWrapper), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList.ReadOnlyArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList.ReadOnlyArrayList), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList), Member = "Adapter", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList), Member = "ReadOnly", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Segments", ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListenerCollection", Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainElementCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Build", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509Certificate2" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ExtensionCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "BuildCommandsList", MemberParameters = new object[] { "System.Net.WebRequest" }, ReturnType = "PipelineEntry[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Permissions.PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { "System.Net.NetworkAccess" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { "System.Net.NetworkAccess", "System.Text.RegularExpressions.Regex" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.NetworkAccess",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = ".ctor", MemberParameters = new object[] { "System.Net.NetworkAccess", "System.Uri" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "AddPermission", MemberParameters = new object[]
		{
			"System.Net.NetworkAccess",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "AddPermission", MemberParameters = new object[] { "System.Net.NetworkAccess", "System.Uri" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "AddAsPattern", MemberParameters = new object[] { "System.Net.NetworkAccess", "System.Net.DelayedRegex" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "FromXml", MemberParameters = new object[] { typeof(global::System.Security.SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "PopulatePrefixList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxyDataBuilder", Member = "ParseBypassList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref bool)
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieCollection", Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = "get_BypassList", ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = "get_BypassArrayList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.AuthenticationManager", Member = "EnsureModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestClient", Member = "CheckExpired", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Dns", Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"System.String[]",
			"System.String[]"
		}, ReturnType = "System.Net.IPHostEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndPointListener", Member = "AddPrefix", MemberParameters = new object[] { "System.Net.ListenerPrefix", "System.Net.HttpListener" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndPointListener", Member = "RemovePrefix", MemberParameters = new object[] { "System.Net.ListenerPrefix", "System.Net.HttpListener" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndPointManager", Member = "AddListener", MemberParameters = new object[] { "System.Net.HttpListener" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkParser", Member = ".ctor", MemberParameters = new object[] { "System.Net.WebHeaderCollection" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Permissions.PermissionState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.NetworkAccess",
			"System.Net.TransportType",
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "FromXml", MemberParameters = new object[] { typeof(global::System.Security.SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ListSortDescriptionCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ListSortDescriptionCollection", Member = ".ctor", MemberParameters = new object[] { "System.ComponentModel.ListSortDescription[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = ".ctor", MemberParameters = new object[] { "System.ComponentModel.MemberDescriptor", "System.Attribute[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "GetPopulatedTypes", MemberParameters = new object[] { typeof(global::System.Reflection.Module) }, ReturnType = "System.Type[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.WeakHashtable", Member = "ScavengeKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.StringCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDocument", Member = "GetElement", MemberParameters = new object[]
		{
			typeof(ArrayList),
			"System.Xml.XmlElement"
		}, ReturnType = typeof(global::System.WeakReference))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDocument", Member = "AddElementWithId", MemberParameters = new object[]
		{
			typeof(string),
			"System.Xml.XmlElement"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlNamedNodeMap.SmallXmlNodeList", Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlNamedNodeMap.SmallXmlNodeList", Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.SymbolsDictionary", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.SymbolsDictionary", Member = "GetNamespaceListSymbols", MemberParameters = new object[] { "System.Xml.Schema.NamespaceList" }, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Positions", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.ParticleContentValidator", Member = "BuildTransitionTable", MemberParameters = new object[]
		{
			"System.Xml.Schema.BitSet",
			"System.Xml.Schema.BitSet[]",
			typeof(int)
		}, ReturnType = "System.Int32[][]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_List", Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			"System.Xml.XmlNameTable",
			"System.Xml.IXmlNamespaceResolver",
			typeof(ref object)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1", Member = "Add", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = "Mono.Security.ASN1")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1", Member = "GetBytes", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.PKCS7.SignedData", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.PKCS7.SignerInfo", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "GetBytes", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "GetAttributes", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "GetAttributes", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "Parse", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "get_Crls", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "BuildCrlsCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_IntermediateCACrls", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_TrustedRootCACrls", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS8.PrivateKeyInfo", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 125)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ArrayList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0DC30", Offset = "0x1C0DC30", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListenerCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "get_ConnectList", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "get_AcceptList", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "GetStandardValues", MemberParameters = new object[] { "System.ComponentModel.ITypeDescriptorContext" }, ReturnType = "System.ComponentModel.TypeConverter.StandardValuesCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "GetExtendedProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.ComponentModel.PropertyDescriptorCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { "System.ComponentModel.IExtenderProvider" }, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "CreateAssociation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "FilterMembers", MemberParameters = new object[]
		{
			typeof(IList),
			"System.Attribute[]"
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "PipelineMerge", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameValueCollection", Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameValueCollection", Member = "Set", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "Reset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public ArrayList(int capacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0DD70", Offset = "0x1C0DD70", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = "RegisterDynamicProperty", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Contexts.IDynamicProperty) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage), Member = "GetArguments", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage), Member = "GetArguments", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "GetValues", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Uri",
			typeof(bool),
			"System.String[]",
			"System.Net.ICredentials"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = "set_BypassList", MemberParameters = new object[] { "System.String[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "PipelineAttributeFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			"System.Attribute[]",
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public ArrayList(ICollection c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700074C")]
		public virtual int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0DF1C", Offset = "0x1C0DF1C", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700074D")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E028", Offset = "0x1C0E028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700074E")]
		public virtual bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E030", Offset = "0x1C0E030", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700074F")]
		public virtual bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E038", Offset = "0x1C0E038", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000750")]
		public virtual bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E040", Offset = "0x1C0E040", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000751")]
		public virtual object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E048", Offset = "0x1C0E048", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000752")]
		public virtual object this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E0B8", Offset = "0x1C0E0B8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002EAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E144", Offset = "0x1C0E144", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E214", Offset = "0x1C0E214", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "SortDescriptorArray", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ArrayList Adapter(IList list)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E2E4", Offset = "0x1C0E2E4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual int Add(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E400", Offset = "0x1C0E400", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void AddRange(ICollection c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E41C", Offset = "0x1C0E41C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public virtual void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E458", Offset = "0x1C0E458", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E4D8", Offset = "0x1C0E4D8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool Contains(object item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E570", Offset = "0x1C0E570", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void CopyTo(global::System.Array array)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E584", Offset = "0x1C0E584", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void CopyTo(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E630", Offset = "0x1C0E630", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual void CopyTo(int index, global::System.Array array, int arrayIndex, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E3B8", Offset = "0x1C0E3B8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void EnsureCapacity(int min)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E730", Offset = "0x1C0E730", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList.ArrayListEnumeratorSimple), Member = ".ctor", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E888", Offset = "0x1C0E888", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public virtual int IndexOf(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E8A0", Offset = "0x1C0E8A0", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual void Insert(int index, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E9F4", Offset = "0x1C0E9F4", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public virtual void InsertRange(int index, ICollection c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0EC88", Offset = "0x1C0EC88", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_Secrets", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "get_Entries", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ArrayList ReadOnly(ArrayList list)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0ED50", Offset = "0x1C0ED50", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Remove(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0ED90", Offset = "0x1C0ED90", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void RemoveAt(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0EE58", Offset = "0x1C0EE58", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual void RemoveRange(int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0EF9C", Offset = "0x1C0EF9C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Sort(IComparer comparer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0EFE8", Offset = "0x1C0EFE8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual void Sort(int index, int count, IComparer comparer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0F0E0", Offset = "0x1C0F0E0", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual object[] ToArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002EC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0F1B0", Offset = "0x1C0F1B0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual global::System.Array ToArray(global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40019E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object[] _items;

		[global::Cpp2ILInjected.Token(Token = "0x40019E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _size;

		[global::Cpp2ILInjected.Token(Token = "0x40019E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _version;

		[global::Cpp2ILInjected.Token(Token = "0x40019E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private object _syncRoot;

		[global::Cpp2ILInjected.Token(Token = "0x2000604")]
		[global::System.Serializable]
		private class IListWrapper : ArrayList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E2BC", Offset = "0x1C0E2BC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			internal IListWrapper(IList list)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000753")]
			public override int Capacity
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EC7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F2A0", Offset = "0x1C0F2A0", Length = "0x90")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(string),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000754")]
			public override int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EC8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F330", Offset = "0x1C0F330", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000755")]
			public override bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EC9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F3CC", Offset = "0x1C0F3CC", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000756")]
			public override bool IsFixedSize
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002ECA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F468", Offset = "0x1C0F468", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000757")]
			public override bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002ECB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F504", Offset = "0x1C0F504", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000758")]
			public override object this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002ECC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F5A0", Offset = "0x1C0F5A0", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002ECD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F648", Offset = "0x1C0F648", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000759")]
			public override object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002ECE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F70C", Offset = "0x1C0F70C", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ECF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0F7A8", Offset = "0x1C0F7A8", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override int Add(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0F864", Offset = "0x1C0F864", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void AddRange(ICollection c)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0F8AC", Offset = "0x1C0F8AC", Length = "0x158")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override void Clear()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FA04", Offset = "0x1C0FA04", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override object Clone()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FA64", Offset = "0x1C0FA64", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override bool Contains(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FB10", Offset = "0x1C0FB10", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override void CopyTo(global::System.Array array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FBC0", Offset = "0x1C0FBC0", Length = "0x328")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
			public override void CopyTo(int index, global::System.Array array, int arrayIndex, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FEE8", Offset = "0x1C0FEE8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override IEnumerator GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FF80", Offset = "0x1C0FF80", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override int IndexOf(object value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1002C", Offset = "0x1C1002C", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override void Insert(int index, object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002ED9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C100F0", Offset = "0x1C100F0", Length = "0x3BC")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			public override void InsertRange(int index, ICollection c)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C104AC", Offset = "0x1C104AC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Remove(object value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C104EC", Offset = "0x1C104EC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override void RemoveAt(int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C105A8", Offset = "0x1C105A8", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			public override void RemoveRange(int index, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C107B4", Offset = "0x1C107B4", Length = "0x29C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(int),
				typeof(IComparer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			public override void Sort(int index, int count, IComparer comparer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10A50", Offset = "0x1C10A50", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override object[] ToArray()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10BA4", Offset = "0x1C10BA4", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(int)
			}, ReturnType = typeof(global::System.Array))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public override global::System.Array ToArray(global::System.Type type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40019E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IList _list;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000605")]
		[global::System.Serializable]
		private class ReadOnlyArrayList : ArrayList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0ED2C", Offset = "0x1C0ED2C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			internal ReadOnlyArrayList(ArrayList l)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700075A")]
			public override int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D4C", Offset = "0x1C10D4C", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700075B")]
			public override bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D60", Offset = "0x1C10D60", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700075C")]
			public override bool IsFixedSize
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D68", Offset = "0x1C10D68", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700075D")]
			public override bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D70", Offset = "0x1C10D70", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700075E")]
			public override object this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D84", Offset = "0x1C10D84", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002EE6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D98", Offset = "0x1C10D98", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700075F")]
			public override object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10DE4", Offset = "0x1C10DE4", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10DF8", Offset = "0x1C10DF8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override int Add(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10E44", Offset = "0x1C10E44", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void AddRange(ICollection c)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000760")]
			public override int Capacity
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EEA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10E90", Offset = "0x1C10E90", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10EDC", Offset = "0x1C10EDC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void Clear()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10F28", Offset = "0x1C10F28", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override object Clone()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11008", Offset = "0x1C11008", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override bool Contains(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1101C", Offset = "0x1C1101C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void CopyTo(global::System.Array array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11030", Offset = "0x1C11030", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void CopyTo(int index, global::System.Array array, int arrayIndex, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11044", Offset = "0x1C11044", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override IEnumerator GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11058", Offset = "0x1C11058", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int IndexOf(object value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1106C", Offset = "0x1C1106C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void Insert(int index, object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C110B8", Offset = "0x1C110B8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void InsertRange(int index, ICollection c)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11104", Offset = "0x1C11104", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void Remove(object value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11150", Offset = "0x1C11150", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void RemoveAt(int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1119C", Offset = "0x1C1119C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void RemoveRange(int index, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C111E8", Offset = "0x1C111E8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void Sort(int index, int count, IComparer comparer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11234", Offset = "0x1C11234", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override object[] ToArray()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11248", Offset = "0x1C11248", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override global::System.Array ToArray(global::System.Type type)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40019E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ArrayList _list;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000606")]
		[global::System.Serializable]
		private sealed class ArrayListEnumeratorSimple : IEnumerator, global::System.ICloneable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E788", Offset = "0x1C0E788", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal ArrayListEnumeratorSimple(ArrayList list)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1125C", Offset = "0x1C1125C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
			public object Clone()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11264", Offset = "0x1C11264", Length = "0x190")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000761")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EFD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C113F4", Offset = "0x1C113F4", Length = "0xCC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002EFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C114C0", Offset = "0x1C114C0", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public void Reset()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6002EFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11584", Offset = "0x1C11584", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			static ArrayListEnumeratorSimple()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40019E9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ArrayList _list;

			[global::Cpp2ILInjected.Token(Token = "0x40019EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;

			[global::Cpp2ILInjected.Token(Token = "0x40019EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _version;

			[global::Cpp2ILInjected.Token(Token = "0x40019EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object _currentElement;

			[global::Cpp2ILInjected.Token(Token = "0x40019ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private bool _isArrayList;

			[global::Cpp2ILInjected.Token(Token = "0x40019EE")]
			private static object s_dummyObject;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000607")]
		internal class ArrayListDebugView
		{
		}
	}
}
