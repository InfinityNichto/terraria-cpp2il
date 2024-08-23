using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

namespace ReLogic.Content.Sources
{
	// Token: 0x0200074B RID: 1867
	[global::Cpp2ILInjected.Token(Token = "0x2000B4D")]
	public class FileSystemContentSource : IContentSource
	{
		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x0002EBD7 File Offset: 0x0002CDD7
		// (set) Token: 0x06004762 RID: 18274 RVA: 0x0002EBDA File Offset: 0x0002CDDA
		[global::Cpp2ILInjected.Token(Token = "0x17000925")]
		public IContentValidator ContentValidator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600541F")]
			[global::Cpp2ILInjected.Address(RVA = "0x947790", Offset = "0x947790", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005420")]
			[global::Cpp2ILInjected.Address(RVA = "0x947798", Offset = "0x947798", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		[global::Cpp2ILInjected.Token(Token = "0x17000926")]
		public int FileCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005421")]
			[global::Cpp2ILInjected.Address(RVA = "0x9477A0", Offset = "0x9477A0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		[global::Cpp2ILInjected.Token(Token = "0x6005422")]
		[global::Cpp2ILInjected.Address(RVA = "0x9477E8", Offset = "0x9477E8", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "GetContentSource", ReturnType = typeof(IContentSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemContentSource), Member = "BuildNameToAbsolutePathDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public FileSystemContentSource(string basePath)
		{
			throw null;
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x0002EBE3 File Offset: 0x0002CDE3
		[global::Cpp2ILInjected.Token(Token = "0x6005423")]
		[global::Cpp2ILInjected.Address(RVA = "0x947AD8", Offset = "0x947AD8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "IsRejected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool HasAsset(string assetName)
		{
			throw null;
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x0002EBE6 File Offset: 0x0002CDE6
		[global::Cpp2ILInjected.Token(Token = "0x6005424")]
		[global::Cpp2ILInjected.Address(RVA = "0x947B48", Offset = "0x947B48", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = "FromMissingAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string GetExtension(string assetName)
		{
			throw null;
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x0002EBE9 File Offset: 0x0002CDE9
		[global::Cpp2ILInjected.Token(Token = "0x6005425")]
		[global::Cpp2ILInjected.Address(RVA = "0x947C2C", Offset = "0x947C2C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = "FromMissingAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public Stream OpenStream(string assetName)
		{
			throw null;
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x0002EBEC File Offset: 0x0002CDEC
		[global::Cpp2ILInjected.Token(Token = "0x6005426")]
		[global::Cpp2ILInjected.Address(RVA = "0x947974", Offset = "0x947974", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemContentSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchOption)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void BuildNameToAbsolutePathDictionary()
		{
			throw null;
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x0002EBEF File Offset: 0x0002CDEF
		[global::Cpp2ILInjected.Token(Token = "0x6005427")]
		[global::Cpp2ILInjected.Address(RVA = "0x947D54", Offset = "0x947D54", Length = "0x8")]
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

		// Token: 0x0600476A RID: 18282 RVA: 0x0002EBF2 File Offset: 0x0002CDF2
		[global::Cpp2ILInjected.Token(Token = "0x6005428")]
		[global::Cpp2ILInjected.Address(RVA = "0x947D5C", Offset = "0x947D5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "Clear", ReturnType = typeof(void))]
		public void ClearRejections()
		{
			throw null;
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x0002EBF5 File Offset: 0x0002CDF5
		[global::Cpp2ILInjected.Token(Token = "0x6005429")]
		[global::Cpp2ILInjected.Address(RVA = "0x947D64", Offset = "0x947D64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "TryGetRejections", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(bool))]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			throw null;
		}

		// Token: 0x04007372 RID: 29554
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008D14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x04007373 RID: 29555
		[global::Cpp2ILInjected.Token(Token = "0x4008D15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string _basePath;

		// Token: 0x04007374 RID: 29556
		[global::Cpp2ILInjected.Token(Token = "0x4008D16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, string> _nameToAbsolutePath;

		// Token: 0x04007375 RID: 29557
		[global::Cpp2ILInjected.Token(Token = "0x4008D17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly RejectedAssetCollection _rejections;
	}
}
