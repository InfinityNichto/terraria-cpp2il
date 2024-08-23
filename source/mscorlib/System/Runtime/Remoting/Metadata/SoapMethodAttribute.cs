using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x020002EB RID: 747
	[global::System.AttributeUsage(global::System.AttributeTargets.Method)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200038F")]
	public sealed class SoapMethodAttribute : SoapAttribute
	{
		// Token: 0x06001B48 RID: 6984 RVA: 0x0001915A File Offset: 0x0001735A
		[global::Cpp2ILInjected.Token(Token = "0x6001D75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42FE4", Offset = "0x1B42FE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(SoapAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SoapMethodAttribute()
		{
			throw null;
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x0001915D File Offset: 0x0001735D
		[global::Cpp2ILInjected.Token(Token = "0x17000385")]
		public override bool UseAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D76")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B42FEC", Offset = "0x1B42FEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00019160 File Offset: 0x00017360
		[global::Cpp2ILInjected.Token(Token = "0x17000386")]
		public override string XmlNamespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B42FF4", Offset = "0x1B42FF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00019163 File Offset: 0x00017363
		[global::Cpp2ILInjected.Token(Token = "0x6001D78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42FFC", Offset = "0x1B42FFC", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodResponse", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodCall", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal override void SetReflectionObject(object reflectionObject)
		{
			throw null;
		}

		// Token: 0x04000BE8 RID: 3048
		[global::Cpp2ILInjected.Token(Token = "0x4000ED3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _responseElement;

		// Token: 0x04000BE9 RID: 3049
		[global::Cpp2ILInjected.Token(Token = "0x4000ED4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _responseNamespace;

		// Token: 0x04000BEA RID: 3050
		[global::Cpp2ILInjected.Token(Token = "0x4000ED5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _returnElement;

		// Token: 0x04000BEB RID: 3051
		[global::Cpp2ILInjected.Token(Token = "0x4000ED6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _soapAction;

		// Token: 0x04000BEC RID: 3052
		[global::Cpp2ILInjected.Token(Token = "0x4000ED7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool _useAttribute;

		// Token: 0x04000BED RID: 3053
		[global::Cpp2ILInjected.Token(Token = "0x4000ED8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _namespace;
	}
}
