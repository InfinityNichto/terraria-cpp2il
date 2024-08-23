using System;
using System.Collections;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200005D RID: 93
	[DefaultMember("ItemOf")]
	[global::Cpp2ILInjected.Token(Token = "0x200007C")]
	public abstract class XmlNodeList : IEnumerable, IDisposable
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000578 RID: 1400
		[global::Cpp2ILInjected.Token(Token = "0x1700018D")]
		public abstract int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005FA")]
			get;
		}

		// Token: 0x06000579 RID: 1401
		[global::Cpp2ILInjected.Token(Token = "0x60005FB")]
		public abstract IEnumerator GetEnumerator();

		// Token: 0x0600057A RID: 1402 RVA: 0x00003F23 File Offset: 0x00002123
		[global::Cpp2ILInjected.Token(Token = "0x60005FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A60C", Offset = "0x1D9A60C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00003F26 File Offset: 0x00002126
		[global::Cpp2ILInjected.Token(Token = "0x60005FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A618", Offset = "0x1D9A618", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void PrivateDisposeNodeList()
		{
			throw null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00003F29 File Offset: 0x00002129
		[global::Cpp2ILInjected.Token(Token = "0x60005FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9A61C", Offset = "0x1D9A61C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlChildNodes), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlNodeList()
		{
			throw null;
		}
	}
}
