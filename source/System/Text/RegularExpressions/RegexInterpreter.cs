using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000063 RID: 99
	[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
	internal sealed class RegexInterpreter : RegexRunner
	{
		// Token: 0x06000331 RID: 817 RVA: 0x00003743 File Offset: 0x00001943
		[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8F14", Offset = "0x1EB8F14", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Run", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RegexInterpreter(RegexCode code, CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00003746 File Offset: 0x00001946
		[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8F48", Offset = "0x1EB8F48", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void InitTrackCount()
		{
			throw null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00003749 File Offset: 0x00001949
		[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8F58", Offset = "0x1EB8F58", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Advance(int i)
		{
			throw null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000374C File Offset: 0x0000194C
		[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8FB8", Offset = "0x1EB8FB8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
		private void Goto(int newpos)
		{
			throw null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000374F File Offset: 0x0000194F
		[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB905C", Offset = "0x1EB905C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Textto(int newpos)
		{
			throw null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00003752 File Offset: 0x00001952
		[global::Cpp2ILInjected.Token(Token = "0x60003D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9064", Offset = "0x1EB9064", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Trackto(int newpos)
		{
			throw null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003755 File Offset: 0x00001955
		[global::Cpp2ILInjected.Token(Token = "0x60003D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9078", Offset = "0x1EB9078", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Textstart()
		{
			throw null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003758 File Offset: 0x00001958
		[global::Cpp2ILInjected.Token(Token = "0x60003D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9080", Offset = "0x1EB9080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Textpos()
		{
			throw null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000375B File Offset: 0x0000195B
		[global::Cpp2ILInjected.Token(Token = "0x60003D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9088", Offset = "0x1EB9088", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Trackpos()
		{
			throw null;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000375E File Offset: 0x0000195E
		[global::Cpp2ILInjected.Token(Token = "0x60003DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB909C", Offset = "0x1EB909C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void TrackPush()
		{
			throw null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003761 File Offset: 0x00001961
		[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB90BC", Offset = "0x1EB90BC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void TrackPush(int I1)
		{
			throw null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00003764 File Offset: 0x00001964
		[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB90EC", Offset = "0x1EB90EC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void TrackPush(int I1, int I2)
		{
			throw null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003767 File Offset: 0x00001967
		[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB912C", Offset = "0x1EB912C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void TrackPush(int I1, int I2, int I3)
		{
			throw null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000376A File Offset: 0x0000196A
		[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB917C", Offset = "0x1EB917C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void TrackPush2(int I1)
		{
			throw null;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000376D File Offset: 0x0000196D
		[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB91B0", Offset = "0x1EB91B0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void TrackPush2(int I1, int I2)
		{
			throw null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003770 File Offset: 0x00001970
		[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB91F4", Offset = "0x1EB91F4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
		private void Backtrack()
		{
			throw null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003773 File Offset: 0x00001973
		[global::Cpp2ILInjected.Token(Token = "0x60003E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8F98", Offset = "0x1EB8F98", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetOperator(int op)
		{
			throw null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00003776 File Offset: 0x00001976
		[global::Cpp2ILInjected.Token(Token = "0x60003E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9298", Offset = "0x1EB9298", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void TrackPop()
		{
			throw null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003779 File Offset: 0x00001979
		[global::Cpp2ILInjected.Token(Token = "0x60003E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB92A8", Offset = "0x1EB92A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void TrackPop(int framesize)
		{
			throw null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000377C File Offset: 0x0000197C
		[global::Cpp2ILInjected.Token(Token = "0x60003E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB92B8", Offset = "0x1EB92B8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int TrackPeek()
		{
			throw null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000377F File Offset: 0x0000197F
		[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB92D0", Offset = "0x1EB92D0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int TrackPeek(int i)
		{
			throw null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003782 File Offset: 0x00001982
		[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB92EC", Offset = "0x1EB92EC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void StackPush(int I1)
		{
			throw null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003785 File Offset: 0x00001985
		[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9308", Offset = "0x1EB9308", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void StackPush(int I1, int I2)
		{
			throw null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00003788 File Offset: 0x00001988
		[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9334", Offset = "0x1EB9334", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void StackPop()
		{
			throw null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000378B File Offset: 0x0000198B
		[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9344", Offset = "0x1EB9344", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void StackPop(int framesize)
		{
			throw null;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000378E File Offset: 0x0000198E
		[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9354", Offset = "0x1EB9354", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int StackPeek()
		{
			throw null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00003791 File Offset: 0x00001991
		[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB936C", Offset = "0x1EB936C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int StackPeek(int i)
		{
			throw null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003794 File Offset: 0x00001994
		[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9388", Offset = "0x1EB9388", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Operator()
		{
			throw null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003797 File Offset: 0x00001997
		[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9390", Offset = "0x1EB9390", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Operand(int i)
		{
			throw null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000379A File Offset: 0x0000199A
		[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB93B0", Offset = "0x1EB93B0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Leftchars()
		{
			throw null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000379D File Offset: 0x0000199D
		[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB93C0", Offset = "0x1EB93C0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Rightchars()
		{
			throw null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000037A0 File Offset: 0x000019A0
		[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB93D0", Offset = "0x1EB93D0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Bump()
		{
			throw null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000037A3 File Offset: 0x000019A3
		[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB93E4", Offset = "0x1EB93E4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Forwardchars()
		{
			throw null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000037A6 File Offset: 0x000019A6
		[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9410", Offset = "0x1EB9410", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private char Forwardcharnext()
		{
			throw null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000037A9 File Offset: 0x000019A9
		[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9488", Offset = "0x1EB9488", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private bool Stringmatch(string str)
		{
			throw null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000037AC File Offset: 0x000019AC
		[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB95D0", Offset = "0x1EB95D0", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private bool Refmatch(int index, int len)
		{
			throw null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000037AF File Offset: 0x000019AF
		[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9740", Offset = "0x1EB9740", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Backwardnext()
		{
			throw null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000037B2 File Offset: 0x000019B2
		[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9760", Offset = "0x1EB9760", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private char CharAt(int j)
		{
			throw null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000037B5 File Offset: 0x000019B5
		[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB976C", Offset = "0x1EB976C", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexBoyerMoore), Member = "Scan", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsSingleton", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "SingletonChar", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexInterpreter), Member = "Forwardcharnext", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexBoyerMoore), Member = "IsMatch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override bool FindFirstChar()
		{
			throw null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000037B8 File Offset: 0x000019B8
		[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB9AB8", Offset = "0x1EB9AB8", Length = "0x173C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexInterpreter), Member = "Goto", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "DoCheckTimeout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "TransferCapture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexInterpreter), Member = "Forwardcharnext", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "IsECMABoundary", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexInterpreter), Member = "Stringmatch", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "IsBoundary", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexInterpreter), Member = "Refmatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexInterpreter), Member = "Backtrack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexRunner), Member = "Capture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplemented), Member = "ByDesignWithMessage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected override void Go()
		{
			throw null;
		}

		// Token: 0x040001EF RID: 495
		[global::Cpp2ILInjected.Token(Token = "0x4000330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private readonly RegexCode _code;

		// Token: 0x040001F0 RID: 496
		[global::Cpp2ILInjected.Token(Token = "0x4000331")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private readonly CultureInfo _culture;

		// Token: 0x040001F1 RID: 497
		[global::Cpp2ILInjected.Token(Token = "0x4000332")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private int _operator;

		// Token: 0x040001F2 RID: 498
		[global::Cpp2ILInjected.Token(Token = "0x4000333")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private int _codepos;

		// Token: 0x040001F3 RID: 499
		[global::Cpp2ILInjected.Token(Token = "0x4000334")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private bool _rightToLeft;

		// Token: 0x040001F4 RID: 500
		[global::Cpp2ILInjected.Token(Token = "0x4000335")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x99")]
		private bool _caseInsensitive;
	}
}
