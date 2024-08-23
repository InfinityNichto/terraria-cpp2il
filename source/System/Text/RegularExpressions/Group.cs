using System;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000056 RID: 86
	[global::Cpp2ILInjected.Token(Token = "0x20000A7")]
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x06000264 RID: 612 RVA: 0x000034E2 File Offset: 0x000016E2
		[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8918", Offset = "0x1EA8918", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "GetGroupImpl", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal Group(string text, int[] caps, int capcount, string name)
		{
			throw null;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000034E5 File Offset: 0x000016E5
		[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
		public bool Success
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8990", Offset = "0x1EA8990", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new object[]
			{
				typeof(Regex),
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "BypassStringEscape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertGuid", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref Guid)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.CopyHelper", Member = "AppendCopyToFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000034E8 File Offset: 0x000016E8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA89A0", Offset = "0x1EA89A0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static Group()
		{
			throw null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000034EB File Offset: 0x000016EB
		[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8A94", Offset = "0x1EA8A94", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Group()
		{
			throw null;
		}

		// Token: 0x0400015D RID: 349
		[global::Cpp2ILInjected.Token(Token = "0x4000286")]
		internal static readonly Group s_emptyGroup;

		// Token: 0x0400015E RID: 350
		[global::Cpp2ILInjected.Token(Token = "0x4000287")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal readonly int[] _caps;

		// Token: 0x0400015F RID: 351
		[global::Cpp2ILInjected.Token(Token = "0x4000288")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int _capcount;

		// Token: 0x04000160 RID: 352
		[global::Cpp2ILInjected.Token(Token = "0x4000289")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal CaptureCollection _capcoll;

		// Token: 0x04000161 RID: 353
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400028A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly string <Name>k__BackingField;
	}
}
