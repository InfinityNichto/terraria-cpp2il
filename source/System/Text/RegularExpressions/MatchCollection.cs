using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200005A RID: 90
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
	[global::Cpp2ILInjected.Token(Token = "0x20000AC")]
	[Serializable]
	public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection
	{
		// Token: 0x0600029B RID: 667 RVA: 0x00003587 File Offset: 0x00001787
		[global::Cpp2ILInjected.Token(Token = "0x600032A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA798", Offset = "0x1EAA798", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Matches", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(MatchCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal MatchCollection(Regex regex, string input, int beginning, int length, int startat)
		{
			throw null;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000358A File Offset: 0x0000178A
		[global::Cpp2ILInjected.Token(Token = "0x170000B0")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600032B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAA8B8", Offset = "0x1EAA8B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000358D File Offset: 0x0000178D
		[global::Cpp2ILInjected.Token(Token = "0x170000B1")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600032C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAA8C0", Offset = "0x1EAA8C0", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AE RID: 174
		[global::Cpp2ILInjected.Token(Token = "0x170000B2")]
		public virtual Match this[int i]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600032D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAA928", Offset = "0x1EAA928", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00003593 File Offset: 0x00001793
		[global::Cpp2ILInjected.Token(Token = "0x600032E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAAD8", Offset = "0x1EAAAD8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = "CanFormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.Chat.ChatManager", Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			"Microsoft.Xna.Framework.Graphics.Color",
			typeof(float)
		}, ReturnType = "Terraria.UI.Chat.TextSnippet[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00003596 File Offset: 0x00001796
		[global::Cpp2ILInjected.Token(Token = "0x600032F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAB6C", Offset = "0x1EAAB6C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00003599 File Offset: 0x00001799
		[global::Cpp2ILInjected.Token(Token = "0x6000330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA988", Offset = "0x1EAA988", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection.Enumerator), Member = "get_Current", ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection), Member = "EnsureInitialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Match[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection), Member = "System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf", MemberParameters = new object[] { typeof(Match) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection), Member = "System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains", MemberParameters = new object[] { typeof(Match) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Match GetMatch(int i)
		{
			throw null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000359C File Offset: 0x0000179C
		[global::Cpp2ILInjected.Token(Token = "0x6000331")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAA914", Offset = "0x1EAA914", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
		private void EnsureInitialized()
		{
			throw null;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000359F File Offset: 0x0000179F
		[global::Cpp2ILInjected.Token(Token = "0x170000B3")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000332")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAABD0", Offset = "0x1EAABD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000035A2 File Offset: 0x000017A2
		[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000333")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAABD8", Offset = "0x1EAABD8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000035A5 File Offset: 0x000017A5
		[global::Cpp2ILInjected.Token(Token = "0x6000334")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAABDC", Offset = "0x1EAABDC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyTo(Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000035A8 File Offset: 0x000017A8
		[global::Cpp2ILInjected.Token(Token = "0x6000335")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAACA0", Offset = "0x1EAACA0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(Match[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000035AB File Offset: 0x000017AB
		[global::Cpp2ILInjected.Token(Token = "0x6000336")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAD14", Offset = "0x1EAAD14", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item)
		{
			throw null;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000035AE File Offset: 0x000017AE
		[global::Cpp2ILInjected.Token(Token = "0x6000337")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAD78", Offset = "0x1EAAD78", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item)
		{
			throw null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000035B1 File Offset: 0x000017B1
		[global::Cpp2ILInjected.Token(Token = "0x6000338")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAADC4", Offset = "0x1EAADC4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000035B4 File Offset: 0x000017B4
		// (set) Token: 0x060002AB RID: 683 RVA: 0x000035B7 File Offset: 0x000017B7
		[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
		private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000339")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAAE10", Offset = "0x1EAAE10", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600033A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAAE20", Offset = "0x1EAAE20", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000035BA File Offset: 0x000017BA
		[global::Cpp2ILInjected.Token(Token = "0x600033B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAE6C", Offset = "0x1EAAE6C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item)
		{
			throw null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000035BD File Offset: 0x000017BD
		[global::Cpp2ILInjected.Token(Token = "0x600033C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAEB8", Offset = "0x1EAAEB8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear()
		{
			throw null;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000035C0 File Offset: 0x000017C0
		[global::Cpp2ILInjected.Token(Token = "0x600033D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAF04", Offset = "0x1EAAF04", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item)
		{
			throw null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000035C3 File Offset: 0x000017C3
		[global::Cpp2ILInjected.Token(Token = "0x600033E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAF68", Offset = "0x1EAAF68", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item)
		{
			throw null;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000035C6 File Offset: 0x000017C6
		[global::Cpp2ILInjected.Token(Token = "0x600033F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAAFB4", Offset = "0x1EAAFB4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000035C9 File Offset: 0x000017C9
		[global::Cpp2ILInjected.Token(Token = "0x6000340")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB000", Offset = "0x1EAB000", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Clear()
		{
			throw null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000035CC File Offset: 0x000017CC
		[global::Cpp2ILInjected.Token(Token = "0x6000341")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB04C", Offset = "0x1EAB04C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000035CF File Offset: 0x000017CF
		[global::Cpp2ILInjected.Token(Token = "0x6000342")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB140", Offset = "0x1EAB140", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000035D2 File Offset: 0x000017D2
		[global::Cpp2ILInjected.Token(Token = "0x6000343")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB234", Offset = "0x1EAB234", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000035D5 File Offset: 0x000017D5
		[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000344")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAB280", Offset = "0x1EAB280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000035D8 File Offset: 0x000017D8
		[global::Cpp2ILInjected.Token(Token = "0x6000345")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB288", Offset = "0x1EAB288", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000035DB File Offset: 0x000017DB
		[global::Cpp2ILInjected.Token(Token = "0x6000346")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB2D4", Offset = "0x1EAB2D4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x000035DE File Offset: 0x000017DE
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x000035E1 File Offset: 0x000017E1
		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000347")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAB320", Offset = "0x1EAB320", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000348")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAB330", Offset = "0x1EAB330", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000035E4 File Offset: 0x000017E4
		[global::Cpp2ILInjected.Token(Token = "0x6000349")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB37C", Offset = "0x1EAB37C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal MatchCollection()
		{
			throw null;
		}

		// Token: 0x04000170 RID: 368
		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Regex _regex;

		// Token: 0x04000171 RID: 369
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<Match> _matches;

		// Token: 0x04000172 RID: 370
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _done;

		// Token: 0x04000173 RID: 371
		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string _input;

		// Token: 0x04000174 RID: 372
		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly int _beginning;

		// Token: 0x04000175 RID: 373
		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private readonly int _length;

		// Token: 0x04000176 RID: 374
		[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _startat;

		// Token: 0x04000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int _prevlen;

		// Token: 0x020003BA RID: 954
		[global::Cpp2ILInjected.Token(Token = "0x20000AD")]
		[Serializable]
		private sealed class Enumerator : IEnumerator<Match>, IDisposable, IEnumerator
		{
			// Token: 0x06001D33 RID: 7475 RVA: 0x0000808D File Offset: 0x0000628D
			[global::Cpp2ILInjected.Token(Token = "0x600034A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAAB3C", Offset = "0x1EAAB3C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Enumerator(MatchCollection collection)
			{
				throw null;
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x00008090 File Offset: 0x00006290
			[global::Cpp2ILInjected.Token(Token = "0x600034B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAB3B4", Offset = "0x1EAB3B4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00008093 File Offset: 0x00006293
			[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
			public Match Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600034C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1EAB3FC", Offset = "0x1EAB3FC", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MatchCollection.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Match))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00008096 File Offset: 0x00006296
			[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600034D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1EAB45C", Offset = "0x1EAB45C", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection.Enumerator), Member = "get_Current", ReturnType = typeof(Match))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001D37 RID: 7479 RVA: 0x00008099 File Offset: 0x00006299
			[global::Cpp2ILInjected.Token(Token = "0x600034E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAB460", Offset = "0x1EAB460", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x06001D38 RID: 7480 RVA: 0x0000809C File Offset: 0x0000629C
			[global::Cpp2ILInjected.Token(Token = "0x600034F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAB46C", Offset = "0x1EAB46C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x040010DC RID: 4316
			[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly MatchCollection _collection;

			// Token: 0x040010DD RID: 4317
			[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;
		}
	}
}
