using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	// Token: 0x02000008 RID: 8
	[DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	public abstract class ConfigurationElementCollection : ConfigurationElement
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000207A File Offset: 0x0000027A
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public virtual ConfigurationElementCollectionType CollectionType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3BF38", Offset = "0x1D3BF38", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		protected virtual string ElementName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000010")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3BF70", Offset = "0x1D3BF70", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002080 File Offset: 0x00000280
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		protected virtual bool ThrowOnDuplicate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000011")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3BFA8", Offset = "0x1D3BFA8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		protected abstract ConfigurationElement CreateNewElement();

		// Token: 0x06000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		protected abstract object GetElementKey(ConfigurationElement element);
	}
}
