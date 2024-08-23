using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000053 RID: 83
	[global::Cpp2ILInjected.Token(Token = "0x20000A4")]
	public class Capture
	{
		// Token: 0x06000259 RID: 601 RVA: 0x000034C1 File Offset: 0x000016C1
		[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8750", Offset = "0x1EA8750", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal Capture(string text, int index, int length)
		{
			throw null;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000034C4 File Offset: 0x000016C4
		// (set) Token: 0x0600025B RID: 603 RVA: 0x000034C7 File Offset: 0x000016C7
		[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
		public int Index
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA878C", Offset = "0x1EA878C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8794", Offset = "0x1EA8794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private protected set
			{
				throw null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000034CA File Offset: 0x000016CA
		// (set) Token: 0x0600025D RID: 605 RVA: 0x000034CD File Offset: 0x000016CD
		[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
		public int Length
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA879C", Offset = "0x1EA879C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA87A4", Offset = "0x1EA87A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private protected set
			{
				throw null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000034D0 File Offset: 0x000016D0
		// (set) Token: 0x0600025F RID: 607 RVA: 0x000034D3 File Offset: 0x000016D3
		[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
		protected internal string Text
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA87AC", Offset = "0x1EA87AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA87B4", Offset = "0x1EA87B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private protected set
			{
				throw null;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000034D6 File Offset: 0x000016D6
		[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA87BC", Offset = "0x1EA87BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FileUtilities", Member = "GetFileName", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.FileUtilities", Member = "GetParentFolderPath", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.iOS.CloudSocialModule", Member = "GetParentFolderPath", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.Chat.ChatManager", Member = "ParseMessage", MemberParameters = new object[]
			{
				typeof(string),
				"Microsoft.Xna.Framework.Graphics.Color",
				typeof(float)
			}, ReturnType = "Terraria.UI.Chat.TextSnippet[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "BypassStringEscape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.VersionInfo", Member = "UnityVersion", ReturnType = "InControl.VersionInfo")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.CopyHelper", Member = "AppendCopyToFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000034D9 File Offset: 0x000016D9
		[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA87D0", Offset = "0x1EA87D0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000034DC File Offset: 0x000016DC
		[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA87E4", Offset = "0x1EA87E4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImpl", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(Match)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImplRTL", MemberParameters = new object[]
		{
			typeof(List<string>),
			typeof(Match)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { "System.ExceptionArgument" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal ReadOnlySpan<char> GetLeftSubstring()
		{
			throw null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000034DF File Offset: 0x000016DF
		[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA886C", Offset = "0x1EA886C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImpl", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(Match)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImplRTL", MemberParameters = new object[]
		{
			typeof(List<string>),
			typeof(Match)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { "System.ExceptionArgument" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal ReadOnlySpan<char> GetRightSubstring()
		{
			throw null;
		}

		// Token: 0x04000157 RID: 343
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000280")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <Index>k__BackingField;

		// Token: 0x04000158 RID: 344
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000281")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int <Length>k__BackingField;

		// Token: 0x04000159 RID: 345
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000282")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Text>k__BackingField;
	}
}
