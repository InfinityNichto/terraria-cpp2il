using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Cpp2ILInjected;

namespace System.Resources
{
	// Token: 0x020003F6 RID: 1014
	[global::Cpp2ILInjected.Token(Token = "0x20004B1")]
	internal interface IResourceGroveler
	{
		// Token: 0x06002074 RID: 8308
		[global::Cpp2ILInjected.Token(Token = "0x60022F3")]
		ResourceSet GrovelForResourceSet(global::System.Globalization.CultureInfo culture, global::System.Collections.Generic.Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref global::System.Threading.StackCrawlMark stackMark);
	}
}
