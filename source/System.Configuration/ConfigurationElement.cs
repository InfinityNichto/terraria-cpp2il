using System;
using System.Reflection;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	// Token: 0x02000003 RID: 3
	[DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	public abstract class ConfigurationElement
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		protected internal virtual ConfigurationPropertyCollection Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000002")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3BC60", Offset = "0x1D3BC60", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002056 File Offset: 0x00000256
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BC98", Offset = "0x1D3BC98", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BCD0", Offset = "0x1D3BCD0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual void InitializeDefault()
		{
			throw null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000205C File Offset: 0x0000025C
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BD08", Offset = "0x1D3BD08", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual bool IsModified()
		{
			throw null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BD40", Offset = "0x1D3BD40", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void PostDeserialize()
		{
			throw null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BD78", Offset = "0x1D3BD78", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual void Reset(ConfigurationElement parentElement)
		{
			throw null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BDB0", Offset = "0x1D3BDB0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual void ResetModified()
		{
			throw null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BDE8", Offset = "0x1D3BDE8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual bool SerializeToXmlElement(XmlWriter writer, string elementName)
		{
			throw null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BE20", Offset = "0x1D3BE20", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
		{
			throw null;
		}
	}
}
