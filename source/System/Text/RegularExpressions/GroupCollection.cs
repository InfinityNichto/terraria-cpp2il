using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000057 RID: 87
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Group>))]
	[global::Cpp2ILInjected.Token(Token = "0x20000A8")]
	[Serializable]
	public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection
	{
		// Token: 0x06000268 RID: 616 RVA: 0x000034EE File Offset: 0x000016EE
		[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8ACC", Offset = "0x1EA8ACC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal GroupCollection(Match match, Hashtable caps)
		{
			throw null;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000034F1 File Offset: 0x000016F1
		[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8AF8", Offset = "0x1EA8AF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000034F4 File Offset: 0x000016F4
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8B00", Offset = "0x1EA8B00", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		public Group this[int groupnum]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8B10", Offset = "0x1EA8B10", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils.<>c__DisplayClass47_0", Member = "<FormatWith>b__0", MemberParameters = new object[] { typeof(Match) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "<ProcessCopyCommandsInTexts>b__27_0", MemberParameters = new object[] { typeof(Match) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText.<>c__DisplayClass9_0", Member = "<FormatWith>b__0", MemberParameters = new object[] { typeof(Match) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = "CanFormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.VersionInfo", Member = "UnityVersion", ReturnType = "InControl.VersionInfo")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.CopyHelper", Member = "AppendCopyToFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A3 RID: 163
		[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
		public Group this[string groupname]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8C0C", Offset = "0x1EA8C0C", Length = "0x88")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "GroupNumberFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000034FD File Offset: 0x000016FD
		[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8DDC", Offset = "0x1EA8DDC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00003500 File Offset: 0x00001700
		[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8E70", Offset = "0x1EA8E70", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003503 File Offset: 0x00001703
		[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8B14", Offset = "0x1EA8B14", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection.Enumerator), Member = "get_Current", ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Group[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf", MemberParameters = new object[] { typeof(Group) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "System.Collections.IList.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Split", MemberParameters = new object[]
		{
			typeof(Regex),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashtableExtensions), Member = "TryGetValue", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(Hashtable),
			typeof(object),
			"T&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroupImpl", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Group GetGroup(int groupnum)
		{
			throw null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00003506 File Offset: 0x00001706
		[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8ED4", Offset = "0x1EA8ED4", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "GroupNameFromNumber", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Group), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int[]),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private Group GetGroupImpl(int groupnum)
		{
			throw null;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00003509 File Offset: 0x00001709
		[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9170", Offset = "0x1EA9170", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000350C File Offset: 0x0000170C
		[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9178", Offset = "0x1EA9178", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000350F File Offset: 0x0000170F
		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9180", Offset = "0x1EA9180", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void CopyTo(Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00003512 File Offset: 0x00001712
		[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9248", Offset = "0x1EA9248", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void CopyTo(Group[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003515 File Offset: 0x00001715
		[global::Cpp2ILInjected.Token(Token = "0x60002FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA93AC", Offset = "0x1EA93AC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item)
		{
			throw null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00003518 File Offset: 0x00001718
		[global::Cpp2ILInjected.Token(Token = "0x60002FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9464", Offset = "0x1EA9464", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item)
		{
			throw null;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000351B File Offset: 0x0000171B
		[global::Cpp2ILInjected.Token(Token = "0x6000300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA94B0", Offset = "0x1EA94B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000351E File Offset: 0x0000171E
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00003521 File Offset: 0x00001721
		[global::Cpp2ILInjected.Token(Token = "0x170000A8")]
		private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000301")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA94FC", Offset = "0x1EA94FC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000302")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9500", Offset = "0x1EA9500", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00003524 File Offset: 0x00001724
		[global::Cpp2ILInjected.Token(Token = "0x6000303")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA954C", Offset = "0x1EA954C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item)
		{
			throw null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00003527 File Offset: 0x00001727
		[global::Cpp2ILInjected.Token(Token = "0x6000304")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9598", Offset = "0x1EA9598", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear()
		{
			throw null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000352A File Offset: 0x0000172A
		[global::Cpp2ILInjected.Token(Token = "0x6000305")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA95E4", Offset = "0x1EA95E4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item)
		{
			throw null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000352D File Offset: 0x0000172D
		[global::Cpp2ILInjected.Token(Token = "0x6000306")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9698", Offset = "0x1EA9698", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item)
		{
			throw null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00003530 File Offset: 0x00001730
		[global::Cpp2ILInjected.Token(Token = "0x6000307")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA96E4", Offset = "0x1EA96E4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003533 File Offset: 0x00001733
		[global::Cpp2ILInjected.Token(Token = "0x6000308")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9730", Offset = "0x1EA9730", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Clear()
		{
			throw null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00003536 File Offset: 0x00001736
		[global::Cpp2ILInjected.Token(Token = "0x6000309")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA977C", Offset = "0x1EA977C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00003539 File Offset: 0x00001739
		[global::Cpp2ILInjected.Token(Token = "0x600030A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9870", Offset = "0x1EA9870", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000353C File Offset: 0x0000173C
		[global::Cpp2ILInjected.Token(Token = "0x600030B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9964", Offset = "0x1EA9964", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000353F File Offset: 0x0000173F
		[global::Cpp2ILInjected.Token(Token = "0x170000A9")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600030C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA99B0", Offset = "0x1EA99B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003542 File Offset: 0x00001742
		[global::Cpp2ILInjected.Token(Token = "0x600030D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA99B8", Offset = "0x1EA99B8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00003545 File Offset: 0x00001745
		[global::Cpp2ILInjected.Token(Token = "0x600030E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9A04", Offset = "0x1EA9A04", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00003548 File Offset: 0x00001748
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000354B File Offset: 0x0000174B
		[global::Cpp2ILInjected.Token(Token = "0x170000AA")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x600030F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9A50", Offset = "0x1EA9A50", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000310")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9A54", Offset = "0x1EA9A54", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000354E File Offset: 0x0000174E
		[global::Cpp2ILInjected.Token(Token = "0x6000311")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA9AA0", Offset = "0x1EA9AA0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal GroupCollection()
		{
			throw null;
		}

		// Token: 0x04000162 RID: 354
		[global::Cpp2ILInjected.Token(Token = "0x400028B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Match _match;

		// Token: 0x04000163 RID: 355
		[global::Cpp2ILInjected.Token(Token = "0x400028C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Hashtable _captureMap;

		// Token: 0x04000164 RID: 356
		[global::Cpp2ILInjected.Token(Token = "0x400028D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Group[] _groups;

		// Token: 0x020003B9 RID: 953
		[global::Cpp2ILInjected.Token(Token = "0x20000A9")]
		private sealed class Enumerator : IEnumerator<Group>, IDisposable, IEnumerator
		{
			// Token: 0x06001D2D RID: 7469 RVA: 0x0000807B File Offset: 0x0000627B
			[global::Cpp2ILInjected.Token(Token = "0x6000312")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8E40", Offset = "0x1EA8E40", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Enumerator(GroupCollection collection)
			{
				throw null;
			}

			// Token: 0x06001D2E RID: 7470 RVA: 0x0000807E File Offset: 0x0000627E
			[global::Cpp2ILInjected.Token(Token = "0x6000313")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9AD8", Offset = "0x1EA9AD8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00008081 File Offset: 0x00006281
			[global::Cpp2ILInjected.Token(Token = "0x170000AB")]
			public Group Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000314")]
				[global::Cpp2ILInjected.Address(RVA = "0x1EA9B10", Offset = "0x1EA9B10", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupCollection.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00008084 File Offset: 0x00006284
			[global::Cpp2ILInjected.Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000315")]
				[global::Cpp2ILInjected.Address(RVA = "0x1EA9B84", Offset = "0x1EA9B84", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection.Enumerator), Member = "get_Current", ReturnType = typeof(Group))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001D31 RID: 7473 RVA: 0x00008087 File Offset: 0x00006287
			[global::Cpp2ILInjected.Token(Token = "0x6000316")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9B88", Offset = "0x1EA9B88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x06001D32 RID: 7474 RVA: 0x0000808A File Offset: 0x0000628A
			[global::Cpp2ILInjected.Token(Token = "0x6000317")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA9B94", Offset = "0x1EA9B94", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x040010DA RID: 4314
			[global::Cpp2ILInjected.Token(Token = "0x400028E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly GroupCollection _collection;

			// Token: 0x040010DB RID: 4315
			[global::Cpp2ILInjected.Token(Token = "0x400028F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;
		}
	}
}
