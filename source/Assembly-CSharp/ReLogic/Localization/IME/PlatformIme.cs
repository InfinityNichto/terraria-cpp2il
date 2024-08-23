using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000732 RID: 1842
	[global::Cpp2ILInjected.Token(Token = "0x2000B31")]
	public abstract class PlatformIme : IImeService, IDisposable
	{
		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060046DB RID: 18139
		[global::Cpp2ILInjected.Token(Token = "0x17000905")]
		public abstract string CompositionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005390")]
			get;
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060046DC RID: 18140
		[global::Cpp2ILInjected.Token(Token = "0x17000906")]
		public abstract bool IsCandidateListVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005391")]
			get;
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060046DD RID: 18141
		[global::Cpp2ILInjected.Token(Token = "0x17000907")]
		public abstract uint SelectedCandidate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005392")]
			get;
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060046DE RID: 18142
		[global::Cpp2ILInjected.Token(Token = "0x17000908")]
		public abstract uint CandidateCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005393")]
			get;
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060046DF RID: 18143 RVA: 0x0002EAA8 File Offset: 0x0002CCA8
		// (set) Token: 0x060046E0 RID: 18144 RVA: 0x0002EAAB File Offset: 0x0002CCAB
		[global::Cpp2ILInjected.Token(Token = "0x17000909")]
		public bool IsEnabled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005394")]
			[global::Cpp2ILInjected.Address(RVA = "0x944AD4", Offset = "0x944AD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005395")]
			[global::Cpp2ILInjected.Address(RVA = "0x944ADC", Offset = "0x944ADC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0002EAAE File Offset: 0x0002CCAE
		[global::Cpp2ILInjected.Token(Token = "0x6005396")]
		[global::Cpp2ILInjected.Address(RVA = "0x944754", Offset = "0x944754", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnsupportedPlatformIme), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected PlatformIme()
		{
			throw null;
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x0002EAB1 File Offset: 0x0002CCB1
		[global::Cpp2ILInjected.Token(Token = "0x6005397")]
		[global::Cpp2ILInjected.Address(RVA = "0x944AE8", Offset = "0x944AE8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddKeyListener(Action<char> listener)
		{
			throw null;
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
		[global::Cpp2ILInjected.Token(Token = "0x6005398")]
		[global::Cpp2ILInjected.Address(RVA = "0x944B90", Offset = "0x944B90", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveKeyListener(Action<char> listener)
		{
			throw null;
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x0002EAB7 File Offset: 0x0002CCB7
		[global::Cpp2ILInjected.Token(Token = "0x6005399")]
		[global::Cpp2ILInjected.Address(RVA = "0x9447E8", Offset = "0x9447E8", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected void OnKeyPress(char character)
		{
			throw null;
		}

		// Token: 0x060046E5 RID: 18149
		[global::Cpp2ILInjected.Token(Token = "0x600539A")]
		public abstract string GetCandidate(uint index);

		// Token: 0x060046E6 RID: 18150 RVA: 0x0002EABA File Offset: 0x0002CCBA
		[global::Cpp2ILInjected.Token(Token = "0x600539B")]
		[global::Cpp2ILInjected.Address(RVA = "0x944BE8", Offset = "0x944BE8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Enable()
		{
			throw null;
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x0002EABD File Offset: 0x0002CCBD
		[global::Cpp2ILInjected.Token(Token = "0x600539C")]
		[global::Cpp2ILInjected.Address(RVA = "0x944A10", Offset = "0x944A10", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x0002EAC0 File Offset: 0x0002CCC0
		[global::Cpp2ILInjected.Token(Token = "0x600539D")]
		[global::Cpp2ILInjected.Address(RVA = "0x944C18", Offset = "0x944C18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x0002EAC3 File Offset: 0x0002CCC3
		[global::Cpp2ILInjected.Token(Token = "0x600539E")]
		[global::Cpp2ILInjected.Address(RVA = "0x944C1C", Offset = "0x944C1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x0002EAC6 File Offset: 0x0002CCC6
		[global::Cpp2ILInjected.Token(Token = "0x600539F")]
		[global::Cpp2ILInjected.Address(RVA = "0x944C20", Offset = "0x944C20", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x0002EAC9 File Offset: 0x0002CCC9
		[global::Cpp2ILInjected.Token(Token = "0x60053A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x944C38", Offset = "0x944C38", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FnaIme), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x0002EACC File Offset: 0x0002CCCC
		[global::Cpp2ILInjected.Token(Token = "0x60053A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x944CDC", Offset = "0x944CDC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04007194 RID: 29076
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008B31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <IsEnabled>k__BackingField;

		// Token: 0x04007195 RID: 29077
		[global::Cpp2ILInjected.Token(Token = "0x4008B32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<Action<char>> _keyPressCallbacks;

		// Token: 0x04007196 RID: 29078
		[global::Cpp2ILInjected.Token(Token = "0x4008B33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _disposedValue;
	}
}
