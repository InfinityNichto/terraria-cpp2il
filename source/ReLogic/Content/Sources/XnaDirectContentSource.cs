using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Content.Sources
{
	// Token: 0x0200074E RID: 1870
	[global::Cpp2ILInjected.Token(Token = "0x2000B50")]
	public class XnaDirectContentSource : IContentSource
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x0002EC19 File Offset: 0x0002CE19
		// (set) Token: 0x06004780 RID: 18304 RVA: 0x0002EC1C File Offset: 0x0002CE1C
		[global::Cpp2ILInjected.Token(Token = "0x17000929")]
		public IContentValidator ContentValidator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600543D")]
			[global::Cpp2ILInjected.Address(RVA = "0x948278", Offset = "0x948278", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600543E")]
			[global::Cpp2ILInjected.Address(RVA = "0x948280", Offset = "0x948280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0002EC1F File Offset: 0x0002CE1F
		[global::Cpp2ILInjected.Token(Token = "0x600543F")]
		[global::Cpp2ILInjected.Address(RVA = "0x948288", Offset = "0x948288", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XnaDirectContentSource(string rootDirectory)
		{
			throw null;
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0002EC22 File Offset: 0x0002CE22
		[global::Cpp2ILInjected.Token(Token = "0x6005440")]
		[global::Cpp2ILInjected.Address(RVA = "0x948358", Offset = "0x948358", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchOption)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void BuildFileMap()
		{
			throw null;
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0002EC25 File Offset: 0x0002CE25
		[global::Cpp2ILInjected.Token(Token = "0x6005441")]
		[global::Cpp2ILInjected.Address(RVA = "0x948438", Offset = "0x948438", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "IsRejected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool HasAsset(string assetName)
		{
			throw null;
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x0002EC28 File Offset: 0x0002CE28
		[global::Cpp2ILInjected.Token(Token = "0x6005442")]
		[global::Cpp2ILInjected.Address(RVA = "0x948524", Offset = "0x948524", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetExtension(string assetName)
		{
			throw null;
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x0002EC2B File Offset: 0x0002CE2B
		[global::Cpp2ILInjected.Token(Token = "0x6005443")]
		[global::Cpp2ILInjected.Address(RVA = "0x948564", Offset = "0x948564", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = "FromMissingAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public Stream OpenStream(string assetName)
		{
			throw null;
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x0002EC2E File Offset: 0x0002CE2E
		[global::Cpp2ILInjected.Token(Token = "0x6005444")]
		[global::Cpp2ILInjected.Address(RVA = "0x948694", Offset = "0x948694", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "Reject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IRejectionReason)
		}, ReturnType = typeof(void))]
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
			throw null;
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x0002EC31 File Offset: 0x0002CE31
		[global::Cpp2ILInjected.Token(Token = "0x6005445")]
		[global::Cpp2ILInjected.Address(RVA = "0x94869C", Offset = "0x94869C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "Clear", ReturnType = typeof(void))]
		public void ClearRejections()
		{
			throw null;
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x0002EC34 File Offset: 0x0002CE34
		[global::Cpp2ILInjected.Token(Token = "0x6005446")]
		[global::Cpp2ILInjected.Address(RVA = "0x9486A4", Offset = "0x9486A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "TryGetRejections", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(bool))]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			throw null;
		}

		// Token: 0x0400737A RID: 29562
		[global::Cpp2ILInjected.Token(Token = "0x4008D1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _rootDirectory;

		// Token: 0x0400737B RID: 29563
		[global::Cpp2ILInjected.Token(Token = "0x4008D1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly HashSet<string> _files;

		// Token: 0x0400737C RID: 29564
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008D1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x0400737D RID: 29565
		[global::Cpp2ILInjected.Token(Token = "0x4008D1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly RejectedAssetCollection _rejections;
	}
}
