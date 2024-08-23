using System;
using System.Collections;
using System.Collections.Specialized;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000133 RID: 307
	[global::Cpp2ILInjected.Token(Token = "0x20001BA")]
	internal class KnownHttpVerb
	{
		// Token: 0x060009A0 RID: 2464 RVA: 0x0000495B File Offset: 0x00002B5B
		[global::Cpp2ILInjected.Token(Token = "0x6000AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0FF58", Offset = "0x1F0FF58", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse)
		{
			throw null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0000495E File Offset: 0x00002B5E
		[global::Cpp2ILInjected.Token(Token = "0x6000AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0FFB0", Offset = "0x1F0FFB0", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListDictionary), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		static KnownHttpVerb()
		{
			throw null;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00004961 File Offset: 0x00002B61
		[global::Cpp2ILInjected.Token(Token = "0x6000AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10284", Offset = "0x1F10284", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		public bool Equals(KnownHttpVerb verb)
		{
			throw null;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00004964 File Offset: 0x00002B64
		[global::Cpp2ILInjected.Token(Token = "0x6000AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F102BC", Offset = "0x1F102BC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "CanGetRequestStream", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListDictionary), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static KnownHttpVerb Parse(string name)
		{
			throw null;
		}

		// Token: 0x04000743 RID: 1859
		[global::Cpp2ILInjected.Token(Token = "0x400095C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string Name;

		// Token: 0x04000744 RID: 1860
		[global::Cpp2ILInjected.Token(Token = "0x400095D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal bool RequireContentBody;

		// Token: 0x04000745 RID: 1861
		[global::Cpp2ILInjected.Token(Token = "0x400095E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		internal bool ContentBodyNotAllowed;

		// Token: 0x04000746 RID: 1862
		[global::Cpp2ILInjected.Token(Token = "0x400095F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		internal bool ConnectRequest;

		// Token: 0x04000747 RID: 1863
		[global::Cpp2ILInjected.Token(Token = "0x4000960")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B")]
		internal bool ExpectNoContentResponse;

		// Token: 0x04000748 RID: 1864
		[global::Cpp2ILInjected.Token(Token = "0x4000961")]
		private static ListDictionary NamedHeaders;

		// Token: 0x04000749 RID: 1865
		[global::Cpp2ILInjected.Token(Token = "0x4000962")]
		internal static KnownHttpVerb Get;

		// Token: 0x0400074A RID: 1866
		[global::Cpp2ILInjected.Token(Token = "0x4000963")]
		internal static KnownHttpVerb Connect;

		// Token: 0x0400074B RID: 1867
		[global::Cpp2ILInjected.Token(Token = "0x4000964")]
		internal static KnownHttpVerb Head;

		// Token: 0x0400074C RID: 1868
		[global::Cpp2ILInjected.Token(Token = "0x4000965")]
		internal static KnownHttpVerb Put;

		// Token: 0x0400074D RID: 1869
		[global::Cpp2ILInjected.Token(Token = "0x4000966")]
		internal static KnownHttpVerb Post;

		// Token: 0x0400074E RID: 1870
		[global::Cpp2ILInjected.Token(Token = "0x4000967")]
		internal static KnownHttpVerb MkCol;
	}
}
