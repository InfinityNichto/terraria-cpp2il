using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x020002EA RID: 746
	[global::System.AttributeUsage(global::System.AttributeTargets.Field)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200038E")]
	public sealed class SoapFieldAttribute : SoapAttribute
	{
		// Token: 0x06001B44 RID: 6980 RVA: 0x0001914E File Offset: 0x0001734E
		[global::Cpp2ILInjected.Token(Token = "0x6001D71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42F34", Offset = "0x1B42F34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(SoapAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SoapFieldAttribute()
		{
			throw null;
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00019151 File Offset: 0x00017351
		[global::Cpp2ILInjected.Token(Token = "0x17000384")]
		public string XmlElementName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B42F3C", Offset = "0x1B42F3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00019154 File Offset: 0x00017354
		[global::Cpp2ILInjected.Token(Token = "0x6001D73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42F44", Offset = "0x1B42F44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsInteropXmlElement()
		{
			throw null;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00019157 File Offset: 0x00017357
		[global::Cpp2ILInjected.Token(Token = "0x6001D74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42F4C", Offset = "0x1B42F4C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override void SetReflectionObject(object reflectionObject)
		{
			throw null;
		}

		// Token: 0x04000BE6 RID: 3046
		[global::Cpp2ILInjected.Token(Token = "0x4000ED1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _elementName;

		// Token: 0x04000BE7 RID: 3047
		[global::Cpp2ILInjected.Token(Token = "0x4000ED2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _isElement;
	}
}
