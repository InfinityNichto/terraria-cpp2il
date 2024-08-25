using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x2000470")]
	public sealed class HttpCachePolicyElement : ConfigurationElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E99390", Offset = "0x1E99390", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HttpCachePolicyElement()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001ED0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E995C0", Offset = "0x1E995C0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw null;
		}

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
