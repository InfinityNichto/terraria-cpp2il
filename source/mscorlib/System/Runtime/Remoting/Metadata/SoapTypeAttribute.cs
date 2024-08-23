using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x020002ED RID: 749
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Interface)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000391")]
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		// Token: 0x06001B4D RID: 6989 RVA: 0x00019169 File Offset: 0x00017369
		[global::Cpp2ILInjected.Token(Token = "0x6001D7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B431A4", Offset = "0x1B431A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(SoapAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SoapTypeAttribute()
		{
			throw null;
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0001916C File Offset: 0x0001736C
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x0001916F File Offset: 0x0001736F
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00019172 File Offset: 0x00017372
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00019175 File Offset: 0x00017375
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x00019178 File Offset: 0x00017378
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

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0001917B File Offset: 0x0001737B
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0001917E File Offset: 0x0001737E
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

		// Token: 0x06001B55 RID: 6997 RVA: 0x00019181 File Offset: 0x00017381
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

		// Token: 0x04000BEE RID: 3054
		[global::Cpp2ILInjected.Token(Token = "0x4000ED9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _useAttribute;

		// Token: 0x04000BEF RID: 3055
		[global::Cpp2ILInjected.Token(Token = "0x4000EDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _xmlElementName;

		// Token: 0x04000BF0 RID: 3056
		[global::Cpp2ILInjected.Token(Token = "0x4000EDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _xmlNamespace;

		// Token: 0x04000BF1 RID: 3057
		[global::Cpp2ILInjected.Token(Token = "0x4000EDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _xmlTypeName;

		// Token: 0x04000BF2 RID: 3058
		[global::Cpp2ILInjected.Token(Token = "0x4000EDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string _xmlTypeNamespace;

		// Token: 0x04000BF3 RID: 3059
		[global::Cpp2ILInjected.Token(Token = "0x4000EDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _isType;

		// Token: 0x04000BF4 RID: 3060
		[global::Cpp2ILInjected.Token(Token = "0x4000EDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		private bool _isElement;
	}
}
