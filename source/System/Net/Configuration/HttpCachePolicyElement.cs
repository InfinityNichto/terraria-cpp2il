using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Configuration
{
	// Token: 0x02000339 RID: 825
	[global::Cpp2ILInjected.Token(Token = "0x2000470")]
	public sealed class HttpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x06001B6D RID: 7021 RVA: 0x00007B7D File Offset: 0x00005D7D
		[global::Cpp2ILInjected.Token(Token = "0x6001EC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E99390", Offset = "0x1E99390", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HttpCachePolicyElement()
		{
			throw null;
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x00007B80 File Offset: 0x00005D80
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x00007B83 File Offset: 0x00005D83
		[global::Cpp2ILInjected.Token(Token = "0x170006FE")]
		public TimeSpan MaximumAge
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E993C8", Offset = "0x1E993C8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001EC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E99400", Offset = "0x1E99400", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x00007B86 File Offset: 0x00005D86
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x00007B89 File Offset: 0x00005D89
		[global::Cpp2ILInjected.Token(Token = "0x170006FF")]
		public TimeSpan MaximumStale
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EC9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E99438", Offset = "0x1E99438", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001ECA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E99470", Offset = "0x1E99470", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x00007B8C File Offset: 0x00005D8C
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x00007B8F File Offset: 0x00005D8F
		[global::Cpp2ILInjected.Token(Token = "0x17000700")]
		public TimeSpan MinimumFresh
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ECB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E994A8", Offset = "0x1E994A8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001ECC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E994E0", Offset = "0x1E994E0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x00007B92 File Offset: 0x00005D92
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x00007B95 File Offset: 0x00005D95
		[global::Cpp2ILInjected.Token(Token = "0x17000701")]
		public HttpRequestCacheLevel PolicyLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ECD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E99518", Offset = "0x1E99518", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001ECE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E99550", Offset = "0x1E99550", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x00007B98 File Offset: 0x00005D98
		[global::Cpp2ILInjected.Token(Token = "0x17000702")]
		protected override ConfigurationPropertyCollection Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ECF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E99588", Offset = "0x1E99588", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00007B9B File Offset: 0x00005D9B
		[global::Cpp2ILInjected.Token(Token = "0x6001ED0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E995C0", Offset = "0x1E995C0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw null;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00007B9E File Offset: 0x00005D9E
		[global::Cpp2ILInjected.Token(Token = "0x6001ED1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E995F8", Offset = "0x1E995F8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw null;
		}
	}
}
