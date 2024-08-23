using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003F5 RID: 1013
	[global::Cpp2ILInjected.Token(Token = "0x20004B0")]
	internal class FileBasedResourceGroveler : IResourceGroveler
	{
		// Token: 0x06002070 RID: 8304 RVA: 0x00019FDF File Offset: 0x000181DF
		[global::Cpp2ILInjected.Token(Token = "0x60022EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77E18", Offset = "0x1B77E18", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		{
			throw null;
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00019FE2 File Offset: 0x000181E2
		[global::Cpp2ILInjected.Token(Token = "0x60022F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B77E40", Offset = "0x1B77E40", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileBasedResourceGroveler), Member = "FindResourceFile", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileBasedResourceGroveler), Member = "CreateResourceSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_HasInvariantCultureName", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MissingManifestResourceException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public ResourceSet GrovelForResourceSet(global::System.Globalization.CultureInfo culture, global::System.Collections.Generic.Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00019FE5 File Offset: 0x000181E5
		[global::Cpp2ILInjected.Token(Token = "0x60022F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B780E8", Offset = "0x1B780E8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileBasedResourceGroveler), Member = "GrovelForResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceSet>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string FindResourceFile(global::System.Globalization.CultureInfo culture, string fileName)
		{
			throw null;
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00019FE8 File Offset: 0x000181E8
		[global::Cpp2ILInjected.Token(Token = "0x60022F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B781A0", Offset = "0x1B781A0", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileBasedResourceGroveler), Member = "GrovelForResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceSet>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeResourceSet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private ResourceSet CreateResourceSet(string file)
		{
			throw null;
		}

		// Token: 0x0400100C RID: 4108
		[global::Cpp2ILInjected.Token(Token = "0x4001321")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ResourceManager.ResourceManagerMediator _mediator;
	}
}
