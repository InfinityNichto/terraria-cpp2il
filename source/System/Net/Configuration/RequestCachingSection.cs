using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Configuration
{
	// Token: 0x02000343 RID: 835
	[global::Cpp2ILInjected.Token(Token = "0x200047A")]
	public sealed class RequestCachingSection : ConfigurationSection
	{
		// Token: 0x06001BC0 RID: 7104 RVA: 0x00007C76 File Offset: 0x00005E76
		[global::Cpp2ILInjected.Token(Token = "0x6001F19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9A5B8", Offset = "0x1E9A5B8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RequestCachingSection()
		{
			throw null;
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00007C79 File Offset: 0x00005E79
		[global::Cpp2ILInjected.Token(Token = "0x1700072D")]
		public FtpCachePolicyElement DefaultFtpCachePolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A5F0", Offset = "0x1E9A5F0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00007C7C File Offset: 0x00005E7C
		[global::Cpp2ILInjected.Token(Token = "0x1700072E")]
		public HttpCachePolicyElement DefaultHttpCachePolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A628", Offset = "0x1E9A628", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00007C7F File Offset: 0x00005E7F
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x00007C82 File Offset: 0x00005E82
		[global::Cpp2ILInjected.Token(Token = "0x1700072F")]
		public RequestCacheLevel DefaultPolicyLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A660", Offset = "0x1E9A660", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A698", Offset = "0x1E9A698", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00007C85 File Offset: 0x00005E85
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x00007C88 File Offset: 0x00005E88
		[global::Cpp2ILInjected.Token(Token = "0x17000730")]
		public bool DisableAllCaching
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A6D0", Offset = "0x1E9A6D0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A708", Offset = "0x1E9A708", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00007C8B File Offset: 0x00005E8B
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x00007C8E File Offset: 0x00005E8E
		[global::Cpp2ILInjected.Token(Token = "0x17000731")]
		public bool IsPrivateCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A740", Offset = "0x1E9A740", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F21")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A778", Offset = "0x1E9A778", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00007C91 File Offset: 0x00005E91
		[global::Cpp2ILInjected.Token(Token = "0x17000732")]
		protected override ConfigurationPropertyCollection Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A7B0", Offset = "0x1E9A7B0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00007C94 File Offset: 0x00005E94
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x00007C97 File Offset: 0x00005E97
		[global::Cpp2ILInjected.Token(Token = "0x17000733")]
		public TimeSpan UnspecifiedMaximumAge
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A7E8", Offset = "0x1E9A7E8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9A820", Offset = "0x1E9A820", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00007C9A File Offset: 0x00005E9A
		[global::Cpp2ILInjected.Token(Token = "0x6001F25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9A858", Offset = "0x1E9A858", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw null;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00007C9D File Offset: 0x00005E9D
		[global::Cpp2ILInjected.Token(Token = "0x6001F26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9A890", Offset = "0x1E9A890", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void PostDeserialize()
		{
			throw null;
		}
	}
}
