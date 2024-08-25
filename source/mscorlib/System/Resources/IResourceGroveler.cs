using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Cpp2ILInjected;

namespace System.Resources
{
	[global::Cpp2ILInjected.Token(Token = "0x20004B1")]
	internal interface IResourceGroveler
	{
		[global::Cpp2ILInjected.Token(Token = "0x60022F3")]
		ResourceSet GrovelForResourceSet(global::System.Globalization.CultureInfo culture, global::System.Collections.Generic.Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref global::System.Threading.StackCrawlMark stackMark);
	}
}
