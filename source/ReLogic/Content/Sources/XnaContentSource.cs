using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace ReLogic.Content.Sources
{
	// Token: 0x0200074D RID: 1869
	[global::Cpp2ILInjected.Token(Token = "0x2000B4F")]
	public class XnaContentSource : IContentSource
	{
		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x0002EBF8 File Offset: 0x0002CDF8
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x0002EBFB File Offset: 0x0002CDFB
		[global::Cpp2ILInjected.Token(Token = "0x17000928")]
		public IContentValidator ContentValidator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005432")]
			[global::Cpp2ILInjected.Address(RVA = "0x947D6C", Offset = "0x947D6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005433")]
			[global::Cpp2ILInjected.Address(RVA = "0x947D74", Offset = "0x947D74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x0002EBFE File Offset: 0x0002CDFE
		[global::Cpp2ILInjected.Token(Token = "0x6005434")]
		[global::Cpp2ILInjected.Address(RVA = "0x947D7C", Offset = "0x947D7C", Length = "0xD0")]
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
		public XnaContentSource(string rootDirectory)
		{
			throw null;
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x0002EC01 File Offset: 0x0002CE01
		[global::Cpp2ILInjected.Token(Token = "0x6005435")]
		[global::Cpp2ILInjected.Address(RVA = "0x947E4C", Offset = "0x947E4C", Length = "0xE0")]
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

		// Token: 0x06004778 RID: 18296 RVA: 0x0002EC04 File Offset: 0x0002CE04
		[global::Cpp2ILInjected.Token(Token = "0x6005436")]
		[global::Cpp2ILInjected.Address(RVA = "0x947F2C", Offset = "0x947F2C", Length = "0xEC")]
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

		// Token: 0x06004779 RID: 18297 RVA: 0x0002EC07 File Offset: 0x0002CE07
		[global::Cpp2ILInjected.Token(Token = "0x6005437")]
		[global::Cpp2ILInjected.Address(RVA = "0x948018", Offset = "0x948018", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetExtension(string assetName)
		{
			throw null;
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x0002EC0A File Offset: 0x0002CE0A
		[global::Cpp2ILInjected.Token(Token = "0x6005438")]
		[global::Cpp2ILInjected.Address(RVA = "0x948058", Offset = "0x948058", Length = "0x130")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TitleContainer), Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
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

		// Token: 0x0600477B RID: 18299 RVA: 0x0002EC0D File Offset: 0x0002CE0D
		[global::Cpp2ILInjected.Token(Token = "0x6005439")]
		[global::Cpp2ILInjected.Address(RVA = "0x948188", Offset = "0x948188", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "GetEntryAssembly", ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "GetCallingAssembly", ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string GetTitleLocationPath()
		{
			throw null;
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x0002EC10 File Offset: 0x0002CE10
		[global::Cpp2ILInjected.Token(Token = "0x600543A")]
		[global::Cpp2ILInjected.Address(RVA = "0x948260", Offset = "0x948260", Length = "0x8")]
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

		// Token: 0x0600477D RID: 18301 RVA: 0x0002EC13 File Offset: 0x0002CE13
		[global::Cpp2ILInjected.Token(Token = "0x600543B")]
		[global::Cpp2ILInjected.Address(RVA = "0x948268", Offset = "0x948268", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "Clear", ReturnType = typeof(void))]
		public void ClearRejections()
		{
			throw null;
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x0002EC16 File Offset: 0x0002CE16
		[global::Cpp2ILInjected.Token(Token = "0x600543C")]
		[global::Cpp2ILInjected.Address(RVA = "0x948270", Offset = "0x948270", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "TryGetRejections", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(bool))]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			throw null;
		}

		// Token: 0x04007376 RID: 29558
		[global::Cpp2ILInjected.Token(Token = "0x4008D18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _rootDirectory;

		// Token: 0x04007377 RID: 29559
		[global::Cpp2ILInjected.Token(Token = "0x4008D19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly HashSet<string> _files;

		// Token: 0x04007378 RID: 29560
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008D1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x04007379 RID: 29561
		[global::Cpp2ILInjected.Token(Token = "0x4008D1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly RejectedAssetCollection _rejections;
	}
}
