using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000350")]
	public class SoapServices
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000342")]
		public static string XmlNsForClrTypeWithAssembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B31A7C", Offset = "0x1B31A7C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000343")]
		public static string XmlNsForClrTypeWithNs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B31ABC", Offset = "0x1B31ABC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000344")]
		public static string XmlNsForClrTypeWithNsAndAssembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B31AFC", Offset = "0x1B31AFC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31B3C", Offset = "0x1B31B3C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodCall", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodResponse", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Metadata.SoapTypeAttribute), Member = "SetReflectionObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31DC0", Offset = "0x1B31DC0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetNameKey(string name, string namspace)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31E28", Offset = "0x1B31E28", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodCall", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodResponse", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string GetAssemblyName(global::System.Reflection.MethodBase mb)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31F48", Offset = "0x1B31F48", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Runtime.Remoting.Metadata.SoapAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool GetXmlElementForInteropType(global::System.Type type, out string xmlElement, out string xmlNamespace)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B32014", Offset = "0x1B32014", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Metadata.SoapMethodAttribute), Member = "SetReflectionObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "GetAssemblyName", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetXmlNamespaceForMethodCall(global::System.Reflection.MethodBase mb)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3209C", Offset = "0x1B3209C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Metadata.SoapMethodAttribute), Member = "SetReflectionObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "GetAssemblyName", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetXmlNamespaceForMethodResponse(global::System.Reflection.MethodBase mb)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B32124", Offset = "0x1B32124", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Runtime.Remoting.Metadata.SoapAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool GetXmlTypeForInteropType(global::System.Type type, out string xmlType, out string xmlTypeNamespace)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B321E8", Offset = "0x1B321E8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadPreload", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void PreLoad(global::System.Reflection.Assembly assembly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B32288", Offset = "0x1B32288", Length = "0x450")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadPreload", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "GetXmlTypeForInteropType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "RegisterInteropXmlType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "GetXmlElementForInteropType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "RegisterInteropXmlElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.Runtime.Remoting.Metadata.SoapAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "GetNameKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static void PreLoad(global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B32858", Offset = "0x1B32858", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadInteropXml", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B326D8", Offset = "0x1B326D8", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadInteropXml", MemberParameters = new object[]
		{
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B31CD4", Offset = "0x1B31CD4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string EncodeNs(string ns)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001C74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B329E0", Offset = "0x1B329E0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static SoapServices()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E65")]
		private static global::System.Collections.Hashtable _xmlTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000E66")]
		private static global::System.Collections.Hashtable _xmlElements;

		[global::Cpp2ILInjected.Token(Token = "0x4000E67")]
		private static global::System.Collections.Hashtable _soapActions;

		[global::Cpp2ILInjected.Token(Token = "0x4000E68")]
		private static global::System.Collections.Hashtable _soapActionsMethods;

		[global::Cpp2ILInjected.Token(Token = "0x4000E69")]
		private static global::System.Collections.Hashtable _typeInfos;

		[global::Cpp2ILInjected.Token(Token = "0x2000351")]
		private class TypeInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C75")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B329D8", Offset = "0x1B329D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TypeInfo()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000E6A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public global::System.Collections.Hashtable Attributes;

			[global::Cpp2ILInjected.Token(Token = "0x4000E6B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public global::System.Collections.Hashtable Elements;
		}
	}
}
