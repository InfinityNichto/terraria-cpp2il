using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Metadata
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Interface)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000391")]
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B431A4", Offset = "0x1B431A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(SoapAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SoapTypeAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000387")]
		public override bool UseAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B431AC", Offset = "0x1B431AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000388")]
		public string XmlElementName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B431B4", Offset = "0x1B431B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000389")]
		public override string XmlNamespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B431BC", Offset = "0x1B431BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038A")]
		public string XmlTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B431C4", Offset = "0x1B431C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038B")]
		public string XmlTypeNamespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B431CC", Offset = "0x1B431CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038C")]
		internal bool IsInteropXmlElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B431D4", Offset = "0x1B431D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038D")]
		internal bool IsInteropXmlType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B431DC", Offset = "0x1B431DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B431E4", Offset = "0x1B431E4", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override void SetReflectionObject(object reflectionObject)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000ED9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _useAttribute;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _xmlElementName;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _xmlNamespace;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _xmlTypeName;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string _xmlTypeNamespace;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _isType;

		[global::Cpp2ILInjected.Token(Token = "0x4000EDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		private bool _isElement;
	}
}
