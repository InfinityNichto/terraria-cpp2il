using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003F1 RID: 1009
	[global::Cpp2ILInjected.Token(Token = "0x20004AC")]
	internal sealed class RuntimeResourceSet : ResourceSet, global::System.Collections.IEnumerable
	{
		// Token: 0x06002056 RID: 8278 RVA: 0x00019F91 File Offset: 0x00018191
		[global::Cpp2ILInjected.Token(Token = "0x60022D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75FF0", Offset = "0x1B75FF0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileBasedResourceGroveler), Member = "CreateResourceSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, ResourceLocator>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.FileMode),
			typeof(global::System.IO.FileAccess),
			typeof(global::System.IO.FileShare)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceLocator>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal RuntimeResourceSet(string fileName)
		{
			throw null;
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00019F94 File Offset: 0x00018194
		[global::Cpp2ILInjected.Token(Token = "0x60022D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7620C", Offset = "0x1B7620C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "CreateResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, ResourceLocator>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceLocator>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal RuntimeResourceSet(global::System.IO.Stream stream)
		{
			throw null;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00019F97 File Offset: 0x00018197
		[global::Cpp2ILInjected.Token(Token = "0x60022D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76300", Offset = "0x1B76300", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceSet), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00019F9A File Offset: 0x0001819A
		[global::Cpp2ILInjected.Token(Token = "0x60022D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76530", Offset = "0x1B76530", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override global::System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00019F9D File Offset: 0x0001819D
		[global::Cpp2ILInjected.Token(Token = "0x60022D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76630", Offset = "0x1B76630", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeResourceSet), Member = "GetEnumeratorHelper", ReturnType = typeof(global::System.Collections.IDictionaryEnumerator))]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00019FA0 File Offset: 0x000181A0
		[global::Cpp2ILInjected.Token(Token = "0x60022DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76534", Offset = "0x1B76534", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private global::System.Collections.IDictionaryEnumerator GetEnumeratorHelper()
		{
			throw null;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00019FA3 File Offset: 0x000181A3
		[global::Cpp2ILInjected.Token(Token = "0x60022DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76634", Offset = "0x1B76634", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string GetString(string key)
		{
			throw null;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00019FA6 File Offset: 0x000181A6
		[global::Cpp2ILInjected.Token(Token = "0x60022DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76F0C", Offset = "0x1B76F0C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string GetString(string key, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00019FA9 File Offset: 0x000181A9
		[global::Cpp2ILInjected.Token(Token = "0x60022DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76F88", Offset = "0x1B76F88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		public override object GetObject(string key)
		{
			throw null;
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00019FAC File Offset: 0x000181AC
		[global::Cpp2ILInjected.Token(Token = "0x60022DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76F94", Offset = "0x1B76F94", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		public override object GetObject(string key, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00019FAF File Offset: 0x000181AF
		[global::Cpp2ILInjected.Token(Token = "0x60022DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B766A4", Offset = "0x1B766A4", Length = "0x868")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, ResourceLocator>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref ResourceLocator)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "FindPosForResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObject", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, ResourceLocator>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ResourceLocator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, ResourceLocator>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "GetEnumeratorInternal", ReturnType = typeof(ResourceReader.ResourceEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader.ResourceEnumerator), Member = "get_Key", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, ResourceLocator>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ResourceLocator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeResourceSet), Member = "ResolveResourceLocator", MemberParameters = new object[]
		{
			typeof(ResourceLocator),
			typeof(string),
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceLocator>),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		private object GetObject(string key, bool ignoreCase, bool isString)
		{
			throw null;
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00019FB2 File Offset: 0x000181B2
		[global::Cpp2ILInjected.Token(Token = "0x60022E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7777C", Offset = "0x1B7777C", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceReader), Member = "LoadObject", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, ResourceLocator>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ResourceLocator)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private object ResolveResourceLocator(ResourceLocator resLocation, string key, global::System.Collections.Generic.Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase)
		{
			throw null;
		}

		// Token: 0x04001002 RID: 4098
		[global::Cpp2ILInjected.Token(Token = "0x4001317")]
		internal const int Version = 2;

		// Token: 0x04001003 RID: 4099
		[global::Cpp2ILInjected.Token(Token = "0x4001318")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Collections.Generic.Dictionary<string, ResourceLocator> _resCache;

		// Token: 0x04001004 RID: 4100
		[global::Cpp2ILInjected.Token(Token = "0x4001319")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ResourceReader _defaultReader;

		// Token: 0x04001005 RID: 4101
		[global::Cpp2ILInjected.Token(Token = "0x400131A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Collections.Generic.Dictionary<string, ResourceLocator> _caseInsensitiveTable;

		// Token: 0x04001006 RID: 4102
		[global::Cpp2ILInjected.Token(Token = "0x400131B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _haveReadFromReader;
	}
}
